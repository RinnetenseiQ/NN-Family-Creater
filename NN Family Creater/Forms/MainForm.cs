using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace NN_Family_Creater
{
    public partial class Form1 : Form
    {
        public Thread worker;

        List<String> convActivations;
        List<String> denseActivations;

        List<String> optimazers;
        List<String> loss_functions;

        List<ConvolutionalChromosome> population;
        List<ConvolutionalNetwork> eliteChromosomes;

        ConvRandomParams crp;
        DenseRandomParams drp;
        NetworkRandomParams nrp;

        static Random random;

        Form propertyWindow;
        Form nnCollectionsWindow;
        Form aboutWindow;
        Form predsWindow;

        public float tempAccuracy = 0;
        public int tempParameters = 0;
        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            InitializeUserElements();
            InitializeProperties();


               
            random = new Random();
            instance = this;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TO DO
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    //Task.Run(TrainConvolutionalNN());
                    //worker = new Thread(new ThreadStart(TrainConvolutionalNN));
                    //worker.Start();
                    var task = new Task(() => TrainConvolutionalNN());
                    task.Start();
                    break;
                case 1:
                    TrainLSTM_NN();
                    break;
                case 2:
                    TrainPerceptronNN();
                    break;
                case 3:
                    TrainGAN_NN();
                    break;
            }

        }



        public void CollectConv_NN_Params()
        {
            convActivations = new List<string>();
            if (reluConvChb.Checked) convActivations.Add("relu");
            if (softmaxConvChb.Checked) convActivations.Add("softmax");
            if (lReluConvChb.Checked) convActivations.Add("Leaky ReLU");
            if (softsignConvChb.Checked) convActivations.Add("softsign");
            if (sigmoidConvChb.Checked) convActivations.Add("sigmoid");
            if (eluConvChb.Checked) convActivations.Add("elu");
            if (seluConvChb.Checked) convActivations.Add("selu");
            if (softplusConvChb.Checked) convActivations.Add("softplus");
            if (tanhConvChb.Checked) convActivations.Add("tang");
            if (PReLUConvChB.Checked) convActivations.Add("PReLu");
            if (TReLUConvChB.Checked) convActivations.Add("TReLU");

            denseActivations = new List<string>();
            if (reluDenseChb.Checked) denseActivations.Add("relu");
            if (softmaxDenseChb.Checked) denseActivations.Add("softmax");
            if (lReluDenseChb.Checked) denseActivations.Add("Leaky ReLU");
            if (softsignDenseChb.Checked) denseActivations.Add("softsign");
            if (sigmoidDenseChb.Checked) denseActivations.Add("sigmoid");
            if (eluDenseChb.Checked) denseActivations.Add("elu");
            if (seluDenseChb.Checked) denseActivations.Add("selu");
            if (softplusDenseChb.Checked) denseActivations.Add("softplus");
            if (tanhDenseChb.Checked) denseActivations.Add("tang");
            if (PReLUDenseChB.Checked) denseActivations.Add("PReLU");
            if (ThReLUDenseChB.Checked) denseActivations.Add("TReLU");

            optimazers = new List<string>();
            if (SGD_OptChB.Checked) optimazers.Add("SGD");

            loss_functions = new List<string>();
            if (categorical_crossentropyChB.Checked) loss_functions.Add("categorical_crossentropy");

            nrp = new NetworkRandomParams(new float[2] {float.Parse(minConstSpeedTB.Text, System.Globalization.CultureInfo.InvariantCulture),
                                                        float.Parse(maxConstSpeedTB.Text, System.Globalization.CultureInfo.InvariantCulture)},
                                                        datasetPathTB.Text, networkNameTB.Text, optimazers, loss_functions, (int)learningEpochsNUD.Value, (int)batchSizeNUD.Value);

            crp = new ConvRandomParams((int)ConvLayersNumbNUD.Value,
                                       (int)ConvFiltersNUD.Value,
                                            convActivations.Count,
                                            convActivations,
                                        new int[] { (int)slidingWindow1NUD.Value, (int)slidingWindow2NUD.Value },
                                            convDropoutChB.Checked,
                                       (int)convDropoutNUD.Value);
            drp = new DenseRandomParams((int)DenseLayersNumbNUD.Value,
                                        (int)DenseNeuronsNUD.Value,
                                        nrp.networkOutputNumb, // Support.GetOutputNumb(datasetPath);
                                             denseActivations.Count,
                                             denseActivations,
                                             denseDropoutChB.Checked,
                                        (int)denseDropoutNUD.Value);
        }

        public static void TrainConvolutionalNN()
        {
            if (instance.InvokeRequired)
            {
                //instance.Invoke(new Action<object>(TrainConvolutionalNN), new object[] { });

                instance.Invoke(new Action(TrainConvolutionalNN));
                return;
            }

            instance.CollectConv_NN_Params();
            instance.textBox9.Clear();
            instance.population = new List<ConvolutionalChromosome>((int)instance.popolationCountNUD.Value);
            
            while (instance.population.Count != instance.population.Capacity)
            {
                instance.population.Add(new ConvolutionalChromosome(instance.nrp, instance.crp, instance.drp, random));
                instance.population[instance.population.Count - 1].name = "Chromosome " + instance.population.Count.ToString();
                //UpdateAssesmentParams(population[population.Count - 1]);
                instance.UpdateAssesmentParams(instance.population[instance.population.Count - 1]);

            }
            
            Support.UpdateAssesment(instance.population);
         
            instance.population.Sort(new ChromosomeComparer2());
            instance.eliteChromosomes.Add(new ConvolutionalNetwork(instance.population[0]));

            /////
            instance.textBox9.AppendText("Epoch 0" + Environment.NewLine);
            for (int v = 0; v < instance.population.Count; v++) instance.textBox9.AppendText(instance.population[v].assessment + ":" + instance.population[v].accuracy + "/" + instance.population[v].paramsCount + " ");
            instance.textBox9.AppendText(Environment.NewLine + "---------------------------" + Environment.NewLine);

            // train

            for (int i = 0; i < instance.geneticEpochsNUD.Value; i++)
            {
                for (int m = 1; m < instance.population.Count; m++)
                {
                    if (new Random().Next() < 5) instance.population[m] = new ConvolutionalChromosome(instance.nrp, instance.crp, instance.drp, random);
                    else
                    {
                        instance.population[m].MutateConvolutional(instance.crp, (int)instance.mutateRateNUD.Value);
                        instance.population[m].MutateDense(instance.drp, (int)instance.denseDropoutNUD.Value);
                    }
                }


                for (int n = 0; n < instance.population.Count; n++)
                {
                    instance.UpdateAssesmentParams(instance.population[n]);
                }
                
                Support.UpdateAssesment(instance.population); 


                //population.Sort(new ChromosomeComparer((float)memPriorityNUD.Value, (float)accPriorityNUD.Value));
                instance.population.Sort(new ChromosomeComparer2());
                instance.eliteChromosomes.Add(new ConvolutionalNetwork(instance.population[0]));


                instance.textBox9.AppendText("Epoch: " + (i + 1).ToString());
                instance.textBox9.AppendText(Environment.NewLine);
                instance.textBox9.AppendText(instance.population[0].name);
                instance.textBox9.AppendText(Environment.NewLine);

                instance.textBox9.AppendText("Conv Layers: is " + instance.population[0].convPart.convLayers.Count.ToString() + ", should be " + instance.population[0].convPart.convLayers.Capacity.ToString());
                instance.textBox9.AppendText(Environment.NewLine);
                instance.textBox9.AppendText("Filters:");
                for (int l = 0; l < instance.population[0].convPart.convLayersNumb; l++)
                {
                    instance.textBox9.AppendText(" " + instance.population[0].convPart.convLayers[l].filters);
                }
                instance.textBox9.AppendText(Environment.NewLine);
                instance.textBox9.AppendText("Window: " + instance.population[0].convPart.convLayers[0].slidingWindow[0].ToString() + "x" + instance.population[0].convPart.convLayers[0].slidingWindow[1].ToString());
                instance.textBox9.AppendText(Environment.NewLine);
                instance.textBox9.AppendText("SameWindow: " + instance.population[0].convPart.sameSlidingWindowsSize + ", allWindowSquare: " + instance.population[0].convPart.allSquareSlidingWindows + " firstSquare: " + instance.population[0].convPart.convLayers[0].squareSlidingWindow);
                instance.textBox9.AppendText(Environment.NewLine);
                instance.textBox9.AppendText("Activation: " + instance.convActivations[instance.population[0].convPart.convLayers[0].activationIndex] + " - same = " + instance.population[0].convPart.sameActivations);
                instance.textBox9.AppendText(Environment.NewLine);
                instance.textBox9.AppendText("Dense Layers: is " + instance.population[0].densePart.denseLayer.Count.ToString() + ", should be " + instance.population[0].densePart.denseLayer.Capacity.ToString());
                instance.textBox9.AppendText(Environment.NewLine);
                //textBox9.AppendText("Neurons: " + population[0].densePart.denseLayer[0].neurons.ToString());
                instance.textBox9.AppendText("Neurons:");
                for (int k = 0; k < instance.population[0].densePart.denseLayersNumb; k++)
                {
                    instance.textBox9.AppendText(" " + instance.population[0].densePart.denseLayer[k].neurons);
                }
                instance.textBox9.AppendText(Environment.NewLine);
                instance.textBox9.AppendText("Activation: " + instance.denseActivations[instance.population[0].densePart.denseLayer[0].activationIndex] + " - same = " + instance.population[0].densePart.sameActivations);
                instance.textBox9.AppendText(Environment.NewLine);
                for (int s = 0; s < instance.population.Count; s++)
                {
                    instance.textBox9.AppendText(instance.population[s].assessment.ToString() + ":" + instance.population[s].accuracy.ToString() + "/" + instance.population[s].paramsCount.ToString() + "  ");
                }
                instance.textBox9.AppendText(Environment.NewLine);
                instance.textBox9.AppendText("-----------------------------------------------------");
                instance.textBox9.AppendText(Environment.NewLine);
            }
        }

        public void TrainLSTM_NN()
        {
            textBox9.Clear();
            textBox9.AppendText("Are you kretin?");
            textBox9.AppendText(Environment.NewLine);
            textBox9.AppendText("Snachala realizui your LSTM network");
            //TO DO LATER!!!
        }

        public void TrainPerceptronNN()
        {
            textBox9.Clear();
            textBox9.AppendText("Are you kretin?");
            textBox9.AppendText(Environment.NewLine);
            textBox9.AppendText("Snachala realizui your Perceptron");
            //TO DO LATER!!!
        }

        public void TrainGAN_NN()
        {
            textBox9.Clear();
            textBox9.AppendText("Are you kretin?");
            textBox9.AppendText(Environment.NewLine);
            textBox9.AppendText("Snachala realizui your GAN network");
            // TO DO LATER!!!
        }


        public void InitializeUserElements()
        {
            propertyWindow = new PropertyForm();
            nnCollectionsWindow = new NNCollectionsForm();
            aboutWindow = new AboutForm();
            predsWindow = new PredictionForm();
            eliteChromosomes = new List<ConvolutionalNetwork>();
            /// To initialize elite networks list from ConfigEditor

            //////// GB
            convWithoutGenGB.Location = ConvModelGB.Location;

            GANModelGB.Location = ConvModelGB.Location;
            ganWithoutGB.Location = ConvModelGB.Location;

            LSTMModelGB.Location = ConvModelGB.Location;
            lstmWithoutGB.Location = ConvModelGB.Location;

            PercModelGB.Location = ConvModelGB.Location;
            percWithoutGB.Location = ConvModelGB.Location;


            convWithoutGenGB.Size = ConvModelGB.Size;

            GANModelGB.Size = ConvModelGB.Size;
            ganWithoutGB.Size = ConvModelGB.Size;

            LSTMModelGB.Size = ConvModelGB.Size;
            lstmWithoutGB.Size = ConvModelGB.Size;

            PercModelGB.Size = ConvModelGB.Size;
            percWithoutGB.Size = ConvModelGB.Size;

            UpdateGeneticsGB.Size = geneticGB.Size;
            UpdateGeneticsGB.Location = geneticGB.Location;


            ErrorTB.Location = textBox9.Location;
            ErrorTB.Size = textBox9.Size;
            chrOutTB.Location = textBox9.Location;
            chrOutTB.Size = textBox9.Size;
            //////////


            textBox9.ScrollBars = ScrollBars.Vertical;
            ErrorTB.ScrollBars = ScrollBars.Vertical;
            chrOutTB.ScrollBars = ScrollBars.Vertical;
            textBox9.ReadOnly = true;
            ErrorTB.ReadOnly = true;
            chrOutTB.ReadOnly = true;
            datasetPathTB.ReadOnly = true;
            modelsPathTB.ReadOnly = true;
            labelsPathTB.ReadOnly = true;
            plotsPathTB.ReadOnly = true;

            coutModeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            coutModeCB.SelectedIndex = 0;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.SelectedIndex = 0;
            DisplayModeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            DisplayModeCB.SelectedIndex = 0;
        }

        public void InitializeProperties()
        {
            Properties.Settings.Default.DirectoryPath = ConfigEditor.Config.Read("DirectoryPath").ToString();
            Properties.Settings.Default.convScriptNumber = Convert.ToInt32(ConfigEditor.Config.Read("convScriptNumber"));
            Properties.Settings.Default.datasetDirectory = datasetPathTB.Text = ConfigEditor.Config.Read("datasetDirectory").ToString();
            Properties.Settings.Default.modelsDirectory = modelsPathTB.Text = ConfigEditor.Config.Read("modelsDirectory").ToString();
            Properties.Settings.Default.labelsDirectory = labelsPathTB.Text = ConfigEditor.Config.Read("labelsDirectory").ToString();
            Properties.Settings.Default.plotsDirectory = plotsPathTB.Text = ConfigEditor.Config.Read("plotsDirectory").ToString();



        }
        public void ModelGBHideShow()
        {
            if (withoutGenChB.Checked)
            {
                geneticGB.Enabled = false;
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        ConvModelGB.Visible = false; convWithoutGenGB.Visible = true;
                        LSTMModelGB.Visible = false; lstmWithoutGB.Visible = false;
                        PercModelGB.Visible = false; percWithoutGB.Visible = false;
                        GANModelGB.Visible = false; ganWithoutGB.Visible = false;
                        break;
                    case 1:
                        ConvModelGB.Visible = false; convWithoutGenGB.Visible = false;
                        LSTMModelGB.Visible = false; lstmWithoutGB.Visible = true;
                        PercModelGB.Visible = false; percWithoutGB.Visible = false;
                        GANModelGB.Visible = false; ganWithoutGB.Visible = false;
                        break;
                    case 2:
                        ConvModelGB.Visible = false; convWithoutGenGB.Visible = false;
                        LSTMModelGB.Visible = false; lstmWithoutGB.Visible = false;
                        PercModelGB.Visible = false; percWithoutGB.Visible = true;
                        GANModelGB.Visible = false; ganWithoutGB.Visible = false;
                        break;
                    case 3:
                        ConvModelGB.Visible = false; convWithoutGenGB.Visible = false;
                        LSTMModelGB.Visible = false; lstmWithoutGB.Visible = false;
                        PercModelGB.Visible = false; percWithoutGB.Visible = false;
                        GANModelGB.Visible = false; ganWithoutGB.Visible = true;
                        break;
                }
            }
            else
            {
                geneticGB.Enabled = true;
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        ConvModelGB.Visible = true; convWithoutGenGB.Visible = false;
                        LSTMModelGB.Visible = false; lstmWithoutGB.Visible = false;
                        PercModelGB.Visible = false; percWithoutGB.Visible = false;
                        GANModelGB.Visible = false; ganWithoutGB.Visible = false;
                        break;
                    case 1:
                        ConvModelGB.Visible = false; convWithoutGenGB.Visible = false;
                        LSTMModelGB.Visible = true; lstmWithoutGB.Visible = false;
                        PercModelGB.Visible = false; percWithoutGB.Visible = false;
                        GANModelGB.Visible = false; ganWithoutGB.Visible = false;
                        break;
                    case 2:
                        ConvModelGB.Visible = false; convWithoutGenGB.Visible = false;
                        LSTMModelGB.Visible = false; lstmWithoutGB.Visible = false;
                        PercModelGB.Visible = true; percWithoutGB.Visible = false;
                        GANModelGB.Visible = false; ganWithoutGB.Visible = false;
                        break;
                    case 3:
                        ConvModelGB.Visible = false; convWithoutGenGB.Visible = false;
                        LSTMModelGB.Visible = false; lstmWithoutGB.Visible = false;
                        PercModelGB.Visible = false; percWithoutGB.Visible = false;
                        GANModelGB.Visible = true; ganWithoutGB.Visible = false;
                        break;
                }
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                minConstSpeedTB.Visible = true;
                maxConstSpeedTB.Visible = true;
                
            }
            else
            {
                minConstSpeedTB.Visible = false;
                maxConstSpeedTB.Visible = false;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            propertyWindow.ShowDialog(this);
        }


        private void button8_Click(object sender, EventArgs e)
        {
            predsWindow.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelGBHideShow();
        }

        private void коллекцияСетейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nnCollectionsWindow.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow.Show();
        }


        private void withoutGenChB_CheckedChanged(object sender, EventArgs e)
        {
            ModelGBHideShow();

        }

        private void upgradePopulationChB_CheckedChanged(object sender, EventArgs e)
        {
            if (upgradePopulationChB.Checked)
            {
                UpdateGeneticsGB.Visible = true;
                geneticGB.Visible = false;
            }
            else
            {
                UpdateGeneticsGB.Visible = false;
                geneticGB.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(@"C:\keras\Directory\scripts\convolutional\convolutional.py", @"C:\keras\Directory\scripts\convolutional\genetic\temp_convolution.py", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Support.insertLineToFile(@"C:\keras\Directory\scripts\convolutional\genetic\temp_convolution.py", 73, Support.code_2);
            MessageBox.Show("Записано!!"); /// cjmment
        } ///Test it

        private void pauseQueryBtn_Click(object sender, EventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //string dataPath = String.Concat()
            ConvolutionalNetwork.CreateConvBatFile("convolutional_v742.py", @"C:\keras\Directory\scripts\convolutional\genetic\elites", datasetPathTB.Text + @"\showplaces", modelsPathTB.Text, labelsPathTB.Text, plotsPathTB.Text);
        }

        private void createScriptsBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < eliteChromosomes.Count; i++) ConvolutionalNetwork.CreateNetworkScript(eliteChromosomes[i], convActivations, denseActivations);
        }

        private void openModelsFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = Properties.Settings.Default.DirectoryPath + @"\";
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                modelsPathTB.Text = Properties.Settings.Default.modelsDirectory = FBD.SelectedPath;
                ConfigEditor.Config.Write("modelsDirectory", Properties.Settings.Default.modelsDirectory);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = Properties.Settings.Default.DirectoryPath + @"\";
            //Thread.Sleep(100);
            SendKeys.Send("{TAB}{TAB}{RIGHT}");
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                datasetPathTB.Text = Properties.Settings.Default.datasetDirectory = FBD.SelectedPath;
                ConfigEditor.Config.Write("datasetDirectory", Properties.Settings.Default.datasetDirectory);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = Properties.Settings.Default.DirectoryPath + @"\";

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                labelsPathTB.Text = Properties.Settings.Default.labelsDirectory = FBD.SelectedPath;
                ConfigEditor.Config.Write("labelsDirectory", Properties.Settings.Default.labelsDirectory);
            }
        }

        private void openPlotsFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = Properties.Settings.Default.DirectoryPath + @"\";
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                plotsPathTB.Text = Properties.Settings.Default.plotsDirectory = FBD.SelectedPath;
                ConfigEditor.Config.Write("plotsDirectory", Properties.Settings.Default.plotsDirectory);
            }
        }



        ///////////////////////////////////////////////////////
        // new Process
        public class ThreadParam
        {
            public Form1 form1;
            public ConvolutionalChromosome chromosome;
            public ThreadParam(Form1 frm, ConvolutionalChromosome ch)
            {
                form1 = frm;
                chromosome = ch;
            }
        }
        
        //public void startUpdateAssesmentParams(ConvolutionalChromosome chr)
        //{
        //    ThreadParam threadParam = new ThreadParam(instance, chr);
        //    worker = new Thread(new ParameterizedThreadStart(UpdateAssesmentParams));
        //    worker.Start(threadParam);
        //}
        

        public void UpdateAssesmentParams(ConvolutionalChromosome chromosome)
        {
            //ThreadParam param = (ThreadParam)par;
            //if (param.form1.InvokeRequired)
            //{
            //    param.form1.Invoke(new Action<object>(UpdateAssesmentParams), new object[] { par });
            //    return;
            //}

            ErrorTB.Clear();
            chrOutTB.Clear();

            ConvolutionalNetwork temp_net = new ConvolutionalNetwork(chromosome);
            ConvolutionalNetwork.CreateNetworkScript(temp_net, chromosome.crp.convActivations, chromosome.drp.denseActivations);
            ConvolutionalNetwork.CreateConvBatFile("temp_convolution.py", @"C:\keras\Directory\scripts\convolutional\genetic", datasetPathTB.Text, modelsPathTB.Text, labelsPathTB.Text, plotsPathTB.Text);
            createConvBatProcess();
            
            //worker.Suspend();
            

            chromosome.accuracy = tempAccuracy;
            chromosome.paramsCount = tempParameters;
        }

        void OutputHandler(object sendingProcess, DataReceivedEventArgs consoleLine)
        {
            string accString = "";
            string totalParamsString = "";
            string str = consoleLine.Data;
            addTextToTexbox(str);
            if (str != null)
            {
                if (str.Contains("accuracy"))
                {
                    accString = str;
                    accString = accString.Remove(accString.IndexOf("accuracy"), "accuracy".Length);
                    accString = accString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                    accString = accString.Replace(" ", "");
                    getAccuracyToMainProcess(accString);
                }
                if (consoleLine.Data.Contains("Total params:"))
                {
                    totalParamsString = str;
                    totalParamsString = totalParamsString.Remove(totalParamsString.IndexOf("Total params:"), "Total params:".Length);
                    totalParamsString = totalParamsString.Replace(" ", "");
                    totalParamsString = totalParamsString.Replace(",", "");
                    getParamsCountToMainProcess(totalParamsString);
                }
            }

            //s.Add(consoleLine.Data + Environment.NewLine);
        }

        void ErrorHandler(object sendingProcess, DataReceivedEventArgs consoleLine)
        {
            addTextToErrTexbox(consoleLine.Data);
        }

        public void getAccuracyToMainProcess(string acc)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(getAccuracyToMainProcess), new object[] { acc });
                return;
            }
            tempAccuracy = float.Parse(acc, System.Globalization.CultureInfo.InvariantCulture);
        }

        public void getParamsCountToMainProcess(string parameters)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(getAccuracyToMainProcess), new object[] { parameters });
                return;
            }
            tempParameters = int.Parse(parameters);
        }
        public void addTextToTexbox(string data)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(addTextToTexbox), new object[] { data });
                return;
            }
            chrOutTB.AppendText(data + Environment.NewLine);
        }

        public void addTextToErrTexbox(string data)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(addTextToErrTexbox), new object[] { data });
                return;
            }
            ErrorTB.AppendText(data + Environment.NewLine);
        }
        public void processExited(object sender, System.EventArgs e)
        {
            worker.Resume();
        }
        public void createConvBatProcess()
        {
            Process p = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = @"/c C:\keras\Directory\scripts\convolutional\temp_train.bat",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false
                }

            };
            p.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            p.ErrorDataReceived += new DataReceivedEventHandler(ErrorHandler);

            p.Start();

            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            //p.WaitForExit();
            //p.Exited += new EventHandler(processExited);
        }

        ///////////////////////////////////////////////////////


        private void trainQueryBtn_ClickAsync(object sender, EventArgs e)
        {
            textBox9.Clear();
            ErrorTB.Clear();
            chrOutTB.Clear();
            CollectConv_NN_Params();
            ConvolutionalChromosome chr = new ConvolutionalChromosome(nrp, crp, drp, random);
            ConvolutionalNetwork cnn = new ConvolutionalNetwork(chr);
            ConvolutionalNetwork.CreateNetworkScript(cnn, convActivations, denseActivations);
            ConvolutionalNetwork.CreateConvBatFile("temp_convolution.py", @"C:\keras\Directory\scripts\convolutional\genetic", datasetPathTB.Text, modelsPathTB.Text, labelsPathTB.Text, plotsPathTB.Text);

            createConvBatProcess();


        }

        private void coutModeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (coutModeCB.SelectedIndex)
            {
                case 0:
                    ErrorTB.Visible = false;
                    textBox9.Visible = true;
                    chrOutTB.Visible = false;
                    break;
                case 1:
                    ErrorTB.Visible = true;
                    textBox9.Visible = false;
                    chrOutTB.Visible = false;
                    break;
                case 2:
                    ErrorTB.Visible = false;
                    textBox9.Visible = false;
                    chrOutTB.Visible = true;
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void networkNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar == 47 || e.KeyChar == 34 || e.KeyChar == 58 || e.KeyChar == 60 ||
                e.KeyChar == 62 || e.KeyChar == 92 || e.KeyChar == 42 || e.KeyChar == 124 ||
                e.KeyChar == 63)
            {
                e.Handled = true;
            }
        }
    }
}
