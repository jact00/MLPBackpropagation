
namespace MLPBackpropagation
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Canvas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.rb5Classes = new System.Windows.Forms.RadioButton();
            this.rb4Classes = new System.Windows.Forms.RadioButton();
            this.rb3Classes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNeurons2 = new System.Windows.Forms.NumericUpDown();
            this.nudNeurons1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbClass5 = new System.Windows.Forms.RadioButton();
            this.rbClass4 = new System.Windows.Forms.RadioButton();
            this.rbClass3 = new System.Windows.Forms.RadioButton();
            this.rbClass2 = new System.Windows.Forms.RadioButton();
            this.rbClass1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnTrainStochastic = new System.Windows.Forms.Button();
            this.lbMinError = new System.Windows.Forms.Label();
            this.lbLearningRate = new System.Windows.Forms.Label();
            this.btnTrainBatch = new System.Windows.Forms.Button();
            this.nudMaxEpochs = new System.Windows.Forms.NumericUpDown();
            this.tbMinError = new System.Windows.Forms.TrackBar();
            this.tbLearningRate = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEpochs = new System.Windows.Forms.TextBox();
            this.txtMinError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeurons2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeurons1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxEpochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLearningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChart)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            chartArea3.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.MajorGrid.Interval = 1D;
            chartArea3.AxisX.MajorTickMark.Interval = 1D;
            chartArea3.AxisX.Maximum = 5D;
            chartArea3.AxisX.Minimum = -5D;
            chartArea3.AxisY.Interval = 1D;
            chartArea3.AxisY.Maximum = 5D;
            chartArea3.AxisY.Minimum = -5D;
            chartArea3.Name = "ChartArea1";
            this.Canvas.ChartAreas.Add(chartArea3);
            this.Canvas.Location = new System.Drawing.Point(276, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Canvas.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Silver,
        System.Drawing.Color.CornflowerBlue,
        System.Drawing.Color.Red,
        System.Drawing.Color.ForestGreen,
        System.Drawing.Color.Goldenrod,
        System.Drawing.Color.Gray,
        System.Drawing.Color.Blue};
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series13.Legend = "Legend1";
            series13.Name = "placeholder";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series14.Name = "EvalClass1";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series15.Name = "EvalClass2";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series16.Name = "EvalClass3";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series17.Name = "EvalClass4";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series18.Name = "EvalClass5";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series19.Legend = "Legend1";
            series19.Name = "Class1";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series20.Legend = "Legend1";
            series20.Name = "Class2";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series21.Legend = "Legend1";
            series21.Name = "Class3";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series22.Legend = "Legend1";
            series22.Name = "Class4";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series23.Legend = "Legend1";
            series23.Name = "Class5";
            this.Canvas.Series.Add(series13);
            this.Canvas.Series.Add(series14);
            this.Canvas.Series.Add(series15);
            this.Canvas.Series.Add(series16);
            this.Canvas.Series.Add(series17);
            this.Canvas.Series.Add(series18);
            this.Canvas.Series.Add(series19);
            this.Canvas.Series.Add(series20);
            this.Canvas.Series.Add(series21);
            this.Canvas.Series.Add(series22);
            this.Canvas.Series.Add(series23);
            this.Canvas.Size = new System.Drawing.Size(300, 300);
            this.Canvas.TabIndex = 0;
            this.Canvas.Text = "chart1";
            this.Canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnInitialize);
            this.groupBox1.Controls.Add(this.rb5Classes);
            this.groupBox1.Controls.Add(this.rb4Classes);
            this.groupBox1.Controls.Add(this.rb3Classes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudNeurons2);
            this.groupBox1.Controls.Add(this.nudNeurons1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquitectura de la red";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(23, 101);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(104, 101);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(75, 23);
            this.btnInitialize.TabIndex = 6;
            this.btnInitialize.Text = "Inicializar";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // rb5Classes
            // 
            this.rb5Classes.AutoSize = true;
            this.rb5Classes.Location = new System.Drawing.Point(146, 75);
            this.rb5Classes.Name = "rb5Classes";
            this.rb5Classes.Size = new System.Drawing.Size(31, 17);
            this.rb5Classes.TabIndex = 5;
            this.rb5Classes.TabStop = true;
            this.rb5Classes.Text = "5";
            this.rb5Classes.UseVisualStyleBackColor = true;
            this.rb5Classes.CheckedChanged += new System.EventHandler(this.rbNClasses_CheckedChanged);
            // 
            // rb4Classes
            // 
            this.rb4Classes.AutoSize = true;
            this.rb4Classes.Location = new System.Drawing.Point(109, 75);
            this.rb4Classes.Name = "rb4Classes";
            this.rb4Classes.Size = new System.Drawing.Size(31, 17);
            this.rb4Classes.TabIndex = 5;
            this.rb4Classes.TabStop = true;
            this.rb4Classes.Text = "4";
            this.rb4Classes.UseVisualStyleBackColor = true;
            this.rb4Classes.CheckedChanged += new System.EventHandler(this.rbNClasses_CheckedChanged);
            // 
            // rb3Classes
            // 
            this.rb3Classes.AutoSize = true;
            this.rb3Classes.Location = new System.Drawing.Point(72, 75);
            this.rb3Classes.Name = "rb3Classes";
            this.rb3Classes.Size = new System.Drawing.Size(31, 17);
            this.rb3Classes.TabIndex = 5;
            this.rb3Classes.TabStop = true;
            this.rb3Classes.Text = "3";
            this.rb3Classes.UseVisualStyleBackColor = true;
            this.rb3Classes.CheckedChanged += new System.EventHandler(this.rbNClasses_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clases";
            // 
            // nudNeurons2
            // 
            this.nudNeurons2.Location = new System.Drawing.Point(127, 48);
            this.nudNeurons2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNeurons2.Name = "nudNeurons2";
            this.nudNeurons2.Size = new System.Drawing.Size(63, 20);
            this.nudNeurons2.TabIndex = 3;
            // 
            // nudNeurons1
            // 
            this.nudNeurons1.Location = new System.Drawing.Point(127, 22);
            this.nudNeurons1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNeurons1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNeurons1.Name = "nudNeurons1";
            this.nudNeurons1.Size = new System.Drawing.Size(63, 20);
            this.nudNeurons1.TabIndex = 2;
            this.nudNeurons1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Neuronas 2da capa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neuronas 1ra capa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbClass5);
            this.groupBox2.Controls.Add(this.rbClass4);
            this.groupBox2.Controls.Add(this.rbClass3);
            this.groupBox2.Controls.Add(this.rbClass2);
            this.groupBox2.Controls.Add(this.rbClass1);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(53, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clase";
            // 
            // rbClass5
            // 
            this.rbClass5.AutoSize = true;
            this.rbClass5.Location = new System.Drawing.Point(13, 111);
            this.rbClass5.Name = "rbClass5";
            this.rbClass5.Size = new System.Drawing.Size(31, 17);
            this.rbClass5.TabIndex = 4;
            this.rbClass5.TabStop = true;
            this.rbClass5.Text = "5";
            this.rbClass5.UseVisualStyleBackColor = true;
            // 
            // rbClass4
            // 
            this.rbClass4.AutoSize = true;
            this.rbClass4.Location = new System.Drawing.Point(13, 88);
            this.rbClass4.Name = "rbClass4";
            this.rbClass4.Size = new System.Drawing.Size(31, 17);
            this.rbClass4.TabIndex = 3;
            this.rbClass4.TabStop = true;
            this.rbClass4.Text = "4";
            this.rbClass4.UseVisualStyleBackColor = true;
            // 
            // rbClass3
            // 
            this.rbClass3.AutoSize = true;
            this.rbClass3.Location = new System.Drawing.Point(13, 65);
            this.rbClass3.Name = "rbClass3";
            this.rbClass3.Size = new System.Drawing.Size(31, 17);
            this.rbClass3.TabIndex = 2;
            this.rbClass3.TabStop = true;
            this.rbClass3.Text = "3";
            this.rbClass3.UseVisualStyleBackColor = true;
            // 
            // rbClass2
            // 
            this.rbClass2.AutoSize = true;
            this.rbClass2.Location = new System.Drawing.Point(13, 42);
            this.rbClass2.Name = "rbClass2";
            this.rbClass2.Size = new System.Drawing.Size(31, 17);
            this.rbClass2.TabIndex = 1;
            this.rbClass2.TabStop = true;
            this.rbClass2.Text = "2";
            this.rbClass2.UseVisualStyleBackColor = true;
            // 
            // rbClass1
            // 
            this.rbClass1.AutoSize = true;
            this.rbClass1.Location = new System.Drawing.Point(13, 16);
            this.rbClass1.Name = "rbClass1";
            this.rbClass1.Size = new System.Drawing.Size(31, 17);
            this.rbClass1.TabIndex = 0;
            this.rbClass1.TabStop = true;
            this.rbClass1.Text = "1";
            this.rbClass1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTrainStochastic);
            this.groupBox3.Controls.Add(this.lbMinError);
            this.groupBox3.Controls.Add(this.lbLearningRate);
            this.groupBox3.Controls.Add(this.btnTrainBatch);
            this.groupBox3.Controls.Add(this.nudMaxEpochs);
            this.groupBox3.Controls.Add(this.tbMinError);
            this.groupBox3.Controls.Add(this.tbLearningRate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 160);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiper-parámetros";
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(29, 136);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(65, 23);
            this.btnEvaluate.TabIndex = 12;
            this.btnEvaluate.Text = "Evaluar";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnTrainStochastic
            // 
            this.btnTrainStochastic.Location = new System.Drawing.Point(53, 124);
            this.btnTrainStochastic.Name = "btnTrainStochastic";
            this.btnTrainStochastic.Size = new System.Drawing.Size(84, 23);
            this.btnTrainStochastic.TabIndex = 11;
            this.btnTrainStochastic.Text = "G. estocástico";
            this.btnTrainStochastic.UseVisualStyleBackColor = true;
            this.btnTrainStochastic.Click += new System.EventHandler(this.btnTrainStochastic_Click);
            // 
            // lbMinError
            // 
            this.lbMinError.AutoSize = true;
            this.lbMinError.Location = new System.Drawing.Point(231, 61);
            this.lbMinError.Name = "lbMinError";
            this.lbMinError.Size = new System.Drawing.Size(13, 13);
            this.lbMinError.TabIndex = 10;
            this.lbMinError.Text = "0";
            // 
            // lbLearningRate
            // 
            this.lbLearningRate.AutoSize = true;
            this.lbLearningRate.Location = new System.Drawing.Point(231, 29);
            this.lbLearningRate.Name = "lbLearningRate";
            this.lbLearningRate.Size = new System.Drawing.Size(13, 13);
            this.lbLearningRate.TabIndex = 9;
            this.lbLearningRate.Text = "0";
            // 
            // btnTrainBatch
            // 
            this.btnTrainBatch.Location = new System.Drawing.Point(143, 124);
            this.btnTrainBatch.Name = "btnTrainBatch";
            this.btnTrainBatch.Size = new System.Drawing.Size(65, 23);
            this.btnTrainBatch.TabIndex = 8;
            this.btnTrainBatch.Text = "G. por lote";
            this.btnTrainBatch.UseVisualStyleBackColor = true;
            this.btnTrainBatch.Click += new System.EventHandler(this.btnTrainBatch_Click);
            // 
            // nudMaxEpochs
            // 
            this.nudMaxEpochs.Location = new System.Drawing.Point(100, 91);
            this.nudMaxEpochs.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudMaxEpochs.Name = "nudMaxEpochs";
            this.nudMaxEpochs.Size = new System.Drawing.Size(114, 20);
            this.nudMaxEpochs.TabIndex = 8;
            // 
            // tbMinError
            // 
            this.tbMinError.Location = new System.Drawing.Point(84, 52);
            this.tbMinError.Maximum = 100;
            this.tbMinError.Name = "tbMinError";
            this.tbMinError.Size = new System.Drawing.Size(143, 45);
            this.tbMinError.TabIndex = 8;
            this.tbMinError.TickFrequency = 10;
            this.tbMinError.ValueChanged += new System.EventHandler(this.tbMinError_ValueChanged);
            // 
            // tbLearningRate
            // 
            this.tbLearningRate.Location = new System.Drawing.Point(84, 19);
            this.tbLearningRate.Maximum = 100;
            this.tbLearningRate.Name = "tbLearningRate";
            this.tbLearningRate.Size = new System.Drawing.Size(143, 45);
            this.tbLearningRate.TabIndex = 7;
            this.tbLearningRate.TickFrequency = 10;
            this.tbLearningRate.ValueChanged += new System.EventHandler(this.tbLearningRate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Épocas máximas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Error mínimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Learning rate";
            // 
            // errorChart
            // 
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisX.MajorGrid.Interval = 0D;
            chartArea4.AxisX.MajorTickMark.Interval = 0D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.Interval = 0.1D;
            chartArea4.AxisY.MajorGrid.Interval = 0.1D;
            chartArea4.AxisY.MajorTickMark.Interval = 0.1D;
            chartArea4.AxisY.Maximum = 1D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.errorChart.ChartAreas.Add(chartArea4);
            this.errorChart.Location = new System.Drawing.Point(144, 318);
            this.errorChart.Name = "errorChart";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Color = System.Drawing.Color.Red;
            series24.Name = "Error";
            this.errorChart.Series.Add(series24);
            this.errorChart.Size = new System.Drawing.Size(432, 175);
            this.errorChart.TabIndex = 4;
            this.errorChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Error Acumulado";
            this.errorChart.Titles.Add(title2);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEvaluate);
            this.groupBox4.Controls.Add(this.txtMinError);
            this.groupBox4.Controls.Add(this.txtEpochs);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(126, 175);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Epocas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Error mínimo:";
            // 
            // txtEpochs
            // 
            this.txtEpochs.Location = new System.Drawing.Point(6, 45);
            this.txtEpochs.Name = "txtEpochs";
            this.txtEpochs.ReadOnly = true;
            this.txtEpochs.Size = new System.Drawing.Size(114, 20);
            this.txtEpochs.TabIndex = 2;
            // 
            // txtMinError
            // 
            this.txtMinError.Location = new System.Drawing.Point(6, 99);
            this.txtMinError.Name = "txtMinError";
            this.txtMinError.ReadOnly = true;
            this.txtMinError.Size = new System.Drawing.Size(114, 20);
            this.txtMinError.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 502);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.errorChart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeurons2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeurons1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxEpochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLearningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorChart)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Canvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudNeurons2;
        private System.Windows.Forms.NumericUpDown nudNeurons1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbClass3;
        private System.Windows.Forms.RadioButton rbClass2;
        private System.Windows.Forms.RadioButton rbClass1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.RadioButton rb5Classes;
        private System.Windows.Forms.RadioButton rb4Classes;
        private System.Windows.Forms.RadioButton rb3Classes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbClass5;
        private System.Windows.Forms.RadioButton rbClass4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar tbMinError;
        private System.Windows.Forms.TrackBar tbLearningRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTrainBatch;
        private System.Windows.Forms.NumericUpDown nudMaxEpochs;
        private System.Windows.Forms.Label lbMinError;
        private System.Windows.Forms.Label lbLearningRate;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnTrainStochastic;
        private System.Windows.Forms.DataVisualization.Charting.Chart errorChart;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMinError;
        private System.Windows.Forms.TextBox txtEpochs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

