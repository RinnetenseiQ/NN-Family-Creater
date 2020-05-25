using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    public class ConvolutionalNetwork
    {
        public List<int[]> slidingWindows;
        public List<int> convActivationIndexes;
        public List<int> filters;
        public List<int> denseActivationIndexes;
        public List<int> neurons;
        public List<int> denseDropoutIndexes;
        public List<int> denseDropoutRates;

        public List<int> convDropoutIndexes;
        public List<int> convDropoutRates;

        public int batchSize;
        public int networkLearningEpochs;
        

        public float trainConstSpeed;
        public string optimizer;
        public string loss_finction;
        public int outputs;


        public ConvolutionalNetwork(ConvolutionalChromosome chromosome)
        {
            trainConstSpeed = chromosome.trainConstSpeed;
            optimizer = chromosome.optimizer;
            loss_finction = chromosome.loss_function;
            outputs = chromosome.nrp.networkOutputNumb;

            batchSize = chromosome.nrp.batchSize;
            networkLearningEpochs = chromosome.nrp.epochs;


            slidingWindows = new List<int[]>();
            convActivationIndexes = new List<int>();
            filters = new List<int>();
            denseActivationIndexes = new List<int>();
            neurons = new List<int>();
            denseDropoutIndexes = new List<int>();
            denseDropoutRates = new List<int>();
            convDropoutIndexes = new List<int>();
            convDropoutRates = new List<int>();

            for (int i = 0; i < chromosome.convPart.convLayers.Count; i++)
            {
                slidingWindows.Add(new int[2] { chromosome.convPart.convLayers[i].slidingWindow[0], chromosome.convPart.convLayers[i].slidingWindow[1] });
                convActivationIndexes.Add(chromosome.convPart.convLayers[i].activationIndex);
                filters.Add(chromosome.convPart.convLayers[i].filters);
                if (chromosome.convPart.convLayers[i].dropoutExist)
                {
                    convDropoutIndexes.Add(i);
                    convDropoutRates.Add(chromosome.convPart.convLayers[i].dropoutRate);
                }
            }

            for (int i = 0; i < chromosome.densePart.denseLayers.Count; i++)
            {
                denseActivationIndexes.Add(chromosome.densePart.denseLayers[i].activationIndex);
                neurons.Add(chromosome.densePart.denseLayers[i].neurons);
                if (chromosome.densePart.denseLayers[i].dropoutExist)
                {
                    denseDropoutIndexes.Add(i);
                    denseDropoutRates.Add(chromosome.densePart.denseLayers[i].dropoutRate);
                }
            }
        }

        public static void CreateConvBatFile(string scriptName, string scriptsPath, string datasetPath, string modelPath, string labelPath, string plotPath)
        {
            DirectoryInfo di; 
            // добавить безопасность созданию директорий
            // Models Directory
            di = Directory.CreateDirectory(@"C:\keras\folder");
            string currentModelsDirectory = modelPath + @"\" + di.CreationTime.ToString("dd-MM-yyyy");
            if(!Directory.Exists(currentModelsDirectory)) Directory.Move(@"C:\keras\folder", currentModelsDirectory);
            else Directory.Delete(@"C:\keras\folder");
            // Labels Directory
            di = Directory.CreateDirectory(@"C:\keras\folder");
            string currentLabelsDirectory = labelPath + @"\" + di.CreationTime.ToString("dd-MM-yyyy");
            if (!Directory.Exists(currentLabelsDirectory)) Directory.Move(@"C:\keras\folder", currentLabelsDirectory);
            else Directory.Delete(@"C:\keras\folder");
            // Plots Directory
            di = Directory.CreateDirectory(@"C:\keras\folder");
            string currentPlotsDirectory = plotPath + @"\" + di.CreationTime.ToString("dd-MM-yyyy");
            if (!Directory.Exists(currentPlotsDirectory)) Directory.Move(@"C:\keras\folder", currentPlotsDirectory);
            else Directory.Delete(@"C:\keras\folder");

            string time = File.GetLastWriteTime(scriptsPath + @"\" + scriptName).ToString("HH-mm-ss");
            string currentTask = new DirectoryInfo(datasetPath).Name; 

            string code = @"C:\Users\Rinnetensei\Anaconda3\envs\keras\python.exe " + scriptsPath + @"\" + scriptName + " -d " +
                            datasetPath + " -m " + currentModelsDirectory + @"\" + currentTask + "_" + time + "_m_genetic -l " + currentLabelsDirectory + @"\" +
                            currentTask + time + "_l_genetic -p " + currentPlotsDirectory + @"\" + currentTask + time + "_p_genetic.png";

            try
            {
                File.Copy(@"C:\keras\Directory\scripts\train.bat", @"C:\keras\Directory\scripts\convolutional\temp_train.bat", true);
                
                Support.insertLineToFile(@"C:\keras\Directory\scripts\convolutional\temp_train.bat", 3, code);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            
        }

        public static void CreateNetworkScript(/*String toCopyPath, String copyPath, int line,*/ ConvolutionalNetwork network, List<String> convActivations, List<String> denseActivations)
        {
            string fileName;  // = "convolutional_v" + Properties.Settings.Default.convScriptNumber + ".py";
            fileName = "temp_convolution.py";
            string path = @"C:\keras\Directory\scripts\convolutional\genetic\";
            //path = @"C:\keras\Directory\scripts\convolutional\genetic\elites\";
            try
            {
                File.Copy(@"C:\keras\Directory\scripts\convolutional\convolutional.py", path + fileName, true);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            InsertConvNetworkCode(path + fileName, 75, network, convActivations, denseActivations);
            //Properties.Settings.Default.convScriptNumber++;
            //ConfigEditor.Config.Write("convScriptNumber", Properties.Settings.Default.convScriptNumber);
        }

        public static void InsertConvNetworkCode(String path, int line, ConvolutionalNetwork network, List<String> convActivations, List<String> denseActivations)
        {
            string loss_function = "\"categorical_crossentropy\"";
            if (network.outputs == 2) loss_function = "\"binary_crossentropy\"";

            string init_lr = network.trainConstSpeed.ToString();
            init_lr = init_lr.Replace(",", ".");
            string code = "";
            for (int i = 0; i < network.filters.Count; i++)
            {
                if (i == 0) code += "model.add(ZeroPadding2D((1, 1), input_shape = (128, 128, 3)))" + Environment.NewLine;
                code += "model.add(Conv2D(" + network.filters[i].ToString() + ", kernel_size = (" +
                        network.slidingWindows[i][0].ToString() + ", " + network.slidingWindows[i][1].ToString() +
                        "), strides = (1, 1), padding='same', activation = '" + convActivations[network.convActivationIndexes[i]] + "'))" + Environment.NewLine;
                code += "model.add(MaxPooling2D(pool_size = (2, 2), strides = (2, 2)))" + Environment.NewLine;
            }
            code += "model.add(Flatten())" + Environment.NewLine;
            int dropoutCounter = 0;
            for (int i = 0; i < network.neurons.Count; i++)
            {
                code += "model.add(Dense(" + network.neurons[i].ToString() + ", activation = '" +
                         denseActivations[network.denseActivationIndexes[i]] + "'))" + Environment.NewLine;
                if (network.denseDropoutIndexes.Count > 0)
                {
                    if (network.denseDropoutIndexes[dropoutCounter] == i)  
                    {
                        code += "model.add(Dropout(" + ((float)network.denseDropoutRates[dropoutCounter] / 100).ToString() + "))" + Environment.NewLine;

                        if((network.denseDropoutIndexes.Count - 1) != dropoutCounter)dropoutCounter++;
                    }
                }
                
            }
            if(network.outputs == 2) code += "model.add(Dense(2, activation = \"softmax\"))" + Environment.NewLine;
            else code += "model.add(Dense(len(lb.classes_), activation = \"softmax\"))" + Environment.NewLine;
            code += "INIT_LR = " + init_lr + Environment.NewLine + 
                    "EPOCHS = " + network.networkLearningEpochs.ToString() + Environment.NewLine + 
                    "BS = " + network.batchSize.ToString() + Environment.NewLine + Environment.NewLine;
            code += "print(\"[INFO] training network...\")" + Environment.NewLine;
            code += "opt = SGD(lr=INIT_LR)" + Environment.NewLine;
            code += "model.compile(loss=" + loss_function + ", optimizer=opt, metrics=[\"accuracy\"])" + Environment.NewLine;
            //code += "" + Environment.NewLine;
            Support.insertLineToFile(path, line, code);

            string forBinaryCode = "trainY = to_categorical(trainY)" + Environment.NewLine + 
                                   "testY = to_categorical(testY)" + Environment.NewLine;
            if (network.outputs == 2) Support.insertLineToFile(path, 66, forBinaryCode);
        }
    }
}
