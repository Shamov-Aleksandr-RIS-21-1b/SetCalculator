namespace SetCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSaveSet = new System.Windows.Forms.Button();
            this.labelUniversuum = new System.Windows.Forms.Label();
            this.buttonApplyUniversuum = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxSet = new System.Windows.Forms.ComboBox();
            this.buttonResetSet = new System.Windows.Forms.Button();
            this.textBoxUniversuum = new System.Windows.Forms.TextBox();
            this.textBoxSet = new System.Windows.Forms.TextBox();
            this.labelSet = new System.Windows.Forms.Label();
            this.buttonDeleteSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BelongInt = new System.Windows.Forms.TextBox();
            this.labelInclusion = new System.Windows.Forms.Label();
            this.InclusionSet2 = new System.Windows.Forms.ComboBox();
            this.InclusionSet1 = new System.Windows.Forms.ComboBox();
            this.BelongSet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InclusionResult = new System.Windows.Forms.TextBox();
            this.BelongsResult = new System.Windows.Forms.TextBox();
            this.UnionResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UnionSet1 = new System.Windows.Forms.ComboBox();
            this.UnionSet2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AdditionSet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AdditionResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CrossSet2 = new System.Windows.Forms.ComboBox();
            this.CrossSet1 = new System.Windows.Forms.ComboBox();
            this.CrossResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DiffSet2 = new System.Windows.Forms.ComboBox();
            this.DiffSet1 = new System.Windows.Forms.ComboBox();
            this.DiffResult = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SymmDiffSet2 = new System.Windows.Forms.ComboBox();
            this.SymmDiffSet1 = new System.Windows.Forms.ComboBox();
            this.SymmDiffResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonRandomInit = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveSet
            // 
            this.buttonSaveSet.Enabled = false;
            this.buttonSaveSet.Location = new System.Drawing.Point(174, 225);
            this.buttonSaveSet.Name = "buttonSaveSet";
            this.buttonSaveSet.Size = new System.Drawing.Size(110, 38);
            this.buttonSaveSet.TabIndex = 6;
            this.buttonSaveSet.Text = "Сохранить";
            this.buttonSaveSet.UseVisualStyleBackColor = true;
            this.buttonSaveSet.Click += new System.EventHandler(this.buttonSaveSet_Click);
            // 
            // labelUniversuum
            // 
            this.labelUniversuum.AutoSize = true;
            this.labelUniversuum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUniversuum.Location = new System.Drawing.Point(93, 45);
            this.labelUniversuum.Name = "labelUniversuum";
            this.labelUniversuum.Size = new System.Drawing.Size(679, 38);
            this.labelUniversuum.TabIndex = 0;
            this.labelUniversuum.Text = "U =  {                                                                         }";
            // 
            // buttonApplyUniversuum
            // 
            this.buttonApplyUniversuum.Location = new System.Drawing.Point(174, 92);
            this.buttonApplyUniversuum.Name = "buttonApplyUniversuum";
            this.buttonApplyUniversuum.Size = new System.Drawing.Size(110, 38);
            this.buttonApplyUniversuum.TabIndex = 2;
            this.buttonApplyUniversuum.Text = "Сохранить";
            this.buttonApplyUniversuum.UseVisualStyleBackColor = true;
            this.buttonApplyUniversuum.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(290, 92);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(110, 38);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Обновить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxSet
            // 
            this.comboBoxSet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSet.FormattingEnabled = true;
            this.comboBoxSet.Location = new System.Drawing.Point(19, 184);
            this.comboBoxSet.MaxLength = 1;
            this.comboBoxSet.Name = "comboBoxSet";
            this.comboBoxSet.Size = new System.Drawing.Size(106, 38);
            this.comboBoxSet.Sorted = true;
            this.comboBoxSet.TabIndex = 4;
            this.comboBoxSet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSet_SelectedIndexChanged);
            this.comboBoxSet.TextUpdate += new System.EventHandler(this.comboBoxSet_TextUpdate);
            // 
            // buttonResetSet
            // 
            this.buttonResetSet.Enabled = false;
            this.buttonResetSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResetSet.Location = new System.Drawing.Point(290, 225);
            this.buttonResetSet.Name = "buttonResetSet";
            this.buttonResetSet.Size = new System.Drawing.Size(110, 38);
            this.buttonResetSet.TabIndex = 7;
            this.buttonResetSet.Text = "Обновить";
            this.buttonResetSet.UseVisualStyleBackColor = true;
            this.buttonResetSet.Click += new System.EventHandler(this.buttonResetSet_Click);
            // 
            // textBoxUniversuum
            // 
            this.textBoxUniversuum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUniversuum.Location = new System.Drawing.Point(174, 49);
            this.textBoxUniversuum.Name = "textBoxUniversuum";
            this.textBoxUniversuum.Size = new System.Drawing.Size(575, 37);
            this.textBoxUniversuum.TabIndex = 1;
            this.textBoxUniversuum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUniversuum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUniversuum_KeyDown);
            // 
            // textBoxSet
            // 
            this.textBoxSet.Enabled = false;
            this.textBoxSet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSet.Location = new System.Drawing.Point(174, 182);
            this.textBoxSet.Name = "textBoxSet";
            this.textBoxSet.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxSet.Size = new System.Drawing.Size(575, 37);
            this.textBoxSet.TabIndex = 5;
            this.textBoxSet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSet_KeyDown);
            // 
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSet.Location = new System.Drawing.Point(120, 180);
            this.labelSet.Name = "labelSet";
            this.labelSet.Size = new System.Drawing.Size(652, 38);
            this.labelSet.TabIndex = 0;
            this.labelSet.Text = " = {                                                                         }";
            // 
            // buttonDeleteSet
            // 
            this.buttonDeleteSet.Enabled = false;
            this.buttonDeleteSet.Location = new System.Drawing.Point(612, 225);
            this.buttonDeleteSet.Name = "buttonDeleteSet";
            this.buttonDeleteSet.Size = new System.Drawing.Size(110, 38);
            this.buttonDeleteSet.TabIndex = 10;
            this.buttonDeleteSet.Text = "Удалить";
            this.buttonDeleteSet.UseVisualStyleBackColor = true;
            this.buttonDeleteSet.Click += new System.EventHandler(this.buttonDeleteSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(402, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Операции с множествами:";
            // 
            // BelongInt
            // 
            this.BelongInt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BelongInt.Location = new System.Drawing.Point(25, 649);
            this.BelongInt.MaxLength = 1;
            this.BelongInt.Name = "BelongInt";
            this.BelongInt.Size = new System.Drawing.Size(106, 37);
            this.BelongInt.TabIndex = 28;
            this.BelongInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BelongInt.TextChanged += new System.EventHandler(this.CalculateBelongs);
            // 
            // labelInclusion
            // 
            this.labelInclusion.AutoSize = true;
            this.labelInclusion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInclusion.Location = new System.Drawing.Point(137, 596);
            this.labelInclusion.Name = "labelInclusion";
            this.labelInclusion.Size = new System.Drawing.Size(176, 30);
            this.labelInclusion.TabIndex = 0;
            this.labelInclusion.Text = "⊆                      =";
            // 
            // InclusionSet2
            // 
            this.InclusionSet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InclusionSet2.FormattingEnabled = true;
            this.InclusionSet2.Location = new System.Drawing.Point(172, 592);
            this.InclusionSet2.MaxLength = 1;
            this.InclusionSet2.Name = "InclusionSet2";
            this.InclusionSet2.Size = new System.Drawing.Size(106, 38);
            this.InclusionSet2.Sorted = true;
            this.InclusionSet2.TabIndex = 26;
            this.InclusionSet2.SelectedIndexChanged += new System.EventHandler(this.CalculateInclusion);
            this.InclusionSet2.TextUpdate += new System.EventHandler(this.CalculateInclusion);
            // 
            // InclusionSet1
            // 
            this.InclusionSet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InclusionSet1.FormattingEnabled = true;
            this.InclusionSet1.Location = new System.Drawing.Point(25, 593);
            this.InclusionSet1.MaxLength = 1;
            this.InclusionSet1.Name = "InclusionSet1";
            this.InclusionSet1.Size = new System.Drawing.Size(106, 38);
            this.InclusionSet1.Sorted = true;
            this.InclusionSet1.TabIndex = 25;
            this.InclusionSet1.SelectedIndexChanged += new System.EventHandler(this.CalculateInclusion);
            this.InclusionSet1.TextUpdate += new System.EventHandler(this.CalculateInclusion);
            // 
            // BelongSet
            // 
            this.BelongSet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BelongSet.FormattingEnabled = true;
            this.BelongSet.Location = new System.Drawing.Point(172, 648);
            this.BelongSet.MaxLength = 1;
            this.BelongSet.Name = "BelongSet";
            this.BelongSet.Size = new System.Drawing.Size(106, 38);
            this.BelongSet.Sorted = true;
            this.BelongSet.TabIndex = 29;
            this.BelongSet.SelectedIndexChanged += new System.EventHandler(this.CalculateBelongs);
            this.BelongSet.TextUpdate += new System.EventHandler(this.CalculateBelongs);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 651);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "∈                      =";
            // 
            // InclusionResult
            // 
            this.InclusionResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InclusionResult.Location = new System.Drawing.Point(319, 594);
            this.InclusionResult.Name = "InclusionResult";
            this.InclusionResult.ReadOnly = true;
            this.InclusionResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.InclusionResult.Size = new System.Drawing.Size(106, 37);
            this.InclusionResult.TabIndex = 27;
            // 
            // BelongsResult
            // 
            this.BelongsResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BelongsResult.Location = new System.Drawing.Point(319, 648);
            this.BelongsResult.Name = "BelongsResult";
            this.BelongsResult.ReadOnly = true;
            this.BelongsResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BelongsResult.Size = new System.Drawing.Size(106, 37);
            this.BelongsResult.TabIndex = 30;
            // 
            // UnionResult
            // 
            this.UnionResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnionResult.Location = new System.Drawing.Point(319, 317);
            this.UnionResult.Name = "UnionResult";
            this.UnionResult.ReadOnly = true;
            this.UnionResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.UnionResult.Size = new System.Drawing.Size(575, 37);
            this.UnionResult.TabIndex = 13;
            this.UnionResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(415, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Множества:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(415, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Универсум:";
            // 
            // UnionSet1
            // 
            this.UnionSet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnionSet1.FormattingEnabled = true;
            this.UnionSet1.Location = new System.Drawing.Point(25, 316);
            this.UnionSet1.MaxLength = 1;
            this.UnionSet1.Name = "UnionSet1";
            this.UnionSet1.Size = new System.Drawing.Size(106, 38);
            this.UnionSet1.Sorted = true;
            this.UnionSet1.TabIndex = 11;
            this.UnionSet1.SelectedIndexChanged += new System.EventHandler(this.CalculateUnion);
            this.UnionSet1.TextUpdate += new System.EventHandler(this.CalculateUnion);
            // 
            // UnionSet2
            // 
            this.UnionSet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnionSet2.FormattingEnabled = true;
            this.UnionSet2.Location = new System.Drawing.Point(173, 316);
            this.UnionSet2.MaxLength = 1;
            this.UnionSet2.Name = "UnionSet2";
            this.UnionSet2.Size = new System.Drawing.Size(106, 38);
            this.UnionSet2.Sorted = true;
            this.UnionSet2.TabIndex = 12;
            this.UnionSet2.SelectedIndexChanged += new System.EventHandler(this.CalculateUnion);
            this.UnionSet2.TextUpdate += new System.EventHandler(this.CalculateUnion);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "_____________";
            // 
            // AdditionSet
            // 
            this.AdditionSet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdditionSet.FormattingEnabled = true;
            this.AdditionSet.Location = new System.Drawing.Point(173, 539);
            this.AdditionSet.MaxLength = 1;
            this.AdditionSet.Name = "AdditionSet";
            this.AdditionSet.Size = new System.Drawing.Size(106, 38);
            this.AdditionSet.Sorted = true;
            this.AdditionSet.TabIndex = 23;
            this.AdditionSet.SelectedIndexChanged += new System.EventHandler(this.CalculateAddition);
            this.AdditionSet.TextUpdate += new System.EventHandler(this.CalculateAddition);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(285, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "=";
            // 
            // AdditionResult
            // 
            this.AdditionResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdditionResult.Location = new System.Drawing.Point(319, 540);
            this.AdditionResult.Name = "AdditionResult";
            this.AdditionResult.ReadOnly = true;
            this.AdditionResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AdditionResult.Size = new System.Drawing.Size(575, 37);
            this.AdditionResult.TabIndex = 24;
            this.AdditionResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(137, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "⋃                      =";
            // 
            // CrossSet2
            // 
            this.CrossSet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CrossSet2.FormattingEnabled = true;
            this.CrossSet2.Location = new System.Drawing.Point(173, 372);
            this.CrossSet2.MaxLength = 1;
            this.CrossSet2.Name = "CrossSet2";
            this.CrossSet2.Size = new System.Drawing.Size(106, 38);
            this.CrossSet2.Sorted = true;
            this.CrossSet2.TabIndex = 15;
            this.CrossSet2.SelectedIndexChanged += new System.EventHandler(this.CalculateCross);
            this.CrossSet2.TextUpdate += new System.EventHandler(this.CalculateCross);
            // 
            // CrossSet1
            // 
            this.CrossSet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CrossSet1.FormattingEnabled = true;
            this.CrossSet1.Location = new System.Drawing.Point(25, 372);
            this.CrossSet1.MaxLength = 1;
            this.CrossSet1.Name = "CrossSet1";
            this.CrossSet1.Size = new System.Drawing.Size(106, 38);
            this.CrossSet1.Sorted = true;
            this.CrossSet1.TabIndex = 14;
            this.CrossSet1.SelectedIndexChanged += new System.EventHandler(this.CalculateCross);
            this.CrossSet1.TextUpdate += new System.EventHandler(this.CalculateCross);
            // 
            // CrossResult
            // 
            this.CrossResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CrossResult.Location = new System.Drawing.Point(319, 373);
            this.CrossResult.Name = "CrossResult";
            this.CrossResult.ReadOnly = true;
            this.CrossResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CrossResult.Size = new System.Drawing.Size(575, 37);
            this.CrossResult.TabIndex = 16;
            this.CrossResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(137, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "∩                      =";
            // 
            // DiffSet2
            // 
            this.DiffSet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiffSet2.FormattingEnabled = true;
            this.DiffSet2.Location = new System.Drawing.Point(173, 427);
            this.DiffSet2.MaxLength = 1;
            this.DiffSet2.Name = "DiffSet2";
            this.DiffSet2.Size = new System.Drawing.Size(106, 38);
            this.DiffSet2.Sorted = true;
            this.DiffSet2.TabIndex = 18;
            this.DiffSet2.SelectedIndexChanged += new System.EventHandler(this.CalculateDiff);
            this.DiffSet2.TextUpdate += new System.EventHandler(this.CalculateDiff);
            // 
            // DiffSet1
            // 
            this.DiffSet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiffSet1.FormattingEnabled = true;
            this.DiffSet1.Location = new System.Drawing.Point(25, 427);
            this.DiffSet1.MaxLength = 1;
            this.DiffSet1.Name = "DiffSet1";
            this.DiffSet1.Size = new System.Drawing.Size(106, 38);
            this.DiffSet1.Sorted = true;
            this.DiffSet1.TabIndex = 17;
            this.DiffSet1.SelectedIndexChanged += new System.EventHandler(this.CalculateDiff);
            this.DiffSet1.TextUpdate += new System.EventHandler(this.CalculateDiff);
            // 
            // DiffResult
            // 
            this.DiffResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiffResult.Location = new System.Drawing.Point(319, 428);
            this.DiffResult.Name = "DiffResult";
            this.DiffResult.ReadOnly = true;
            this.DiffResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DiffResult.Size = new System.Drawing.Size(575, 37);
            this.DiffResult.TabIndex = 19;
            this.DiffResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(137, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = " \\                      =";
            // 
            // SymmDiffSet2
            // 
            this.SymmDiffSet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SymmDiffSet2.FormattingEnabled = true;
            this.SymmDiffSet2.Location = new System.Drawing.Point(173, 483);
            this.SymmDiffSet2.MaxLength = 1;
            this.SymmDiffSet2.Name = "SymmDiffSet2";
            this.SymmDiffSet2.Size = new System.Drawing.Size(106, 38);
            this.SymmDiffSet2.Sorted = true;
            this.SymmDiffSet2.TabIndex = 21;
            this.SymmDiffSet2.SelectedIndexChanged += new System.EventHandler(this.CalculateSymmDiff);
            this.SymmDiffSet2.TextUpdate += new System.EventHandler(this.CalculateSymmDiff);
            // 
            // SymmDiffSet1
            // 
            this.SymmDiffSet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SymmDiffSet1.FormattingEnabled = true;
            this.SymmDiffSet1.Location = new System.Drawing.Point(25, 483);
            this.SymmDiffSet1.MaxLength = 1;
            this.SymmDiffSet1.Name = "SymmDiffSet1";
            this.SymmDiffSet1.Size = new System.Drawing.Size(106, 38);
            this.SymmDiffSet1.Sorted = true;
            this.SymmDiffSet1.TabIndex = 20;
            this.SymmDiffSet1.SelectedIndexChanged += new System.EventHandler(this.CalculateSymmDiff);
            this.SymmDiffSet1.TextUpdate += new System.EventHandler(this.CalculateSymmDiff);
            // 
            // SymmDiffResult
            // 
            this.SymmDiffResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SymmDiffResult.Location = new System.Drawing.Point(319, 484);
            this.SymmDiffResult.Name = "SymmDiffResult";
            this.SymmDiffResult.ReadOnly = true;
            this.SymmDiffResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.SymmDiffResult.Size = new System.Drawing.Size(575, 37);
            this.SymmDiffResult.TabIndex = 22;
            this.SymmDiffResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(137, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Δ                      =";
            // 
            // buttonRandomInit
            // 
            this.buttonRandomInit.Enabled = false;
            this.buttonRandomInit.Location = new System.Drawing.Point(496, 225);
            this.buttonRandomInit.Name = "buttonRandomInit";
            this.buttonRandomInit.Size = new System.Drawing.Size(110, 38);
            this.buttonRandomInit.TabIndex = 9;
            this.buttonRandomInit.Text = "ДСЧ";
            this.buttonRandomInit.UseVisualStyleBackColor = true;
            this.buttonRandomInit.Click += new System.EventHandler(this.buttonRandomInit_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(406, 227);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 31);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 695);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonRandomInit);
            this.Controls.Add(this.SymmDiffSet2);
            this.Controls.Add(this.SymmDiffSet1);
            this.Controls.Add(this.SymmDiffResult);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DiffSet2);
            this.Controls.Add(this.DiffSet1);
            this.Controls.Add(this.DiffResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CrossSet2);
            this.Controls.Add(this.CrossSet1);
            this.Controls.Add(this.CrossResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AdditionResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AdditionSet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UnionSet2);
            this.Controls.Add(this.UnionSet1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UnionResult);
            this.Controls.Add(this.BelongsResult);
            this.Controls.Add(this.InclusionResult);
            this.Controls.Add(this.BelongSet);
            this.Controls.Add(this.InclusionSet1);
            this.Controls.Add(this.InclusionSet2);
            this.Controls.Add(this.labelInclusion);
            this.Controls.Add(this.BelongInt);
            this.Controls.Add(this.buttonDeleteSet);
            this.Controls.Add(this.textBoxSet);
            this.Controls.Add(this.textBoxUniversuum);
            this.Controls.Add(this.buttonResetSet);
            this.Controls.Add(this.comboBoxSet);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonApplyUniversuum);
            this.Controls.Add(this.labelUniversuum);
            this.Controls.Add(this.buttonSaveSet);
            this.Controls.Add(this.labelSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "3";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonSaveSet;
        private Label labelUniversuum;
        private Button buttonApplyUniversuum;
        private Button buttonReset;
        private ComboBox comboBoxSet;
        private Button buttonResetSet;
        private TextBox textBoxUniversuum;
        private TextBox textBoxSet;
        private Label labelSet;
        private Button buttonDeleteSet;
        private Label label1;
        private TextBox BelongInt;
        private Label labelInclusion;
        private ComboBox InclusionSet2;
        private ComboBox InclusionSet1;
        private ComboBox BelongSet;
        private Label label2;
        private TextBox InclusionResult;
        private TextBox BelongsResult;
        private TextBox UnionResult;
        private Label label4;
        private Label label5;
        private ComboBox UnionSet1;
        private ComboBox UnionSet2;
        private Label label6;
        private ComboBox AdditionSet;
        private Label label7;
        private TextBox AdditionResult;
        private Label label3;
        private ComboBox CrossSet2;
        private ComboBox CrossSet1;
        private TextBox CrossResult;
        private Label label8;
        private ComboBox DiffSet2;
        private ComboBox DiffSet1;
        private TextBox DiffResult;
        private Label label9;
        private ComboBox SymmDiffSet2;
        private ComboBox SymmDiffSet1;
        private TextBox SymmDiffResult;
        private Label label10;

        Universum Univers;
        delegate Set BinaryAct(Set set1, Set set2);
        delegate Set UnaryAct(Set set);
        delegate bool BoolSetSetAct(Set set1, Set set2);
        delegate bool BoolIntSetAct(int number, Set set);
        ComboBox[] comboBoxes;
        private Button buttonRandomInit;
        private NumericUpDown numericUpDown1;
    }
}