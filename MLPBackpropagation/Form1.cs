using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MLPBackpropagation
{
    public partial class Form1 : Form
    {
        private MLP MLP;
        private List<Data> Data;
        public Form1()
        {
            InitializeComponent();
            Canvas.Series["placeholder"].Points.AddXY(10, 10);

            MLP = null;

            Reset();
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            var r = Canvas.HitTest(e.X, e.Y, ChartElementType.PlottingArea);

            ClearEvalClasses();

            if (r.ChartElementType == ChartElementType.PlottingArea)
            {
                var xchart = r.ChartArea.AxisX.PixelPositionToValue(e.X);
                var ychart = r.ChartArea.AxisY.PixelPositionToValue(e.Y);
                int clas = 0;

                if (rbClass1.Checked) clas = 1;
                else if (rbClass2.Checked) clas = 2;
                else if (rbClass3.Checked) clas = 3;
                else if (rbClass4.Checked) clas = 4;
                else if (rbClass5.Checked) clas = 5;

                if(clas != 0)
                {
                    Data data = new Data(2);

                    data.X[0] = xchart;
                    data.X[1] = ychart;
                    data.Y = clas-1;

                    Data.Add(data);
                    Canvas.Series["Class"+clas.ToString()].Points.AddXY(xchart, ychart);
                }   
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            nudNeurons1.Enabled = true;
            nudNeurons2.Enabled = true;
            nudNeurons1.Value = 2;
            nudNeurons2.Value = 0;

            rb3Classes.Enabled = true;
            rb4Classes.Enabled = true;
            rb5Classes.Enabled = true;
            rb3Classes.Checked = false;
            rb4Classes.Checked = false;
            rb5Classes.Checked = false;

            rbClass1.Checked = false;
            rbClass2.Checked = false;
            rbClass3.Checked = false;
            rbClass4.Checked = false;
            rbClass5.Checked = false;
            rbClass1.Enabled = false;
            rbClass2.Enabled = false;
            rbClass3.Enabled = false;
            rbClass4.Enabled = false;
            rbClass5.Enabled = false;


            tbLearningRate.Value = 0;
            lbLearningRate.Text = "0";
            tbMinError.Value = 0;
            lbMinError.Text = "0";

            nudMaxEpochs.Value = 0;

            btnEvaluate.Enabled = false;
            btnInitialize.Enabled = false;
            btnTrainBatch.Enabled = false;
            btnTrainStochastic.Enabled = false;
            btnReset.Enabled = false;

            foreach(var series in Canvas.Series)
            {
                if(series.Name != "placeholder")
                {
                    series.Points.Clear();
                }
            }

            ClearResults();
            RemoveWs();
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            rbClass1.Enabled = true;
            rbClass2.Enabled = true;
            rbClass3.Enabled = true;
            rbClass4.Enabled = rb4Classes.Checked || rb5Classes.Checked;
            rbClass5.Enabled = rb5Classes.Checked;

            Data = new List<Data>();
            InitializeMLP();

            ShowWs();

            btnInitialize.Enabled = false;
            btnReset.Enabled = true;
            btnTrainBatch.Enabled = true;
            btnTrainStochastic.Enabled = true;
            nudNeurons1.Enabled = false;
            nudNeurons2.Enabled = false;
            rb3Classes.Enabled = false;
            rb4Classes.Enabled = false;
            rb5Classes.Enabled = false;

        }

        private void tbLearningRate_ValueChanged(object sender, EventArgs e)
        {
            lbLearningRate.Text = ((double)tbLearningRate.Value / 100).ToString("0.##");
        }

        private void tbMinError_ValueChanged(object sender, EventArgs e)
        {
            lbMinError.Text = ((double)tbMinError.Value / 100).ToString("0.##");
        }

        private void rbNClasses_CheckedChanged(object sender, EventArgs e)
        {
            btnInitialize.Enabled = rb3Classes.Checked || rb4Classes.Checked || rb5Classes.Checked;
        }

        private void InitializeMLP()
        {
            int outputs = 3 + (rb4Classes.Checked ? 1 : 0) + (rb5Classes.Checked ? 2 : 0);

            List<int> neuronsPerLayer = new List<int>();

            neuronsPerLayer.Add(2);
            neuronsPerLayer.Add((int)nudNeurons1.Value);

            if (nudNeurons2.Value != 0)
                neuronsPerLayer.Add((int)nudNeurons2.Value);

            neuronsPerLayer.Add(outputs);

            MLP = new MLP(neuronsPerLayer.ToArray());
        }

        private void btnTrainStochastic_Click(object sender, EventArgs e)
        {
            ClearEvalClasses();
            ClearResults();

            double eta = (double)tbLearningRate.Value / 100;
            double minError = (double)tbMinError.Value / 100;
            int epochs = MLP.TrainStochastic(Data, eta, minError, (int)nudMaxEpochs.Value, errorChart);

            btnEvaluate.Enabled = true;

            HideWs();
            FillResults();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            ClearEvalClasses();

            for(double x = -5; x <= 5; x += 0.2)
            {
                for(double y = -5; y <= 5; y += 0.2 )
                {
                    int clas = MLP.Evaluate(new double[] { x, y });

                    Canvas.Series["EvalClass" + (clas + 1).ToString()].Points.AddXY(x, y);
                }
            }
        }

        private void ClearEvalClasses()
        {
            for(int i = 1; i <= 5; i++)
            {
                Canvas.Series["EvalClass" + i.ToString()].Points.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearResults()
        {
            errorChart.Series["Error"].Points.Clear();
            txtEpochs.Text = "";
            txtMinError.Text = "";
        }

        private void FillResults()
        {
            txtEpochs.Text = (errorChart.Series["Error"].Points.Last().XValue + 1).ToString();
            txtMinError.Text = errorChart.Series["Error"].Points.Last().YValues[0].ToString();
        }

        private void btnTrainBatch_Click(object sender, EventArgs e)
        {
            ClearEvalClasses();
            ClearResults();

            double eta = (double)tbLearningRate.Value / 100;
            double minError = (double)tbMinError.Value / 100;
            int epochs = MLP.TrainBatch(Data, eta, minError, (int)nudMaxEpochs.Value, errorChart);

            btnEvaluate.Enabled = true;

            HideWs();
            FillResults();
        }

        private void ShowWs()
        {
            for (int i = 0; i < MLP.W[0].Length; i++)
            {
                string name = "W" + i.ToString();
                int x0 = -5;
                int x1 = 5;
                double y0 = (MLP.W[0][i][0] - x0 * MLP.W[0][i][1]) / MLP.W[0][i][2];
                double y1 = (MLP.W[0][i][0] - x1 * MLP.W[0][i][1]) / MLP.W[0][i][2];

                Canvas.Series.Add(name);
                Canvas.Series[name].ChartType = SeriesChartType.Line;
                Canvas.Series[name].Color = Color.Magenta;
                Canvas.Series[name].Points.AddXY(x0, y0);
                Canvas.Series[name].Points.AddXY(x1, y1);
            }
        }

        private void RemoveWs()
        {
            if(MLP != null)
                for (int i = 0; i < MLP.W[0].Length; i++)
                    Canvas.Series.Remove(Canvas.Series["W" + i.ToString()]);               
        }

        private void HideWs()
        {
            for (int i = 0; i < MLP.W[0].Length; i++)
                Canvas.Series["W" + i.ToString()].Enabled = false;
        }
    }
}
