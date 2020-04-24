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

namespace NN_Family_Creater
{
    public partial class Form1 : Form
    {
        List<String> convActivations;
        List<String> denseActivations;

        List<Chromosome> population;
        List<ConvolutionalNetwork> eliteChromosomes;
        Random random;

        Form propertyWindow;
        Form nnCollectionsWindow;
        Form aboutWindow;
        Form predsWindow;

        public Form1()
        {
            InitializeComponent();
            InitializeUserElements();
            InitializeProperties();


            random = new Random();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TO DO
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    TrainConvolutionalNN();
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

        public void Mutate(int mutateRate)
        {
            if(random.Next(100) < mutateRate)
            {
                if(random.Next(100) < 5)
                {
                    //TO DOOOOOOOOOOOOOO  new Chromosome

                }
            }
        }

        public void TrainConvolutionalNN()
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


            population = new List<Chromosome>((int)numericUpDown14.Value);
            while (population.Count != population.Capacity)
            {
                population.Add(new Chromosome((int)ConvLayersNumbNUD.Value,
                                              (int)DenseLayersNumbNUD.Value,
                                              (int)ConvNeuronsNUD.Value,
                                              (int)DenseNeuronsNUD.Value,
                                              (int)convActivations.Count,
                                              (int)denseActivations.Count,
                                              new int[] { (int)slidingWindow1NUD.Value, (int)slidingWindow2NUD.Value },
                                              (int)dropoutRateNUD.Value));
                population[population.Count - 1].name = "Chromosome " + population.Count.ToString();

            }
            for (int i = 0; i < population.Count; i++)
            {
                population[i].UpdateAssessmentParam(); //заглушка для сортировки
            }

            for(int i = 0; i < population.Count; i++)
            {
                Support.UpdateAssesment(population, (float)maxMemoryNUD.Value);
            }
            population.Sort(new ChromosomeComparer2());
            eliteChromosomes.Add(new ConvolutionalNetwork(population[0]));

            textBox9.Clear();   
            /////
            textBox9.AppendText("Epoch 0" + Environment.NewLine);
            for (int v = 0; v < population.Count; v++) textBox9.AppendText(population[v].assessment + ":" + population[v].accuracy + "/" + population[v].memory + " ");
            textBox9.AppendText(Environment.NewLine + "---------------------------" + Environment.NewLine);

            // train
            
            for (int i = 0; i < numericUpDown12.Value; i++)
            {
                for (int m = 1; m < population.Count; m++)
                {
                    population[m].MutateConvolutional((int)numericUpDown20.Value);
                    population[m].MutateDense((int)numericUpDown20.Value, (int)dropoutRateNUD.Value);
                }


                for (int n = 0; n < population.Count; n++)
                {
                    population[n].UpdateAssessmentParam(); //заглушка для сортировки
                }

                Support.UpdateAssesment(population, (float)maxMemoryNUD.Value);
                //population.Sort(new ChromosomeComparer((float)memPriorityNUD.Value, (float)accPriorityNUD.Value));
                population.Sort(new ChromosomeComparer2());
                eliteChromosomes.Add(new ConvolutionalNetwork(population[0]));


                textBox9.AppendText("Epoch: " + (i+1).ToString());
                textBox9.AppendText(Environment.NewLine);
                textBox9.AppendText(population[0].name);
                textBox9.AppendText(Environment.NewLine);
                
                textBox9.AppendText("Conv Layers: is " + population[0].convPart.convLayers.Count.ToString() + ", should be " + population[0].convPart.convLayers.Capacity.ToString());
                textBox9.AppendText(Environment.NewLine);
                textBox9.AppendText("Filters:");
                for (int l = 0; l < population[0].convPart.convLayersNumb; l++)
                {
                    textBox9.AppendText(" " + population[0].convPart.convLayers[l].neurons);
                }
                textBox9.AppendText(Environment.NewLine);
                textBox9.AppendText("Window: " + population[0].convPart.convLayers[0].slidingWindow[0].ToString() + "x" + population[0].convPart.convLayers[0].slidingWindow[1].ToString());
                textBox9.AppendText(Environment.NewLine);
                textBox9.AppendText("SameWindow: " + population[0].convPart.sameSlidingWindowsSize + ", allWindowSquare: " + population[0].convPart.allSquareSlidingWindows + " firstSquare: " + population[0].convPart.convLayers[0].squareSlidingWindow);
                textBox9.AppendText(Environment.NewLine);
                textBox9.AppendText("Activation: " + convActivations[population[0].convPart.convLayers[0].activationIndex] + " - same = " + population[0].convPart.sameActivations);
                textBox9.AppendText(Environment.NewLine);
                textBox9.AppendText("Dense Layers: is " + population[0].densePart.denseLayer.Count.ToString() + ", should be " + population[0].densePart.denseLayer.Capacity.ToString());
                textBox9.AppendText(Environment.NewLine);
                //textBox9.AppendText("Neurons: " + population[0].densePart.denseLayer[0].neurons.ToString());
                textBox9.AppendText("Neurons:");
                for (int k = 0; k < population[0].densePart.denseLayersNumb; k++)
                {
                    textBox9.AppendText(" " + population[0].densePart.denseLayer[k].neurons);
                }
                textBox9.AppendText(Environment.NewLine);
                textBox9.AppendText("Activation: " + denseActivations[population[0].densePart.denseLayer[0].activationIndex] + " - same = " + population[0].densePart.sameActivations);
                textBox9.AppendText(Environment.NewLine);
                for(int s = 0; s < population.Count; s++)
                {
                    textBox9.AppendText(population[s].assessment.ToString() + ":" +  population[s].accuracy.ToString() + "/" + population[s].memory.ToString() + "  ");
                }
                textBox9.AppendText(Environment.NewLine);
                textBox9.AppendText("-----------------------------------------------------");
                textBox9.AppendText(Environment.NewLine);
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
            //////////


            textBox9.ScrollBars = ScrollBars.Vertical;
            textBox9.ReadOnly = true;

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
        public void ModelCBHideShow()
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
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                trackBar1.Visible = false;
                trackBar2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
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
            ModelCBHideShow();
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
            ModelCBHideShow(); 
            
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

       
    }
}
