﻿namespace NN_Family_Creater
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.minConstSpeedTB = new System.Windows.Forms.TextBox();
            this.maxConstSpeedTB = new System.Windows.Forms.TextBox();
            this.constSpeedChB = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mean_squared_errorChB = new System.Windows.Forms.CheckBox();
            this.cosine_proximityChB = new System.Windows.Forms.CheckBox();
            this.poissonChB = new System.Windows.Forms.CheckBox();
            this.mean_absolute_errorChB = new System.Windows.Forms.CheckBox();
            this.kullback_leibler_divergenceChB = new System.Windows.Forms.CheckBox();
            this.mean_absolute_percentage_errorChB = new System.Windows.Forms.CheckBox();
            this.binary_crossentropyChB = new System.Windows.Forms.CheckBox();
            this.squared_hingeChB = new System.Windows.Forms.CheckBox();
            this.sparse_categorical_crossentropyChB = new System.Windows.Forms.CheckBox();
            this.mean_squared_logarithmic_errorChB = new System.Windows.Forms.CheckBox();
            this.categorical_crossentropyChB = new System.Windows.Forms.CheckBox();
            this.hingeChB = new System.Windows.Forms.CheckBox();
            this.logcoshChB = new System.Windows.Forms.CheckBox();
            this.categorical_hingeChB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SGD_OptChB = new System.Windows.Forms.CheckBox();
            this.RMSp_OptChB = new System.Windows.Forms.CheckBox();
            this.Adagrad_OptChB = new System.Windows.Forms.CheckBox();
            this.Adadelta_OptChB = new System.Windows.Forms.CheckBox();
            this.Adam_OptChB = new System.Windows.Forms.CheckBox();
            this.Adamax_OptChB = new System.Windows.Forms.CheckBox();
            this.Nadam_OptChB = new System.Windows.Forms.CheckBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mutateRateNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.batchSizeNUD = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.geneticEpochsNUD = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.geneticGB = new System.Windows.Forms.GroupBox();
            this.EstimatorCB = new System.Windows.Forms.ComboBox();
            this.PriorityEstimGB = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.accPriorityNUD = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.memPriorityNUD = new System.Windows.Forms.NumericUpDown();
            this.PercentEstimGB = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.percentNUD = new System.Windows.Forms.NumericUpDown();
            this.AssessFuncGB = new System.Windows.Forms.GroupBox();
            this.label70 = new System.Windows.Forms.Label();
            this.networkNameTB = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.predsBtn = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.mutateSelNUD = new System.Windows.Forms.NumericUpDown();
            this.crossSelNUD = new System.Windows.Forms.NumericUpDown();
            this.copySelNUD = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.popolationCountNUD = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.createScriptsBtn = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.learningEpochsNUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.openPlotsFolderBtn = new System.Windows.Forms.Button();
            this.plotsPathTB = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.openLabelsFolderBtn = new System.Windows.Forms.Button();
            this.modelsPathTB = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.openModelsFolderBtn = new System.Windows.Forms.Button();
            this.labelsPathTB = new System.Windows.Forms.TextBox();
            this.openDatasetFolderBtn = new System.Windows.Forms.Button();
            this.datasetPathTB = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.pauseQueryBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.QueueGB = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trainQueryBtn = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коллекцияСетейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coutModeCB = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AssesGenZedGraph = new ZedGraph.ZedGraphControl();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.GANModelGB = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.sigmoidConvChb = new System.Windows.Forms.CheckBox();
            this.eluConvChb = new System.Windows.Forms.CheckBox();
            this.softsignConvChb = new System.Windows.Forms.CheckBox();
            this.seluConvChb = new System.Windows.Forms.CheckBox();
            this.lReluConvChb = new System.Windows.Forms.CheckBox();
            this.softplusConvChb = new System.Windows.Forms.CheckBox();
            this.softmaxConvChb = new System.Windows.Forms.CheckBox();
            this.tanhConvChb = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reluDenseChb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.softmaxDenseChb = new System.Windows.Forms.CheckBox();
            this.DenseNeuronsNUD = new System.Windows.Forms.NumericUpDown();
            this.lReluDenseChb = new System.Windows.Forms.CheckBox();
            this.softsignDenseChb = new System.Windows.Forms.CheckBox();
            this.ConvFiltersNUD = new System.Windows.Forms.NumericUpDown();
            this.sigmoidDenseChb = new System.Windows.Forms.CheckBox();
            this.slidingWindow2NUD = new System.Windows.Forms.NumericUpDown();
            this.eluDenseChb = new System.Windows.Forms.CheckBox();
            this.slidingWindow1NUD = new System.Windows.Forms.NumericUpDown();
            this.seluDenseChb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.softplusDenseChb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tanhDenseChb = new System.Windows.Forms.CheckBox();
            this.DenseLayersNumbNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ConvLayersNumbNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.reluConvChb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.denseDropoutNUD = new System.Windows.Forms.NumericUpDown();
            this.PReLUConvChB = new System.Windows.Forms.CheckBox();
            this.PReLUDenseChB = new System.Windows.Forms.CheckBox();
            this.TReLUConvChB = new System.Windows.Forms.CheckBox();
            this.ThReLUDenseChB = new System.Windows.Forms.CheckBox();
            this.ConvModelGB = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.denseDropoutChB = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.convDropoutChB = new System.Windows.Forms.CheckBox();
            this.convDropoutNUD = new System.Windows.Forms.NumericUpDown();
            this.LSTMModelGB = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.PercModelGB = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.convWithoutGenGB = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trainConvWithout = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ParamDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layer1DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layer2DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layer3DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layer4DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layer5DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layer6DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layer7DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layer8DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayModeCB = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.withoutGenChB = new System.Windows.Forms.CheckBox();
            this.label46 = new System.Windows.Forms.Label();
            this.lstmWithoutGB = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.percWithoutGB = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.ganWithoutGB = new System.Windows.Forms.GroupBox();
            this.label49 = new System.Windows.Forms.Label();
            this.upgradePopulationChB = new System.Windows.Forms.CheckBox();
            this.UpdateGeneticsGB = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label56 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ErrorTB = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.chrOutTB = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.genDontClearChB = new System.Windows.Forms.CheckBox();
            this.errDontClearChB = new System.Windows.Forms.CheckBox();
            this.chrDontClearChB = new System.Windows.Forms.CheckBox();
            this.ParamsZedGraph = new ZedGraph.ZedGraphControl();
            this.ZedGraphCB = new System.Windows.Forms.ComboBox();
            this.currentTaskPB = new System.Windows.Forms.ProgressBar();
            this.curTaskLabel = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.allTasksLabel = new System.Windows.Forms.Label();
            this.accZG = new ZedGraph.ZedGraphControl();
            this.callbacksGB = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.LRReducerChB = new System.Windows.Forms.CheckBox();
            this.LRShedulerChB = new System.Windows.Forms.CheckBox();
            this.earlyStopChB = new System.Windows.Forms.CheckBox();
            this.tensorboardChB = new System.Windows.Forms.CheckBox();
            this.modelCPChB = new System.Windows.Forms.CheckBox();
            this.TestTB1 = new System.Windows.Forms.TextBox();
            this.TestTB2 = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.TestTB3 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mutateRateNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchSizeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneticEpochsNUD)).BeginInit();
            this.geneticGB.SuspendLayout();
            this.PriorityEstimGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accPriorityNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memPriorityNUD)).BeginInit();
            this.PercentEstimGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentNUD)).BeginInit();
            this.AssessFuncGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mutateSelNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossSelNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copySelNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popolationCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningEpochsNUD)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.QueueGB.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GANModelGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DenseNeuronsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvFiltersNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidingWindow2NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidingWindow1NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DenseLayersNumbNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvLayersNumbNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denseDropoutNUD)).BeginInit();
            this.ConvModelGB.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convDropoutNUD)).BeginInit();
            this.LSTMModelGB.SuspendLayout();
            this.PercModelGB.SuspendLayout();
            this.convWithoutGenGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.lstmWithoutGB.SuspendLayout();
            this.percWithoutGB.SuspendLayout();
            this.ganWithoutGB.SuspendLayout();
            this.UpdateGeneticsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.callbacksGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // minConstSpeedTB
            // 
            this.minConstSpeedTB.Location = new System.Drawing.Point(96, 44);
            this.minConstSpeedTB.Name = "minConstSpeedTB";
            this.minConstSpeedTB.Size = new System.Drawing.Size(45, 22);
            this.minConstSpeedTB.TabIndex = 1;
            this.minConstSpeedTB.Text = "0.01";
            this.minConstSpeedTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // maxConstSpeedTB
            // 
            this.maxConstSpeedTB.Location = new System.Drawing.Point(166, 43);
            this.maxConstSpeedTB.Name = "maxConstSpeedTB";
            this.maxConstSpeedTB.Size = new System.Drawing.Size(45, 22);
            this.maxConstSpeedTB.TabIndex = 2;
            this.maxConstSpeedTB.Text = "0.700";
            this.maxConstSpeedTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // constSpeedChB
            // 
            this.constSpeedChB.AutoSize = true;
            this.constSpeedChB.Checked = true;
            this.constSpeedChB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.constSpeedChB.Location = new System.Drawing.Point(24, 45);
            this.constSpeedChB.Name = "constSpeedChB";
            this.constSpeedChB.Size = new System.Drawing.Size(66, 21);
            this.constSpeedChB.TabIndex = 40;
            this.constSpeedChB.Text = "Const";
            this.constSpeedChB.UseVisualStyleBackColor = true;
            this.constSpeedChB.CheckedChanged += new System.EventHandler(this.CheckBox19_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Обучение";
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(228, 43);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(85, 21);
            this.checkBox20.TabIndex = 42;
            this.checkBox20.Text = "Adaptive";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(319, 44);
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(45, 22);
            this.numericUpDown10.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label67);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.constSpeedChB);
            this.groupBox1.Controls.Add(this.minConstSpeedTB);
            this.groupBox1.Controls.Add(this.numericUpDown10);
            this.groupBox1.Controls.Add(this.maxConstSpeedTB);
            this.groupBox1.Controls.Add(this.checkBox20);
            this.groupBox1.Location = new System.Drawing.Point(5, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(418, 300);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mean_squared_errorChB);
            this.groupBox3.Controls.Add(this.cosine_proximityChB);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.poissonChB);
            this.groupBox3.Controls.Add(this.mean_absolute_errorChB);
            this.groupBox3.Controls.Add(this.kullback_leibler_divergenceChB);
            this.groupBox3.Controls.Add(this.mean_absolute_percentage_errorChB);
            this.groupBox3.Controls.Add(this.binary_crossentropyChB);
            this.groupBox3.Controls.Add(this.squared_hingeChB);
            this.groupBox3.Controls.Add(this.sparse_categorical_crossentropyChB);
            this.groupBox3.Controls.Add(this.mean_squared_logarithmic_errorChB);
            this.groupBox3.Controls.Add(this.categorical_crossentropyChB);
            this.groupBox3.Controls.Add(this.hingeChB);
            this.groupBox3.Controls.Add(this.logcoshChB);
            this.groupBox3.Controls.Add(this.categorical_hingeChB);
            this.groupBox3.Location = new System.Drawing.Point(134, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 202);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // mean_squared_errorChB
            // 
            this.mean_squared_errorChB.AutoSize = true;
            this.mean_squared_errorChB.Location = new System.Drawing.Point(6, 12);
            this.mean_squared_errorChB.Name = "mean_squared_errorChB";
            this.mean_squared_errorChB.Size = new System.Drawing.Size(59, 21);
            this.mean_squared_errorChB.TabIndex = 59;
            this.mean_squared_errorChB.Text = "MSE";
            this.mean_squared_errorChB.UseVisualStyleBackColor = true;
            // 
            // cosine_proximityChB
            // 
            this.cosine_proximityChB.AutoSize = true;
            this.cosine_proximityChB.Location = new System.Drawing.Point(129, 148);
            this.cosine_proximityChB.Name = "cosine_proximityChB";
            this.cosine_proximityChB.Size = new System.Drawing.Size(130, 21);
            this.cosine_proximityChB.TabIndex = 72;
            this.cosine_proximityChB.Text = "cosine proximity";
            this.cosine_proximityChB.UseVisualStyleBackColor = true;
            // 
            // poissonChB
            // 
            this.poissonChB.AutoSize = true;
            this.poissonChB.Location = new System.Drawing.Point(6, 148);
            this.poissonChB.Name = "poissonChB";
            this.poissonChB.Size = new System.Drawing.Size(79, 21);
            this.poissonChB.TabIndex = 71;
            this.poissonChB.Text = "poisson";
            this.poissonChB.UseVisualStyleBackColor = true;
            // 
            // mean_absolute_errorChB
            // 
            this.mean_absolute_errorChB.AutoSize = true;
            this.mean_absolute_errorChB.Location = new System.Drawing.Point(6, 40);
            this.mean_absolute_errorChB.Name = "mean_absolute_errorChB";
            this.mean_absolute_errorChB.Size = new System.Drawing.Size(59, 21);
            this.mean_absolute_errorChB.TabIndex = 60;
            this.mean_absolute_errorChB.Text = "MAE";
            this.mean_absolute_errorChB.UseVisualStyleBackColor = true;
            // 
            // kullback_leibler_divergenceChB
            // 
            this.kullback_leibler_divergenceChB.AutoSize = true;
            this.kullback_leibler_divergenceChB.Location = new System.Drawing.Point(6, 121);
            this.kullback_leibler_divergenceChB.Name = "kullback_leibler_divergenceChB";
            this.kullback_leibler_divergenceChB.Size = new System.Drawing.Size(57, 21);
            this.kullback_leibler_divergenceChB.TabIndex = 70;
            this.kullback_leibler_divergenceChB.Text = "KLD";
            this.kullback_leibler_divergenceChB.UseVisualStyleBackColor = true;
            // 
            // mean_absolute_percentage_errorChB
            // 
            this.mean_absolute_percentage_errorChB.AutoSize = true;
            this.mean_absolute_percentage_errorChB.Location = new System.Drawing.Point(6, 67);
            this.mean_absolute_percentage_errorChB.Name = "mean_absolute_percentage_errorChB";
            this.mean_absolute_percentage_errorChB.Size = new System.Drawing.Size(68, 21);
            this.mean_absolute_percentage_errorChB.TabIndex = 61;
            this.mean_absolute_percentage_errorChB.Text = "MAPE";
            this.mean_absolute_percentage_errorChB.UseVisualStyleBackColor = true;
            // 
            // binary_crossentropyChB
            // 
            this.binary_crossentropyChB.AutoSize = true;
            this.binary_crossentropyChB.Location = new System.Drawing.Point(129, 94);
            this.binary_crossentropyChB.Name = "binary_crossentropyChB";
            this.binary_crossentropyChB.Size = new System.Drawing.Size(126, 21);
            this.binary_crossentropyChB.TabIndex = 69;
            this.binary_crossentropyChB.Text = "B-crossentropy";
            this.binary_crossentropyChB.UseVisualStyleBackColor = true;
            // 
            // squared_hingeChB
            // 
            this.squared_hingeChB.AutoSize = true;
            this.squared_hingeChB.Location = new System.Drawing.Point(129, 121);
            this.squared_hingeChB.Name = "squared_hingeChB";
            this.squared_hingeChB.Size = new System.Drawing.Size(121, 21);
            this.squared_hingeChB.TabIndex = 62;
            this.squared_hingeChB.Text = "squared hinge";
            this.squared_hingeChB.UseVisualStyleBackColor = true;
            // 
            // sparse_categorical_crossentropyChB
            // 
            this.sparse_categorical_crossentropyChB.AutoSize = true;
            this.sparse_categorical_crossentropyChB.Location = new System.Drawing.Point(129, 67);
            this.sparse_categorical_crossentropyChB.Name = "sparse_categorical_crossentropyChB";
            this.sparse_categorical_crossentropyChB.Size = new System.Drawing.Size(135, 21);
            this.sparse_categorical_crossentropyChB.TabIndex = 68;
            this.sparse_categorical_crossentropyChB.Text = "SC-crossentropy";
            this.sparse_categorical_crossentropyChB.UseVisualStyleBackColor = true;
            // 
            // mean_squared_logarithmic_errorChB
            // 
            this.mean_squared_logarithmic_errorChB.AutoSize = true;
            this.mean_squared_logarithmic_errorChB.Location = new System.Drawing.Point(6, 94);
            this.mean_squared_logarithmic_errorChB.Name = "mean_squared_logarithmic_errorChB";
            this.mean_squared_logarithmic_errorChB.Size = new System.Drawing.Size(67, 21);
            this.mean_squared_logarithmic_errorChB.TabIndex = 63;
            this.mean_squared_logarithmic_errorChB.Text = "MSLE";
            this.mean_squared_logarithmic_errorChB.UseVisualStyleBackColor = true;
            // 
            // categorical_crossentropyChB
            // 
            this.categorical_crossentropyChB.AutoSize = true;
            this.categorical_crossentropyChB.Checked = true;
            this.categorical_crossentropyChB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.categorical_crossentropyChB.Location = new System.Drawing.Point(129, 40);
            this.categorical_crossentropyChB.Name = "categorical_crossentropyChB";
            this.categorical_crossentropyChB.Size = new System.Drawing.Size(126, 21);
            this.categorical_crossentropyChB.TabIndex = 67;
            this.categorical_crossentropyChB.Text = "C-crossentropy";
            this.categorical_crossentropyChB.UseVisualStyleBackColor = true;
            // 
            // hingeChB
            // 
            this.hingeChB.AutoSize = true;
            this.hingeChB.Location = new System.Drawing.Point(6, 175);
            this.hingeChB.Name = "hingeChB";
            this.hingeChB.Size = new System.Drawing.Size(65, 21);
            this.hingeChB.TabIndex = 64;
            this.hingeChB.Text = "hinge";
            this.hingeChB.UseVisualStyleBackColor = true;
            // 
            // logcoshChB
            // 
            this.logcoshChB.AutoSize = true;
            this.logcoshChB.Location = new System.Drawing.Point(129, 12);
            this.logcoshChB.Name = "logcoshChB";
            this.logcoshChB.Size = new System.Drawing.Size(79, 21);
            this.logcoshChB.TabIndex = 66;
            this.logcoshChB.Text = "logcosh";
            this.logcoshChB.UseVisualStyleBackColor = true;
            // 
            // categorical_hingeChB
            // 
            this.categorical_hingeChB.AutoSize = true;
            this.categorical_hingeChB.Location = new System.Drawing.Point(129, 175);
            this.categorical_hingeChB.Name = "categorical_hingeChB";
            this.categorical_hingeChB.Size = new System.Drawing.Size(104, 21);
            this.categorical_hingeChB.TabIndex = 65;
            this.categorical_hingeChB.Text = "categ hinge";
            this.categorical_hingeChB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SGD_OptChB);
            this.groupBox2.Controls.Add(this.RMSp_OptChB);
            this.groupBox2.Controls.Add(this.Adagrad_OptChB);
            this.groupBox2.Controls.Add(this.Adadelta_OptChB);
            this.groupBox2.Controls.Add(this.Adam_OptChB);
            this.groupBox2.Controls.Add(this.Adamax_OptChB);
            this.groupBox2.Controls.Add(this.Nadam_OptChB);
            this.groupBox2.Location = new System.Drawing.Point(6, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 202);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // SGD_OptChB
            // 
            this.SGD_OptChB.AutoSize = true;
            this.SGD_OptChB.Checked = true;
            this.SGD_OptChB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SGD_OptChB.Location = new System.Drawing.Point(9, 14);
            this.SGD_OptChB.Name = "SGD_OptChB";
            this.SGD_OptChB.Size = new System.Drawing.Size(60, 21);
            this.SGD_OptChB.TabIndex = 50;
            this.SGD_OptChB.Text = "SGD";
            this.SGD_OptChB.UseVisualStyleBackColor = true;
            // 
            // RMSp_OptChB
            // 
            this.RMSp_OptChB.AutoSize = true;
            this.RMSp_OptChB.Location = new System.Drawing.Point(9, 42);
            this.RMSp_OptChB.Name = "RMSp_OptChB";
            this.RMSp_OptChB.Size = new System.Drawing.Size(89, 21);
            this.RMSp_OptChB.TabIndex = 51;
            this.RMSp_OptChB.Text = "RMSprop";
            this.RMSp_OptChB.UseVisualStyleBackColor = true;
            // 
            // Adagrad_OptChB
            // 
            this.Adagrad_OptChB.AutoSize = true;
            this.Adagrad_OptChB.Location = new System.Drawing.Point(9, 69);
            this.Adagrad_OptChB.Name = "Adagrad_OptChB";
            this.Adagrad_OptChB.Size = new System.Drawing.Size(84, 21);
            this.Adagrad_OptChB.TabIndex = 52;
            this.Adagrad_OptChB.Text = "Adagrad";
            this.Adagrad_OptChB.UseVisualStyleBackColor = true;
            // 
            // Adadelta_OptChB
            // 
            this.Adadelta_OptChB.AutoSize = true;
            this.Adadelta_OptChB.Location = new System.Drawing.Point(9, 96);
            this.Adadelta_OptChB.Name = "Adadelta_OptChB";
            this.Adadelta_OptChB.Size = new System.Drawing.Size(86, 21);
            this.Adadelta_OptChB.TabIndex = 53;
            this.Adadelta_OptChB.Text = "Adadelta";
            this.Adadelta_OptChB.UseVisualStyleBackColor = true;
            // 
            // Adam_OptChB
            // 
            this.Adam_OptChB.AutoSize = true;
            this.Adam_OptChB.Location = new System.Drawing.Point(9, 123);
            this.Adam_OptChB.Name = "Adam_OptChB";
            this.Adam_OptChB.Size = new System.Drawing.Size(66, 21);
            this.Adam_OptChB.TabIndex = 54;
            this.Adam_OptChB.Text = "Adam";
            this.Adam_OptChB.UseVisualStyleBackColor = true;
            // 
            // Adamax_OptChB
            // 
            this.Adamax_OptChB.AutoSize = true;
            this.Adamax_OptChB.Location = new System.Drawing.Point(9, 150);
            this.Adamax_OptChB.Name = "Adamax_OptChB";
            this.Adamax_OptChB.Size = new System.Drawing.Size(80, 21);
            this.Adamax_OptChB.TabIndex = 55;
            this.Adamax_OptChB.Text = "Adamax";
            this.Adamax_OptChB.UseVisualStyleBackColor = true;
            // 
            // Nadam_OptChB
            // 
            this.Nadam_OptChB.AutoSize = true;
            this.Nadam_OptChB.Location = new System.Drawing.Point(9, 177);
            this.Nadam_OptChB.Name = "Nadam_OptChB";
            this.Nadam_OptChB.Size = new System.Drawing.Size(75, 21);
            this.Nadam_OptChB.TabIndex = 56;
            this.Nadam_OptChB.Text = "Nadam";
            this.Nadam_OptChB.UseVisualStyleBackColor = true;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(207, 72);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(87, 17);
            this.label67.TabIndex = 58;
            this.label67.Text = "loss function";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 57;
            this.label11.Text = "Оптимизатор";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(110, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "Алгоритм расчета скорости";
            // 
            // mutateRateNUD
            // 
            this.mutateRateNUD.Location = new System.Drawing.Point(115, 185);
            this.mutateRateNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.mutateRateNUD.Name = "mutateRateNUD";
            this.mutateRateNUD.Size = new System.Drawing.Size(49, 22);
            this.mutateRateNUD.TabIndex = 39;
            this.mutateRateNUD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Batch Size";
            // 
            // batchSizeNUD
            // 
            this.batchSizeNUD.Location = new System.Drawing.Point(113, 24);
            this.batchSizeNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.batchSizeNUD.Name = "batchSizeNUD";
            this.batchSizeNUD.Size = new System.Drawing.Size(86, 22);
            this.batchSizeNUD.TabIndex = 52;
            this.batchSizeNUD.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 17);
            this.label14.TabIndex = 53;
            this.label14.Text = "Epochs";
            // 
            // geneticEpochsNUD
            // 
            this.geneticEpochsNUD.Location = new System.Drawing.Point(186, 81);
            this.geneticEpochsNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.geneticEpochsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.geneticEpochsNUD.Name = "geneticEpochsNUD";
            this.geneticEpochsNUD.Size = new System.Drawing.Size(78, 22);
            this.geneticEpochsNUD.TabIndex = 54;
            this.geneticEpochsNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(576, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 55;
            this.label15.Text = "Структура";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(967, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 17);
            this.label16.TabIndex = 56;
            this.label16.Text = "Genetic";
            // 
            // geneticGB
            // 
            this.geneticGB.Controls.Add(this.EstimatorCB);
            this.geneticGB.Controls.Add(this.PriorityEstimGB);
            this.geneticGB.Controls.Add(this.PercentEstimGB);
            this.geneticGB.Controls.Add(this.AssessFuncGB);
            this.geneticGB.Controls.Add(this.networkNameTB);
            this.geneticGB.Controls.Add(this.label36);
            this.geneticGB.Controls.Add(this.button9);
            this.geneticGB.Controls.Add(this.label38);
            this.geneticGB.Controls.Add(this.predsBtn);
            this.geneticGB.Controls.Add(this.label31);
            this.geneticGB.Controls.Add(this.mutateRateNUD);
            this.geneticGB.Controls.Add(this.button1);
            this.geneticGB.Controls.Add(this.label25);
            this.geneticGB.Controls.Add(this.textBox4);
            this.geneticGB.Controls.Add(this.label24);
            this.geneticGB.Controls.Add(this.label23);
            this.geneticGB.Controls.Add(this.label22);
            this.geneticGB.Controls.Add(this.label21);
            this.geneticGB.Controls.Add(this.label20);
            this.geneticGB.Controls.Add(this.textBox3);
            this.geneticGB.Controls.Add(this.mutateSelNUD);
            this.geneticGB.Controls.Add(this.crossSelNUD);
            this.geneticGB.Controls.Add(this.copySelNUD);
            this.geneticGB.Controls.Add(this.geneticEpochsNUD);
            this.geneticGB.Controls.Add(this.label19);
            this.geneticGB.Controls.Add(this.label18);
            this.geneticGB.Controls.Add(this.popolationCountNUD);
            this.geneticGB.Controls.Add(this.label17);
            this.geneticGB.Location = new System.Drawing.Point(855, 53);
            this.geneticGB.Name = "geneticGB";
            this.geneticGB.Size = new System.Drawing.Size(296, 468);
            this.geneticGB.TabIndex = 57;
            this.geneticGB.TabStop = false;
            // 
            // EstimatorCB
            // 
            this.EstimatorCB.FormattingEnabled = true;
            this.EstimatorCB.Items.AddRange(new object[] {
            "Params % per Accuracy % Comparer",
            "1st estimator",
            "Priority estimator"});
            this.EstimatorCB.Location = new System.Drawing.Point(6, 246);
            this.EstimatorCB.Name = "EstimatorCB";
            this.EstimatorCB.Size = new System.Drawing.Size(284, 24);
            this.EstimatorCB.TabIndex = 62;
            this.EstimatorCB.SelectedIndexChanged += new System.EventHandler(this.EstimatorCB_SelectedIndexChanged);
            // 
            // PriorityEstimGB
            // 
            this.PriorityEstimGB.Controls.Add(this.label33);
            this.PriorityEstimGB.Controls.Add(this.label35);
            this.PriorityEstimGB.Controls.Add(this.accPriorityNUD);
            this.PriorityEstimGB.Controls.Add(this.label34);
            this.PriorityEstimGB.Controls.Add(this.memPriorityNUD);
            this.PriorityEstimGB.Location = new System.Drawing.Point(236, 215);
            this.PriorityEstimGB.Name = "PriorityEstimGB";
            this.PriorityEstimGB.Size = new System.Drawing.Size(33, 25);
            this.PriorityEstimGB.TabIndex = 106;
            this.PriorityEstimGB.TabStop = false;
            this.PriorityEstimGB.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(31, 61);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(52, 17);
            this.label33.TabIndex = 60;
            this.label33.Text = "Priority";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(193, 30);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(55, 17);
            this.label35.TabIndex = 59;
            this.label35.Text = "память";
            // 
            // accPriorityNUD
            // 
            this.accPriorityNUD.DecimalPlaces = 1;
            this.accPriorityNUD.Location = new System.Drawing.Point(110, 59);
            this.accPriorityNUD.Name = "accPriorityNUD";
            this.accPriorityNUD.Size = new System.Drawing.Size(66, 22);
            this.accPriorityNUD.TabIndex = 56;
            this.accPriorityNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(108, 30);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(68, 17);
            this.label34.TabIndex = 58;
            this.label34.Text = "точность";
            // 
            // memPriorityNUD
            // 
            this.memPriorityNUD.DecimalPlaces = 1;
            this.memPriorityNUD.Location = new System.Drawing.Point(185, 59);
            this.memPriorityNUD.Name = "memPriorityNUD";
            this.memPriorityNUD.Size = new System.Drawing.Size(63, 22);
            this.memPriorityNUD.TabIndex = 57;
            this.memPriorityNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // PercentEstimGB
            // 
            this.PercentEstimGB.Controls.Add(this.label37);
            this.PercentEstimGB.Controls.Add(this.percentNUD);
            this.PercentEstimGB.Location = new System.Drawing.Point(6, 268);
            this.PercentEstimGB.Name = "PercentEstimGB";
            this.PercentEstimGB.Size = new System.Drawing.Size(284, 101);
            this.PercentEstimGB.TabIndex = 105;
            this.PercentEstimGB.TabStop = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(44, 55);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(191, 34);
            this.label37.TabIndex = 61;
            this.label37.Text = "    % params incresment \r\nper 1%  accuracy incresment";
            // 
            // percentNUD
            // 
            this.percentNUD.Location = new System.Drawing.Point(108, 25);
            this.percentNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.percentNUD.Name = "percentNUD";
            this.percentNUD.Size = new System.Drawing.Size(50, 22);
            this.percentNUD.TabIndex = 60;
            this.percentNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // AssessFuncGB
            // 
            this.AssessFuncGB.Controls.Add(this.label70);
            this.AssessFuncGB.Location = new System.Drawing.Point(189, 215);
            this.AssessFuncGB.Name = "AssessFuncGB";
            this.AssessFuncGB.Size = new System.Drawing.Size(38, 24);
            this.AssessFuncGB.TabIndex = 107;
            this.AssessFuncGB.TabStop = false;
            this.AssessFuncGB.Visible = false;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(75, 44);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(111, 17);
            this.label70.TabIndex = 0;
            this.label70.Text = "z = x + x(minY/y)";
            // 
            // networkNameTB
            // 
            this.networkNameTB.Location = new System.Drawing.Point(92, 18);
            this.networkNameTB.Name = "networkNameTB";
            this.networkNameTB.Size = new System.Drawing.Size(172, 22);
            this.networkNameTB.TabIndex = 61;
            this.networkNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NetworkNameTB_KeyPress);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(111, 221);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(58, 17);
            this.label36.TabIndex = 0;
            this.label36.Text = "Оценка";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(103, 439);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 23);
            this.button9.TabIndex = 67;
            this.button9.Text = "Plots";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(17, 18);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(69, 17);
            this.label38.TabIndex = 60;
            this.label38.Text = "Имя сети";
            // 
            // predsBtn
            // 
            this.predsBtn.Location = new System.Drawing.Point(204, 439);
            this.predsBtn.Name = "predsBtn";
            this.predsBtn.Size = new System.Drawing.Size(86, 23);
            this.predsBtn.TabIndex = 62;
            this.predsBtn.Text = "Predict";
            this.predsBtn.UseVisualStyleBackColor = true;
            this.predsBtn.Click += new System.EventHandler(this.Button8_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(167, 187);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 17);
            this.label31.TabIndex = 40;
            this.label31.Text = "%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Train";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(237, 378);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 17);
            this.label25.TabIndex = 16;
            this.label25.Text = ".py";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(20, 375);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(207, 22);
            this.textBox4.TabIndex = 15;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 185);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 17);
            this.label24.TabIndex = 14;
            this.label24.Text = "Mutate Rate";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(216, 123);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 17);
            this.label23.TabIndex = 12;
            this.label23.Text = "mutate";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(168, 123);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 17);
            this.label22.TabIndex = 11;
            this.label22.Text = "cross";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(112, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 17);
            this.label21.TabIndex = 10;
            this.label21.Text = "copy";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(233, 410);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 17);
            this.label20.TabIndex = 9;
            this.label20.Text = ".bat";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 405);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 22);
            this.textBox3.TabIndex = 8;
            // 
            // mutateSelNUD
            // 
            this.mutateSelNUD.Location = new System.Drawing.Point(219, 146);
            this.mutateSelNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.mutateSelNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mutateSelNUD.Name = "mutateSelNUD";
            this.mutateSelNUD.Size = new System.Drawing.Size(45, 22);
            this.mutateSelNUD.TabIndex = 7;
            this.mutateSelNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // crossSelNUD
            // 
            this.crossSelNUD.Location = new System.Drawing.Point(170, 146);
            this.crossSelNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.crossSelNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crossSelNUD.Name = "crossSelNUD";
            this.crossSelNUD.Size = new System.Drawing.Size(43, 22);
            this.crossSelNUD.TabIndex = 6;
            this.crossSelNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // copySelNUD
            // 
            this.copySelNUD.Location = new System.Drawing.Point(115, 146);
            this.copySelNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.copySelNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.copySelNUD.Name = "copySelNUD";
            this.copySelNUD.Size = new System.Drawing.Size(49, 22);
            this.copySelNUD.TabIndex = 5;
            this.copySelNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 148);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "Пропорции";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Эпох обучения";
            // 
            // popolationCountNUD
            // 
            this.popolationCountNUD.Location = new System.Drawing.Point(187, 50);
            this.popolationCountNUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.popolationCountNUD.Name = "popolationCountNUD";
            this.popolationCountNUD.Size = new System.Drawing.Size(77, 22);
            this.popolationCountNUD.TabIndex = 1;
            this.popolationCountNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Размер популяции";
            // 
            // createScriptsBtn
            // 
            this.createScriptsBtn.Location = new System.Drawing.Point(1172, 488);
            this.createScriptsBtn.Name = "createScriptsBtn";
            this.createScriptsBtn.Size = new System.Drawing.Size(80, 23);
            this.createScriptsBtn.TabIndex = 72;
            this.createScriptsBtn.Text = "Create ";
            this.createScriptsBtn.UseVisualStyleBackColor = true;
            this.createScriptsBtn.Click += new System.EventHandler(this.createScriptsBtn_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(1261, 488);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(80, 23);
            this.testButton.TabIndex = 71;
            this.testButton.Text = "Test it!";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // learningEpochsNUD
            // 
            this.learningEpochsNUD.Location = new System.Drawing.Point(337, 24);
            this.learningEpochsNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.learningEpochsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningEpochsNUD.Name = "learningEpochsNUD";
            this.learningEpochsNUD.Size = new System.Drawing.Size(75, 22);
            this.learningEpochsNUD.TabIndex = 3;
            this.learningEpochsNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.openPlotsFolderBtn);
            this.groupBox4.Controls.Add(this.plotsPathTB);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.openLabelsFolderBtn);
            this.groupBox4.Controls.Add(this.modelsPathTB);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.openModelsFolderBtn);
            this.groupBox4.Controls.Add(this.labelsPathTB);
            this.groupBox4.Controls.Add(this.openDatasetFolderBtn);
            this.groupBox4.Controls.Add(this.datasetPathTB);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.batchSizeNUD);
            this.groupBox4.Controls.Add(this.learningEpochsNUD);
            this.groupBox4.Location = new System.Drawing.Point(5, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 173);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            // 
            // openPlotsFolderBtn
            // 
            this.openPlotsFolderBtn.Location = new System.Drawing.Point(337, 140);
            this.openPlotsFolderBtn.Name = "openPlotsFolderBtn";
            this.openPlotsFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.openPlotsFolderBtn.TabIndex = 66;
            this.openPlotsFolderBtn.Text = "Обзор";
            this.openPlotsFolderBtn.UseVisualStyleBackColor = true;
            this.openPlotsFolderBtn.Click += new System.EventHandler(this.openPlotsFolderBtn_Click);
            // 
            // plotsPathTB
            // 
            this.plotsPathTB.Location = new System.Drawing.Point(113, 140);
            this.plotsPathTB.Name = "plotsPathTB";
            this.plotsPathTB.Size = new System.Drawing.Size(218, 22);
            this.plotsPathTB.TabIndex = 65;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(20, 140);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(39, 17);
            this.label29.TabIndex = 64;
            this.label29.Text = "Plots";
            // 
            // openLabelsFolderBtn
            // 
            this.openLabelsFolderBtn.Location = new System.Drawing.Point(337, 112);
            this.openLabelsFolderBtn.Name = "openLabelsFolderBtn";
            this.openLabelsFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.openLabelsFolderBtn.TabIndex = 63;
            this.openLabelsFolderBtn.Text = "Обзор";
            this.openLabelsFolderBtn.UseVisualStyleBackColor = true;
            this.openLabelsFolderBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // modelsPathTB
            // 
            this.modelsPathTB.Location = new System.Drawing.Point(113, 83);
            this.modelsPathTB.Name = "modelsPathTB";
            this.modelsPathTB.Size = new System.Drawing.Size(218, 22);
            this.modelsPathTB.TabIndex = 62;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(20, 86);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 17);
            this.label28.TabIndex = 61;
            this.label28.Text = "Models";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(20, 115);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(50, 17);
            this.label27.TabIndex = 60;
            this.label27.Text = "Labels";
            // 
            // openModelsFolderBtn
            // 
            this.openModelsFolderBtn.Location = new System.Drawing.Point(337, 82);
            this.openModelsFolderBtn.Name = "openModelsFolderBtn";
            this.openModelsFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.openModelsFolderBtn.TabIndex = 59;
            this.openModelsFolderBtn.Text = "Обзор";
            this.openModelsFolderBtn.UseVisualStyleBackColor = true;
            this.openModelsFolderBtn.Click += new System.EventHandler(this.openModelsFolderBtn_Click);
            // 
            // labelsPathTB
            // 
            this.labelsPathTB.Location = new System.Drawing.Point(113, 112);
            this.labelsPathTB.Name = "labelsPathTB";
            this.labelsPathTB.Size = new System.Drawing.Size(218, 22);
            this.labelsPathTB.TabIndex = 58;
            // 
            // openDatasetFolderBtn
            // 
            this.openDatasetFolderBtn.Location = new System.Drawing.Point(337, 54);
            this.openDatasetFolderBtn.Name = "openDatasetFolderBtn";
            this.openDatasetFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.openDatasetFolderBtn.TabIndex = 57;
            this.openDatasetFolderBtn.Text = "Обзор";
            this.openDatasetFolderBtn.UseVisualStyleBackColor = true;
            this.openDatasetFolderBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // datasetPathTB
            // 
            this.datasetPathTB.Location = new System.Drawing.Point(113, 54);
            this.datasetPathTB.Name = "datasetPathTB";
            this.datasetPathTB.Size = new System.Drawing.Size(218, 22);
            this.datasetPathTB.TabIndex = 56;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 17);
            this.label26.TabIndex = 55;
            this.label26.Text = "Dataset";
            // 
            // pauseQueryBtn
            // 
            this.pauseQueryBtn.Location = new System.Drawing.Point(109, 440);
            this.pauseQueryBtn.Name = "pauseQueryBtn";
            this.pauseQueryBtn.Size = new System.Drawing.Size(89, 23);
            this.pauseQueryBtn.TabIndex = 60;
            this.pauseQueryBtn.Text = "Pause";
            this.pauseQueryBtn.UseVisualStyleBackColor = true;
            this.pauseQueryBtn.Click += new System.EventHandler(this.pauseQueryBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 61;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(5, 551);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(843, 426);
            this.textBox9.TabIndex = 63;
            // 
            // QueueGB
            // 
            this.QueueGB.Controls.Add(this.listView1);
            this.QueueGB.Controls.Add(this.textBox1);
            this.QueueGB.Controls.Add(this.button5);
            this.QueueGB.Controls.Add(this.progressBar1);
            this.QueueGB.Controls.Add(this.trainQueryBtn);
            this.QueueGB.Controls.Add(this.pauseQueryBtn);
            this.QueueGB.Controls.Add(this.button3);
            this.QueueGB.Location = new System.Drawing.Point(1798, 842);
            this.QueueGB.Name = "QueueGB";
            this.QueueGB.Size = new System.Drawing.Size(78, 98);
            this.QueueGB.TabIndex = 65;
            this.QueueGB.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(301, 321);
            this.listView1.TabIndex = 66;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 65;
            this.textBox1.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 23);
            this.button5.TabIndex = 64;
            this.button5.Text = "x";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(109, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(153, 23);
            this.progressBar1.TabIndex = 63;
            this.progressBar1.Visible = false;
            // 
            // trainQueryBtn
            // 
            this.trainQueryBtn.Location = new System.Drawing.Point(6, 440);
            this.trainQueryBtn.Name = "trainQueryBtn";
            this.trainQueryBtn.Size = new System.Drawing.Size(89, 23);
            this.trainQueryBtn.TabIndex = 62;
            this.trainQueryBtn.Text = "Start";
            this.trainQueryBtn.UseVisualStyleBackColor = true;
            this.trainQueryBtn.Click += new System.EventHandler(this.TrainQueryBtn_ClickAsync);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(1804, 822);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(66, 17);
            this.label32.TabIndex = 66;
            this.label32.Text = "Очередь";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.историяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.НастройкиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.СправкаToolStripMenuItem_Click);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.коллекцияСетейToolStripMenuItem});
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.историяToolStripMenuItem.Text = "История";
            // 
            // коллекцияСетейToolStripMenuItem
            // 
            this.коллекцияСетейToolStripMenuItem.Name = "коллекцияСетейToolStripMenuItem";
            this.коллекцияСетейToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.коллекцияСетейToolStripMenuItem.Text = "Коллекция сетей";
            this.коллекцияСетейToolStripMenuItem.Click += new System.EventHandler(this.КоллекцияСетейToolStripMenuItem_Click);
            // 
            // coutModeCB
            // 
            this.coutModeCB.FormattingEnabled = true;
            this.coutModeCB.Items.AddRange(new object[] {
            "Current Genetic Search",
            "Errorneous Chromosome Configuration",
            "Current Chromosome Output"});
            this.coutModeCB.Location = new System.Drawing.Point(5, 521);
            this.coutModeCB.Name = "coutModeCB";
            this.coutModeCB.Size = new System.Drawing.Size(418, 24);
            this.coutModeCB.TabIndex = 69;
            this.coutModeCB.SelectedIndexChanged += new System.EventHandler(this.CoutModeCB_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1789, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(119, 95);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.Visible = false;
            // 
            // AssesGenZedGraph
            // 
            this.AssesGenZedGraph.IsEnableHZoom = false;
            this.AssesGenZedGraph.IsEnableVZoom = false;
            this.AssesGenZedGraph.IsEnableWheelZoom = false;
            this.AssesGenZedGraph.Location = new System.Drawing.Point(855, 551);
            this.AssesGenZedGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssesGenZedGraph.Name = "AssesGenZedGraph";
            this.AssesGenZedGraph.ScrollGrace = 0D;
            this.AssesGenZedGraph.ScrollMaxX = 0D;
            this.AssesGenZedGraph.ScrollMaxY = 0D;
            this.AssesGenZedGraph.ScrollMaxY2 = 0D;
            this.AssesGenZedGraph.ScrollMinX = 0D;
            this.AssesGenZedGraph.ScrollMinY = 0D;
            this.AssesGenZedGraph.ScrollMinY2 = 0D;
            this.AssesGenZedGraph.Size = new System.Drawing.Size(927, 425);
            this.AssesGenZedGraph.TabIndex = 72;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Convolutional NN",
            "LSTM NN",
            "Perceptron NN",
            "GAN NN"});
            this.comboBox2.Location = new System.Drawing.Point(668, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 24);
            this.comboBox2.TabIndex = 73;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // GANModelGB
            // 
            this.GANModelGB.Controls.Add(this.label39);
            this.GANModelGB.Controls.Add(this.label30);
            this.GANModelGB.Location = new System.Drawing.Point(1743, 170);
            this.GANModelGB.Name = "GANModelGB";
            this.GANModelGB.Size = new System.Drawing.Size(48, 40);
            this.GANModelGB.TabIndex = 74;
            this.GANModelGB.TabStop = false;
            this.GANModelGB.Visible = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(146, 208);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(108, 17);
            this.label39.TabIndex = 1;
            this.label39.Text = "TO DO LATER!!";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(159, 185);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(80, 17);
            this.label30.TabIndex = 0;
            this.label30.Text = "GAN Model";
            // 
            // sigmoidConvChb
            // 
            this.sigmoidConvChb.AutoSize = true;
            this.sigmoidConvChb.Location = new System.Drawing.Point(287, 113);
            this.sigmoidConvChb.Name = "sigmoidConvChb";
            this.sigmoidConvChb.Size = new System.Drawing.Size(18, 17);
            this.sigmoidConvChb.TabIndex = 22;
            this.sigmoidConvChb.UseVisualStyleBackColor = true;
            // 
            // eluConvChb
            // 
            this.eluConvChb.AutoSize = true;
            this.eluConvChb.Location = new System.Drawing.Point(11, 44);
            this.eluConvChb.Name = "eluConvChb";
            this.eluConvChb.Size = new System.Drawing.Size(18, 17);
            this.eluConvChb.TabIndex = 23;
            this.eluConvChb.UseVisualStyleBackColor = true;
            // 
            // softsignConvChb
            // 
            this.softsignConvChb.AutoSize = true;
            this.softsignConvChb.Location = new System.Drawing.Point(287, 90);
            this.softsignConvChb.Name = "softsignConvChb";
            this.softsignConvChb.Size = new System.Drawing.Size(18, 17);
            this.softsignConvChb.TabIndex = 21;
            this.softsignConvChb.UseVisualStyleBackColor = true;
            // 
            // seluConvChb
            // 
            this.seluConvChb.AutoSize = true;
            this.seluConvChb.Location = new System.Drawing.Point(11, 67);
            this.seluConvChb.Name = "seluConvChb";
            this.seluConvChb.Size = new System.Drawing.Size(18, 17);
            this.seluConvChb.TabIndex = 24;
            this.seluConvChb.UseVisualStyleBackColor = true;
            // 
            // lReluConvChb
            // 
            this.lReluConvChb.AutoSize = true;
            this.lReluConvChb.Location = new System.Drawing.Point(11, 90);
            this.lReluConvChb.Name = "lReluConvChb";
            this.lReluConvChb.Size = new System.Drawing.Size(18, 17);
            this.lReluConvChb.TabIndex = 20;
            this.lReluConvChb.UseVisualStyleBackColor = true;
            // 
            // softplusConvChb
            // 
            this.softplusConvChb.AutoSize = true;
            this.softplusConvChb.Location = new System.Drawing.Point(287, 21);
            this.softplusConvChb.Name = "softplusConvChb";
            this.softplusConvChb.Size = new System.Drawing.Size(18, 17);
            this.softplusConvChb.TabIndex = 25;
            this.softplusConvChb.UseVisualStyleBackColor = true;
            // 
            // softmaxConvChb
            // 
            this.softmaxConvChb.AutoSize = true;
            this.softmaxConvChb.Location = new System.Drawing.Point(287, 44);
            this.softmaxConvChb.Name = "softmaxConvChb";
            this.softmaxConvChb.Size = new System.Drawing.Size(18, 17);
            this.softmaxConvChb.TabIndex = 19;
            this.softmaxConvChb.UseVisualStyleBackColor = true;
            // 
            // tanhConvChb
            // 
            this.tanhConvChb.AutoSize = true;
            this.tanhConvChb.Location = new System.Drawing.Point(287, 67);
            this.tanhConvChb.Name = "tanhConvChb";
            this.tanhConvChb.Size = new System.Drawing.Size(18, 17);
            this.tanhConvChb.TabIndex = 26;
            this.tanhConvChb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 34);
            this.label6.TabIndex = 18;
            this.label6.Text = " Функции \r\nактивации";
            // 
            // reluDenseChb
            // 
            this.reluDenseChb.AutoSize = true;
            this.reluDenseChb.Location = new System.Drawing.Point(35, 19);
            this.reluDenseChb.Name = "reluDenseChb";
            this.reluDenseChb.Size = new System.Drawing.Size(66, 21);
            this.reluDenseChb.TabIndex = 27;
            this.reluDenseChb.Text = "ReLU";
            this.reluDenseChb.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 51);
            this.label5.TabIndex = 17;
            this.label5.Text = "          Степень\r\nфильтров нейронов\r\n      первого слоя";
            // 
            // softmaxDenseChb
            // 
            this.softmaxDenseChb.AutoSize = true;
            this.softmaxDenseChb.Location = new System.Drawing.Point(311, 42);
            this.softmaxDenseChb.Name = "softmaxDenseChb";
            this.softmaxDenseChb.Size = new System.Drawing.Size(80, 21);
            this.softmaxDenseChb.TabIndex = 28;
            this.softmaxDenseChb.Text = "SoftMax";
            this.softmaxDenseChb.UseVisualStyleBackColor = true;
            // 
            // DenseNeuronsNUD
            // 
            this.DenseNeuronsNUD.Location = new System.Drawing.Point(33, 69);
            this.DenseNeuronsNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DenseNeuronsNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DenseNeuronsNUD.Name = "DenseNeuronsNUD";
            this.DenseNeuronsNUD.Size = new System.Drawing.Size(58, 22);
            this.DenseNeuronsNUD.TabIndex = 16;
            this.DenseNeuronsNUD.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lReluDenseChb
            // 
            this.lReluDenseChb.AutoSize = true;
            this.lReluDenseChb.Location = new System.Drawing.Point(35, 88);
            this.lReluDenseChb.Name = "lReluDenseChb";
            this.lReluDenseChb.Size = new System.Drawing.Size(74, 21);
            this.lReluDenseChb.TabIndex = 29;
            this.lReluDenseChb.Text = "LReLU";
            this.lReluDenseChb.UseVisualStyleBackColor = true;
            // 
            // softsignDenseChb
            // 
            this.softsignDenseChb.AutoSize = true;
            this.softsignDenseChb.Location = new System.Drawing.Point(311, 88);
            this.softsignDenseChb.Name = "softsignDenseChb";
            this.softsignDenseChb.Size = new System.Drawing.Size(83, 21);
            this.softsignDenseChb.TabIndex = 30;
            this.softsignDenseChb.Text = "SoftSign";
            this.softsignDenseChb.UseVisualStyleBackColor = true;
            // 
            // ConvFiltersNUD
            // 
            this.ConvFiltersNUD.Location = new System.Drawing.Point(34, 69);
            this.ConvFiltersNUD.Name = "ConvFiltersNUD";
            this.ConvFiltersNUD.Size = new System.Drawing.Size(58, 22);
            this.ConvFiltersNUD.TabIndex = 14;
            this.ConvFiltersNUD.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // sigmoidDenseChb
            // 
            this.sigmoidDenseChb.AutoSize = true;
            this.sigmoidDenseChb.Checked = true;
            this.sigmoidDenseChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sigmoidDenseChb.Location = new System.Drawing.Point(311, 111);
            this.sigmoidDenseChb.Name = "sigmoidDenseChb";
            this.sigmoidDenseChb.Size = new System.Drawing.Size(80, 21);
            this.sigmoidDenseChb.TabIndex = 31;
            this.sigmoidDenseChb.Text = "Sigmoid";
            this.sigmoidDenseChb.UseVisualStyleBackColor = true;
            // 
            // slidingWindow2NUD
            // 
            this.slidingWindow2NUD.Location = new System.Drawing.Point(6, 184);
            this.slidingWindow2NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slidingWindow2NUD.Name = "slidingWindow2NUD";
            this.slidingWindow2NUD.Size = new System.Drawing.Size(49, 22);
            this.slidingWindow2NUD.TabIndex = 12;
            this.slidingWindow2NUD.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.slidingWindow2NUD.ValueChanged += new System.EventHandler(this.NumericUpDown4_ValueChanged);
            // 
            // eluDenseChb
            // 
            this.eluDenseChb.AutoSize = true;
            this.eluDenseChb.Location = new System.Drawing.Point(35, 42);
            this.eluDenseChb.Name = "eluDenseChb";
            this.eluDenseChb.Size = new System.Drawing.Size(57, 21);
            this.eluDenseChb.TabIndex = 32;
            this.eluDenseChb.Text = "ELU";
            this.eluDenseChb.UseVisualStyleBackColor = true;
            // 
            // slidingWindow1NUD
            // 
            this.slidingWindow1NUD.Location = new System.Drawing.Point(6, 161);
            this.slidingWindow1NUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.slidingWindow1NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slidingWindow1NUD.Name = "slidingWindow1NUD";
            this.slidingWindow1NUD.Size = new System.Drawing.Size(49, 22);
            this.slidingWindow1NUD.TabIndex = 11;
            this.slidingWindow1NUD.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // seluDenseChb
            // 
            this.seluDenseChb.AutoSize = true;
            this.seluDenseChb.Location = new System.Drawing.Point(35, 65);
            this.seluDenseChb.Name = "seluDenseChb";
            this.seluDenseChb.Size = new System.Drawing.Size(66, 21);
            this.seluDenseChb.TabIndex = 33;
            this.seluDenseChb.Text = "SELU";
            this.seluDenseChb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "sliding \r\nwindow";
            // 
            // softplusDenseChb
            // 
            this.softplusDenseChb.AutoSize = true;
            this.softplusDenseChb.Location = new System.Drawing.Point(311, 19);
            this.softplusDenseChb.Name = "softplusDenseChb";
            this.softplusDenseChb.Size = new System.Drawing.Size(82, 21);
            this.softplusDenseChb.TabIndex = 34;
            this.softplusDenseChb.Text = "SoftPlus";
            this.softplusDenseChb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество \r\n слоёв(max)";
            // 
            // tanhDenseChb
            // 
            this.tanhDenseChb.AutoSize = true;
            this.tanhDenseChb.Location = new System.Drawing.Point(311, 65);
            this.tanhDenseChb.Name = "tanhDenseChb";
            this.tanhDenseChb.Size = new System.Drawing.Size(63, 21);
            this.tanhDenseChb.TabIndex = 35;
            this.tanhDenseChb.Text = "Tanh";
            this.tanhDenseChb.UseVisualStyleBackColor = true;
            // 
            // DenseLayersNumbNUD
            // 
            this.DenseLayersNumbNUD.Location = new System.Drawing.Point(33, 21);
            this.DenseLayersNumbNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DenseLayersNumbNUD.Name = "DenseLayersNumbNUD";
            this.DenseLayersNumbNUD.Size = new System.Drawing.Size(58, 22);
            this.DenseLayersNumbNUD.TabIndex = 8;
            this.DenseLayersNumbNUD.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Dropout";
            // 
            // ConvLayersNumbNUD
            // 
            this.ConvLayersNumbNUD.Location = new System.Drawing.Point(34, 21);
            this.ConvLayersNumbNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ConvLayersNumbNUD.Name = "ConvLayersNumbNUD";
            this.ConvLayersNumbNUD.Size = new System.Drawing.Size(58, 22);
            this.ConvLayersNumbNUD.TabIndex = 7;
            this.ConvLayersNumbNUD.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Полносвязные\r\n         слои";
            // 
            // reluConvChb
            // 
            this.reluConvChb.AutoSize = true;
            this.reluConvChb.Checked = true;
            this.reluConvChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reluConvChb.Location = new System.Drawing.Point(11, 21);
            this.reluConvChb.Name = "reluConvChb";
            this.reluConvChb.Size = new System.Drawing.Size(18, 17);
            this.reluConvChb.TabIndex = 4;
            this.reluConvChb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сверточные\r\n      слои";
            // 
            // denseDropoutNUD
            // 
            this.denseDropoutNUD.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.denseDropoutNUD.Location = new System.Drawing.Point(42, 118);
            this.denseDropoutNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.denseDropoutNUD.Name = "denseDropoutNUD";
            this.denseDropoutNUD.Size = new System.Drawing.Size(58, 22);
            this.denseDropoutNUD.TabIndex = 38;
            this.denseDropoutNUD.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // PReLUConvChB
            // 
            this.PReLUConvChB.AutoSize = true;
            this.PReLUConvChB.Location = new System.Drawing.Point(11, 113);
            this.PReLUConvChB.Name = "PReLUConvChB";
            this.PReLUConvChB.Size = new System.Drawing.Size(18, 17);
            this.PReLUConvChB.TabIndex = 41;
            this.PReLUConvChB.UseVisualStyleBackColor = true;
            // 
            // PReLUDenseChB
            // 
            this.PReLUDenseChB.AutoSize = true;
            this.PReLUDenseChB.Location = new System.Drawing.Point(35, 111);
            this.PReLUDenseChB.Name = "PReLUDenseChB";
            this.PReLUDenseChB.Size = new System.Drawing.Size(75, 21);
            this.PReLUDenseChB.TabIndex = 42;
            this.PReLUDenseChB.Text = "PReLU";
            this.PReLUDenseChB.UseVisualStyleBackColor = true;
            // 
            // TReLUConvChB
            // 
            this.TReLUConvChB.AutoSize = true;
            this.TReLUConvChB.Location = new System.Drawing.Point(11, 136);
            this.TReLUConvChB.Name = "TReLUConvChB";
            this.TReLUConvChB.Size = new System.Drawing.Size(18, 17);
            this.TReLUConvChB.TabIndex = 43;
            this.TReLUConvChB.UseVisualStyleBackColor = true;
            // 
            // ThReLUDenseChB
            // 
            this.ThReLUDenseChB.AutoSize = true;
            this.ThReLUDenseChB.Location = new System.Drawing.Point(35, 134);
            this.ThReLUDenseChB.Name = "ThReLUDenseChB";
            this.ThReLUDenseChB.Size = new System.Drawing.Size(75, 21);
            this.ThReLUDenseChB.TabIndex = 44;
            this.ThReLUDenseChB.Text = "TReLU";
            this.ThReLUDenseChB.UseVisualStyleBackColor = true;
            // 
            // ConvModelGB
            // 
            this.ConvModelGB.Controls.Add(this.groupBox9);
            this.ConvModelGB.Controls.Add(this.groupBox8);
            this.ConvModelGB.Controls.Add(this.groupBox7);
            this.ConvModelGB.Controls.Add(this.groupBox5);
            this.ConvModelGB.Controls.Add(this.label1);
            this.ConvModelGB.Controls.Add(this.label2);
            this.ConvModelGB.Location = new System.Drawing.Point(429, 53);
            this.ConvModelGB.Name = "ConvModelGB";
            this.ConvModelGB.Size = new System.Drawing.Size(419, 468);
            this.ConvModelGB.TabIndex = 50;
            this.ConvModelGB.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.eluConvChb);
            this.groupBox9.Controls.Add(this.seluConvChb);
            this.groupBox9.Controls.Add(this.ThReLUDenseChB);
            this.groupBox9.Controls.Add(this.lReluConvChb);
            this.groupBox9.Controls.Add(this.TReLUConvChB);
            this.groupBox9.Controls.Add(this.reluDenseChb);
            this.groupBox9.Controls.Add(this.softplusConvChb);
            this.groupBox9.Controls.Add(this.lReluDenseChb);
            this.groupBox9.Controls.Add(this.PReLUDenseChB);
            this.groupBox9.Controls.Add(this.eluDenseChb);
            this.groupBox9.Controls.Add(this.sigmoidConvChb);
            this.groupBox9.Controls.Add(this.seluDenseChb);
            this.groupBox9.Controls.Add(this.PReLUConvChB);
            this.groupBox9.Controls.Add(this.tanhDenseChb);
            this.groupBox9.Controls.Add(this.softsignConvChb);
            this.groupBox9.Controls.Add(this.softplusDenseChb);
            this.groupBox9.Controls.Add(this.softmaxConvChb);
            this.groupBox9.Controls.Add(this.sigmoidDenseChb);
            this.groupBox9.Controls.Add(this.tanhConvChb);
            this.groupBox9.Controls.Add(this.reluConvChb);
            this.groupBox9.Controls.Add(this.softmaxDenseChb);
            this.groupBox9.Controls.Add(this.softsignDenseChb);
            this.groupBox9.Location = new System.Drawing.Point(6, 290);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(408, 172);
            this.groupBox9.TabIndex = 105;
            this.groupBox9.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Location = new System.Drawing.Point(135, 52);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(145, 160);
            this.groupBox8.TabIndex = 105;
            this.groupBox8.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.DenseLayersNumbNUD);
            this.groupBox7.Controls.Add(this.denseDropoutChB);
            this.groupBox7.Controls.Add(this.DenseNeuronsNUD);
            this.groupBox7.Controls.Add(this.denseDropoutNUD);
            this.groupBox7.Location = new System.Drawing.Point(284, 52);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(129, 238);
            this.groupBox7.TabIndex = 105;
            this.groupBox7.TabStop = false;
            // 
            // denseDropoutChB
            // 
            this.denseDropoutChB.AutoSize = true;
            this.denseDropoutChB.Location = new System.Drawing.Point(18, 121);
            this.denseDropoutChB.Name = "denseDropoutChB";
            this.denseDropoutChB.Size = new System.Drawing.Size(18, 17);
            this.denseDropoutChB.TabIndex = 46;
            this.denseDropoutChB.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.convDropoutChB);
            this.groupBox5.Controls.Add(this.ConvLayersNumbNUD);
            this.groupBox5.Controls.Add(this.ConvFiltersNUD);
            this.groupBox5.Controls.Add(this.convDropoutNUD);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.slidingWindow2NUD);
            this.groupBox5.Controls.Add(this.slidingWindow1NUD);
            this.groupBox5.Location = new System.Drawing.Point(6, 52);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(125, 238);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            // 
            // convDropoutChB
            // 
            this.convDropoutChB.AutoSize = true;
            this.convDropoutChB.Location = new System.Drawing.Point(20, 121);
            this.convDropoutChB.Name = "convDropoutChB";
            this.convDropoutChB.Size = new System.Drawing.Size(18, 17);
            this.convDropoutChB.TabIndex = 47;
            this.convDropoutChB.UseVisualStyleBackColor = true;
            // 
            // convDropoutNUD
            // 
            this.convDropoutNUD.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.convDropoutNUD.Location = new System.Drawing.Point(44, 118);
            this.convDropoutNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.convDropoutNUD.Name = "convDropoutNUD";
            this.convDropoutNUD.Size = new System.Drawing.Size(58, 22);
            this.convDropoutNUD.TabIndex = 45;
            this.convDropoutNUD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // LSTMModelGB
            // 
            this.LSTMModelGB.Controls.Add(this.label40);
            this.LSTMModelGB.Location = new System.Drawing.Point(1743, 77);
            this.LSTMModelGB.Name = "LSTMModelGB";
            this.LSTMModelGB.Size = new System.Drawing.Size(48, 40);
            this.LSTMModelGB.TabIndex = 75;
            this.LSTMModelGB.TabStop = false;
            this.LSTMModelGB.Visible = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(146, 185);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(114, 34);
            this.label40.TabIndex = 0;
            this.label40.Text = "   LSTM Model\r\nTO DO LATER!!!!";
            // 
            // PercModelGB
            // 
            this.PercModelGB.Controls.Add(this.label41);
            this.PercModelGB.Location = new System.Drawing.Point(1743, 125);
            this.PercModelGB.Name = "PercModelGB";
            this.PercModelGB.Size = new System.Drawing.Size(48, 40);
            this.PercModelGB.TabIndex = 76;
            this.PercModelGB.TabStop = false;
            this.PercModelGB.Visible = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(145, 187);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(120, 34);
            this.label41.TabIndex = 0;
            this.label41.Text = "Perceptron Model\r\n  TO DO LATER!!!";
            // 
            // convWithoutGenGB
            // 
            this.convWithoutGenGB.Controls.Add(this.numericUpDown1);
            this.convWithoutGenGB.Controls.Add(this.trainConvWithout);
            this.convWithoutGenGB.Controls.Add(this.dataGridView2);
            this.convWithoutGenGB.Location = new System.Drawing.Point(1797, 31);
            this.convWithoutGenGB.Name = "convWithoutGenGB";
            this.convWithoutGenGB.Size = new System.Drawing.Size(48, 40);
            this.convWithoutGenGB.TabIndex = 77;
            this.convWithoutGenGB.TabStop = false;
            this.convWithoutGenGB.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(184, 371);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // trainConvWithout
            // 
            this.trainConvWithout.Location = new System.Drawing.Point(15, 401);
            this.trainConvWithout.Name = "trainConvWithout";
            this.trainConvWithout.Size = new System.Drawing.Size(75, 23);
            this.trainConvWithout.TabIndex = 1;
            this.trainConvWithout.Text = "Train";
            this.trainConvWithout.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParamDGV,
            this.layer1DGV,
            this.layer2DGV,
            this.layer3DGV,
            this.layer4DGV,
            this.layer5DGV,
            this.layer6DGV,
            this.layer7DGV,
            this.layer8DGV});
            this.dataGridView2.Location = new System.Drawing.Point(6, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(390, 317);
            this.dataGridView2.TabIndex = 0;
            // 
            // ParamDGV
            // 
            this.ParamDGV.HeaderText = "Param";
            this.ParamDGV.Name = "ParamDGV";
            // 
            // layer1DGV
            // 
            this.layer1DGV.HeaderText = "1";
            this.layer1DGV.Name = "layer1DGV";
            // 
            // layer2DGV
            // 
            this.layer2DGV.HeaderText = "2";
            this.layer2DGV.Name = "layer2DGV";
            // 
            // layer3DGV
            // 
            this.layer3DGV.HeaderText = "3";
            this.layer3DGV.Name = "layer3DGV";
            // 
            // layer4DGV
            // 
            this.layer4DGV.HeaderText = "4";
            this.layer4DGV.Name = "layer4DGV";
            // 
            // layer5DGV
            // 
            this.layer5DGV.HeaderText = "5";
            this.layer5DGV.Name = "layer5DGV";
            // 
            // layer6DGV
            // 
            this.layer6DGV.HeaderText = "6";
            this.layer6DGV.Name = "layer6DGV";
            // 
            // layer7DGV
            // 
            this.layer7DGV.HeaderText = "7";
            this.layer7DGV.Name = "layer7DGV";
            // 
            // layer8DGV
            // 
            this.layer8DGV.HeaderText = "8";
            this.layer8DGV.Name = "layer8DGV";
            // 
            // DisplayModeCB
            // 
            this.DisplayModeCB.FormattingEnabled = true;
            this.DisplayModeCB.Items.AddRange(new object[] {
            "Current Epoch Graph",
            "Current Genetic Search Graph"});
            this.DisplayModeCB.Location = new System.Drawing.Point(1789, 365);
            this.DisplayModeCB.Name = "DisplayModeCB";
            this.DisplayModeCB.Size = new System.Drawing.Size(119, 24);
            this.DisplayModeCB.TabIndex = 78;
            this.DisplayModeCB.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(44, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 79;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox4);
            this.groupBox6.Controls.Add(this.checkBox3);
            this.groupBox6.Controls.Add(this.checkBox2);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Location = new System.Drawing.Point(1789, 496);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(119, 115);
            this.groupBox6.TabIndex = 80;
            this.groupBox6.TabStop = false;
            this.groupBox6.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(239, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(98, 21);
            this.checkBox4.TabIndex = 82;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(44, 102);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 21);
            this.checkBox3.TabIndex = 81;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(239, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 80;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(1846, 182);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(38, 17);
            this.label42.TabIndex = 81;
            this.label42.Text = "GAN";
            this.label42.Visible = false;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(1844, 137);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(78, 17);
            this.label43.TabIndex = 82;
            this.label43.Text = "Perceptron";
            this.label43.Visible = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(1844, 91);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(45, 17);
            this.label44.TabIndex = 83;
            this.label44.Text = "LSTM";
            this.label44.Visible = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(1718, 29);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(59, 17);
            this.label45.TabIndex = 84;
            this.label45.Text = "New GB";
            this.label45.Visible = false;
            // 
            // withoutGenChB
            // 
            this.withoutGenChB.AutoSize = true;
            this.withoutGenChB.Location = new System.Drawing.Point(429, 28);
            this.withoutGenChB.Name = "withoutGenChB";
            this.withoutGenChB.Size = new System.Drawing.Size(131, 21);
            this.withoutGenChB.TabIndex = 85;
            this.withoutGenChB.Text = "Without Genetic";
            this.withoutGenChB.UseVisualStyleBackColor = true;
            this.withoutGenChB.CheckedChanged += new System.EventHandler(this.WithoutGenChB_CheckedChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(1844, 49);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(40, 17);
            this.label46.TabIndex = 86;
            this.label46.Text = "Conv";
            this.label46.Visible = false;
            // 
            // lstmWithoutGB
            // 
            this.lstmWithoutGB.Controls.Add(this.label47);
            this.lstmWithoutGB.Location = new System.Drawing.Point(1797, 77);
            this.lstmWithoutGB.Name = "lstmWithoutGB";
            this.lstmWithoutGB.Size = new System.Drawing.Size(48, 40);
            this.lstmWithoutGB.TabIndex = 87;
            this.lstmWithoutGB.TabStop = false;
            this.lstmWithoutGB.Visible = false;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(127, 171);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(150, 34);
            this.label47.TabIndex = 0;
            this.label47.Text = "        TO DO!!!!!\r\nLSTM Without Genetic";
            // 
            // percWithoutGB
            // 
            this.percWithoutGB.Controls.Add(this.label48);
            this.percWithoutGB.Location = new System.Drawing.Point(1797, 123);
            this.percWithoutGB.Name = "percWithoutGB";
            this.percWithoutGB.Size = new System.Drawing.Size(48, 41);
            this.percWithoutGB.TabIndex = 88;
            this.percWithoutGB.TabStop = false;
            this.percWithoutGB.Visible = false;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(110, 176);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(183, 34);
            this.label48.TabIndex = 0;
            this.label48.Text = "            TO DO!!!!\r\nPerceptron Without Genetic";
            // 
            // ganWithoutGB
            // 
            this.ganWithoutGB.Controls.Add(this.label49);
            this.ganWithoutGB.Location = new System.Drawing.Point(1797, 170);
            this.ganWithoutGB.Name = "ganWithoutGB";
            this.ganWithoutGB.Size = new System.Drawing.Size(48, 40);
            this.ganWithoutGB.TabIndex = 89;
            this.ganWithoutGB.TabStop = false;
            this.ganWithoutGB.Visible = false;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(132, 176);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(143, 34);
            this.label49.TabIndex = 0;
            this.label49.Text = "      TO DO!!!!!!!\r\nGAN Without Genetic";
            // 
            // upgradePopulationChB
            // 
            this.upgradePopulationChB.AutoSize = true;
            this.upgradePopulationChB.Location = new System.Drawing.Point(856, 27);
            this.upgradePopulationChB.Name = "upgradePopulationChB";
            this.upgradePopulationChB.Size = new System.Drawing.Size(85, 21);
            this.upgradePopulationChB.TabIndex = 90;
            this.upgradePopulationChB.Text = "Upgrade";
            this.upgradePopulationChB.UseVisualStyleBackColor = true;
            this.upgradePopulationChB.CheckedChanged += new System.EventHandler(this.upgradePopulationChB_CheckedChanged);
            // 
            // UpdateGeneticsGB
            // 
            this.UpdateGeneticsGB.Controls.Add(this.label55);
            this.UpdateGeneticsGB.Controls.Add(this.numericUpDown4);
            this.UpdateGeneticsGB.Controls.Add(this.label57);
            this.UpdateGeneticsGB.Controls.Add(this.label58);
            this.UpdateGeneticsGB.Controls.Add(this.label59);
            this.UpdateGeneticsGB.Controls.Add(this.numericUpDown5);
            this.UpdateGeneticsGB.Controls.Add(this.numericUpDown6);
            this.UpdateGeneticsGB.Controls.Add(this.label60);
            this.UpdateGeneticsGB.Controls.Add(this.label61);
            this.UpdateGeneticsGB.Controls.Add(this.numericUpDown7);
            this.UpdateGeneticsGB.Controls.Add(this.label62);
            this.UpdateGeneticsGB.Controls.Add(this.label63);
            this.UpdateGeneticsGB.Controls.Add(this.label64);
            this.UpdateGeneticsGB.Controls.Add(this.label65);
            this.UpdateGeneticsGB.Controls.Add(this.numericUpDown8);
            this.UpdateGeneticsGB.Controls.Add(this.numericUpDown9);
            this.UpdateGeneticsGB.Controls.Add(this.numericUpDown11);
            this.UpdateGeneticsGB.Controls.Add(this.label66);
            this.UpdateGeneticsGB.Controls.Add(this.numericUpDown3);
            this.UpdateGeneticsGB.Controls.Add(this.label56);
            this.UpdateGeneticsGB.Controls.Add(this.label54);
            this.UpdateGeneticsGB.Controls.Add(this.numericUpDown2);
            this.UpdateGeneticsGB.Controls.Add(this.label53);
            this.UpdateGeneticsGB.Controls.Add(this.label52);
            this.UpdateGeneticsGB.Controls.Add(this.textBox5);
            this.UpdateGeneticsGB.Controls.Add(this.button4);
            this.UpdateGeneticsGB.Controls.Add(this.button2);
            this.UpdateGeneticsGB.Location = new System.Drawing.Point(1743, 222);
            this.UpdateGeneticsGB.Name = "UpdateGeneticsGB";
            this.UpdateGeneticsGB.Size = new System.Drawing.Size(48, 40);
            this.UpdateGeneticsGB.TabIndex = 91;
            this.UpdateGeneticsGB.TabStop = false;
            this.UpdateGeneticsGB.Visible = false;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(215, 288);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(28, 17);
            this.label55.TabIndex = 88;
            this.label55.Text = "MB";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 1;
            this.numericUpDown4.Location = new System.Drawing.Point(143, 286);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(69, 22);
            this.numericUpDown4.TabIndex = 87;
            this.numericUpDown4.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(16, 288);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(87, 17);
            this.label57.TabIndex = 86;
            this.label57.Text = "Max memory";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(215, 231);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(55, 17);
            this.label58.TabIndex = 85;
            this.label58.Text = "память";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(141, 231);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(68, 17);
            this.label59.TabIndex = 84;
            this.label59.Text = "точность";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 1;
            this.numericUpDown5.Location = new System.Drawing.Point(214, 252);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown5.TabIndex = 83;
            this.numericUpDown5.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DecimalPlaces = 1;
            this.numericUpDown6.Location = new System.Drawing.Point(143, 252);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(66, 22);
            this.numericUpDown6.TabIndex = 82;
            this.numericUpDown6.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(18, 254);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(117, 17);
            this.label60.TabIndex = 81;
            this.label60.Text = "Приоритетность";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(183, 195);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(20, 17);
            this.label61.TabIndex = 80;
            this.label61.Text = "%";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(128, 193);
            this.numericUpDown7.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(49, 22);
            this.numericUpDown7.TabIndex = 79;
            this.numericUpDown7.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(18, 195);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(85, 17);
            this.label62.TabIndex = 78;
            this.label62.Text = "Mutate Rate";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(229, 131);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(51, 17);
            this.label63.TabIndex = 77;
            this.label63.Text = "mutate";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(181, 131);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(42, 17);
            this.label64.TabIndex = 76;
            this.label64.Text = "cross";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(125, 131);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(38, 17);
            this.label65.TabIndex = 75;
            this.label65.Text = "copy";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(232, 154);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(45, 22);
            this.numericUpDown8.TabIndex = 74;
            this.numericUpDown8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(183, 154);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown9.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(43, 22);
            this.numericUpDown9.TabIndex = 73;
            this.numericUpDown9.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(128, 154);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown11.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(49, 22);
            this.numericUpDown11.TabIndex = 72;
            this.numericUpDown11.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(18, 156);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(82, 17);
            this.label66.TabIndex = 71;
            this.label66.Text = "Пропорции";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(202, 97);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown3.TabIndex = 9;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(18, 99);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(106, 17);
            this.label56.TabIndex = 8;
            this.label56.Text = "Эпох обучения";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(18, 61);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(113, 17);
            this.label54.TabIndex = 6;
            this.label54.Text = "Дополнительно";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(202, 59);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown2.TabIndex = 5;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(170, 25);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(26, 17);
            this.label53.TabIndex = 4;
            this.label53.Text = "шт";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(18, 23);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(81, 17);
            this.label52.TabIndex = 3;
            this.label52.Text = "Популяция";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(105, 22);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(59, 22);
            this.textBox5.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Train";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Обзор";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ErrorTB
            // 
            this.ErrorTB.Location = new System.Drawing.Point(1721, 274);
            this.ErrorTB.Multiline = true;
            this.ErrorTB.Name = "ErrorTB";
            this.ErrorTB.Size = new System.Drawing.Size(48, 34);
            this.ErrorTB.TabIndex = 92;
            this.ErrorTB.Visible = false;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(1780, 283);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(83, 17);
            this.label50.TabIndex = 93;
            this.label50.Text = "error output";
            this.label50.Visible = false;
            // 
            // chrOutTB
            // 
            this.chrOutTB.Location = new System.Drawing.Point(1721, 314);
            this.chrOutTB.Multiline = true;
            this.chrOutTB.Name = "chrOutTB";
            this.chrOutTB.Size = new System.Drawing.Size(48, 33);
            this.chrOutTB.TabIndex = 94;
            this.chrOutTB.Visible = false;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(1780, 317);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(133, 17);
            this.label51.TabIndex = 95;
            this.label51.Text = "chromosome output";
            this.label51.Visible = false;
            // 
            // genDontClearChB
            // 
            this.genDontClearChB.AutoSize = true;
            this.genDontClearChB.Location = new System.Drawing.Point(429, 523);
            this.genDontClearChB.Name = "genDontClearChB";
            this.genDontClearChB.Size = new System.Drawing.Size(100, 21);
            this.genDontClearChB.TabIndex = 96;
            this.genDontClearChB.Text = "Don`t clear";
            this.genDontClearChB.UseVisualStyleBackColor = true;
            // 
            // errDontClearChB
            // 
            this.errDontClearChB.AutoSize = true;
            this.errDontClearChB.Location = new System.Drawing.Point(535, 523);
            this.errDontClearChB.Name = "errDontClearChB";
            this.errDontClearChB.Size = new System.Drawing.Size(100, 21);
            this.errDontClearChB.TabIndex = 97;
            this.errDontClearChB.Text = "Don`t clear";
            this.errDontClearChB.UseVisualStyleBackColor = true;
            this.errDontClearChB.Visible = false;
            // 
            // chrDontClearChB
            // 
            this.chrDontClearChB.AutoSize = true;
            this.chrDontClearChB.Location = new System.Drawing.Point(639, 523);
            this.chrDontClearChB.Name = "chrDontClearChB";
            this.chrDontClearChB.Size = new System.Drawing.Size(100, 21);
            this.chrDontClearChB.TabIndex = 98;
            this.chrDontClearChB.Text = "Don`t clear";
            this.chrDontClearChB.UseVisualStyleBackColor = true;
            this.chrDontClearChB.Visible = false;
            // 
            // ParamsZedGraph
            // 
            this.ParamsZedGraph.Location = new System.Drawing.Point(1789, 632);
            this.ParamsZedGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ParamsZedGraph.Name = "ParamsZedGraph";
            this.ParamsZedGraph.ScrollGrace = 0D;
            this.ParamsZedGraph.ScrollMaxX = 0D;
            this.ParamsZedGraph.ScrollMaxY = 0D;
            this.ParamsZedGraph.ScrollMaxY2 = 0D;
            this.ParamsZedGraph.ScrollMinX = 0D;
            this.ParamsZedGraph.ScrollMinY = 0D;
            this.ParamsZedGraph.ScrollMinY2 = 0D;
            this.ParamsZedGraph.Size = new System.Drawing.Size(56, 53);
            this.ParamsZedGraph.TabIndex = 99;
            this.ParamsZedGraph.Visible = false;
            // 
            // ZedGraphCB
            // 
            this.ZedGraphCB.FormattingEnabled = true;
            this.ZedGraphCB.Items.AddRange(new object[] {
            "Assesments - Epoch",
            "Accuracy - Params",
            "Accuracy - Epoch"});
            this.ZedGraphCB.Location = new System.Drawing.Point(855, 523);
            this.ZedGraphCB.Name = "ZedGraphCB";
            this.ZedGraphCB.Size = new System.Drawing.Size(397, 24);
            this.ZedGraphCB.TabIndex = 100;
            this.ZedGraphCB.SelectedIndexChanged += new System.EventHandler(this.ZedGraphCB_SelectedIndexChanged);
            // 
            // currentTaskPB
            // 
            this.currentTaskPB.Location = new System.Drawing.Point(1323, 523);
            this.currentTaskPB.Name = "currentTaskPB";
            this.currentTaskPB.Size = new System.Drawing.Size(459, 24);
            this.currentTaskPB.TabIndex = 101;
            // 
            // curTaskLabel
            // 
            this.curTaskLabel.AutoSize = true;
            this.curTaskLabel.Location = new System.Drawing.Point(1258, 527);
            this.curTaskLabel.Name = "curTaskLabel";
            this.curTaskLabel.Size = new System.Drawing.Size(16, 17);
            this.curTaskLabel.TabIndex = 102;
            this.curTaskLabel.Text = "0";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(1280, 527);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(12, 17);
            this.label68.TabIndex = 103;
            this.label68.Text = "/";
            // 
            // allTasksLabel
            // 
            this.allTasksLabel.AutoSize = true;
            this.allTasksLabel.Location = new System.Drawing.Point(1298, 527);
            this.allTasksLabel.Name = "allTasksLabel";
            this.allTasksLabel.Size = new System.Drawing.Size(16, 17);
            this.allTasksLabel.TabIndex = 104;
            this.allTasksLabel.Text = "0";
            // 
            // accZG
            // 
            this.accZG.Location = new System.Drawing.Point(1789, 693);
            this.accZG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accZG.Name = "accZG";
            this.accZG.ScrollGrace = 0D;
            this.accZG.ScrollMaxX = 0D;
            this.accZG.ScrollMaxY = 0D;
            this.accZG.ScrollMaxY2 = 0D;
            this.accZG.ScrollMinX = 0D;
            this.accZG.ScrollMinY = 0D;
            this.accZG.ScrollMinY2 = 0D;
            this.accZG.Size = new System.Drawing.Size(56, 56);
            this.accZG.TabIndex = 105;
            this.accZG.Visible = false;
            // 
            // callbacksGB
            // 
            this.callbacksGB.Controls.Add(this.checkBox5);
            this.callbacksGB.Controls.Add(this.LRReducerChB);
            this.callbacksGB.Controls.Add(this.LRShedulerChB);
            this.callbacksGB.Controls.Add(this.earlyStopChB);
            this.callbacksGB.Controls.Add(this.tensorboardChB);
            this.callbacksGB.Controls.Add(this.modelCPChB);
            this.callbacksGB.Location = new System.Drawing.Point(1172, 59);
            this.callbacksGB.Name = "callbacksGB";
            this.callbacksGB.Size = new System.Drawing.Size(277, 339);
            this.callbacksGB.TabIndex = 106;
            this.callbacksGB.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(26, 178);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(98, 21);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // LRReducerChB
            // 
            this.LRReducerChB.AutoSize = true;
            this.LRReducerChB.Location = new System.Drawing.Point(26, 152);
            this.LRReducerChB.Name = "LRReducerChB";
            this.LRReducerChB.Size = new System.Drawing.Size(176, 21);
            this.LRReducerChB.TabIndex = 4;
            this.LRReducerChB.Text = "Reduce LR On Plateau";
            this.LRReducerChB.UseVisualStyleBackColor = true;
            // 
            // LRShedulerChB
            // 
            this.LRShedulerChB.AutoSize = true;
            this.LRShedulerChB.Location = new System.Drawing.Point(26, 125);
            this.LRShedulerChB.Name = "LRShedulerChB";
            this.LRShedulerChB.Size = new System.Drawing.Size(188, 21);
            this.LRShedulerChB.TabIndex = 3;
            this.LRShedulerChB.Text = "Learning Rate Scheduler";
            this.LRShedulerChB.UseVisualStyleBackColor = true;
            // 
            // earlyStopChB
            // 
            this.earlyStopChB.AutoSize = true;
            this.earlyStopChB.Location = new System.Drawing.Point(26, 97);
            this.earlyStopChB.Name = "earlyStopChB";
            this.earlyStopChB.Size = new System.Drawing.Size(122, 21);
            this.earlyStopChB.TabIndex = 2;
            this.earlyStopChB.Text = "Early Stopping";
            this.earlyStopChB.UseVisualStyleBackColor = true;
            // 
            // tensorboardChB
            // 
            this.tensorboardChB.AutoSize = true;
            this.tensorboardChB.Location = new System.Drawing.Point(26, 70);
            this.tensorboardChB.Name = "tensorboardChB";
            this.tensorboardChB.Size = new System.Drawing.Size(117, 21);
            this.tensorboardChB.TabIndex = 1;
            this.tensorboardChB.Text = "Tensor Board";
            this.tensorboardChB.UseVisualStyleBackColor = true;
            // 
            // modelCPChB
            // 
            this.modelCPChB.AutoSize = true;
            this.modelCPChB.Location = new System.Drawing.Point(26, 47);
            this.modelCPChB.Name = "modelCPChB";
            this.modelCPChB.Size = new System.Drawing.Size(142, 21);
            this.modelCPChB.TabIndex = 0;
            this.modelCPChB.Text = "Model Checkpoint";
            this.modelCPChB.UseVisualStyleBackColor = true;
            // 
            // TestTB1
            // 
            this.TestTB1.Location = new System.Drawing.Point(1620, 59);
            this.TestTB1.Multiline = true;
            this.TestTB1.Name = "TestTB1";
            this.TestTB1.Size = new System.Drawing.Size(82, 46);
            this.TestTB1.TabIndex = 107;
            this.TestTB1.Visible = false;
            // 
            // TestTB2
            // 
            this.TestTB2.Location = new System.Drawing.Point(1620, 170);
            this.TestTB2.Multiline = true;
            this.TestTB2.Name = "TestTB2";
            this.TestTB2.Size = new System.Drawing.Size(82, 40);
            this.TestTB2.TabIndex = 108;
            this.TestTB2.Visible = false;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(1618, 32);
            this.label69.Name = "label69";
            this.label69.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label69.Size = new System.Drawing.Size(84, 17);
            this.label69.TabIndex = 109;
            this.label69.Text = "Without sort";
            this.label69.Visible = false;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(1620, 145);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(118, 17);
            this.label71.TabIndex = 110;
            this.label71.Text = "A = a + a *Pmin/P";
            this.label71.Visible = false;
            // 
            // TestTB3
            // 
            this.TestTB3.Location = new System.Drawing.Point(1620, 280);
            this.TestTB3.Multiline = true;
            this.TestTB3.Name = "TestTB3";
            this.TestTB3.Size = new System.Drawing.Size(82, 49);
            this.TestTB3.TabIndex = 111;
            this.TestTB3.Visible = false;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(1632, 260);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(57, 17);
            this.label72.TabIndex = 112;
            this.label72.Text = "Segm A";
            this.label72.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1220, 434);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 113;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.TestTB3);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.TestTB2);
            this.Controls.Add(this.TestTB1);
            this.Controls.Add(this.callbacksGB);
            this.Controls.Add(this.accZG);
            this.Controls.Add(this.allTasksLabel);
            this.Controls.Add(this.createScriptsBtn);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.curTaskLabel);
            this.Controls.Add(this.currentTaskPB);
            this.Controls.Add(this.ZedGraphCB);
            this.Controls.Add(this.ParamsZedGraph);
            this.Controls.Add(this.chrDontClearChB);
            this.Controls.Add(this.errDontClearChB);
            this.Controls.Add(this.genDontClearChB);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.chrOutTB);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.ErrorTB);
            this.Controls.Add(this.UpdateGeneticsGB);
            this.Controls.Add(this.upgradePopulationChB);
            this.Controls.Add(this.ganWithoutGB);
            this.Controls.Add(this.percWithoutGB);
            this.Controls.Add(this.lstmWithoutGB);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.withoutGenChB);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.DisplayModeCB);
            this.Controls.Add(this.convWithoutGenGB);
            this.Controls.Add(this.PercModelGB);
            this.Controls.Add(this.LSTMModelGB);
            this.Controls.Add(this.GANModelGB);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.AssesGenZedGraph);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.coutModeCB);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.QueueGB);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.geneticGB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ConvModelGB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " NN Family Creater";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mutateRateNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchSizeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneticEpochsNUD)).EndInit();
            this.geneticGB.ResumeLayout(false);
            this.geneticGB.PerformLayout();
            this.PriorityEstimGB.ResumeLayout(false);
            this.PriorityEstimGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accPriorityNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memPriorityNUD)).EndInit();
            this.PercentEstimGB.ResumeLayout(false);
            this.PercentEstimGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentNUD)).EndInit();
            this.AssessFuncGB.ResumeLayout(false);
            this.AssessFuncGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mutateSelNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossSelNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copySelNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popolationCountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningEpochsNUD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.QueueGB.ResumeLayout(false);
            this.QueueGB.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GANModelGB.ResumeLayout(false);
            this.GANModelGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DenseNeuronsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvFiltersNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidingWindow2NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidingWindow1NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DenseLayersNumbNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvLayersNumbNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denseDropoutNUD)).EndInit();
            this.ConvModelGB.ResumeLayout(false);
            this.ConvModelGB.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convDropoutNUD)).EndInit();
            this.LSTMModelGB.ResumeLayout(false);
            this.LSTMModelGB.PerformLayout();
            this.PercModelGB.ResumeLayout(false);
            this.PercModelGB.PerformLayout();
            this.convWithoutGenGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.lstmWithoutGB.ResumeLayout(false);
            this.lstmWithoutGB.PerformLayout();
            this.percWithoutGB.ResumeLayout(false);
            this.percWithoutGB.PerformLayout();
            this.ganWithoutGB.ResumeLayout(false);
            this.ganWithoutGB.PerformLayout();
            this.UpdateGeneticsGB.ResumeLayout(false);
            this.UpdateGeneticsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.callbacksGB.ResumeLayout(false);
            this.callbacksGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox minConstSpeedTB;
        private System.Windows.Forms.TextBox maxConstSpeedTB;
        private System.Windows.Forms.CheckBox constSpeedChB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown batchSizeNUD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown geneticEpochsNUD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox geneticGB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown mutateSelNUD;
        private System.Windows.Forms.NumericUpDown crossSelNUD;
        private System.Windows.Forms.NumericUpDown copySelNUD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown learningEpochsNUD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown popolationCountNUD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button openPlotsFolderBtn;
        private System.Windows.Forms.TextBox plotsPathTB;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button openLabelsFolderBtn;
        private System.Windows.Forms.TextBox modelsPathTB;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button openModelsFolderBtn;
        private System.Windows.Forms.TextBox labelsPathTB;
        private System.Windows.Forms.Button openDatasetFolderBtn;
        private System.Windows.Forms.TextBox datasetPathTB;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pauseQueryBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button predsBtn;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.NumericUpDown mutateRateNUD;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox QueueGB;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown memPriorityNUD;
        private System.Windows.Forms.NumericUpDown accPriorityNUD;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox networkNameTB;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ComboBox coutModeCB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ZedGraph.ZedGraphControl AssesGenZedGraph;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox GANModelGB;
        private System.Windows.Forms.CheckBox sigmoidConvChb;
        private System.Windows.Forms.CheckBox eluConvChb;
        private System.Windows.Forms.CheckBox softsignConvChb;
        private System.Windows.Forms.CheckBox seluConvChb;
        private System.Windows.Forms.CheckBox lReluConvChb;
        private System.Windows.Forms.CheckBox softplusConvChb;
        private System.Windows.Forms.CheckBox softmaxConvChb;
        private System.Windows.Forms.CheckBox tanhConvChb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox reluDenseChb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox softmaxDenseChb;
        private System.Windows.Forms.NumericUpDown DenseNeuronsNUD;
        private System.Windows.Forms.CheckBox lReluDenseChb;
        private System.Windows.Forms.CheckBox softsignDenseChb;
        private System.Windows.Forms.NumericUpDown ConvFiltersNUD;
        private System.Windows.Forms.CheckBox sigmoidDenseChb;
        private System.Windows.Forms.NumericUpDown slidingWindow2NUD;
        private System.Windows.Forms.CheckBox eluDenseChb;
        private System.Windows.Forms.NumericUpDown slidingWindow1NUD;
        private System.Windows.Forms.CheckBox seluDenseChb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox softplusDenseChb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox tanhDenseChb;
        private System.Windows.Forms.NumericUpDown DenseLayersNumbNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ConvLayersNumbNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox reluConvChb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown denseDropoutNUD;
        private System.Windows.Forms.CheckBox PReLUConvChB;
        private System.Windows.Forms.CheckBox PReLUDenseChB;
        private System.Windows.Forms.CheckBox TReLUConvChB;
        private System.Windows.Forms.CheckBox ThReLUDenseChB;
        private System.Windows.Forms.GroupBox ConvModelGB;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox LSTMModelGB;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.GroupBox PercModelGB;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox convWithoutGenGB;
        private System.Windows.Forms.ComboBox DisplayModeCB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коллекцияСетейToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button trainConvWithout;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParamDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer1DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer2DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer3DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer4DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer5DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer6DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer7DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer8DGV;
        private System.Windows.Forms.CheckBox withoutGenChB;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.GroupBox lstmWithoutGB;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox percWithoutGB;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox ganWithoutGB;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button createScriptsBtn;
        private System.Windows.Forms.CheckBox upgradePopulationChB;
        private System.Windows.Forms.GroupBox UpdateGeneticsGB;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox convDropoutChB;
        private System.Windows.Forms.CheckBox denseDropoutChB;
        private System.Windows.Forms.NumericUpDown convDropoutNUD;
        private System.Windows.Forms.Button trainQueryBtn;
        public System.Windows.Forms.TextBox ErrorTB;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox chrOutTB;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox Nadam_OptChB;
        private System.Windows.Forms.CheckBox Adamax_OptChB;
        private System.Windows.Forms.CheckBox Adam_OptChB;
        private System.Windows.Forms.CheckBox Adadelta_OptChB;
        private System.Windows.Forms.CheckBox Adagrad_OptChB;
        private System.Windows.Forms.CheckBox RMSp_OptChB;
        private System.Windows.Forms.CheckBox SGD_OptChB;
        private System.Windows.Forms.CheckBox cosine_proximityChB;
        private System.Windows.Forms.CheckBox poissonChB;
        private System.Windows.Forms.CheckBox kullback_leibler_divergenceChB;
        private System.Windows.Forms.CheckBox binary_crossentropyChB;
        private System.Windows.Forms.CheckBox sparse_categorical_crossentropyChB;
        private System.Windows.Forms.CheckBox categorical_crossentropyChB;
        private System.Windows.Forms.CheckBox logcoshChB;
        private System.Windows.Forms.CheckBox categorical_hingeChB;
        private System.Windows.Forms.CheckBox hingeChB;
        private System.Windows.Forms.CheckBox mean_squared_logarithmic_errorChB;
        private System.Windows.Forms.CheckBox squared_hingeChB;
        private System.Windows.Forms.CheckBox mean_absolute_percentage_errorChB;
        private System.Windows.Forms.CheckBox mean_absolute_errorChB;
        private System.Windows.Forms.CheckBox mean_squared_errorChB;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox genDontClearChB;
        private System.Windows.Forms.CheckBox errDontClearChB;
        private System.Windows.Forms.CheckBox chrDontClearChB;
        private System.Windows.Forms.ListView listView1;
        private ZedGraph.ZedGraphControl ParamsZedGraph;
        private System.Windows.Forms.ComboBox ZedGraphCB;
        private System.Windows.Forms.ProgressBar currentTaskPB;
        private System.Windows.Forms.Label curTaskLabel;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label allTasksLabel;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox PercentEstimGB;
        private System.Windows.Forms.Label label36;
        private ZedGraph.ZedGraphControl accZG;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown percentNUD;
        private System.Windows.Forms.ComboBox EstimatorCB;
        private System.Windows.Forms.GroupBox PriorityEstimGB;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox AssessFuncGB;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.GroupBox callbacksGB;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox LRReducerChB;
        private System.Windows.Forms.CheckBox LRShedulerChB;
        private System.Windows.Forms.CheckBox earlyStopChB;
        private System.Windows.Forms.CheckBox tensorboardChB;
        private System.Windows.Forms.CheckBox modelCPChB;
        private System.Windows.Forms.TextBox TestTB1;
        private System.Windows.Forms.TextBox TestTB2;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox TestTB3;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Button button6;
    }
}

