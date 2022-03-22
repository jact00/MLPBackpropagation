using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace MLPBackpropagation
{
    class MLP
    {
        public double[][][] W;

        public MLP(int[] neuronsPerLayer)
        {
            // neuronsPerLayer = [inputs, layer 1, ..., layer n, outputs]
            int layers = neuronsPerLayer.Length;
            Random r = new Random();
            W = new double[layers-1][][];
            
            for(int i = 1; i < layers; i++)
            {
                W[i-1] = new double[neuronsPerLayer[i]][];
                
                for(int j = 0; j < neuronsPerLayer[i]; j++)
                {
                    W[i - 1][j] = new double[neuronsPerLayer[i - 1] + 1];

                    for (int k = 0; k < neuronsPerLayer[i - 1]; k++)
                        W[i - 1][j][k + 1] = 2 * r.NextDouble() - 1;

                    W[i - 1][j][0] = 0.4 * r.NextDouble() - 0.2;
                }
                    
            }
        }

        private double[] Pw(int layer, double[] x)
        {
            double[] a = new double[W[layer].Length]; 

            for (int i = 0; i < W[layer].Length; i++)
            {
                double sum = 0;

                for (int j = 0; j < x.Length; j++)
                {
                    sum += x[j] * W[layer][i][j + 1];
                }
                sum -= W[layer][i][0];
                
                a[i] = 1 / (1 + Math.Exp(-sum));
            }

            return a;            
        }

        private int[] EncodeY(int y)
        {
            int[] encodedY = new int[W[W.Length - 1].Length];

            for (int i = 0; i < encodedY.Length; i++)
                encodedY[i] = 0;

            encodedY[y] = 1;

            return encodedY;
        }

        public int Evaluate(double[] x)
        {
            double[] a = x;

            for(int i = 0; i < W.Length; i++)
            {
                double[] newA = new double[W[i].Length];

                for(int j = 0; j < W[i].Length; j++)
                {
                    double sum = 0;

                    for(int k = 0; k < a.Length; k++)
                        sum += a[k] * W[i][j][k + 1];

                    sum -= W[i][j][0];

                    newA[j] = 1 / (1 + Math.Exp(-sum));
                }

                a = newA;
            }

            int clas = 0;

            for (int i = 1; i < a.Length; i++)
                if (a[i] > a[clas]) clas = i;

            return clas;
        }

        private double[] OutputLayerSensitivity(int y, double[] a) 
        {
            int[] encodedY = EncodeY(y);
            double[] s = new double[encodedY.Length];

            for (int i = 0; i < encodedY.Length; i++)
            {
                double nDerivative = a[i] * (1 - a[i]);
                s[i] = -2 * nDerivative * (encodedY[i] - a[i]);
            }

            return s;
        }

        private double[] HiddenLayerSensitivity(int layer, double[] a, double[] sn)
        {
            double[] s = new double[W[layer].Length];

            //Jacobian matrix
            double[][] jacobian = new double[W[layer].Length][];

            for (int i = 0; i < W[layer].Length; i++)
            {
                jacobian[i] = new double[W[layer + 1].Length];
                double nDerivative = a[i] * (1 - a[i]);

                for (int j = 0; j < W[layer + 1].Length; j++)
                {
                    jacobian[i][j] = nDerivative * W[layer + 1][j][i+1];
                }
            }

            //Sensibility
            for (int i = 0; i < W[layer].Length; i++)
            {
                s[i] = 0;

                for (int j = 0; j < sn.Length; j++)
                {
                    s[i] += jacobian[i][j] * sn[j];
                }
            }

            return s;
        }

        private double[][] WeightIncrement(double eta, double[] s, double[] a)
        {
            double[][] increment = new double[s.Length][];

            for(int i = 0; i < s.Length; i++)
            {
                increment[i] = new double[a.Length+1];

                for(int j = 0; j < a.Length; j++)
                {
                    increment[i][j+1] = -eta * s[i] * a[j];
                }

                increment[i][0] = -eta * s[i] * -1;
            }

            return increment;
        }

        public int TrainStochastic(List<Data> trainingData, double learningRate, double minError, int maxEpochs, Chart errorChart)
        {
            int epochs = 0;
            double epochError = 1;

            while (epochs < maxEpochs && minError < epochError)
            {
                epochError = 0;

                for (int i = 0; i < trainingData.Count; i++)
                {
                    double[][] a = new double[W.Length + 1][];
                    a[0] = trainingData[i].X;
                    
                    //Forward
                    for(int j = 0; j < W.Length; j++)
                        a[j + 1] = Pw(j, a[j]);

                    //Error calculation
                    epochError += 1 - a[W.Length][trainingData[i].Y];

                    //Backward
                    ///1-Sensitivity calculation
                    double[][] s = new double[W.Length][];

                    ////Output layer
                    s[W.Length - 1] = OutputLayerSensitivity(trainingData[i].Y, a[W.Length]);

                    ////Hidden layers
                    for(int j = W.Length-2; j >= 0; j--)
                        s[j] = HiddenLayerSensitivity(j, a[j + 1], s[j + 1]);

                    ///2-Weights adjustment
                    for(int j = W.Length-1; j >= 0; j--)
                    {
                        double[][] increment = WeightIncrement(learningRate, s[j], a[j]);

                        for(int k = 0; k < W[j].Length; k++)
                        {
                            for(int l = 0; l < W[j][k].Length; l++)
                            {
                                W[j][k][l] = W[j][k][l] + increment[k][l];
                            }
                        }
                    }

                }

                epochError /= trainingData.Count;
                Console.WriteLine(epochError);
                errorChart.Series["Error"].Points.AddXY(epochs, epochError);
                errorChart.Update();
                epochs++;
            }

            Console.WriteLine(epochs);
            return epochs;
        }

        public int TrainBatch(List<Data> trainingData, double learningRate, double minError, int maxEpochs, Chart errorChart)
        {
            int epochs = 0;
            double epochError = 1;

            while (epochs < maxEpochs && minError < epochError)
            {
                epochError = 0;

                double[][][] totalIncrement = new double[W.Length][][];

                for(int i = 0; i < W.Length; i++)
                {
                    totalIncrement[i] = new double[W[i].Length][];

                    for (int j = 0; j < W[i].Length; j++)
                    {
                        totalIncrement[i][j] = new double[W[i][j].Length];

                        for(int k= 0; k < W[i][j].Length; k++)
                        {
                            totalIncrement[i][j][k] = 0;
                        }
                    }
                }

                for (int i = 0; i < trainingData.Count; i++)
                {
                    double[][] a = new double[W.Length + 1][];
                    a[0] = trainingData[i].X;

                    //Forward
                    for (int j = 0; j < W.Length; j++)
                        a[j + 1] = Pw(j, a[j]);

                    //Error calculation
                    epochError += 1 - a[W.Length][trainingData[i].Y];

                    //Backward
                    ///1-Sensibility calculation
                    double[][] s = new double[W.Length][];

                    ////Output layer
                    s[W.Length - 1] = OutputLayerSensitivity(trainingData[i].Y, a[W.Length]);

                    ////Hidden layers
                    for (int j = W.Length - 2; j >= 0; j--)
                        s[j] = HiddenLayerSensitivity(j, a[j + 1], s[j + 1]);

                    ///2-Weights acumulation
                    for (int j = W.Length - 1; j >= 0; j--)
                    {
                        double[][] increment = WeightIncrement(learningRate, s[j], a[j]);

                        for (int k = 0; k < W[j].Length; k++)
                        {
                            for (int l = 0; l < W[j][k].Length; l++)
                            {
                                totalIncrement[j][k][l] += increment[k][l];
                            }
                        }
                    }

                }

                //Batch Weight Increment
                for (int i = W.Length - 1; i >= 0; i--)
                    for (int j = 0; j < W[i].Length; j++)
                        for (int k = 0; k < W[i][j].Length; k++)
                            W[i][j][k] += totalIncrement[i][j][k]/trainingData.Count;

                epochError /= trainingData.Count;
                Console.WriteLine(epochError);
                errorChart.Series["Error"].Points.AddXY(epochs, epochError);
                errorChart.Update();
                epochs++;
            }

            Console.WriteLine(epochs);
            return epochs;
        }
    }
}
