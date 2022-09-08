using System;
using System.IO;
using System.Collections.Generic;

namespace ClassLibraryForArray
{
    public class IntArray
    {
        public delegate void MessageHandler(string txt);
        public static event MessageHandler Notify;

        // Закрытые поля:
        int[] m_array;      //закрытый одномерный массив
        int m_length;      //закрытая длина

        // Конструкторы:
        public IntArray(int length)  //конструктор 1 для создания массива заданной длины length, стр. 114-117, 158
        {
            m_length = Convert.ToInt32(Math.Abs(length));
            m_array = new int[m_length];

            Notify?.Invoke("Сработал конструктор IntArray одним параметром длины массива\n");
        }
        public IntArray(params int[] arr)   //конструктор 2 с переменным числом параметров, стр. 154, 163
        {
            m_length = arr.Length;
            m_array = new int[m_length];
            for (int i = 0; i < m_length; i++)
            {
               m_array[i] = arr[i];
            }

            Notify?.Invoke("Сработал конструктор IntArray с переменным числом параметров - элементами массива\n");
        }

        // Свойства:
        public int Length
        {
            get { return m_length; }
        }

        // Cвойство Длина массива, стр. 120-123
        public int this[int i]  // Индексатор, стр. 157-159         (закрытый массив требует)
        {
            get
            {
                i = Math.Abs(i);
                if (i < m_length)
                { return m_array[i]; }

                else
                { throw new IndexOutOfRangeException(); }
            }

            set
            {
                i = Math.Abs(i);
                if (i < m_length)
                { m_array[i] = value; }
                else
                { throw new IndexOutOfRangeException(); }
            }
        }

        // Методы класса:
        public static IntArray RandomIntArray(int length, int a, int b) // создание массива длины length и заполнение его случайными целыми числами в диапазоне от a до b, стр. 148-150 
        {
            Random R = new Random();
            IntArray arr = new IntArray(Convert.ToInt32(Math.Abs(length)));
            for (int i = 0; i < length; i++)
            {
                arr[i] = R.Next(a,(b+1));
            }   

            Notify?.Invoke("Был создан массив длины" + Convert.ToInt32(Math.Abs(length)) + " и он был заполнен случайными числами в диапазоне от " + a + " до " + b + "\n");
            return arr;
        }
       
        public static IntArray ArrayFromTextFile(string fileName)  //ввод массива из текстового файла с именем filename, стр. 258-259
        {
            string line;
            string[] buffer;

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    line = sr.ReadToEnd();
                }

                char[] separators = { ',', '\n', ' ' };
                buffer = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                int length = buffer.Length;
                IntArray arr = new IntArray(length);

                for (int i = 0; i < length; ++i)
                {
                    arr[i] = Convert.ToInt32(buffer[i]);
                }

                Notify?.Invoke("Массив был считан из файла\n");
                return arr;
            }

            catch (FileNotFoundException ex)
            {
                Notify?.Invoke("Произошла ошибка: "+ ex + "\n");
                return null;
            }
        }

        public static void ArrayToTextFile(IntArray arr, string fileName)    //вывод массива arr в текстовый файл с именем filename, стр. 256-257
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, false))
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i == arr.Length - 1)
                        { sw.Write(arr[i]); }
                        else
                        { sw.Write(arr[i] + " "); }
                    };
                }
                Notify?.Invoke("Массив был внесен в текстовый файл с именем " + fileName + "\n");
            }

            catch
            {
                Notify?.Invoke("Ошибка внесения массива в файл\n");
            }
        }

        public static int SumArray(IntArray arr)   //вычисление суммы элементов массива arr, стр. 128-129
        {
            int sum=0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Notify?.Invoke("Вычисление суммы элементов массива sum: " + sum + "\n");
            return sum;
        }

        // Метод созданный по варианту №6
        // Метод, который перестраивает массив из n целых чисел таким образом, что сначала пойдут все положительные элементы,
        // затем все отрицательные элементы, а в конце массива — нули.
        public static IntArray MySort(IntArray arr) 
        {
            List<int> list = new List<int>(arr.Length);
            IntArray tempArr = new IntArray(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) { list.Add(arr[i]); }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) { list.Add(arr[i]); }
            }

            int listSize = list.Count;
            for (int i = listSize; i < arr.Length; i++)
            {
                list.Add(0) ;
            }

            for (int i = 0; i < tempArr.Length; i++)
            {
                tempArr[i] = list[i];
            }

            Notify?.Invoke("Произведена сортировка массива так, что сначала идут положительные числа, затем все отрицательные, а после - нули\n");
            return tempArr;
        }

        public static bool AreEqual(IntArray arr1, IntArray arr2)
        {
            bool AreEqual = true;
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        AreEqual = false;
                        break;
                    }
                }
            }
            else AreEqual = false;

            Notify?.Invoke("Произведена проверка равенства размеров и элементов массива\n");
            return AreEqual;
        }

        // Операции класса:

        public static IntArray operator ++(IntArray arr)    // ++: инкремент: увеличение на 1 всех элементов массива, 163-164
        {
            IntArray tempArr = new IntArray(arr.Length);
            for (int i = 0; i < arr.Length; ++i)
            {
                tempArr[i] = arr[i]++;
            }
            Notify?.Invoke("Осуществлено увеличение на 1 всех элементов массива!\n");
            return tempArr;
        }

        public static IntArray operator +(IntArray x, int y)  // +: сложение массива x со скаляром y, стр. 165-167
        {
            IntArray arr = new IntArray(x.Length);
            for (int i = 0; i < x.Length; ++i)
            {
                arr[i] = x[i] + y;
            }
            Notify?.Invoke("Осуществлено сложение массива со скаляром\n");
            return arr;
        }

        public static IntArray operator +(int x, IntArray y)  // +: сложение скаляра x с массивом y, стр. 165-167
        {
            IntArray arr = new IntArray(y.Length);
            for (int i = 0; i < y.Length; ++i)
            {
                arr[i] = x + y[i];
            }
            Notify?.Invoke("Осуществлено сложение скаляра с массивом\n");
            return arr;
        }

        public static IntArray operator +(IntArray x, IntArray y)  // +: сложение двух массивов x и y, стр. 165-167
        {
            int length = x.Length < y.Length ? x.Length : y.Length; 

            IntArray arr = new IntArray(length);
            for (int i = 0; i < length; ++i)
            {
                arr[i] = x[i] + y[i];
            }
            Notify?.Invoke("Осуществлено сложение двух массивов\n");
            return arr;
        }

        public static IntArray operator --(IntArray arr)    // --: декремент: уменьшение на 1 всех элементов массива
        {
            IntArray tempArr = new IntArray(arr.Length);
            for (int i = 0; i < arr.Length; ++i)
            {
                tempArr[i] = arr[i]--;
            }
            Notify?.Invoke("Осуществлено уменьшение на 1 всех элементов массива!\n");
            return tempArr;
        }

        public static IntArray operator -(IntArray x, int y)  // -: вычитание из массива x скаляра y (x - y)
        {
            IntArray arr = new IntArray(x.Length);
            for (int i = 0; i < x.Length; ++i)
            {
                arr[i] = x[i] - y;
            }
            Notify?.Invoke("Осуществлено вычитание из массива скаляра\n");
            return arr;
        }

        public static IntArray operator -(int x, IntArray y)  // -: вычитание из скаляра x массива y (x - y)
        {
            IntArray arr = new IntArray(y.Length);
            for (int i = 0; i < y.Length; ++i)
            {
                arr[i] = x - y[i];
            }
            Notify?.Invoke("Осуществлено вычитание из скаляра массива\n");
            return arr;
        }

        public static IntArray operator -(IntArray x, IntArray y)  // -: вычитание из массива x массива y (x - y)
        {
            int length = x.Length < y.Length ? x.Length : y.Length;
            IntArray arr = new IntArray(length);
            for (int i = 0; i < length; ++i)
            {
                arr[i] = x[i] - y[i];
            }
            Notify?.Invoke("Осуществлено вычитание из массива второго массива\n");
            return arr;
        }
    
    }
}
