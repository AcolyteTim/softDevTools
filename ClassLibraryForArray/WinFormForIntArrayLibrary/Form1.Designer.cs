namespace WinFormForIntArrayLibrary
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelArr1 = new System.Windows.Forms.Label();
            this.comboBoxArr1 = new System.Windows.Forms.ComboBox();
            this.labelArr1Length = new System.Windows.Forms.Label();
            this.textBoxArr1Length = new System.Windows.Forms.TextBox();
            this.comboBoxArr1FuncChoice = new System.Windows.Forms.ComboBox();
            this.labelArr1SumResult = new System.Windows.Forms.Label();
            this.textBoxArr1SumResult = new System.Windows.Forms.TextBox();
            this.dataGridViewArr2 = new System.Windows.Forms.DataGridView();
            this.textBoxArr2SumResult = new System.Windows.Forms.TextBox();
            this.labelArr2SumResult = new System.Windows.Forms.Label();
            this.comboBoxArr2FuncChoice = new System.Windows.Forms.ComboBox();
            this.textBoxArr2Length = new System.Windows.Forms.TextBox();
            this.labelArr2Length = new System.Windows.Forms.Label();
            this.comboBoxArr2 = new System.Windows.Forms.ComboBox();
            this.labelArr2 = new System.Windows.Forms.Label();
            this.labelArr3 = new System.Windows.Forms.Label();
            this.dataGridViewArr3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewArr1 = new System.Windows.Forms.DataGridView();
            this.textBoxArr1downBorder = new System.Windows.Forms.TextBox();
            this.textBoxArr1upBorder = new System.Windows.Forms.TextBox();
            this.labelArr1downBorder = new System.Windows.Forms.Label();
            this.labelArr1upBorder = new System.Windows.Forms.Label();
            this.buttonArr1Create = new System.Windows.Forms.Button();
            this.buttonArr1Action = new System.Windows.Forms.Button();
            this.labelArr1Scalar = new System.Windows.Forms.Label();
            this.textBoxArr1Scalar = new System.Windows.Forms.TextBox();
            this.labelArr1MultiplesAmount = new System.Windows.Forms.Label();
            this.labelArr1NumForMultiplesAmountSearch = new System.Windows.Forms.Label();
            this.textBoxArr1NumForMultiplesAmountSearch = new System.Windows.Forms.TextBox();
            this.textBoxArr1MultiplesAmount = new System.Windows.Forms.TextBox();
            this.textBoxArr2MultiplesAmount = new System.Windows.Forms.TextBox();
            this.textBoxArr2NumForMultiplesAmountSearch = new System.Windows.Forms.TextBox();
            this.labelArr2NumForMultiplesAmountSearch = new System.Windows.Forms.Label();
            this.labelArr2MultiplesAmount = new System.Windows.Forms.Label();
            this.textBoxArr2Scalar = new System.Windows.Forms.TextBox();
            this.labelArr2Scalar = new System.Windows.Forms.Label();
            this.buttonArr2Action = new System.Windows.Forms.Button();
            this.buttonArr2Create = new System.Windows.Forms.Button();
            this.labelArr2upBorder = new System.Windows.Forms.Label();
            this.labelArr2downBorder = new System.Windows.Forms.Label();
            this.textBoxArr2upBorder = new System.Windows.Forms.TextBox();
            this.textBoxArr2downBorder = new System.Windows.Forms.TextBox();
            this.buttonSumArrays = new System.Windows.Forms.Button();
            this.buttonArr1minus2 = new System.Windows.Forms.Button();
            this.buttonArr2minus1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelArr1
            // 
            this.labelArr1.AutoSize = true;
            this.labelArr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArr1.Location = new System.Drawing.Point(13, 5);
            this.labelArr1.Name = "labelArr1";
            this.labelArr1.Size = new System.Drawing.Size(72, 17);
            this.labelArr1.TabIndex = 0;
            this.labelArr1.Text = "Массив 1:";
            // 
            // comboBoxArr1
            // 
            this.comboBoxArr1.FormattingEnabled = true;
            this.comboBoxArr1.Location = new System.Drawing.Point(15, 25);
            this.comboBoxArr1.Name = "comboBoxArr1";
            this.comboBoxArr1.Size = new System.Drawing.Size(196, 21);
            this.comboBoxArr1.TabIndex = 1;
            this.comboBoxArr1.Text = "Способ получения";
            this.comboBoxArr1.SelectedIndexChanged += new System.EventHandler(this.comboBoxArr1_SelectedIndexChanged);
            // 
            // labelArr1Length
            // 
            this.labelArr1Length.AutoSize = true;
            this.labelArr1Length.Location = new System.Drawing.Point(14, 58);
            this.labelArr1Length.Name = "labelArr1Length";
            this.labelArr1Length.Size = new System.Drawing.Size(43, 13);
            this.labelArr1Length.TabIndex = 2;
            this.labelArr1Length.Text = "Длина:";
            // 
            // textBoxArr1Length
            // 
            this.textBoxArr1Length.Location = new System.Drawing.Point(62, 55);
            this.textBoxArr1Length.Name = "textBoxArr1Length";
            this.textBoxArr1Length.Size = new System.Drawing.Size(149, 20);
            this.textBoxArr1Length.TabIndex = 3;
            this.textBoxArr1Length.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxArr1Length_KeyDown);
            // 
            // comboBoxArr1FuncChoice
            // 
            this.comboBoxArr1FuncChoice.FormattingEnabled = true;
            this.comboBoxArr1FuncChoice.Location = new System.Drawing.Point(237, 25);
            this.comboBoxArr1FuncChoice.Name = "comboBoxArr1FuncChoice";
            this.comboBoxArr1FuncChoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxArr1FuncChoice.Size = new System.Drawing.Size(230, 21);
            this.comboBoxArr1FuncChoice.TabIndex = 4;
            this.comboBoxArr1FuncChoice.Text = "Выбор действия";
            this.comboBoxArr1FuncChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxArr1FuncChoice_SelectedIndexChanged);
            // 
            // labelArr1SumResult
            // 
            this.labelArr1SumResult.AutoSize = true;
            this.labelArr1SumResult.Location = new System.Drawing.Point(234, 58);
            this.labelArr1SumResult.Name = "labelArr1SumResult";
            this.labelArr1SumResult.Size = new System.Drawing.Size(128, 13);
            this.labelArr1SumResult.TabIndex = 5;
            this.labelArr1SumResult.Text = "Сумма всех элементов:";
            // 
            // textBoxArr1SumResult
            // 
            this.textBoxArr1SumResult.Location = new System.Drawing.Point(368, 55);
            this.textBoxArr1SumResult.Name = "textBoxArr1SumResult";
            this.textBoxArr1SumResult.Size = new System.Drawing.Size(99, 20);
            this.textBoxArr1SumResult.TabIndex = 6;
            // 
            // dataGridViewArr2
            // 
            this.dataGridViewArr2.AllowUserToAddRows = false;
            this.dataGridViewArr2.AllowUserToDeleteRows = false;
            this.dataGridViewArr2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewArr2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewArr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArr2.Location = new System.Drawing.Point(510, 198);
            this.dataGridViewArr2.Name = "dataGridViewArr2";
            this.dataGridViewArr2.Size = new System.Drawing.Size(460, 60);
            this.dataGridViewArr2.TabIndex = 15;
            this.dataGridViewArr2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArr_CellEndEdit);
            // 
            // textBoxArr2SumResult
            // 
            this.textBoxArr2SumResult.Location = new System.Drawing.Point(368, 225);
            this.textBoxArr2SumResult.Name = "textBoxArr2SumResult";
            this.textBoxArr2SumResult.Size = new System.Drawing.Size(99, 20);
            this.textBoxArr2SumResult.TabIndex = 14;
            // 
            // labelArr2SumResult
            // 
            this.labelArr2SumResult.AutoSize = true;
            this.labelArr2SumResult.Location = new System.Drawing.Point(234, 228);
            this.labelArr2SumResult.Name = "labelArr2SumResult";
            this.labelArr2SumResult.Size = new System.Drawing.Size(128, 13);
            this.labelArr2SumResult.TabIndex = 13;
            this.labelArr2SumResult.Text = "Сумма всех элементов:";
            // 
            // comboBoxArr2FuncChoice
            // 
            this.comboBoxArr2FuncChoice.FormattingEnabled = true;
            this.comboBoxArr2FuncChoice.Location = new System.Drawing.Point(237, 198);
            this.comboBoxArr2FuncChoice.Name = "comboBoxArr2FuncChoice";
            this.comboBoxArr2FuncChoice.Size = new System.Drawing.Size(230, 21);
            this.comboBoxArr2FuncChoice.TabIndex = 12;
            this.comboBoxArr2FuncChoice.Text = "Выбор действия";
            this.comboBoxArr2FuncChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxArr2FuncChoice_SelectedIndexChanged);
            // 
            // textBoxArr2Length
            // 
            this.textBoxArr2Length.Location = new System.Drawing.Point(62, 225);
            this.textBoxArr2Length.Name = "textBoxArr2Length";
            this.textBoxArr2Length.Size = new System.Drawing.Size(149, 20);
            this.textBoxArr2Length.TabIndex = 11;
            this.textBoxArr2Length.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxArr2Length_KeyDown);
            // 
            // labelArr2Length
            // 
            this.labelArr2Length.AutoSize = true;
            this.labelArr2Length.Location = new System.Drawing.Point(13, 228);
            this.labelArr2Length.Name = "labelArr2Length";
            this.labelArr2Length.Size = new System.Drawing.Size(43, 13);
            this.labelArr2Length.TabIndex = 10;
            this.labelArr2Length.Text = "Длина:";
            // 
            // comboBoxArr2
            // 
            this.comboBoxArr2.FormattingEnabled = true;
            this.comboBoxArr2.Location = new System.Drawing.Point(15, 198);
            this.comboBoxArr2.Name = "comboBoxArr2";
            this.comboBoxArr2.Size = new System.Drawing.Size(196, 21);
            this.comboBoxArr2.TabIndex = 9;
            this.comboBoxArr2.Text = "Способ получения";
            this.comboBoxArr2.SelectedIndexChanged += new System.EventHandler(this.comboBoxArr2_SelectedIndexChanged);
            // 
            // labelArr2
            // 
            this.labelArr2.AutoSize = true;
            this.labelArr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArr2.Location = new System.Drawing.Point(13, 178);
            this.labelArr2.Name = "labelArr2";
            this.labelArr2.Size = new System.Drawing.Size(72, 17);
            this.labelArr2.TabIndex = 8;
            this.labelArr2.Text = "Массив 2:";
            // 
            // labelArr3
            // 
            this.labelArr3.AutoSize = true;
            this.labelArr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArr3.Location = new System.Drawing.Point(507, 379);
            this.labelArr3.Name = "labelArr3";
            this.labelArr3.Size = new System.Drawing.Size(198, 17);
            this.labelArr3.TabIndex = 16;
            this.labelArr3.Text = "Массив 3 (результирующий):";
            // 
            // dataGridViewArr3
            // 
            this.dataGridViewArr3.AllowUserToAddRows = false;
            this.dataGridViewArr3.AllowUserToDeleteRows = false;
            this.dataGridViewArr3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewArr3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewArr3.Location = new System.Drawing.Point(510, 399);
            this.dataGridViewArr3.Name = "dataGridViewArr3";
            this.dataGridViewArr3.Size = new System.Drawing.Size(460, 60);
            this.dataGridViewArr3.TabIndex = 17;
            // 
            // dataGridViewArr1
            // 
            this.dataGridViewArr1.AllowUserToAddRows = false;
            this.dataGridViewArr1.AllowUserToDeleteRows = false;
            this.dataGridViewArr1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewArr1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewArr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArr1.Location = new System.Drawing.Point(510, 25);
            this.dataGridViewArr1.Name = "dataGridViewArr1";
            this.dataGridViewArr1.Size = new System.Drawing.Size(460, 60);
            this.dataGridViewArr1.TabIndex = 18;
            this.dataGridViewArr1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArr_CellEndEdit);
            // 
            // textBoxArr1downBorder
            // 
            this.textBoxArr1downBorder.Location = new System.Drawing.Point(17, 100);
            this.textBoxArr1downBorder.Name = "textBoxArr1downBorder";
            this.textBoxArr1downBorder.Size = new System.Drawing.Size(196, 20);
            this.textBoxArr1downBorder.TabIndex = 20;
            this.textBoxArr1downBorder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxArr1downBorder_KeyDown);
            // 
            // textBoxArr1upBorder
            // 
            this.textBoxArr1upBorder.Location = new System.Drawing.Point(237, 100);
            this.textBoxArr1upBorder.Name = "textBoxArr1upBorder";
            this.textBoxArr1upBorder.Size = new System.Drawing.Size(230, 20);
            this.textBoxArr1upBorder.TabIndex = 21;
            this.textBoxArr1upBorder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxArr1upBorder_KeyDown);
            // 
            // labelArr1downBorder
            // 
            this.labelArr1downBorder.AutoSize = true;
            this.labelArr1downBorder.Location = new System.Drawing.Point(14, 84);
            this.labelArr1downBorder.Name = "labelArr1downBorder";
            this.labelArr1downBorder.Size = new System.Drawing.Size(197, 13);
            this.labelArr1downBorder.TabIndex = 22;
            this.labelArr1downBorder.Text = "Нижняя граница случайных значений";
            // 
            // labelArr1upBorder
            // 
            this.labelArr1upBorder.AutoSize = true;
            this.labelArr1upBorder.Location = new System.Drawing.Point(234, 84);
            this.labelArr1upBorder.Name = "labelArr1upBorder";
            this.labelArr1upBorder.Size = new System.Drawing.Size(199, 13);
            this.labelArr1upBorder.TabIndex = 23;
            this.labelArr1upBorder.Text = "Верхняя граница случайных значений";
            // 
            // buttonArr1Create
            // 
            this.buttonArr1Create.Location = new System.Drawing.Point(510, 100);
            this.buttonArr1Create.Name = "buttonArr1Create";
            this.buttonArr1Create.Size = new System.Drawing.Size(217, 20);
            this.buttonArr1Create.TabIndex = 24;
            this.buttonArr1Create.Text = "Получить массив";
            this.buttonArr1Create.UseVisualStyleBackColor = true;
            this.buttonArr1Create.Click += new System.EventHandler(this.buttonArr1Create_Click);
            // 
            // buttonArr1Action
            // 
            this.buttonArr1Action.Location = new System.Drawing.Point(753, 100);
            this.buttonArr1Action.Name = "buttonArr1Action";
            this.buttonArr1Action.Size = new System.Drawing.Size(217, 20);
            this.buttonArr1Action.TabIndex = 25;
            this.buttonArr1Action.Text = "Совершить действие с массивом";
            this.buttonArr1Action.UseVisualStyleBackColor = true;
            this.buttonArr1Action.Click += new System.EventHandler(this.buttonArr1Action_Click);
            // 
            // labelArr1Scalar
            // 
            this.labelArr1Scalar.AutoSize = true;
            this.labelArr1Scalar.Location = new System.Drawing.Point(507, 144);
            this.labelArr1Scalar.Name = "labelArr1Scalar";
            this.labelArr1Scalar.Size = new System.Drawing.Size(147, 13);
            this.labelArr1Scalar.TabIndex = 26;
            this.labelArr1Scalar.Text = "Введите значение скаляра:";
            // 
            // textBoxArr1Scalar
            // 
            this.textBoxArr1Scalar.Location = new System.Drawing.Point(660, 141);
            this.textBoxArr1Scalar.Name = "textBoxArr1Scalar";
            this.textBoxArr1Scalar.Size = new System.Drawing.Size(310, 20);
            this.textBoxArr1Scalar.TabIndex = 27;
            this.textBoxArr1Scalar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxArr1Scalar_KeyDown);
            // 
            // labelArr1MultiplesAmount
            // 
            this.labelArr1MultiplesAmount.AutoSize = true;
            this.labelArr1MultiplesAmount.Location = new System.Drawing.Point(234, 123);
            this.labelArr1MultiplesAmount.Name = "labelArr1MultiplesAmount";
            this.labelArr1MultiplesAmount.Size = new System.Drawing.Size(201, 13);
            this.labelArr1MultiplesAmount.TabIndex = 28;
            this.labelArr1MultiplesAmount.Text = "Количество чисел кратных заданному";
            // 
            // labelArr1NumForMultiplesAmountSearch
            // 
            this.labelArr1NumForMultiplesAmountSearch.AutoSize = true;
            this.labelArr1NumForMultiplesAmountSearch.Location = new System.Drawing.Point(14, 123);
            this.labelArr1NumForMultiplesAmountSearch.Name = "labelArr1NumForMultiplesAmountSearch";
            this.labelArr1NumForMultiplesAmountSearch.Size = new System.Drawing.Size(194, 13);
            this.labelArr1NumForMultiplesAmountSearch.TabIndex = 29;
            this.labelArr1NumForMultiplesAmountSearch.Text = "Число для поиска кратных значений";
            // 
            // textBoxArr1NumForMultiplesAmountSearch
            // 
            this.textBoxArr1NumForMultiplesAmountSearch.Location = new System.Drawing.Point(17, 141);
            this.textBoxArr1NumForMultiplesAmountSearch.Name = "textBoxArr1NumForMultiplesAmountSearch";
            this.textBoxArr1NumForMultiplesAmountSearch.Size = new System.Drawing.Size(196, 20);
            this.textBoxArr1NumForMultiplesAmountSearch.TabIndex = 30;
            this.textBoxArr1NumForMultiplesAmountSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxArr1NumForMultiplesAmountSearch_KeyDown);
            // 
            // textBoxArr1MultiplesAmount
            // 
            this.textBoxArr1MultiplesAmount.Location = new System.Drawing.Point(237, 141);
            this.textBoxArr1MultiplesAmount.Name = "textBoxArr1MultiplesAmount";
            this.textBoxArr1MultiplesAmount.Size = new System.Drawing.Size(230, 20);
            this.textBoxArr1MultiplesAmount.TabIndex = 31;
            // 
            // textBoxArr2MultiplesAmount
            // 
            this.textBoxArr2MultiplesAmount.Location = new System.Drawing.Point(237, 315);
            this.textBoxArr2MultiplesAmount.Name = "textBoxArr2MultiplesAmount";
            this.textBoxArr2MultiplesAmount.Size = new System.Drawing.Size(230, 20);
            this.textBoxArr2MultiplesAmount.TabIndex = 43;
            // 
            // textBoxArr2NumForMultiplesAmountSearch
            // 
            this.textBoxArr2NumForMultiplesAmountSearch.Location = new System.Drawing.Point(17, 315);
            this.textBoxArr2NumForMultiplesAmountSearch.Name = "textBoxArr2NumForMultiplesAmountSearch";
            this.textBoxArr2NumForMultiplesAmountSearch.Size = new System.Drawing.Size(196, 20);
            this.textBoxArr2NumForMultiplesAmountSearch.TabIndex = 42;
            this.textBoxArr2NumForMultiplesAmountSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxArr2NumForMultiplesAmountSearch_KeyDown);
            // 
            // labelArr2NumForMultiplesAmountSearch
            // 
            this.labelArr2NumForMultiplesAmountSearch.AutoSize = true;
            this.labelArr2NumForMultiplesAmountSearch.Location = new System.Drawing.Point(14, 297);
            this.labelArr2NumForMultiplesAmountSearch.Name = "labelArr2NumForMultiplesAmountSearch";
            this.labelArr2NumForMultiplesAmountSearch.Size = new System.Drawing.Size(194, 13);
            this.labelArr2NumForMultiplesAmountSearch.TabIndex = 41;
            this.labelArr2NumForMultiplesAmountSearch.Text = "Число для поиска кратных значений";
            // 
            // labelArr2MultiplesAmount
            // 
            this.labelArr2MultiplesAmount.AutoSize = true;
            this.labelArr2MultiplesAmount.Location = new System.Drawing.Point(234, 297);
            this.labelArr2MultiplesAmount.Name = "labelArr2MultiplesAmount";
            this.labelArr2MultiplesAmount.Size = new System.Drawing.Size(201, 13);
            this.labelArr2MultiplesAmount.TabIndex = 40;
            this.labelArr2MultiplesAmount.Text = "Количество чисел кратных заданному";
            // 
            // textBoxArr2Scalar
            // 
            this.textBoxArr2Scalar.Location = new System.Drawing.Point(660, 315);
            this.textBoxArr2Scalar.Name = "textBoxArr2Scalar";
            this.textBoxArr2Scalar.Size = new System.Drawing.Size(310, 20);
            this.textBoxArr2Scalar.TabIndex = 39;
            this.textBoxArr2Scalar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxArr2Scalar_KeyDown);
            // 
            // labelArr2Scalar
            // 
            this.labelArr2Scalar.AutoSize = true;
            this.labelArr2Scalar.Location = new System.Drawing.Point(507, 318);
            this.labelArr2Scalar.Name = "labelArr2Scalar";
            this.labelArr2Scalar.Size = new System.Drawing.Size(147, 13);
            this.labelArr2Scalar.TabIndex = 38;
            this.labelArr2Scalar.Text = "Введите значение скаляра:";
            // 
            // buttonArr2Action
            // 
            this.buttonArr2Action.Location = new System.Drawing.Point(753, 274);
            this.buttonArr2Action.Name = "buttonArr2Action";
            this.buttonArr2Action.Size = new System.Drawing.Size(217, 20);
            this.buttonArr2Action.TabIndex = 37;
            this.buttonArr2Action.Text = "Совершить действие с массивом";
            this.buttonArr2Action.UseVisualStyleBackColor = true;
            this.buttonArr2Action.Click += new System.EventHandler(this.buttonArr2Action_Click);
            // 
            // buttonArr2Create
            // 
            this.buttonArr2Create.Location = new System.Drawing.Point(510, 274);
            this.buttonArr2Create.Name = "buttonArr2Create";
            this.buttonArr2Create.Size = new System.Drawing.Size(217, 20);
            this.buttonArr2Create.TabIndex = 36;
            this.buttonArr2Create.Text = "Получить массив";
            this.buttonArr2Create.UseVisualStyleBackColor = true;
            this.buttonArr2Create.Click += new System.EventHandler(this.buttonArr2Create_Click);
            // 
            // labelArr2upBorder
            // 
            this.labelArr2upBorder.AutoSize = true;
            this.labelArr2upBorder.Location = new System.Drawing.Point(234, 258);
            this.labelArr2upBorder.Name = "labelArr2upBorder";
            this.labelArr2upBorder.Size = new System.Drawing.Size(199, 13);
            this.labelArr2upBorder.TabIndex = 35;
            this.labelArr2upBorder.Text = "Верхняя граница случайных значений";
            // 
            // labelArr2downBorder
            // 
            this.labelArr2downBorder.AutoSize = true;
            this.labelArr2downBorder.Location = new System.Drawing.Point(14, 258);
            this.labelArr2downBorder.Name = "labelArr2downBorder";
            this.labelArr2downBorder.Size = new System.Drawing.Size(197, 13);
            this.labelArr2downBorder.TabIndex = 34;
            this.labelArr2downBorder.Text = "Нижняя граница случайных значений";
            // 
            // textBoxArr2upBorder
            // 
            this.textBoxArr2upBorder.Location = new System.Drawing.Point(237, 274);
            this.textBoxArr2upBorder.Name = "textBoxArr2upBorder";
            this.textBoxArr2upBorder.Size = new System.Drawing.Size(230, 20);
            this.textBoxArr2upBorder.TabIndex = 33;
            this.textBoxArr2upBorder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxArr2upBorder_KeyDown);
            // 
            // textBoxArr2downBorder
            // 
            this.textBoxArr2downBorder.Location = new System.Drawing.Point(17, 274);
            this.textBoxArr2downBorder.Name = "textBoxArr2downBorder";
            this.textBoxArr2downBorder.Size = new System.Drawing.Size(196, 20);
            this.textBoxArr2downBorder.TabIndex = 32;
            this.textBoxArr2downBorder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxArr2downBorder_KeyDown);
            // 
            // buttonSumArrays
            // 
            this.buttonSumArrays.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSumArrays.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSumArrays.Location = new System.Drawing.Point(12, 399);
            this.buttonSumArrays.Name = "buttonSumArrays";
            this.buttonSumArrays.Size = new System.Drawing.Size(217, 60);
            this.buttonSumArrays.TabIndex = 44;
            this.buttonSumArrays.Text = "Сложить массивы";
            this.buttonSumArrays.UseVisualStyleBackColor = false;
            this.buttonSumArrays.Click += new System.EventHandler(this.buttonSumArrays_Click);
            // 
            // buttonArr1minus2
            // 
            this.buttonArr1minus2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonArr1minus2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonArr1minus2.Location = new System.Drawing.Point(250, 399);
            this.buttonArr1minus2.Name = "buttonArr1minus2";
            this.buttonArr1minus2.Size = new System.Drawing.Size(217, 30);
            this.buttonArr1minus2.TabIndex = 45;
            this.buttonArr1minus2.Text = "Вычесть из первого массива второй";
            this.buttonArr1minus2.UseVisualStyleBackColor = false;
            this.buttonArr1minus2.Click += new System.EventHandler(this.buttonArr1minus2_Click);
            // 
            // buttonArr2minus1
            // 
            this.buttonArr2minus1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonArr2minus1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonArr2minus1.Location = new System.Drawing.Point(250, 429);
            this.buttonArr2minus1.Name = "buttonArr2minus1";
            this.buttonArr2minus1.Size = new System.Drawing.Size(217, 30);
            this.buttonArr2minus1.TabIndex = 46;
            this.buttonArr2minus1.Text = "Вычесть из второго массива первый";
            this.buttonArr2minus1.UseVisualStyleBackColor = false;
            this.buttonArr2minus1.Click += new System.EventHandler(this.buttonArr2minus1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 509);
            this.Controls.Add(this.buttonArr2minus1);
            this.Controls.Add(this.buttonArr1minus2);
            this.Controls.Add(this.buttonSumArrays);
            this.Controls.Add(this.textBoxArr2MultiplesAmount);
            this.Controls.Add(this.textBoxArr2NumForMultiplesAmountSearch);
            this.Controls.Add(this.labelArr2NumForMultiplesAmountSearch);
            this.Controls.Add(this.labelArr2MultiplesAmount);
            this.Controls.Add(this.textBoxArr2Scalar);
            this.Controls.Add(this.labelArr2Scalar);
            this.Controls.Add(this.buttonArr2Action);
            this.Controls.Add(this.buttonArr2Create);
            this.Controls.Add(this.labelArr2upBorder);
            this.Controls.Add(this.labelArr2downBorder);
            this.Controls.Add(this.textBoxArr2upBorder);
            this.Controls.Add(this.textBoxArr2downBorder);
            this.Controls.Add(this.textBoxArr1MultiplesAmount);
            this.Controls.Add(this.textBoxArr1NumForMultiplesAmountSearch);
            this.Controls.Add(this.labelArr1NumForMultiplesAmountSearch);
            this.Controls.Add(this.labelArr1MultiplesAmount);
            this.Controls.Add(this.textBoxArr1Scalar);
            this.Controls.Add(this.labelArr1Scalar);
            this.Controls.Add(this.buttonArr1Action);
            this.Controls.Add(this.buttonArr1Create);
            this.Controls.Add(this.labelArr1upBorder);
            this.Controls.Add(this.labelArr1downBorder);
            this.Controls.Add(this.textBoxArr1upBorder);
            this.Controls.Add(this.textBoxArr1downBorder);
            this.Controls.Add(this.dataGridViewArr1);
            this.Controls.Add(this.dataGridViewArr3);
            this.Controls.Add(this.labelArr3);
            this.Controls.Add(this.dataGridViewArr2);
            this.Controls.Add(this.textBoxArr2SumResult);
            this.Controls.Add(this.labelArr2SumResult);
            this.Controls.Add(this.comboBoxArr2FuncChoice);
            this.Controls.Add(this.textBoxArr2Length);
            this.Controls.Add(this.labelArr2Length);
            this.Controls.Add(this.comboBoxArr2);
            this.Controls.Add(this.labelArr2);
            this.Controls.Add(this.textBoxArr1SumResult);
            this.Controls.Add(this.labelArr1SumResult);
            this.Controls.Add(this.comboBoxArr1FuncChoice);
            this.Controls.Add(this.textBoxArr1Length);
            this.Controls.Add(this.labelArr1Length);
            this.Controls.Add(this.comboBoxArr1);
            this.Controls.Add(this.labelArr1);
            this.Name = "Form1";
            this.Text = "FormForIntArrayLibrary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelArr1;
        private System.Windows.Forms.ComboBox comboBoxArr1;
        private System.Windows.Forms.Label labelArr1Length;
        private System.Windows.Forms.TextBox textBoxArr1Length;
        private System.Windows.Forms.ComboBox comboBoxArr1FuncChoice;
        private System.Windows.Forms.Label labelArr1SumResult;
        private System.Windows.Forms.TextBox textBoxArr1SumResult;
        private System.Windows.Forms.DataGridView dataGridViewArr2;
        private System.Windows.Forms.TextBox textBoxArr2SumResult;
        private System.Windows.Forms.Label labelArr2SumResult;
        private System.Windows.Forms.ComboBox comboBoxArr2FuncChoice;
        private System.Windows.Forms.TextBox textBoxArr2Length;
        private System.Windows.Forms.Label labelArr2Length;
        private System.Windows.Forms.ComboBox comboBoxArr2;
        private System.Windows.Forms.Label labelArr2;
        private System.Windows.Forms.Label labelArr3;
        private System.Windows.Forms.DataGridView dataGridViewArr3;
        private System.Windows.Forms.DataGridView dataGridViewArr1;
        private System.Windows.Forms.TextBox textBoxArr1downBorder;
        private System.Windows.Forms.TextBox textBoxArr1upBorder;
        private System.Windows.Forms.Label labelArr1downBorder;
        private System.Windows.Forms.Label labelArr1upBorder;
        private System.Windows.Forms.Button buttonArr1Create;
        private System.Windows.Forms.Button buttonArr1Action;
        private System.Windows.Forms.Label labelArr1Scalar;
        private System.Windows.Forms.TextBox textBoxArr1Scalar;
        private System.Windows.Forms.Label labelArr1MultiplesAmount;
        private System.Windows.Forms.Label labelArr1NumForMultiplesAmountSearch;
        private System.Windows.Forms.TextBox textBoxArr1NumForMultiplesAmountSearch;
        private System.Windows.Forms.TextBox textBoxArr1MultiplesAmount;
        private System.Windows.Forms.TextBox textBoxArr2MultiplesAmount;
        private System.Windows.Forms.TextBox textBoxArr2NumForMultiplesAmountSearch;
        private System.Windows.Forms.Label labelArr2NumForMultiplesAmountSearch;
        private System.Windows.Forms.Label labelArr2MultiplesAmount;
        private System.Windows.Forms.TextBox textBoxArr2Scalar;
        private System.Windows.Forms.Label labelArr2Scalar;
        private System.Windows.Forms.Button buttonArr2Action;
        private System.Windows.Forms.Button buttonArr2Create;
        private System.Windows.Forms.Label labelArr2upBorder;
        private System.Windows.Forms.Label labelArr2downBorder;
        private System.Windows.Forms.TextBox textBoxArr2upBorder;
        private System.Windows.Forms.TextBox textBoxArr2downBorder;
        private System.Windows.Forms.Button buttonSumArrays;
        private System.Windows.Forms.Button buttonArr1minus2;
        private System.Windows.Forms.Button buttonArr2minus1;
    }
}

