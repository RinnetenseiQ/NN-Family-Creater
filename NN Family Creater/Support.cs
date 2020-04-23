using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using Newtonsoft.Json;

namespace NN_Family_Creater
{
    class Support
    {
        public static int[] Selection(int totalCount, int copyPart, int crossPart, int mutatePart)
        {
            
            int totalParts = copyPart + crossPart + mutatePart;
            float copyRate = (float)copyPart / totalParts;
            float crossRate = (float)crossPart / totalParts;
            float mutateRate = (float)mutatePart / totalParts;
            int copyCount = (int)Math.Round((float)totalCount * copyRate);
            int crossCount = (int)Math.Round((float)totalCount * crossRate);
            int mutateCount = (int)Math.Round((float)totalCount * mutateRate);
            if ((copyCount + crossCount + mutateCount) < totalCount)
            {
                copyCount++;
            }
            else if ((copyCount + crossCount + mutateCount) > totalCount)
            {
                if (copyCount > 0)
                {
                    copyCount--;
                }
                else
                {
                    if (crossCount > 0)
                    {
                        crossCount--;
                    }
                    else
                    {
                        mutateCount--;
                    }
                }
            }

            if ((crossCount % 2 > 0) && (mutateCount % 2 > 0))
            {
                crossCount--;
                mutateCount++;
            }
            else if ((crossCount % 2) > 0)
            {
                crossCount--;
                copyCount++;
            }
            else if ((mutateCount % 2) > 0)
            {
                mutateCount--;
                copyCount++;
            }
            int[] sel = new int[] { copyCount, crossCount, mutateCount };
            return sel;
        } // тупо копипаст с лабы(компилятор даже не заметил, что код с джавы приплыл)

        public static void UpdateAssesment(List<Chromosome> chrList, float maxMemory)
        {
            float minMemory = maxMemory; //локальная переменная для хранения минимальной памяти
            for (int i = 0; i < chrList.Count; i++)
                if (chrList[i].memory < minMemory) minMemory = chrList[i].memory; // цикл поиска минимума
            for (int i = 0; i < chrList.Count; i++)
                chrList[i].assessment = (chrList[i].accuracy / 100) + (minMemory / chrList[i].memory); // цикл расчета ошибки
        }


        public static void InsertChromosomeCode(String path, int line, Chromosome chr, List<String> convActivations, List<String> denseActivations)
        {
            string code = "";
            for(int i = 0; i < chr.convPart.convLayers.Count; i++)
            {
                if (i == 0) code += "model.add(ZeroPadding2D((1, 1), input_shape = (128, 128, 3)))" + Environment.NewLine;
                else code += "model.add(ZeroPadding2D((1, 1))" + Environment.NewLine;
                code += "model.add(Conv2D(" + chr.convPart.convLayers[i].neurons.ToString() +
                                            ", kernel_size = (" + chr.convPart.convLayers[i].slidingWindow[0].ToString() + ", " +
                                            chr.convPart.convLayers[i].slidingWindow[1].ToString() + "), strides = (1, 1), activation ='" +
                                            convActivations[chr.convPart.convLayers[i].activationIndex] + "'))" + Environment.NewLine;
                code += "model.add(MaxPooling2D(pool_size = (2, 2), strides = (2, 2)))" + Environment.NewLine;
            }
            code += "model.add(Flatten())" + Environment.NewLine;
            for(int i = 0; i < chr.densePart.denseLayer.Count; i++)
            {
                code += "model.add(Dense(" + chr.densePart.denseLayer[i].neurons.ToString() +
                                        ", activation = '" + denseActivations[chr.densePart.denseLayer[i].activationIndex] + "'))" + Environment.NewLine;
                if (chr.densePart.denseLayer[i].dropoutExist)
                    code += "model.add(Dropout(" + ((float)chr.densePart.denseLayer[i].dropoutRate / 100).ToString() + "))" + Environment.NewLine;
            }
            code += "model.add(Dense(len(lb.classes_), activation = \"softmax\"";
            insertLineToFile(path, line, code);
        }

        
        // 30 означает что в 30 строку, а не после нее (1 - в первую строку)
        //insertLineToFile("proba.txt",30,"abc");

        public static void insertLineToFile(String path, int line, String text)
        {
            //уменьшить, т.к. нумерация с единицы и если номер отрицательный - указать начало файла
            if (--line < 0) line = 0;

            //текст из файла
            String textFile = System.IO.File.ReadAllText(path, Encoding.UTF8);

            //если нужно вставить в начало файла, либо файл пуст
            if (line == 0 || textFile == "")
            {
                //в случае пустого файла
                if (textFile == "") textFile = text;
                else textFile = text + Environment.NewLine + textFile;

            }
            else
            {
                //разбиение по строкам
                //для работы нужно подключить using System.Text.RegularExpressions;
                MatchCollection matches = Regex.Matches(textFile, "^.*$", RegexOptions.Multiline);

                //если в файле строк меньше чем указанная
                if (line >= matches.Count)
                {
                    textFile += Environment.NewLine + text;
                }
                else
                {
                    textFile = textFile.Substring(0, matches[line].Index) + text + textFile.Substring(matches[line].Index);
                }

            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, false))
            {
                file.Write(textFile);
            }

        }


        
        ////
        ///
        public void MutateNeurons(int mutateRate, string path, int firstLayer)
        {

        }

        public int GetOutputNumb(string path)
        {
            return Directory.GetDirectories(path).Length;
        }


        public static void WriteConvNetworkConfig(List<ConvolutionalNetwork> eliteConvNets)
        {
            using (StreamWriter sw = new StreamWriter("cNetwork.json"))
            {
                sw.WriteLine(JsonConvert.SerializeObject(eliteConvNets));
            }
        }

        public static void ReadConvNetworkConfig(List<ConvolutionalNetwork> eliteConvNets)
        {
            using (StreamReader sr = new StreamReader("cNetwork.json"))
            {
                eliteConvNets = JsonConvert.DeserializeObject<List<ConvolutionalNetwork>>(sr.ReadLine());
            }
        }
    }
}
