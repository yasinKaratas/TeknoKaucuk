namespace QQ73841_EnginYasinKARATAS
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNumberToBeSummed1 = new System.Windows.Forms.TextBox();
            this.txtNumberToBeSummed2 = new System.Windows.Forms.TextBox();
            this.txtNumberToBeMultiplied = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabFunction1 = new System.Windows.Forms.TabPage();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblNumberToBeMultiplied = new System.Windows.Forms.Label();
            this.lblNumberToBeSummed2 = new System.Windows.Forms.Label();
            this.lblNumberToBeSummed1 = new System.Windows.Forms.Label();
            this.btnShowResult1 = new System.Windows.Forms.Button();
            this.tabFunction2 = new System.Windows.Forms.TabPage();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnShowResult2 = new System.Windows.Forms.Button();
            this.tabFunction3 = new System.Windows.Forms.TabPage();
            this.dgvMultiplicationTable = new System.Windows.Forms.DataGridView();
            this.btnShowResult3 = new System.Windows.Forms.Button();
            this.lblMaksimumCarpan = new System.Windows.Forms.Label();
            this.txtMaxMultiplier = new System.Windows.Forms.TextBox();
            this.tabFunction4 = new System.Windows.Forms.TabPage();
            this.btnShowResult4 = new System.Windows.Forms.Button();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.lstSortedNumbers = new System.Windows.Forms.ListBox();
            this.tabFunction5 = new System.Windows.Forms.TabPage();
            this.btnShowResult5 = new System.Windows.Forms.Button();
            this.lblFibonacciPosition = new System.Windows.Forms.Label();
            this.txtFibonacciPosition = new System.Windows.Forms.TextBox();
            this.txtFibonacciValue = new System.Windows.Forms.TextBox();
            this.lblFibonacciValue = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabFunction1.SuspendLayout();
            this.tabFunction2.SuspendLayout();
            this.tabFunction3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiplicationTable)).BeginInit();
            this.tabFunction4.SuspendLayout();
            this.tabFunction5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumberToBeSummed1
            // 
            this.txtNumberToBeSummed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumberToBeSummed1.Location = new System.Drawing.Point(585, 275);
            this.txtNumberToBeSummed1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberToBeSummed1.Name = "txtNumberToBeSummed1";
            this.txtNumberToBeSummed1.Size = new System.Drawing.Size(228, 30);
            this.txtNumberToBeSummed1.TabIndex = 1;
            this.txtNumberToBeSummed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumberToBeSummed1.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtNumberToBeSummed2
            // 
            this.txtNumberToBeSummed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumberToBeSummed2.Location = new System.Drawing.Point(585, 336);
            this.txtNumberToBeSummed2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberToBeSummed2.Name = "txtNumberToBeSummed2";
            this.txtNumberToBeSummed2.Size = new System.Drawing.Size(228, 30);
            this.txtNumberToBeSummed2.TabIndex = 2;
            this.txtNumberToBeSummed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumberToBeSummed2.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtNumberToBeMultiplied
            // 
            this.txtNumberToBeMultiplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumberToBeMultiplied.Location = new System.Drawing.Point(585, 397);
            this.txtNumberToBeMultiplied.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberToBeMultiplied.Name = "txtNumberToBeMultiplied";
            this.txtNumberToBeMultiplied.Size = new System.Drawing.Size(228, 30);
            this.txtNumberToBeMultiplied.TabIndex = 3;
            this.txtNumberToBeMultiplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumberToBeMultiplied.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResult.Location = new System.Drawing.Point(585, 527);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(228, 30);
            this.txtResult.TabIndex = 4;
            this.txtResult.TabStop = false;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabFunction1);
            this.tabControlMain.Controls.Add(this.tabFunction2);
            this.tabControlMain.Controls.Add(this.tabFunction3);
            this.tabControlMain.Controls.Add(this.tabFunction4);
            this.tabControlMain.Controls.Add(this.tabFunction5);
            this.tabControlMain.Location = new System.Drawing.Point(18, 19);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1206, 1009);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabFunction1
            // 
            this.tabFunction1.Controls.Add(this.lblResult);
            this.tabFunction1.Controls.Add(this.lblNumberToBeMultiplied);
            this.tabFunction1.Controls.Add(this.lblNumberToBeSummed2);
            this.tabFunction1.Controls.Add(this.lblNumberToBeSummed1);
            this.tabFunction1.Controls.Add(this.btnShowResult1);
            this.tabFunction1.Controls.Add(this.txtNumberToBeMultiplied);
            this.tabFunction1.Controls.Add(this.txtNumberToBeSummed1);
            this.tabFunction1.Controls.Add(this.txtResult);
            this.tabFunction1.Controls.Add(this.txtNumberToBeSummed2);
            this.tabFunction1.Location = new System.Drawing.Point(4, 34);
            this.tabFunction1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFunction1.Name = "tabFunction1";
            this.tabFunction1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFunction1.Size = new System.Drawing.Size(1198, 971);
            this.tabFunction1.TabIndex = 0;
            this.tabFunction1.Text = "İşlev-1";
            this.tabFunction1.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(246, 522);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(332, 41);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Sonuç :";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumberToBeMultiplied
            // 
            this.lblNumberToBeMultiplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumberToBeMultiplied.Location = new System.Drawing.Point(246, 392);
            this.lblNumberToBeMultiplied.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberToBeMultiplied.Name = "lblNumberToBeMultiplied";
            this.lblNumberToBeMultiplied.Size = new System.Drawing.Size(332, 41);
            this.lblNumberToBeMultiplied.TabIndex = 3;
            this.lblNumberToBeMultiplied.Text = "Çarpılacak Sayı :";
            this.lblNumberToBeMultiplied.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumberToBeSummed2
            // 
            this.lblNumberToBeSummed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumberToBeSummed2.Location = new System.Drawing.Point(246, 331);
            this.lblNumberToBeSummed2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberToBeSummed2.Name = "lblNumberToBeSummed2";
            this.lblNumberToBeSummed2.Size = new System.Drawing.Size(332, 41);
            this.lblNumberToBeSummed2.TabIndex = 3;
            this.lblNumberToBeSummed2.Text = "Toplanacak Sayı 2 :";
            this.lblNumberToBeSummed2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumberToBeSummed1
            // 
            this.lblNumberToBeSummed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumberToBeSummed1.Location = new System.Drawing.Point(246, 266);
            this.lblNumberToBeSummed1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberToBeSummed1.Name = "lblNumberToBeSummed1";
            this.lblNumberToBeSummed1.Size = new System.Drawing.Size(332, 52);
            this.lblNumberToBeSummed1.TabIndex = 3;
            this.lblNumberToBeSummed1.Text = "Toplanacak Sayı 1 :";
            this.lblNumberToBeSummed1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnShowResult1
            // 
            this.btnShowResult1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowResult1.Location = new System.Drawing.Point(1048, 903);
            this.btnShowResult1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowResult1.Name = "btnShowResult1";
            this.btnShowResult1.Size = new System.Drawing.Size(142, 58);
            this.btnShowResult1.TabIndex = 999;
            this.btnShowResult1.Text = "&SONUÇ";
            this.btnShowResult1.UseVisualStyleBackColor = true;
            this.btnShowResult1.Click += new System.EventHandler(this.btnShowResult1_Click);
            // 
            // tabFunction2
            // 
            this.tabFunction2.Controls.Add(this.lstResults);
            this.tabFunction2.Controls.Add(this.btnShowResult2);
            this.tabFunction2.Location = new System.Drawing.Point(4, 34);
            this.tabFunction2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFunction2.Name = "tabFunction2";
            this.tabFunction2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFunction2.Size = new System.Drawing.Size(1198, 971);
            this.tabFunction2.TabIndex = 1;
            this.tabFunction2.Text = "İşlev-2";
            this.tabFunction2.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 25;
            this.lstResults.Location = new System.Drawing.Point(10, 10);
            this.lstResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(1178, 879);
            this.lstResults.TabIndex = 1001;
            // 
            // btnShowResult2
            // 
            this.btnShowResult2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowResult2.Location = new System.Drawing.Point(1048, 903);
            this.btnShowResult2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowResult2.Name = "btnShowResult2";
            this.btnShowResult2.Size = new System.Drawing.Size(142, 58);
            this.btnShowResult2.TabIndex = 1000;
            this.btnShowResult2.Text = "&SONUÇ";
            this.btnShowResult2.UseVisualStyleBackColor = true;
            this.btnShowResult2.Click += new System.EventHandler(this.btnShowResult2_Click);
            // 
            // tabFunction3
            // 
            this.tabFunction3.Controls.Add(this.dgvMultiplicationTable);
            this.tabFunction3.Controls.Add(this.btnShowResult3);
            this.tabFunction3.Controls.Add(this.lblMaksimumCarpan);
            this.tabFunction3.Controls.Add(this.txtMaxMultiplier);
            this.tabFunction3.Location = new System.Drawing.Point(4, 34);
            this.tabFunction3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFunction3.Name = "tabFunction3";
            this.tabFunction3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFunction3.Size = new System.Drawing.Size(1198, 971);
            this.tabFunction3.TabIndex = 2;
            this.tabFunction3.Text = "İşlev-3";
            this.tabFunction3.UseVisualStyleBackColor = true;
            // 
            // dgvMultiplicationTable
            // 
            this.dgvMultiplicationTable.AllowUserToAddRows = false;
            this.dgvMultiplicationTable.AllowUserToDeleteRows = false;
            this.dgvMultiplicationTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMultiplicationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMultiplicationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultiplicationTable.ColumnHeadersVisible = false;
            this.dgvMultiplicationTable.Location = new System.Drawing.Point(9, 73);
            this.dgvMultiplicationTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMultiplicationTable.Name = "dgvMultiplicationTable";
            this.dgvMultiplicationTable.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMultiplicationTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMultiplicationTable.RowHeadersVisible = false;
            this.dgvMultiplicationTable.RowHeadersWidth = 51;
            this.dgvMultiplicationTable.RowTemplate.Height = 24;
            this.dgvMultiplicationTable.Size = new System.Drawing.Size(1179, 805);
            this.dgvMultiplicationTable.TabIndex = 1002;
            // 
            // btnShowResult3
            // 
            this.btnShowResult3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowResult3.Location = new System.Drawing.Point(1048, 903);
            this.btnShowResult3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowResult3.Name = "btnShowResult3";
            this.btnShowResult3.Size = new System.Drawing.Size(142, 58);
            this.btnShowResult3.TabIndex = 1001;
            this.btnShowResult3.Text = "&SONUÇ";
            this.btnShowResult3.UseVisualStyleBackColor = true;
            this.btnShowResult3.Click += new System.EventHandler(this.btnShowResult3_Click);
            // 
            // lblMaksimumCarpan
            // 
            this.lblMaksimumCarpan.Location = new System.Drawing.Point(4, 24);
            this.lblMaksimumCarpan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaksimumCarpan.Name = "lblMaksimumCarpan";
            this.lblMaksimumCarpan.Size = new System.Drawing.Size(212, 36);
            this.lblMaksimumCarpan.TabIndex = 5;
            this.lblMaksimumCarpan.Text = "Maksimum Çarpan :";
            this.lblMaksimumCarpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaxMultiplier
            // 
            this.txtMaxMultiplier.Location = new System.Drawing.Point(224, 27);
            this.txtMaxMultiplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxMultiplier.Name = "txtMaxMultiplier";
            this.txtMaxMultiplier.Size = new System.Drawing.Size(78, 30);
            this.txtMaxMultiplier.TabIndex = 4;
            this.txtMaxMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxMultiplier.TextChanged += new System.EventHandler(this.txtMaxMultiplier_TextChanged);
            // 
            // tabFunction4
            // 
            this.tabFunction4.Controls.Add(this.lstSortedNumbers);
            this.tabFunction4.Controls.Add(this.btnShowResult4);
            this.tabFunction4.Location = new System.Drawing.Point(4, 34);
            this.tabFunction4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFunction4.Name = "tabFunction4";
            this.tabFunction4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFunction4.Size = new System.Drawing.Size(1198, 971);
            this.tabFunction4.TabIndex = 3;
            this.tabFunction4.Text = "İşlev-4";
            this.tabFunction4.UseVisualStyleBackColor = true;
            // 
            // btnShowResult4
            // 
            this.btnShowResult4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowResult4.Location = new System.Drawing.Point(1048, 903);
            this.btnShowResult4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowResult4.Name = "btnShowResult4";
            this.btnShowResult4.Size = new System.Drawing.Size(142, 58);
            this.btnShowResult4.TabIndex = 1002;
            this.btnShowResult4.Text = "&SONUÇ";
            this.btnShowResult4.UseVisualStyleBackColor = true;
            this.btnShowResult4.Click += new System.EventHandler(this.btnShowResult4_Click);
            // 
            // ofdMain
            // 
            this.ofdMain.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            this.ofdMain.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments";
            this.ofdMain.RestoreDirectory = true;
            this.ofdMain.SupportMultiDottedExtensions = true;
            this.ofdMain.Title = "Lütfen bir metin dosyası seçin.";
            // 
            // lstSortedNumbers
            // 
            this.lstSortedNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSortedNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSortedNumbers.FormattingEnabled = true;
            this.lstSortedNumbers.ItemHeight = 25;
            this.lstSortedNumbers.Location = new System.Drawing.Point(10, 10);
            this.lstSortedNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstSortedNumbers.Name = "lstSortedNumbers";
            this.lstSortedNumbers.Size = new System.Drawing.Size(1178, 879);
            this.lstSortedNumbers.TabIndex = 1003;
            // 
            // tabFunction5
            // 
            this.tabFunction5.Controls.Add(this.btnShowResult5);
            this.tabFunction5.Controls.Add(this.lblFibonacciValue);
            this.tabFunction5.Controls.Add(this.lblFibonacciPosition);
            this.tabFunction5.Controls.Add(this.txtFibonacciValue);
            this.tabFunction5.Controls.Add(this.txtFibonacciPosition);
            this.tabFunction5.Location = new System.Drawing.Point(4, 34);
            this.tabFunction5.Name = "tabFunction5";
            this.tabFunction5.Padding = new System.Windows.Forms.Padding(3);
            this.tabFunction5.Size = new System.Drawing.Size(1198, 971);
            this.tabFunction5.TabIndex = 4;
            this.tabFunction5.Text = "İşlev-5";
            this.tabFunction5.UseVisualStyleBackColor = true;
            // 
            // btnShowResult5
            // 
            this.btnShowResult5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowResult5.Location = new System.Drawing.Point(1048, 903);
            this.btnShowResult5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowResult5.Name = "btnShowResult5";
            this.btnShowResult5.Size = new System.Drawing.Size(142, 58);
            this.btnShowResult5.TabIndex = 1004;
            this.btnShowResult5.Text = "&SONUÇ";
            this.btnShowResult5.UseVisualStyleBackColor = true;
            this.btnShowResult5.Click += new System.EventHandler(this.btnShowResult5_Click);
            // 
            // lblFibonacciPosition
            // 
            this.lblFibonacciPosition.Location = new System.Drawing.Point(4, 24);
            this.lblFibonacciPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFibonacciPosition.Name = "lblFibonacciPosition";
            this.lblFibonacciPosition.Size = new System.Drawing.Size(212, 36);
            this.lblFibonacciPosition.TabIndex = 1003;
            this.lblFibonacciPosition.Text = "Fibonacci Sırası :";
            this.lblFibonacciPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFibonacciPosition
            // 
            this.txtFibonacciPosition.Location = new System.Drawing.Point(224, 27);
            this.txtFibonacciPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFibonacciPosition.Name = "txtFibonacciPosition";
            this.txtFibonacciPosition.Size = new System.Drawing.Size(117, 30);
            this.txtFibonacciPosition.TabIndex = 1002;
            this.txtFibonacciPosition.Text = "1";
            this.txtFibonacciPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFibonacciPosition.TextChanged += new System.EventHandler(this.txtFibonacciPosition_TextChanged);
            // 
            // txtFibonacciValue
            // 
            this.txtFibonacciValue.Location = new System.Drawing.Point(224, 67);
            this.txtFibonacciValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFibonacciValue.Name = "txtFibonacciValue";
            this.txtFibonacciValue.ReadOnly = true;
            this.txtFibonacciValue.Size = new System.Drawing.Size(117, 30);
            this.txtFibonacciValue.TabIndex = 1002;
            this.txtFibonacciValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFibonacciValue.TextChanged += new System.EventHandler(this.txtFibonacciPosition_TextChanged);
            // 
            // lblFibonacciValue
            // 
            this.lblFibonacciValue.Location = new System.Drawing.Point(4, 64);
            this.lblFibonacciValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFibonacciValue.Name = "lblFibonacciValue";
            this.lblFibonacciValue.Size = new System.Drawing.Size(212, 36);
            this.lblFibonacciValue.TabIndex = 1003;
            this.lblFibonacciValue.Text = "Fibonacci Sayısı :";
            this.lblFibonacciValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 1047);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QQ73841 Engin Yasin KARATAŞ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabFunction1.ResumeLayout(false);
            this.tabFunction1.PerformLayout();
            this.tabFunction2.ResumeLayout(false);
            this.tabFunction3.ResumeLayout(false);
            this.tabFunction3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiplicationTable)).EndInit();
            this.tabFunction4.ResumeLayout(false);
            this.tabFunction5.ResumeLayout(false);
            this.tabFunction5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumberToBeSummed1;
        private System.Windows.Forms.TextBox txtNumberToBeSummed2;
        private System.Windows.Forms.TextBox txtNumberToBeMultiplied;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabFunction1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblNumberToBeMultiplied;
        private System.Windows.Forms.Label lblNumberToBeSummed2;
        private System.Windows.Forms.Label lblNumberToBeSummed1;
        private System.Windows.Forms.Button btnShowResult1;
        private System.Windows.Forms.TabPage tabFunction2;
        private System.Windows.Forms.Button btnShowResult2;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.TabPage tabFunction3;
        private System.Windows.Forms.Label lblMaksimumCarpan;
        private System.Windows.Forms.TextBox txtMaxMultiplier;
        private System.Windows.Forms.Button btnShowResult3;
        private System.Windows.Forms.DataGridView dgvMultiplicationTable;
        private System.Windows.Forms.TabPage tabFunction4;
        private System.Windows.Forms.Button btnShowResult4;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.ListBox lstSortedNumbers;
        private System.Windows.Forms.TabPage tabFunction5;
        private System.Windows.Forms.Button btnShowResult5;
        private System.Windows.Forms.Label lblFibonacciPosition;
        private System.Windows.Forms.TextBox txtFibonacciPosition;
        private System.Windows.Forms.Label lblFibonacciValue;
        private System.Windows.Forms.TextBox txtFibonacciValue;
    }
}

