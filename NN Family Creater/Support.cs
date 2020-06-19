using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using Newtonsoft.Json;
using ZedGraph;

namespace NN_Family_Creater
{
    class Support
    {
        public static PointPairList pointAssesList = new PointPairList();
        public static PointPairList pointParamsList = new PointPairList();

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
                else chrList[i].assessment = chrList[i].accuracy + chrList[i].accuracy*(minParamsCount / chrList[i].paramsCount); // цикл расчета оценки
            }
                
        } // расчет оценки сети

        public static string CreateDateTimeDirectory(string path, int mode)
        {
            string configure;
            if (mode == 0) configure = "MM-dd-yyyy";
            else configure = "HH-mm-ss";
            DirectoryInfo di;
            di = Directory.CreateDirectory(@"C:\keras\folder");
            string directory = path + @"\" + di.CreationTime.ToString(configure);
            if (!Directory.Exists(directory)) Directory.Move(@"C:\keras\folder", directory);
            else Directory.Delete(@"C:\keras\folder");
            return directory;
        }

        public static void DrawAssesGraph(ZedGraphControl zedGraph, int currEpoch, int maxEpoch, float assessment, int curChromosome)
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            //PointPairList list = new PointPairList();

            // Интервал, в котором будут лежать точки
        

            // Заполняем список точек

            pointAssesList.Add(currEpoch, assessment);
            // !!!
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurve = pane.AddCurve("Convolutional network", pointAssesList, Color.Blue, SymbolType.Diamond);

            // !!!
            // У кривой линия будет невидимой
            myCurve.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - голубой
            myCurve.Symbol.Fill.Color = Color.Blue;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurve.Symbol.Fill.Type = FillType.Solid;

            // !!!
            // Размер ромбиков
            myCurve.Symbol.Size = 7;


            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = -5;
            pane.XAxis.Scale.Max = maxEpoch + 5;
            pane.XAxis.Title.Text = "Epoch";

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = -0.2;
            pane.YAxis.Scale.Max = 2;
            pane.YAxis.Title.Text = "Assessment";

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        public static void DrawParamsGraph(ZedGraphControl zedGraph, float accuracy, int paramsCount, int maxParams)
        {
            GraphPane pane = zedGraph.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            //PointPairList list = new PointPairList();

            // Интервал, в котором будут лежать точки


            // Заполняем список точек

            pointParamsList.Add(paramsCount, accuracy);
            // !!!
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurve = pane.AddCurve("Convolutional network", pointParamsList, Color.Blue, SymbolType.Diamond);

            // !!!
            // У кривой линия будет невидимой
            myCurve.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - голубой
            myCurve.Symbol.Fill.Color = Color.Blue;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurve.Symbol.Fill.Type = FillType.Solid;

            // !!!
            // Размер ромбиков
            myCurve.Symbol.Size = 7;


            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = -(maxParams/10);
            pane.XAxis.Scale.Max = maxParams + maxParams/2;
            pane.XAxis.Title.Text = "Params";

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = - 0.2;
            pane.YAxis.Scale.Max = 1;
            pane.YAxis.Title.Text = "Accuracy";
            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        public static void DrawAccGraph(ZedGraphControl zedGraph, int currEpoch, int maxEpoch, float accuracy)
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            //PointPairList list = new PointPairList();

            // Интервал, в котором будут лежать точки


            // Заполняем список точек

            pointAssesList.Add(currEpoch, accuracy);
            // !!!
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurve = pane.AddCurve("Convolutional network", pointAssesList, Color.Blue, SymbolType.Diamond);

            // !!!
            // У кривой линия будет невидимой
            myCurve.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - голубой
            myCurve.Symbol.Fill.Color = Color.Blue;

            // !!!
            // Тип заполнения - сплошная заливка
            myCurve.Symbol.Fill.Type = FillType.Solid;

            // !!!
            // Размер ромбиков
            myCurve.Symbol.Size = 7;


            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = -5;
            pane.XAxis.Scale.Max = maxEpoch + 5;
            pane.XAxis.Title.Text = "Epoch";

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = -0.2;
            pane.YAxis.Scale.Max = 1;
            pane.YAxis.Title.Text = "Accuracy";

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        public static int GetPow2(int x)
        {
            int result = (int)Math.Ceiling(Math.Log(x, 2));
            return result;
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
