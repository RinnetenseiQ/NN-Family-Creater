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

        public static void UpdateAssesment(List<ConvolutionalChromosome> chrList)
        {

            float minParamsCount = chrList[0].paramsCount; //локальная переменная для хранения минимальной памяти

            for (int i = 1; i < chrList.Count; i++)
            {
                if(minParamsCount != 0)
                {
                    if (chrList[i].paramsCount < minParamsCount && chrList[i].paramsCount != 0) minParamsCount = chrList[i].paramsCount; // цикл поиска минимума
                }
            
            }
                 
            for (int i = 0; i < chrList.Count; i++)
            {
                if (chrList[i].accuracy == 0 || chrList[i].paramsCount == 0) chrList[i].assessment = 0;
                else chrList[i].assessment = chrList[i].accuracy + (minParamsCount / chrList[i].paramsCount); // цикл расчета оценки
            }
                
        } // расчет оценки сети


        public static void MutateConvChr(ConvRandomParams crp, DenseRandomParams drp, 
                                          int mutateRate)
        {
            if (new Random().Next(100) < mutateRate)
            {
                if (new Random().Next(100) < 5)
                {
                    //TO DOOOOOOOOOOOOOO  new Chromosome

                }
            }
        }


        public static void insertLineToFile(String path, int line, String text)
        {
            //insertLineToFile("proba.txt", 30, "abc");
            // 30 означает что в 30 строку, а не после нее (1 - в первую строку)

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

        } // метод вставки в определенную строку файла


        public static int GetOutputNumb(string path)
        {
            return Directory.GetDirectories(path).Length;
        } // возвращает количество выходов сети(классов), нужных для обучения сети - нужно для распределения нейронов, чтобы не вышло, что предыдущий слой меньше количества классов.


        public static void WriteConvNetworkConfig(List<ConvolutionalNetwork> eliteConvNets)
        {
            using (StreamWriter sw = new StreamWriter("cNetwork.json"))
            {
                sw.WriteLine(JsonConvert.SerializeObject(eliteConvNets));
            }
        } // метод сериализации конфигураций сети в файл

        public static void ReadConvNetworkConfig(List<ConvolutionalNetwork> eliteConvNets)
        {
            using (StreamReader sr = new StreamReader("cNetwork.json"))
            {
                eliteConvNets = JsonConvert.DeserializeObject<List<ConvolutionalNetwork>>(sr.ReadLine());
            }
        } // метод десериализации конфигуриции сети из файла
    }
}
