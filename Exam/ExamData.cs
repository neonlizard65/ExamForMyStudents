using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class ExamData
    {
        public static Question Questions = new Question();
        private static List<Architecture> MPArchitectureList = new List<Architecture>();
        private static List<Architecture1> EXArchitectureList = new List<Architecture1>();
        private static List<Network> MPNetworkList = new List<Network>();
        private static List<Network1> EXNetworkList = new List<Network1>();
        private static List<OS> MPOSList = new List<OS>();
        private static List<OS1> EXOSList = new List<OS1>();

        public static int totalquestcount = 0;
        public static int mparchcount = 0;
        public static int mpnetcount = 0;
        public static int mposcount = 0;
        public static int exarchcount = 0;
        public static int exnetcount = 0;
        public static int exoscount = 0;

        public ExamData(Question rawData)
        {   //Отборка вопросов

            //Архитектура (тестовые)
            int len = rawData.multiplechoice.architecture.Count;
            List<int> usedPositions = new List<int>();
            Random r = new Random();
            int count = 0;
            while(count < 8)
            {
                int position = r.Next(len);
                if (!usedPositions.Contains(position))
                {
                    usedPositions.Add(position);
                    MPArchitectureList.Add(rawData.multiplechoice.architecture[position]);
                    count++;
                }
            }

            //Сети (тестовые)
            len = rawData.multiplechoice.network.Count;
            usedPositions.Clear();
            count = 0;
            while (count < 8)
            {
                int position = r.Next(len);
                if (!usedPositions.Contains(position))
                {
                    usedPositions.Add(position);
                    MPNetworkList.Add(rawData.multiplechoice.network[position]);
                    count++;
                }
            }

            //Сети (тестовые)
            len = rawData.multiplechoice.os.Count;
            usedPositions.Clear();
            count = 0;
            while (count < 8)
            {
                int position = r.Next(len);
                if (!usedPositions.Contains(position))
                {
                    usedPositions.Add(position);
                    MPOSList.Add(rawData.multiplechoice.os[position]);
                    count++;
                }
            }

            //Архитектура (раскрытый ответ)
            len = rawData.extendedanswer.architecture.Count;
            usedPositions.Clear();
            count = 0;
            while (count < 2)
            {
                int position = r.Next(len);
                if (!usedPositions.Contains(position))
                {
                    usedPositions.Add(position);
                    EXArchitectureList.Add(rawData.extendedanswer.architecture[position]);
                    count++;
                }
            }

            //Сети (раскрытый ответ)
            len = rawData.extendedanswer.network.Count;
            usedPositions.Clear();
            count = 0;
            while (count < 2)
            {
                int position = r.Next(len);
                if (!usedPositions.Contains(position))
                {
                    usedPositions.Add(position);
                    EXNetworkList.Add(rawData.extendedanswer.network[position]);
                    count++;
                }
            }

            //ОС (раскрытый ответ)
            len = rawData.extendedanswer.architecture.Count;
            usedPositions.Clear();
            count = 0;
            while (count < 2)
            {
                int position = r.Next(len);
                if (!usedPositions.Contains(position))
                {
                    usedPositions.Add(position);
                    EXOSList.Add(rawData.extendedanswer.os[position]);
                    count++;
                }
            }

            //Общий объект
            Questions.multiplechoice = new Multiplechoice();
            Questions.multiplechoice.architecture = MPArchitectureList;
            Questions.multiplechoice.network = MPNetworkList;
            Questions.multiplechoice.os = MPOSList;
            Questions.extendedanswer = new Extendedanswer();
            Questions.extendedanswer.architecture = EXArchitectureList;
            Questions.extendedanswer.network = EXNetworkList;
            Questions.extendedanswer.os = EXOSList;
        }
    }
}
