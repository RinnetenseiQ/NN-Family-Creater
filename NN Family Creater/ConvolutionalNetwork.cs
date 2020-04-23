using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Family_Creater
{
    class ConvolutionalNetwork
    {
        public List<int[]> slidingWindows;
        public List<int> convActivationIndexes;
        public List<int> filters;
        public List<int> denseActivationIndexes;
        public List<int> neurons;
        public List<int> denseDropoutIndexes;
        public List<int> dropoutRates;

        public ConvolutionalNetwork(Chromosome chromosome)
        {
            slidingWindows = new List<int[]>();
            convActivationIndexes = new List<int>();
            filters = new List<int>();
            denseActivationIndexes = new List<int>();
            neurons = new List<int>();
            denseDropoutIndexes = new List<int>();
            dropoutRates = new List<int>();
            for (int i = 0; i < chromosome.convPart.convLayers.Count; i++)
            {
                slidingWindows.Add(new int[2] { chromosome.convPart.convLayers[i].slidingWindow[0], chromosome.convPart.convLayers[i].slidingWindow[1] });
                convActivationIndexes.Add(chromosome.convPart.convLayers[i].activationIndex);
                filters.Add(chromosome.convPart.convLayers[i].neurons);
            }

            for (int i = 0; i < chromosome.densePart.denseLayer.Count; i++)
            {
                denseActivationIndexes.Add(chromosome.densePart.denseLayer[i].activationIndex);
                neurons.Add(chromosome.densePart.denseLayer[i].neurons);
                if (chromosome.densePart.denseLayer[i].dropoutExist)
                {
                    denseDropoutIndexes.Add(i);
                    dropoutRates.Add(chromosome.densePart.denseLayer[i].dropoutRate);
                }
            }
        }

        public static void CreateConvBatFile(string scriptName, string scriptsPath, string datasetPath, string modelPath, string labelPath, string plotPath)
        {
            DirectoryInfo di;
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


            string code = @"C:\Users\Rinnetensei\Anaconda3\envs\keras\python.exe " + scriptsPath + @"\" + scriptName + " -d " +
                            datasetPath + " -m " + currentModelsDirectory + @"\" + scriptName + "_m_temp -l " + currentLabelsDirectory + @"\" +
                            scriptName + "_l_temp -p " + currentPlotsDirectory + @"\" + scriptName + "_p_temp";

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
            string fileName = "convolutional_v" + Properties.Settings.Default.convScriptNumber + ".py";

            try
            {
                File.Copy(@"C:\keras\Directory\scripts\convolutional\convolutional.py", @"C:\keras\Directory\scripts\convolutional\genetic\elites\" + fileName, true);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            InsertConvNetworkCode(@"C:\keras\Directory\scripts\convolutional\genetic\elites\" + fileName, 72, network, convActivations, denseActivations);
            Properties.Settings.Default.convScriptNumber++;
            ConfigEditor.Config.Write("convScriptNumber", Properties.Settings.Default.convScriptNumber);
        }

        public static void InsertConvNetworkCode(String path, int line, ConvolutionalNetwork network, List<String> convActivations, List<String> denseActivations)
        {
            string code = "";
            for (int i = 0; i < network.filters.Count; i++)
            {
                if (i == 0) code += "model.add(ZeroPadding2D((1, 1), input_shape = (128, 128, 3)))" + Environment.NewLine;
                else code += "model.add(ZeroPadding2D((1, 1)))" + Environment.NewLine;
                code += "model.add(Conv2D(" + network.filters[i].ToString() + ", kernel_size = (" +
                        network.slidingWindows[i][0].ToString() + ", " + network.slidingWindows[i][1].ToString() +
                        "), strides = (1, 1), activation = '" + convActivations[network.convActivationIndexes[i]] + "'))" + Environment.NewLine;
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
                    if (network.denseDropoutIndexes[dropoutCounter] == i)  ///////// error за пределами массива
                    {
                        code += "model.add(Dropout(" + ((float)network.dropoutRates[dropoutCounter] / 100).ToString() + "))" + Environment.NewLine;

                        if((network.denseDropoutIndexes.Count - 1) != dropoutCounter)dropoutCounter++;
                    }
                }
                
            }
            code += "model.add(Dense(len(lb.classes_), activation = \"softmax\"))" + Environment.NewLine;
            code += "INIT_LR = 0.01" + Environment.NewLine + "EPOCHS = 200" + Environment.NewLine + "BS = 16" + Environment.NewLine;


            Support.insertLineToFile(path, line, code);
        }
    }
}
