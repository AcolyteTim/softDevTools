using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ClassLibraryForArray;

namespace WinFormForIntArrayLibrary
{
    public partial class Form1 : Form
    {
        // Методы для DataGridView
        /// <summary>
        /// Заполняет таблицу элементами из массива
        /// </summary>
        /// <param name="arr"> записываемый массив </param>
        /// <param name="dataGridView"> таблица для записи </param>
        /// <param name="textBoxLength"> текстовое поле длины</param>
        private void setDataGridView(IntArray arr, DataGridView dataGridView, TextBox textBoxLength)
        {
            dataGridView.RowCount = 1;                              //установка количества строк
            textBoxLength.Text = Convert.ToString(arr.Length);      //установка длины в поле длины
            dataGridView.ColumnCount = Convert.ToInt32(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                dataGridView.Columns[i].Name = Convert.ToString(i + 1);
                dataGridView.Rows[0].Cells[i].Value = arr[i];
            }
        }

        private IntArray loadArrfromDataGridView(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                IntArray array = new IntArray(dataGridView.ColumnCount);
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    array[i] = Convert.ToInt32(dataGridView.Rows[0].Cells[i].Value);
                }
                return array;
            }
            else
            {
                MessageBox.Show("Ошибка, отсутствуют значения в элементе DataGridView!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Методы регулирующие видимость элементов
        
        //Arr1
        private void makeVisibleForRandMethod1() 
        {
            labelArr1downBorder.Visible = true;
            textBoxArr1downBorder.Visible = true;
            labelArr1upBorder.Visible = true;
            textBoxArr1upBorder.Visible = true;
        }

        private void makeInvsibleForRandMethod1()
        {
            labelArr1downBorder.Visible = false;
            textBoxArr1downBorder.Visible = false;
            labelArr1upBorder.Visible = false;
            textBoxArr1upBorder.Visible = false;
        }

        private void makeVisibleForArrElementsSum1()
        {
            labelArr1SumResult.Visible = true;
            textBoxArr1SumResult.Visible = true;
        }

        private void makeInVisibleForArrElementsSum1()
        {
            labelArr1SumResult.Visible = false;
            textBoxArr1SumResult.Visible = false;
        }

        private void makeVisibleForMultiplesAmountSearch1()
        {
            labelArr1NumForMultiplesAmountSearch.Visible = true;
            textBoxArr1NumForMultiplesAmountSearch.Visible = true;
            labelArr1MultiplesAmount.Visible = true;
            textBoxArr1MultiplesAmount.Visible = true;
        }

        private void makeInvisibleForMultiplesAmountSearch1()
        {
            labelArr1NumForMultiplesAmountSearch.Visible = false;
            textBoxArr1NumForMultiplesAmountSearch.Visible = false;
            labelArr1MultiplesAmount.Visible = false;
            textBoxArr1MultiplesAmount.Visible = false;
        }

        private void makeVisibleForScalar1()
        {
            labelArr1Scalar.Visible = true;
            textBoxArr1Scalar.Visible = true;
        }

        private void makeInvisibleForScalar1()
        {
            labelArr1Scalar.Visible = false;
            textBoxArr1Scalar.Visible = false;
        }

        private void makeInvisibleAllFuncChoiceArr1()
        {
            makeInVisibleForArrElementsSum1();
            makeInvisibleForMultiplesAmountSearch1();
            makeInvisibleForScalar1();
        }

        //Arr2
        private void makeVisibleForRandMethod2()
        {
            labelArr2downBorder.Visible = true;
            textBoxArr2downBorder.Visible = true;
            labelArr2upBorder.Visible = true;
            textBoxArr2upBorder.Visible = true;
        }

        private void makeInvsibleForRandMethod2()
        {
            labelArr2downBorder.Visible = false;
            textBoxArr2downBorder.Visible = false;
            labelArr2upBorder.Visible = false;
            textBoxArr2upBorder.Visible = false;
        }

        private void makeVisibleForArrElementsSum2()
        {
            labelArr2SumResult.Visible = true;
            textBoxArr2SumResult.Visible = true;
        }

        private void makeInVisibleForArrElementsSum2()
        {
            labelArr2SumResult.Visible = false;
            textBoxArr2SumResult.Visible = false;
        }

        private void makeVisibleForMultiplesAmountSearch2()
        {
            labelArr2NumForMultiplesAmountSearch.Visible = true;
            textBoxArr2NumForMultiplesAmountSearch.Visible = true;
            labelArr2MultiplesAmount.Visible = true;
            textBoxArr2MultiplesAmount.Visible = true;
        }

        private void makeInvisibleForMultiplesAmountSearch2()
        {
            labelArr2NumForMultiplesAmountSearch.Visible = false;
            textBoxArr2NumForMultiplesAmountSearch.Visible = false;
            labelArr2MultiplesAmount.Visible = false;
            textBoxArr2MultiplesAmount.Visible = false;
        }

        private void makeVisibleForScalar2()
        {
            labelArr2Scalar.Visible = true;
            textBoxArr2Scalar.Visible = true;
        }

        private void makeInvisibleForScalar2()
        {
            labelArr2Scalar.Visible = false;
            textBoxArr2Scalar.Visible = false;
        }

        private void makeInvisibleAllFuncChoiceArr2()
        {
            makeInVisibleForArrElementsSum2();
            makeInvisibleForMultiplesAmountSearch2();
            makeInvisibleForScalar2();
        }
        //////////////////////////////////////////////

        private void setComboBoxArr(ComboBox comboBoxArr) // заполнение ComboBox способов получения массива
        {
            comboBoxArr.Items.Add("Вручную");
            comboBoxArr.Items.Add("Из файла");
            comboBoxArr.Items.Add("Случайные числа в диапазоне");
        }

        private void setComboBoxArrFuncChoice(ComboBox comboBoxArrFuncChoice) // заполнение ComboBox функций
        {
            // 1 эл.
            comboBoxArrFuncChoice.Items.Add("Загрузить массив в файл");
            comboBoxArrFuncChoice.Items.Add("Просуммировать элементы массива");
            comboBoxArrFuncChoice.Items.Add("Специальная сортировка (6 вар.)");
            comboBoxArrFuncChoice.Items.Add("Операция инкремента (++)");
            comboBoxArrFuncChoice.Items.Add("Операция декремента (--)");
            comboBoxArrFuncChoice.Items.Add("Количество чисел кратных заданному");

            // 2 эл.
            comboBoxArrFuncChoice.Items.Add("Сложение массива со скаляром");
            comboBoxArrFuncChoice.Items.Add("Сложение скаляра с массивом");
            comboBoxArrFuncChoice.Items.Add("Вычитание из массива скаляра");
            comboBoxArrFuncChoice.Items.Add("Вычитание из скаляра массива");
        }

        private void typeEnterWarning() // вывод сообщения об одной из стандартных проблем - ненажатый Enter
        {
            MessageBox.Show("Вероятно вы забыли нажать на Enter для записи и проверки значения! Попробуйте вновь!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void typeConvertToIntError() // вывод сообщения об одной из стандартных ошибок - конвертации в int
        {
            MessageBox.Show("Ошибка конвертации значения в int!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Form1()
        {
            InitializeComponent();

            #region Array1  
            //cкрывают лишние на данный момент поля
            makeInvsibleForRandMethod1(); 
            makeInvisibleAllFuncChoiceArr1();

            //запрет на редактирование
            textBoxArr1SumResult.ReadOnly = true;
            textBoxArr1MultiplesAmount.ReadOnly = true;

            //Combobox
            setComboBoxArr(comboBoxArr1);

            //ComboBoxArrFuncChoice
            setComboBoxArrFuncChoice(comboBoxArr1FuncChoice);
            #endregion

            #region Array2
            //скрывают лишние на данный момент поля
            makeInvsibleForRandMethod2();
            makeInvisibleAllFuncChoiceArr2();

            //запрет на редактирование
            textBoxArr2SumResult.ReadOnly = true;
            textBoxArr2MultiplesAmount.ReadOnly = true;

            //ComboBox
            setComboBoxArr(comboBoxArr2);

            //ComboBoxArrFuncChoice
            setComboBoxArrFuncChoice(comboBoxArr2FuncChoice);
            #endregion

            // 3ий результирующий массив
            #region Array3

            #endregion
        }

        // Array1
        private void comboBoxArr1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxArr1.SelectedIndex) 
            {

                case 0: // Вручную
                    makeInvsibleForRandMethod1();
                    break;

                case 1: // Из файла
                    makeInvsibleForRandMethod1(); // возможно перенести на кнопки.
                    try
                    {
                        string file = "";
                        file = Interaction.InputBox("При вводе только названия файл cчитывается из\nПапкаПроекта\\ClassLibraryForArray\\WinFormForIntArrayLibrary\\bin\\Debug",
                            "Введите полный путь до файла", "test.txt");

                            IntArray arrayF = new IntArray();
                            arrayF = IntArray.ArrayFromTextFile(file);
                            if (arrayF == null) { throw new Exception(); }
                            setDataGridView(arrayF, dataGridViewArr1, textBoxArr1Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка считывания массива из файла!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 2: // Случайные числа в диапазоне
                    makeVisibleForRandMethod1();
                    break;
            }
            //MessageBox.Show($"{this.comboBoxArr1.GetItemText(this.comboBoxArr1.SelectedItem)}!");
        } 

        private void textBoxArr1Length_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int lengthArr1 = 0;
                try
                {
                    if (textBoxArr1Length.Text == "0")
                    {
                        MessageBox.Show("Длины массива не может равняться 0!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    lengthArr1 = Convert.ToInt32(textBoxArr1Length.Text);
                }
                catch
                {
                    textBoxArr1Length.Text = Convert.ToString(""); // Именно так, поскольку в противном случае окно ошибки выводилось 2ды
                    MessageBox.Show("Введено некорректное значение длины массива 1!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 

        private void textBoxArr1downBorder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int downBorderArr1 = 0;
                try
                {
                    downBorderArr1 = int.Parse(textBoxArr1downBorder.Text);
                }
                catch
                {
                    textBoxArr1downBorder.Text = Convert.ToString(0); // Именно так, поскольку в противном случае окно ошибки выводилось 2ды
                    MessageBox.Show("Введено некорректное значение для нижней границы значений случайных чисел массива", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxArr1upBorder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int upBorderArr1 = 0;
                try
                {
                    upBorderArr1 = int.Parse(textBoxArr1upBorder.Text);
                }
                catch
                {
                    textBoxArr1upBorder.Text = Convert.ToString(0); // Именно так, поскольку в противном случае окно ошибки выводилось 2ды
                    MessageBox.Show("Введено некорректное значение для верхней границы значений случайных чисел массива", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonArr1Create_Click(object sender, EventArgs e)
        {
            int length = 0;
            int downBorder = 0;
            int upBorder = 0;
            switch (comboBoxArr1.SelectedIndex)
            {
                case 0: // Вручную
                    if (textBoxArr1Length.Text == "" || textBoxArr1Length.Text == "0")
                    {
                        MessageBox.Show("Введите отличное от 0 значение длины для массива 1!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        try
                        { length = Convert.ToInt32(textBoxArr1Length.Text); }
                        catch
                        { typeEnterWarning(); break; }

                        length = Convert.ToInt32(textBoxArr1Length.Text);
                        IntArray arrayL = new IntArray(length);
                        setDataGridView(arrayL, dataGridViewArr1, textBoxArr1Length);
                    }
                    break;
                case 1: // Из файла
                    // Реализовано через InteractBox в comboBoxArr1_SelectedIndexChanged
                    break;
                case 2: // Случайные числа в диапазоне

                    if (textBoxArr1Length.Text == "" || textBoxArr1Length.Text == "0")
                    {
                        MessageBox.Show("Значение длины массива некорректно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    if (textBoxArr1downBorder.Text == "")
                    {
                        MessageBox.Show("Значение нижней границы случайных значений массива некорректно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    if (textBoxArr1upBorder.Text == "")
                    {
                        MessageBox.Show("Значение верхней границы случайных значений массива некорректно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    try
                    { length = Convert.ToInt32(textBoxArr1Length.Text); }
                    catch
                    { typeEnterWarning(); break; }
                    if (length < 0) { length = Math.Abs(length); };

                    try
                    { downBorder = Convert.ToInt32(textBoxArr1downBorder.Text); }
                    catch
                    { typeEnterWarning(); break; }

                    try
                    { upBorder = Convert.ToInt32(textBoxArr1upBorder.Text); }
                    catch
                    { typeEnterWarning(); break; }
                    

                    if (upBorder < downBorder) { MessageBox.Show("Значение нижней границы случайных значений массива превышает значение верхней", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        IntArray arrayR = new IntArray(length);
                        arrayR = IntArray.RandomIntArray(length, downBorder, upBorder);
                        setDataGridView(arrayR, dataGridViewArr1, textBoxArr1Length);
                    };
                    break;

                default:
                    MessageBox.Show("Выберите способ получения массива 1!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void comboBoxArr1FuncChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxArr1FuncChoice.SelectedIndex) 
            {

                case 0: // Загрузить массив в файл
                    makeInvisibleAllFuncChoiceArr1();
                    if (loadArrfromDataGridView(dataGridViewArr1) == null) { }
                    else
                    {
                        IntArray arr = loadArrfromDataGridView(dataGridViewArr1);
                        IntArray checker = new IntArray();
                        try
                        {
                            string file = "";
                            file = Interaction.InputBox("При вводе только названия файл сохраняется в\nПапкаПроекта\\ClassLibraryForArray\\WinFormForIntArrayLibrary\\bin\\Debug",
                                "Введите полный путь до файла", "D:\\test.txt");
                            IntArray.ArrayToTextFile(checker, file);
                            if (IntArray.ArrayFromTextFile(file) == null) { throw new Exception(); }
                            else
                            {
                                IntArray.ArrayToTextFile(arr, file);
                                if (IntArray.ArrayFromTextFile(file) == null) { throw new Exception(); }
                            }
                        }
                        catch
                        { MessageBox.Show("Ошибка записи массива в файл!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    break;

                case 1: // Просуммировать элементы массива
                    makeInvisibleForMultiplesAmountSearch1();
                    makeInvisibleForScalar1();
                    makeVisibleForArrElementsSum1();
                    // метод подсчета
                    break;

                case 2: // Спец. сортировка - 6 вар.
                    makeInvisibleAllFuncChoiceArr1();
                    // метод сортировки
                    break;

                case 3: // Операция инкремента
                    makeInvisibleAllFuncChoiceArr1();
                    //метод
                    break;

                case 4: // Операция декремента
                    makeInvisibleAllFuncChoiceArr1();
                    //метод
                    break;

                case 5: // Кол-во чисел кратных данному
                    makeInVisibleForArrElementsSum1();
                    makeInvisibleForScalar1();
                    makeVisibleForMultiplesAmountSearch1();
                    //метод
                    break;

                case 6: // Сложение массива со скаляром
                    makeInVisibleForArrElementsSum1();
                    makeInvisibleForMultiplesAmountSearch1();
                    makeVisibleForScalar1();
                    break;

                case 7: // Сложение скаляра с массивом
                    makeInVisibleForArrElementsSum1();
                    makeInvisibleForMultiplesAmountSearch1();
                    makeVisibleForScalar1();
                    break;

                case 8: // Вычитание из массива скаляра
                    makeInVisibleForArrElementsSum1();
                    makeInvisibleForMultiplesAmountSearch1();
                    makeVisibleForScalar1();
                    break;

                case 9: // Вычитание из скаляра массива
                    makeInVisibleForArrElementsSum1();
                    makeInvisibleForMultiplesAmountSearch1();
                    makeVisibleForScalar1();
                    break;
            }
        }

        private void textBoxArr1Scalar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int scalarArr1 = 0;
                try
                {
                    scalarArr1 = Convert.ToInt32(textBoxArr1Scalar.Text);
                }
                catch
                {
                    textBoxArr1Scalar.Text = Convert.ToString(""); // Именно так, поскольку в противном случае окно ошибки выводилось 2ды
                    MessageBox.Show("Введено некорректное значение скаляра для массива 1!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxArr1NumForMultiplesAmountSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int numForMultiplesSearch = 0;
                try
                {
                    numForMultiplesSearch = Convert.ToInt32(textBoxArr1NumForMultiplesAmountSearch.Text);
                }
                catch
                {
                    textBoxArr1NumForMultiplesAmountSearch.Text = Convert.ToString(""); // Именно так, поскольку в противном случае окно ошибки выводилось 2ды
                    MessageBox.Show("Введено некорректное значение для поиска кратных чисел в массиве 1!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonArr1Action_Click(object sender, EventArgs e)
        {
            IntArray arr = loadArrfromDataGridView(dataGridViewArr1);
            int sum = 0;
            int number = 0;
            int scalar = 0;
            switch (this.comboBoxArr1FuncChoice.SelectedIndex)
            {
                case 0: // Загрузить массив в файл
                    // Реализовано через InteractBox в comboBoxArr1_SelectedIndexChanged
                    break;

                case 1: // Просуммировать элементы массива
                    try
                    {
                        sum = IntArray.SumArray(arr);
                        textBoxArr1SumResult.Text = Convert.ToString(sum);
                    }
                    catch
                    { MessageBox.Show("Ошибка рассчета суммы элементов массива!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);  }
                    break;

                case 2: // Спец. сортировка - 6 вар.
                    try
                    {
                        IntArray mySortArr = IntArray.MySort(arr);
                        setDataGridView(mySortArr, dataGridViewArr3, textBoxArr1Length);
                    }
                    catch { MessageBox.Show("Ошибка специальной сортировки массива!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);  }
                    break;

                case 3: // Операция инкремента
                    try
                    {
                        IntArray incrArr = arr++;
                        setDataGridView(incrArr, dataGridViewArr3, textBoxArr1Length);
                    }
                    catch { MessageBox.Show("Ошибка операции инкремента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 4: // Операция декремента
                    try
                    {
                        IntArray decrArr = arr--;
                        setDataGridView(decrArr, dataGridViewArr3, textBoxArr1Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка операции декремента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 5: // Кол-во чисел кратных данному
                    try
                    {   number = Convert.ToInt32(textBoxArr1NumForMultiplesAmountSearch.Text); }
                    catch
                    {
                        if (textBoxArr1NumForMultiplesAmountSearch.Text == "")
                        {
                            MessageBox.Show("Введите значение для поиска чисел кратных ему в массиве", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                        else
                        { typeConvertToIntError(); break; }
                    }

                    try
                    {
                        int amount = 0;
                        if (number == 0) { amount = arr.Length; }
                        else
                        {
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] != 0 && arr[i] % number == 0) amount++;
                            }
                        }
                        textBoxArr1MultiplesAmount.Text = Convert.ToString(amount);
                    }
                    catch
                    { MessageBox.Show("Ошибка в подсчете количества кратных данному значению чисел в массиве!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 6: // Сложение массива со скаляром
                    try
                    { scalar = Convert.ToInt32(textBoxArr1Scalar.Text); }
                    catch
                    {
                        if (textBoxArr1Scalar.Text == "")
                        {
                            MessageBox.Show("Введите значение скаляра для текущего действия с массивом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                        else
                        { typeConvertToIntError(); break; }
                    }

                    try
                    {
                        IntArray scalarArr = arr;
                        IntArray result = scalarArr + scalar;
                        setDataGridView(result, dataGridViewArr3, textBoxArr1Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка в сложении массива со скаляром!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 7: // Сложение скаляра с массивом
                    try
                    { scalar = Convert.ToInt32(textBoxArr1Scalar.Text); }
                    catch
                    {
                        if (textBoxArr1Scalar.Text == "")
                        {
                            MessageBox.Show("Введите значение скаляра для текущего действия с массивом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                        else
                        { typeConvertToIntError(); break; }
                    }

                    try
                    {
                        IntArray scalarArr = arr;
                        IntArray result = scalar+scalarArr;
                        setDataGridView(result, dataGridViewArr3, textBoxArr1Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка в сложении скаляра с массивом!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);  }

                    break;

                case 8: // Вычитание из массива скаляра
                    try
                    { scalar = Convert.ToInt32(textBoxArr1Scalar.Text); }
                    catch
                    {
                        if (textBoxArr1Scalar.Text == "")
                        {
                            MessageBox.Show("Введите значение скаляра для текущего действия с массивом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                        else
                        { typeConvertToIntError(); break; }
                    }

                    try
                    {
                        IntArray scalarArr = arr;
                        IntArray result = scalarArr-scalar;
                        setDataGridView(result, dataGridViewArr3, textBoxArr1Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка в вычитании скаляра из массива!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 9: // Вычитание из скаляра массива
                    try
                    { scalar = Convert.ToInt32(textBoxArr1Scalar.Text); }
                    catch
                    {
                        if (textBoxArr1Scalar.Text == "")
                        {
                            MessageBox.Show("Введите значение скаляра для текущего действия с массивом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                        else
                        { typeConvertToIntError(); break; }
                    }

                    try
                    {
                        IntArray scalarArr = arr;
                        IntArray result = scalar - scalarArr;
                        setDataGridView(result, dataGridViewArr3, textBoxArr1Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка в вычитании массива из скаляра!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                default:
                    MessageBox.Show("Выберите конкретное действие над массивом!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }


        // Array2 
        private void comboBoxArr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxArr2.SelectedIndex)
            {

                case 0: // Вручную
                    makeInvsibleForRandMethod2();
                    break;

                case 1: // Из файла
                    makeInvsibleForRandMethod2(); // возможно перенести на кнопки.
                    try
                    {
                        string file = "";
                        file = Interaction.InputBox("При вводе только названия файл cчитывается из\nПапкаПроекта\\ClassLibraryForArray\\WinFormForIntArrayLibrary\\bin\\Debug",
                            "Введите полный путь до файла", "test.txt");

                        IntArray arrayF = new IntArray();
                        arrayF = IntArray.ArrayFromTextFile(file);
                        if (arrayF == null) { throw new Exception(); }
                        setDataGridView(arrayF, dataGridViewArr2, textBoxArr2Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка считывания массива из файла!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 2: // Случайные числа в диапазоне
                    makeVisibleForRandMethod2();
                    break;
            }
        }
        
        private void textBoxArr2Length_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int lengthArr2 = 0;
                try
                {
                    if (textBoxArr2Length.Text == "0")
                    {
                        MessageBox.Show("Длины массива не может равняться 0!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        lengthArr2 = Convert.ToInt32(textBoxArr2Length.Text);
                }
                catch
                {
                    textBoxArr2Length.Text = Convert.ToString(""); // Именно так, поскольку в противном случае окно ошибки выводилось 2ды
                    MessageBox.Show("Введено некорректное значение длины массива 2!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxArr2downBorder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int downBorderArr2 = 0;
                try
                {
                    downBorderArr2 = int.Parse(textBoxArr2downBorder.Text);
                }
                catch
                {
                    textBoxArr2downBorder.Text = Convert.ToString(0); // Именно так, поскольку в противном случае окно ошибки выводилось 2ды
                    MessageBox.Show("Введено некорректное значение для нижней границы значений случайных чисел массива", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxArr2upBorder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int upBorderArr2 = 0;
                try
                {
                    upBorderArr2 = int.Parse(textBoxArr2upBorder.Text);
                }
                catch
                {
                    textBoxArr2upBorder.Text = Convert.ToString(0); // Именно так, поскольку в противном случае окно ошибки выводилось 2ды
                    MessageBox.Show("Введено некорректное значение для верхней границы значений случайных чисел массива", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonArr2Create_Click(object sender, EventArgs e)
        {
            int length = 0;
            int downBorder = 0;
            int upBorder = 0;
            switch (comboBoxArr2.SelectedIndex)
            {
                case 0: // Вручную
                    if (textBoxArr2Length.Text == "" || textBoxArr2Length.Text == "0")
                    {
                        MessageBox.Show("Введите отличное от 0 значение длины для массива 2!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        try
                        { length = Convert.ToInt32(textBoxArr2Length.Text); }
                        catch
                        { typeEnterWarning(); break; }

                        length = Convert.ToInt32(textBoxArr2Length.Text);
                        IntArray arrayL = new IntArray(length);
                        setDataGridView(arrayL, dataGridViewArr2, textBoxArr2Length);
                    }
                    break;
                case 1: // Из файла
                    // Реализовано через InteractBox в comboBoxArr2_SelectedIndexChanged
                    break;
                case 2: // Случайные числа в диапазоне

                    if (textBoxArr2Length.Text == "" || textBoxArr2Length.Text == "0")
                    {
                        MessageBox.Show("Значение длины массива некорректно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    if (textBoxArr2downBorder.Text == "")
                    {
                        MessageBox.Show("Значение нижней границы случайных значений массива некорректно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    if (textBoxArr2upBorder.Text == "")
                    {
                        MessageBox.Show("Значение верхней границы случайных значений массива некорректно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    try
                    { length = Convert.ToInt32(textBoxArr2Length.Text); }
                    catch
                    { typeEnterWarning(); break; }
                    if (length < 0) { length = Math.Abs(length); };

                    try
                    { downBorder = Convert.ToInt32(textBoxArr2downBorder.Text); }
                    catch
                    { typeEnterWarning(); break; }

                    try
                    { upBorder = Convert.ToInt32(textBoxArr2upBorder.Text); }
                    catch
                    { typeEnterWarning(); break; }


                    if (upBorder < downBorder) { MessageBox.Show("Значение нижней границы случайных значений массива превышает значение верхней", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        IntArray arrayR = new IntArray(length);
                        arrayR = IntArray.RandomIntArray(length, downBorder, upBorder);
                        setDataGridView(arrayR, dataGridViewArr2, textBoxArr2Length);
                    };
                    break;

                default:
                    MessageBox.Show("Выберите способ получения массива 2!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void comboBoxArr2FuncChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxArr2FuncChoice.SelectedIndex)
            {

                case 0: // Загрузить массив в файл
                    makeInvisibleAllFuncChoiceArr2();
                    if (loadArrfromDataGridView(dataGridViewArr2) == null) { }
                    else
                    {
                        IntArray arr = loadArrfromDataGridView(dataGridViewArr2);
                        IntArray checker = new IntArray();
                        try
                        {
                            string file = "";
                            file = Interaction.InputBox("При вводе только названия файл сохраняется в\nПапкаПроекта\\ClassLibraryForArray\\WinFormForIntArrayLibrary\\bin\\Debug",
                                "Введите полный путь до файла", "D:\\test.txt");
                            IntArray.ArrayToTextFile(checker, file);
                            if (IntArray.ArrayFromTextFile(file) == null) { throw new Exception(); }
                            else
                            {
                                IntArray.ArrayToTextFile(arr, file);
                                if (IntArray.ArrayFromTextFile(file) == null) { throw new Exception(); }
                            }
                        }
                        catch
                        { MessageBox.Show("Ошибка записи массива в файл!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    break;

                case 1: // Просуммировать элементы массива
                    makeInvisibleForMultiplesAmountSearch2();
                    makeInvisibleForScalar2();
                    makeVisibleForArrElementsSum2();
                    // метод подсчета
                    break;

                case 2: // Спец. сортировка - 6 вар.
                    makeInvisibleAllFuncChoiceArr2();
                    // метод сортировки
                    break;

                case 3: // Операция инкремента
                    makeInvisibleAllFuncChoiceArr2();
                    //метод
                    break;

                case 4: // Операция декремента
                    makeInvisibleAllFuncChoiceArr2();
                    //метод
                    break;

                case 5: // Кол-во чисел кратных данному
                    makeInVisibleForArrElementsSum2();
                    makeInvisibleForScalar2();
                    makeVisibleForMultiplesAmountSearch2();
                    //метод
                    break;

                case 6: // Сложение массива со скаляром
                    makeInVisibleForArrElementsSum2();
                    makeInvisibleForMultiplesAmountSearch2();
                    makeVisibleForScalar2();
                    break;

                case 7: // Сложение скаляра с массивом
                    makeInVisibleForArrElementsSum2();
                    makeInvisibleForMultiplesAmountSearch2();
                    makeVisibleForScalar2();
                    break;

                case 8: // Вычитание из массива скаляра
                    makeInVisibleForArrElementsSum2();
                    makeInvisibleForMultiplesAmountSearch2();
                    makeVisibleForScalar2();
                    break;

                case 9: // Вычитание из скаляра массива
                    makeInVisibleForArrElementsSum2();
                    makeInvisibleForMultiplesAmountSearch2();
                    makeVisibleForScalar2();
                    break;
            }
        }

        private void textBoxArr2Scalar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int scalarArr2 = 0;
                try
                {
                    scalarArr2 = Convert.ToInt32(textBoxArr2Scalar.Text);
                }
                catch
                {
                    textBoxArr2Scalar.Text = Convert.ToString(""); // Именно так, поскольку в противном случае окно ошибки выводилось 2ды
                    MessageBox.Show("Введено некорректное значение скаляра для массива 2!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxArr2NumForMultiplesAmountSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int numForMultiplesSearch = 0;
                try
                {
                    numForMultiplesSearch = Convert.ToInt32(textBoxArr2NumForMultiplesAmountSearch.Text);
                }
                catch
                {
                    textBoxArr2NumForMultiplesAmountSearch.Text = Convert.ToString(""); // Именно так, поскольку в противном случае окно ошибки выводилось 2ды
                    MessageBox.Show("Введено некорректное значение для поиска кратных чисел в массиве 2!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonArr2Action_Click(object sender, EventArgs e)
        {
            IntArray arr = loadArrfromDataGridView(dataGridViewArr2);
            int sum = 0;
            int number = 0;
            int scalar = 0;
            switch (this.comboBoxArr2FuncChoice.SelectedIndex)
            {
                case 0: // Загрузить массив в файл
                    // Реализовано через InteractBox в comboBoxArr2_SelectedIndexChanged
                    break;

                case 1: // Просуммировать элементы массива
                    try
                    {
                        sum = IntArray.SumArray(arr);
                        textBoxArr2SumResult.Text = Convert.ToString(sum);
                    }
                    catch
                    { MessageBox.Show("Ошибка рассчета суммы элементов массива!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 2: // Спец. сортировка - 6 вар.
                    try
                    {
                        IntArray mySortArr = IntArray.MySort(arr);
                        setDataGridView(mySortArr, dataGridViewArr3, textBoxArr2Length);
                    }
                    catch { MessageBox.Show("Ошибка специальной сортировки массива!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 3: // Операция инкремента
                    try
                    {
                        IntArray incrArr = arr++;
                        setDataGridView(incrArr, dataGridViewArr3, textBoxArr2Length);
                    }
                    catch { MessageBox.Show("Ошибка операции инкремента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 4: // Операция декремента
                    try
                    {
                        IntArray decrArr = arr--;
                        setDataGridView(decrArr, dataGridViewArr3, textBoxArr2Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка операции декремента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 5: // Кол-во чисел кратных данному
                    try
                    { number = Convert.ToInt32(textBoxArr2NumForMultiplesAmountSearch.Text); }
                    catch
                    {
                        if (textBoxArr2NumForMultiplesAmountSearch.Text == "")
                        {
                            MessageBox.Show("Введите значение для поиска чисел кратных ему в массиве", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                        else
                        { typeConvertToIntError(); break; }
                    }

                    try
                    {
                        int amount = 0;
                        if (number == 0) { amount = arr.Length; }
                        else
                        {
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] != 0 && arr[i] % number == 0) amount++;
                            }
                        }
                        textBoxArr1MultiplesAmount.Text = Convert.ToString(amount);
                    }
                    catch
                    { MessageBox.Show("Ошибка в подсчете количества кратных данному значению чисел в массиве!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 6: // Сложение массива со скаляром
                    try
                    { scalar = Convert.ToInt32(textBoxArr2Scalar.Text); }
                    catch
                    {
                        if (textBoxArr2Scalar.Text == "")
                        {
                            MessageBox.Show("Введите значение скаляра для текущего действия с массивом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                        else
                        { typeConvertToIntError(); break; }
                    }

                    try
                    {
                        IntArray scalarArr = arr;
                        IntArray result = scalarArr + scalar;
                        setDataGridView(result, dataGridViewArr3, textBoxArr2Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка в сложении массива со скаляром!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 7: // Сложение скаляра с массивом
                    try
                    { scalar = Convert.ToInt32(textBoxArr2Scalar.Text); }
                    catch
                    {
                        if (textBoxArr2Scalar.Text == "")
                        {
                            MessageBox.Show("Введите значение скаляра для текущего действия с массивом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                        else
                        { typeConvertToIntError(); break; }
                    }

                    try
                    {
                        IntArray scalarArr = arr;
                        IntArray result = scalar + scalarArr;
                        setDataGridView(result, dataGridViewArr3, textBoxArr2Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка в сложении скаляра с массивом!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    break;

                case 8: // Вычитание из массива скаляра
                    try
                    { scalar = Convert.ToInt32(textBoxArr2Scalar.Text); }
                    catch
                    {
                        if (textBoxArr2Scalar.Text == "")
                        {
                            MessageBox.Show("Введите значение скаляра для текущего действия с массивом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                        else
                        { typeConvertToIntError(); break; }
                    }

                    try
                    {
                        IntArray scalarArr = arr;
                        IntArray result = scalarArr - scalar;
                        setDataGridView(result, dataGridViewArr3, textBoxArr2Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка в вычитании скаляра из массива!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                case 9: // Вычитание из скаляра массива
                    try
                    { scalar = Convert.ToInt32(textBoxArr2Scalar.Text); }
                    catch
                    {
                        if (textBoxArr2Scalar.Text == "")
                        {
                            MessageBox.Show("Введите значение скаляра для текущего действия с массивом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                        else
                        { typeConvertToIntError(); break; }
                    }

                    try
                    {
                        IntArray scalarArr = arr;
                        IntArray result = scalar - scalarArr;
                        setDataGridView(result, dataGridViewArr3, textBoxArr2Length);
                    }
                    catch
                    { MessageBox.Show("Ошибка в вычитании массива из скаляра!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;

                default:
                    MessageBox.Show("Выберите конкретное действие над массивом!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        // Array3
        private void buttonSumArrays_Click(object sender, EventArgs e)
        {
            try
            {
                IntArray arr1 = loadArrfromDataGridView(dataGridViewArr1);
                IntArray arr2 = loadArrfromDataGridView(dataGridViewArr2);
                IntArray sumArrays = arr1 + arr2;

                setDataGridView(sumArrays, dataGridViewArr3, textBoxArr1Length);
            }
            catch { MessageBox.Show("Ошибка при суммировании массивов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void buttonArr1minus2_Click(object sender, EventArgs e)
        {
            try
            {
                IntArray arr1 = loadArrfromDataGridView(dataGridViewArr1);
                IntArray arr2 = loadArrfromDataGridView(dataGridViewArr2);
                IntArray arraysSubtraction = arr1 - arr2;

                setDataGridView(arraysSubtraction, dataGridViewArr3, textBoxArr1Length);
            }
            catch { MessageBox.Show("Ошибка при вычитании второго массива из первого!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void buttonArr2minus1_Click(object sender, EventArgs e)
        {
            try
            {
                IntArray arr1 = loadArrfromDataGridView(dataGridViewArr1);
                IntArray arr2 = loadArrfromDataGridView(dataGridViewArr2);
                IntArray arraysSubtraction = arr2 - arr1;

                setDataGridView(arraysSubtraction, dataGridViewArr3, textBoxArr1Length);
            }
            catch { MessageBox.Show("Ошибка при вычитании первого массива из второго!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        // DataGridView
        private void dataGridViewArr_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int tryConvert = 0;
            try
            {
                if (sender.Equals(dataGridViewArr1))
                    tryConvert = Convert.ToInt32(dataGridViewArr1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (sender.Equals(dataGridViewArr2))
                    tryConvert = Convert.ToInt32(dataGridViewArr2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            }
            catch
            {
                MessageBox.Show("Введено некорректное значение в dataGridView, будет невозможно использование функций, измените значение!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (sender.Equals(dataGridViewArr1))
                    dataGridViewArr1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
                if (sender.Equals(dataGridViewArr2))
                    dataGridViewArr2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
            }
        }
    }
}
