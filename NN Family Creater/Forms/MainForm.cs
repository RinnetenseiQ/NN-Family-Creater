using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Security.Permissions;
using System.Text;

// ReSharper disable once CheckNamespace
namespace NN_Family_Creater
{

    [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
    
    public partial class Form1 : Form
    {
        public Thread worker;
        public Process p;

        public List<ConvolutionalChromosome> population;
        public List<ConvolutionalNetwork> eliteChromosomes;

        public static Random random;

        public ImageList imageList;

        public Queue<GeneticProgramm> geneticProgramms;

        
        public Form propertyWindow;
        public Form nnCollectionsWindow;
        public Form aboutWindow;
        public Form predsWindow;


        public int currentTask;
        public int allTasks;

        public float tempAccuracy;
        public int tempParameters;
        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            InitializeUserElements();
            InitializeProperties();

            geneticProgramms = new Queue<GeneticProgramm>();

            random = new Random();
            instance = this;
            curTaskLabel.Text = currentTask.ToString();
            allTasksLabel.Text = allTasks.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TO DO
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    geneticProgramms.Enqueue(CollectConv_NN_Params());
                    BackgroundQueue.QueueTask(TrainConvolutionalNN);
                    allTasks++;
                    allTasksLabel.Text = allTasks.ToString();
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



        public GeneticProgramm CollectConv_NN_Params()
        {
            List<String> convActivations = new List<string>();
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

            List<String> denseActivations = new List<string>();
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

            List<String> optimazers = new List<string>();
            if (SGD_OptChB.Checked) optimazers.Add("SGD");

            List<String> lossFunctions = new List<string>();
            if (categorical_crossentropyChB.Checked) lossFunctions.Add("categorical_crossentropy");

            List<int> callbacks_indexes = new List<int>();
            if(modelCPChB.Checked) callbacks_indexes.Add(0);


            var nrp = new NetworkRandomParams(constSpeedChB.Checked, 
                                              new[] {float.Parse(minConstSpeedTB.Text, System.Globalization.CultureInfo.InvariantCulture),
                                              float.Parse(maxConstSpeedTB.Text, System.Globalization.CultureInfo.InvariantCulture)},
                                              datasetPathTB.Text, modelsPathTB.Text, labelsPathTB.Text,plotsPathTB.Text,
                                              networkNameTB.Text, optimazers, lossFunctions, (int)learningEpochsNUD.Value, (int)batchSizeNUD.Value);

            var crp = new ConvRandomParams((int)ConvLayersNumbNUD.Value,
                                           (int)ConvFiltersNUD.Value,
                                           convActivations.Count,
                                           convActivations,
                                           new[] { (int)slidingWindow1NUD.Value, (int)slidingWindow2NUD.Value },
                                           convDropoutChB.Checked,
                                           (int)convDropoutNUD.Value);
            var drp = new DenseRandomParams((int)DenseLayersNumbNUD.Value,
                                            (int)DenseNeuronsNUD.Value,
                                            nrp.networkOutputNumb, // Support.GetOutputNumb(datasetPath);
                                            denseActivations.Count,
                                            denseActivations,
                                            denseDropoutChB.Checked,
                                            (int)denseDropoutNUD.Value);
            var gp = new GeneticProgramm(nrp, crp, drp, (int)geneticEpochsNUD.Value, new[] { (int)copySelNUD.Value, (int)crossSelNUD.Value, (int)mutateRateNUD.Value },
                                        (int)popolationCountNUD.Value, (int)mutateRateNUD.Value, (float)accPriorityNUD.Value, (float)memPriorityNUD.Value, 
                                        EstimatorCB.SelectedIndex, (int)instance.percentNUD.Value);

            return gp;
        }
        [STAThread]
        // ReSharper disable once InconsistentNaming
        public static void TrainConvolutionalNN()
        {
            Support.pointParamsList.Clear();
            Support.pointAssesList.Clear();
            instance.currentTask++;
            instance.Invoke(new Action((() =>
            {
                instance.curTaskLabel.Text = instance.currentTask.ToString();
                instance.AssesGenZedGraph.Invalidate();
                instance.ParamsZedGraph.Invalidate();
                instance.accZG.Invalidate();

                instance.currentTaskPB.Minimum = 0;
                instance.currentTaskPB.Maximum = (int)instance.geneticEpochsNUD.Value + 1;
                instance.currentTaskPB.Value = 0;
                instance.currentTaskPB.Step = 1;
            })));

               

            string dateDirectory = Support.CreateDateTimeDirectory(@"C:\keras\Directory\reports", 0);
            string timeDirectory = Support.CreateDateTimeDirectory(dateDirectory, 1);
            File.Create(timeDirectory + @"\report.txt").Close();

            int maxParams = 0;
            GeneticProgramm gp = instance.geneticProgramms.Dequeue();
            if (!instance.genDontClearChB.Checked) instance.Invoke(new Action(instance.textBox9.Clear));
            instance.population = new List<ConvolutionalChromosome>(gp._populationSize);
            
            while (instance.population.Count != instance.population.Capacity)
            {
                instance.population.Add(new ConvolutionalChromosome(gp, random));
                instance.population[instance.population.Count - 1].name = "Chromosome " + instance.population.Count.ToString();
                instance.population[instance.population.Count - 1].indexNumber = instance.population.Count;
            }

            for (int i = 0; i < instance.population.Count; i++)
            {
                instance.tempAccuracy = instance.tempParameters = 0;
                instance.WriteAdds(0, i);
                instance.UpdateAssessmentParams(instance.population[i], gp, 0);
                File.AppendAllText(@"C:\keras\Directory\Assessment_Statistic.txt",
                    instance.population[i].accuracy.ToString() + "_" + instance.population[i].paramsCount + Environment.NewLine);
                if (instance.population[i].paramsCount > maxParams) maxParams = instance.population[i].paramsCount;
                Support.DrawParamsGraph(instance.ParamsZedGraph, instance.population[i].accuracy, instance.population[i].paramsCount, maxParams);
                Support.DrawAccGraph(instance.accZG, 0, instance.population[0]._gp._genEpochs, instance.population[i].accuracy);
            }

            Support.UpdateAssesment(instance.population);
            for (int z = 0; z < instance.population.Count; z++)
            {
                Support.DrawAssesGraph(instance.AssesGenZedGraph, 0, instance.population[z]._gp._genEpochs, instance.population[z].assessment, z);
            }

            instance.SortChromosome(instance.population, gp._assessmentIndex, gp._percent);
            //instance.population = SortChromosome(instance.population, gp._assessmentIndex, gp._percent);
            //instance.population.Sort(new ChromosomeComparer4((int)instance.percentNUD.Value));
            //instance.population.Sort(new ChromosomeComparer2());
            //instance.eliteChromosomes.Add(new ConvolutionalNetwork(instance.population[0]));
            instance.WriteConvGeneticOutput(0);
            File.WriteAllLines(timeDirectory + @"\report.txt", instance.textBox9.Lines);
            instance.Invoke(new Action(instance.currentTaskPB.PerformStep));
            // Evolve

            for (int i = 1; i <= gp._genEpochs; i++)
            {
                for (int m = 1; m < instance.population.Count; m++)
                {
                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    if (instance.population[m].assessment == 0)
                    {
                        string buff = instance.population[m].name;
                        instance.population[m] = new ConvolutionalChromosome(gp, random) {name = buff};
                    }
                    else
                    {
                        if (new Random().Next() < 5)
                        {
                            string buff = instance.population[m].name;
                            instance.population[m] = new ConvolutionalChromosome(gp, random) {name = buff};
                        }
                        else
                        {
                            instance.population[m].MutateConvolutional(gp._crp, gp._mutateRate);
                            instance.population[m].MutateDense(gp._drp, gp._mutateRate);
                        }
                    }
                }


                for (int n = 1; n < instance.population.Count; n++)
                {
                    instance.population[n].assessment = instance.population[n].accuracy = instance.population[n].paramsCount = 0;
                    instance.tempAccuracy = instance.tempParameters = 0;
                    instance.WriteAdds(i, n);
                    instance.UpdateAssessmentParams(instance.population[n], gp, i);
                    File.AppendAllText(@"C:\keras\Directory\Assessment_Statistic.txt",
                        instance.population[n].accuracy.ToString() + "_" + instance.population[n].paramsCount + Environment.NewLine);
                    if (instance.population[n].paramsCount > maxParams) maxParams = instance.population[n].paramsCount;
                    Support.DrawParamsGraph(instance.ParamsZedGraph, instance.population[n].accuracy, instance.population[n].paramsCount, maxParams);
                }
                
                Support.UpdateAssesment(instance.population);
                for (int z = 0; z < instance.population.Count; z++)
                {
                    Support.DrawAssesGraph(instance.AssesGenZedGraph, i, instance.population[z]._gp._genEpochs, instance.population[z].assessment, z);
                }

                instance.SortChromosome(instance.population, gp._assessmentIndex, gp._percent);
                //instance.population.Sort(new ChromosomeComparer4((int)instance.percentNUD.Value));
                //population.Sort(new ChromosomeComparer((float)memPriorityNUD.Value, (float)accPriorityNUD.Value));
                //instance.population.Sort(new ChromosomeComparer2());
                //instance.eliteChromosomes.Add(new ConvolutionalNetwork(instance.population[0]));
                instance.WriteConvGeneticOutput(i);
                File.WriteAllLines(timeDirectory + @"\report.txt", instance.textBox9.Lines);
                instance.Invoke(new Action(instance.currentTaskPB.PerformStep));
            }
 
            Image image = new Bitmap(instance.AssesGenZedGraph.GetImage());
            image.Save(timeDirectory + @"\asses.png");
            image = new Bitmap(instance.ParamsZedGraph.GetImage());
            image.Save(timeDirectory + @"\params.png");
            image = new Bitmap(instance.accZG.GetImage());
            image.Save(timeDirectory + @"\acc.png");
        }

        public List<ConvolutionalChromosome> SortChromosome(List<ConvolutionalChromosome> poplist, int estimatorIndex, int percent)
        {
            switch (estimatorIndex)
            {
                case 0:
                    poplist.Sort(new ChromosomeComparer4(percent));
                    break;
                case 1:
                    poplist.Sort(new ChromosomeComparer2());
                    break;
            }
            return poplist;
        }
        

        public void WriteAdds(int epoch, int iter)
        {
            instance.Invoke(new Action((() =>
            {
                instance.ErrorTB.AppendText("Epoch - " + epoch.ToString() + " | " + "Progress iteration - " + (iter + 1).ToString() + " | " + instance.population[iter].name +
                                            "-----------------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
                instance.chrOutTB.AppendText("Epoch - " + epoch.ToString() + " | " + "Progress iteration - " + (iter + 1).ToString() + " | " + instance.population[iter].name +
                                             "-----------------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
            })));
        }

        public void WriteConvGeneticOutput(int iter)
        {
            instance.Invoke(new Action(() => {
                instance.textBox9.AppendText("Epoch " + iter + ":" + Environment.NewLine);
                instance.textBox9.AppendText("Assessments:" + Environment.NewLine);
                foreach (var t in instance.population)
                {
                    instance.textBox9.AppendText(t.name + ": ");
                    instance.textBox9.AppendText(t.assessment + " - " + t.accuracy + "/" + t.paramsCount + " ");
                    instance.textBox9.AppendText(Environment.NewLine);
                }
                instance.textBox9.AppendText(Environment.NewLine + "Structures:" + Environment.NewLine);
                for (int r = 0; r < instance.population.Count; r++)
                {
                    instance.textBox9.AppendText(instance.population[r].name + ":" + Environment.NewLine);
                    instance.textBox9.AppendText("TS - " + instance.population[r].trainConstSpeed.ToString());
                    instance.textBox9.AppendText("   EP - " + instance.population[r].nrp.epochs.ToString());
                    instance.textBox9.AppendText("   BS - " + instance.population[r].nrp.batchSize.ToString());
                    instance.textBox9.AppendText("   Output - " + instance.population[r].nrp.networkOutputNumb.ToString());
                    instance.textBox9.AppendText(Environment.NewLine);
                    instance.textBox9.AppendText("Conv filters: ");
                    foreach (var t1 in instance.population[r].convPart.convLayers)
                    {
                        instance.textBox9.AppendText(t1.filters.ToString() + " ");
                    }
                    instance.textBox9.AppendText(Environment.NewLine);
                    instance.textBox9.AppendText("Conv Activations: ");
                    foreach (var t1 in instance.population[r].convPart.convLayers)
                    {
                        instance.textBox9.AppendText(instance.population[r].crp.convActivations[t1.activationIndex] + " ");
                    }
                    instance.textBox9.AppendText(Environment.NewLine);
                    instance.textBox9.AppendText("SWs: ");
                    foreach (var t1 in instance.population[r].convPart.convLayers)
                    {
                        instance.textBox9.AppendText(t1.slidingWindow[0].ToString() + "x" +
                                                     t1.slidingWindow[1].ToString() + " ");
                    }
                    instance.textBox9.AppendText(Environment.NewLine);
                    instance.textBox9.AppendText("Dense Neurons: ");
                    foreach (var t1 in instance.population[r].densePart.denseLayers)
                    {
                        instance.textBox9.AppendText(t1.neurons.ToString() + " ");
                    }
                    instance.textBox9.AppendText(Environment.NewLine);
                    instance.textBox9.AppendText("Dense Activations: ");
                    foreach (var t1 in instance.population[r].densePart.denseLayers)
                    {
                        instance.textBox9.AppendText(instance.population[r].drp.denseActivations[t1.activationIndex] + " ");
                    }
                    instance.textBox9.AppendText(Environment.NewLine);
                    instance.textBox9.AppendText("Dense dropouts: ");
                    foreach (var t1 in instance.population[r].densePart.denseLayers)
                    {
                        instance.textBox9.AppendText(t1.dropoutRate.ToString() + " ");
                    }
                    if (r != (instance.population.Count - 1)) instance.textBox9.AppendText(Environment.NewLine + Environment.NewLine);
                }
                instance.textBox9.AppendText(Environment.NewLine + "----------------------------------------------------------------------------" + Environment.NewLine);
            }));
        }

        public void AddProgressBar()
        {
            Bitmap progressBarBitmap = new Bitmap(
                imageList.ImageSize.Width,
                imageList.ImageSize.Height);
                imageList.Images.Add(progressBarBitmap);
            ProgressBar progressBar = new ProgressBar
            {
                MinimumSize = imageList.ImageSize,
                MaximumSize = imageList.ImageSize,
                Size = imageList.ImageSize
            };

            // probably create also some BackgroundWorker here with information about
            // this particular progressBar

            // ReSharper disable once SuggestVarOrType_SimpleTypes
            ListViewItem lvi = new ListViewItem(
                new[] {"column1", "column2"},
                listView1.Items.Count) {UseItemStyleForSubItems = true};

            listView1.Items.Add(lvi);
            //lvi.Tag = /* some convenient info class to refer back to related objects */


        }

        public void RefreshPb(ProgressBar progressBar, Bitmap progressBarBitmap)
        {
            //int previousProgress = progressBar.Value;
            //progressBar.Value = ...
            //if (progressBar.Value != previousProgress)
            //{
            //    progressBar.DrawToBitmap(progressBarBitmap, bounds);
            //    progressBarImageList.Images[index] = progressBarBitmap;
            //}
        }

        public void TrainLSTM_NN()
        {
            textBox9.Clear();
            textBox9.AppendText("Are you kretin?");
            textBox9.AppendText(Environment.NewLine);
            textBox9.AppendText("Snachala realizui your LSTM network");
            //TO DO LATER!!!
        }

        // ReSharper disable once InconsistentNaming
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

            imageList = new ImageList();

            

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
            errDontClearChB.Location = genDontClearChB.Location;
            chrDontClearChB.Location = genDontClearChB.Location;
            ParamsZedGraph.Location = AssesGenZedGraph.Location;
            ParamsZedGraph.Size = AssesGenZedGraph.Size;
            accZG.Location = AssesGenZedGraph.Location;
            accZG.Size = AssesGenZedGraph.Size;
            
            PriorityEstimGB.Location = PercentEstimGB.Location;
            PriorityEstimGB.Size = PercentEstimGB.Size;
            AssessFuncGB.Location = PercentEstimGB.Location;
            AssessFuncGB.Size = PercentEstimGB.Size;
            

            //QueueGB
            //////////


            textBox9.ScrollBars = ScrollBars.Vertical;
            ErrorTB.ScrollBars = ScrollBars.Vertical;
            chrOutTB.ScrollBars = ScrollBars.Vertical;
            TestTB1.ScrollBars = ScrollBars.Vertical;
            TestTB2.ScrollBars = ScrollBars.Vertical;
            TestTB3.ScrollBars = ScrollBars.Vertical;
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
            ZedGraphCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ZedGraphCB.SelectedIndex = 0;
            EstimatorCB.DropDownStyle = ComboBoxStyle.DropDownList;
            EstimatorCB.SelectedIndex = 0;
        }

        public void InitializeProperties()
        {
            Properties.Settings.Default.DirectoryPath = ConfigEditor.Config.Read("DirectoryPath").ToString();
            Properties.Settings.Default.convScriptNumber = Convert.ToInt32(ConfigEditor.Config.Read("convScriptNumber"));
            Properties.Settings.Default.datasetDirectory = datasetPathTB.Text = ConfigEditor.Config.Read("datasetDirectory").ToString();
            Properties.Settings.Default.modelsDirectory = modelsPathTB.Text = ConfigEditor.Config.Read("modelsDirectory").ToString();
            Properties.Settings.Default.labelsDirectory = labelsPathTB.Text = ConfigEditor.Config.Read("labelsDirectory").ToString();
            Properties.Settings.Default.plotsDirectory = plotsPathTB.Text = ConfigEditor.Config.Read("plotsDirectory").ToString();

            networkNameTB.Text = new DirectoryInfo(datasetPathTB.Text).Name + @"_cnet";
        }
        public void ModelGbHideShow()
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

        private void CheckBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (constSpeedChB.Checked)
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

        private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void НастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            propertyWindow.ShowDialog(this);
        }


        private void Button8_Click(object sender, EventArgs e)
        {
            predsWindow.Show();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelGbHideShow();
        }

        private void КоллекцияСетейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nnCollectionsWindow.Show();
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow.Show();
        }


        private void WithoutGenChB_CheckedChanged(object sender, EventArgs e)
        {
            ModelGbHideShow();

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
            MessageBox.Show(@"Записано!!"); 
        } ///Test it

        private void pauseQueryBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            List<string> stringList = new List<string>();
            StreamReader f = new StreamReader(@"C:\keras\Directory\Assessment_Statistic.txt", Encoding.UTF8);
            while (!f.EndOfStream)
            {
                string s = f.ReadLine();
                // что-нибудь делаем с прочитанной строкой s
                stringList.Add(s);
            }
            f.Close();

            List<Test> toSortList = new List<Test>();
            List<Test> sortedList = new List<Test>(); 
            List<Test> sortedList2 = new List<Test>(); 

            foreach (var s in stringList) toSortList.Add(new Test(s));
            foreach (var t in toSortList) sortedList.Add(new Test(t));
            foreach (var t in toSortList) sortedList2.Add(new Test(t));
            Test.UpdateAsses(sortedList);
            Test.UpdateAsses(toSortList);
            Test.UpdateAsses(sortedList2, 50);

            sortedList.Sort(new TestComparer2());
            sortedList2.Sort(new TestComparer2());
            for (int i = 0; i < toSortList.Count; i++)
            {
                TestTB1.AppendText(i + ": " + toSortList[i].accuracy + " | " + toSortList[i].paramsCount + " = " + toSortList[i].assessment + Environment.NewLine);
                TestTB2.AppendText(i + ": " + sortedList[i].accuracy + " | " + sortedList[i].paramsCount + " = " + sortedList[i].assessment + Environment.NewLine);
                TestTB3.AppendText(i + ": " + sortedList2[i].accuracy + " | " + sortedList2[i].paramsCount + " = " + sortedList2[i].assessment + Environment.NewLine);
            }
        }

        private void createScriptsBtn_Click(object sender, EventArgs e)
        {
 
        }

        private void openModelsFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog { SelectedPath = Properties.Settings.Default.DirectoryPath + @"\" };
            if (fbd.ShowDialog() != DialogResult.OK) return;
            modelsPathTB.Text = Properties.Settings.Default.modelsDirectory = fbd.SelectedPath;
            ConfigEditor.Config.Write("modelsDirectory", Properties.Settings.Default.modelsDirectory);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog { SelectedPath = Properties.Settings.Default.DirectoryPath + @"\" };
            SendKeys.Send("{TAB}{TAB}{RIGHT}");
            if (fbd.ShowDialog() != DialogResult.OK) return;
            datasetPathTB.Text = Properties.Settings.Default.datasetDirectory = fbd.SelectedPath;
            ConfigEditor.Config.Write("datasetDirectory", Properties.Settings.Default.datasetDirectory);
            networkNameTB.Text = new DirectoryInfo(datasetPathTB.Text).Name + @"_cnet";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog { SelectedPath = Properties.Settings.Default.DirectoryPath + @"\" };
            if (fbd.ShowDialog() != DialogResult.OK) return;
            labelsPathTB.Text = Properties.Settings.Default.labelsDirectory = fbd.SelectedPath;
            ConfigEditor.Config.Write("labelsDirectory", Properties.Settings.Default.labelsDirectory);
        }

        private void openPlotsFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog { SelectedPath = Properties.Settings.Default.DirectoryPath + @"\" };
            if (fbd.ShowDialog() != DialogResult.OK) return;
            plotsPathTB.Text = Properties.Settings.Default.plotsDirectory = fbd.SelectedPath;
            ConfigEditor.Config.Write("plotsDirectory", Properties.Settings.Default.plotsDirectory);
        }


        ///////////////////////////////////////////////////////
        // new Process
        public void UpdateAssessmentParams(ConvolutionalChromosome chromosome, GeneticProgramm gp, int epoch)
        {    
            instance.Invoke(new Action(() => {
                if(!instance.errDontClearChB.Checked) instance.ErrorTB.Clear();
                if (!instance.chrDontClearChB.Checked) instance.chrOutTB.Clear();
            }));
            ConvolutionalNetwork tempNet = new ConvolutionalNetwork(chromosome, epoch, gp._nrp.networkName);
            ConvolutionalNetwork.CreateNetworkScript(tempNet, chromosome.crp.convActivations, chromosome.drp.denseActivations);
            ConvolutionalNetwork.CreateConvBatFile("temp_convolution.py", @"C:\keras\Directory\scripts\convolutional\genetic", gp._nrp.datasetPath, 
                                                   gp._nrp._modelPath, gp._nrp._labelPath, gp._nrp._plotPath, gp._nrp.networkName, epoch, chromosome.indexNumber, 0);

            CreateConvBatProcess();

            chromosome.accuracy = instance.tempAccuracy;
            chromosome.paramsCount = instance.tempParameters;
        }

        public void OutputHandler(object sendingProcess, DataReceivedEventArgs consoleLine)
        {
            string str = consoleLine.Data;
            AddTextToTextBox(str);
            if (str == null) return;
            if (str.Contains("    accuracy"))
            {
                var accString = str;
                accString = accString.Remove(accString.IndexOf("accuracy", StringComparison.Ordinal), "accuracy".Length);
                accString = accString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                accString = accString.Replace(" ", "");
                GetAccuracyToMainProcess(accString);
            }
            if (consoleLine.Data.Contains("Total params:"))
            {
                var totalParamsString = str;
                totalParamsString = totalParamsString.Remove(totalParamsString.IndexOf("Total params:", StringComparison.Ordinal), "Total params:".Length);
                totalParamsString = totalParamsString.Replace(" ", "");
                totalParamsString = totalParamsString.Replace(",", "");
                GetParamsCountToMainProcess(totalParamsString);
            }
        }

        public void ErrorHandler(object sendingProcess, DataReceivedEventArgs consoleLine)
        {
            AddTextToErrTextBox(consoleLine.Data);
        }

        public void GetAccuracyToMainProcess(string acc)
        {
            instance.Invoke(new Action(() => {
                instance.tempAccuracy = float.Parse(acc, System.Globalization.CultureInfo.InvariantCulture);
            }));
        }

        public void GetParamsCountToMainProcess(string parameters)
        {
            instance.Invoke(new Action(() => {
                instance.tempParameters = int.Parse(parameters);
            }));
            
        }
        public void AddTextToTextBox(string data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddTextToTextBox), data);
                return;
            }
            
            instance.Invoke(new Action(() => {
                instance.chrOutTB.AppendText(data + Environment.NewLine);
            }));
        }

        public void AddTextToErrTextBox(string data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddTextToErrTextBox), data);
                return;
            }

            instance.Invoke(new Action(() => {
                instance.ErrorTB.AppendText(data + Environment.NewLine);
            }));
        }

        public void CreateConvBatProcess()
        {
            
            p = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = @"/c C:\keras\Directory\scripts\convolutional\temp_train.bat",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }

            };
            p.OutputDataReceived += OutputHandler;
            p.ErrorDataReceived += ErrorHandler;

            p.Start();

            p.BeginOutputReadLine();
            p.BeginErrorReadLine();

            p.WaitForExit();
        }

        ///////////////////////////////////////////////////////


        private void TrainQueryBtn_ClickAsync(object sender, EventArgs e)
        {
           
        }

        public void CoutModeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (coutModeCB.SelectedIndex)
            {
                case 0:
                    ErrorTB.Visible = false; errDontClearChB.Visible = false;
                    textBox9.Visible = true; genDontClearChB.Visible = true;
                    chrOutTB.Visible = false; chrDontClearChB.Visible = false;
                    break;
                case 1:
                    ErrorTB.Visible = true; errDontClearChB.Visible = true;
                    textBox9.Visible = false; genDontClearChB.Visible = false;
                    chrOutTB.Visible = false; chrDontClearChB.Visible = false;
                    break;
                case 2:
                    ErrorTB.Visible = false; errDontClearChB.Visible = false;
                    textBox9.Visible = false; genDontClearChB.Visible = false;
                    chrOutTB.Visible = true; chrDontClearChB.Visible = true;
                    break;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void NetworkNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 47 || e.KeyChar == 34 || e.KeyChar == 58 || e.KeyChar == 60 ||
                e.KeyChar == 62 || e.KeyChar == 92 || e.KeyChar == 42 || e.KeyChar == 124 ||
                e.KeyChar == 63)
            {
                e.Handled = true;
            }
        }


        
        private void Button3_Click(object sender, EventArgs e)
        {
            
            
            //worker.Abort();
            //p.Kill();
            //p.Close();
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
        }

        private void ZedGraphCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ZedGraphCB.SelectedIndex)
            {
                case 0:
                    AssesGenZedGraph.Visible = true;
                    ParamsZedGraph.Visible = false;
                    accZG.Visible = false;
                    break;
                case 1:
                    AssesGenZedGraph.Visible = false;
                    ParamsZedGraph.Visible = true;
                    accZG.Visible = false;
                    break;
                case 2:
                    AssesGenZedGraph.Visible = false;
                    ParamsZedGraph.Visible = false;
                    accZG.Visible = true;
                    break;
            }
        }

        private void EstimatorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EstimatorCB.SelectedIndex)
            {
                case 0:
                    PercentEstimGB.Visible = true;
                    AssessFuncGB.Visible = false;
                    PriorityEstimGB.Visible = false;
                    break;
                case 1:
                    PercentEstimGB.Visible = false;
                    AssessFuncGB.Visible = true;
                    PriorityEstimGB.Visible = false;
                    break;
                case 2:
                    PercentEstimGB.Visible = false;
                    AssessFuncGB.Visible = false;
                    PriorityEstimGB.Visible = true;
                    break;
            }
        }
    }
}
