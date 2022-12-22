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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxSet = new System.Windows.Forms.ComboBox();
            this.buttonRefreshSet = new System.Windows.Forms.Button();
            this.textBoxUniversuum = new System.Windows.Forms.TextBox();
            this.textBoxSet = new System.Windows.Forms.TextBox();
            this.labelSet = new System.Windows.Forms.Label();
            this.buttonDeleteSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.belongInt = new System.Windows.Forms.TextBox();
            this.labelInclusion = new System.Windows.Forms.Label();
            this.inclusionSet2 = new System.Windows.Forms.ComboBox();
            this.inclusionSet1 = new System.Windows.Forms.ComboBox();
            this.belongSet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inclusionResult = new System.Windows.Forms.TextBox();
            this.belongsResult = new System.Windows.Forms.TextBox();
            this.unionResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unionSet1 = new System.Windows.Forms.ComboBox();
            this.unionSet2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.additionSet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.additionResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.crossSet2 = new System.Windows.Forms.ComboBox();
            this.crossSet1 = new System.Windows.Forms.ComboBox();
            this.crossResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.diffSet2 = new System.Windows.Forms.ComboBox();
            this.diffSet1 = new System.Windows.Forms.ComboBox();
            this.diffResult = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.symmDiffSet2 = new System.Windows.Forms.ComboBox();
            this.symmDiffSet1 = new System.Windows.Forms.ComboBox();
            this.symmDiffResult = new System.Windows.Forms.TextBox();
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
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.Location = new System.Drawing.Point(290, 92);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(110, 38);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
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
            // buttonRefreshSet
            // 
            this.buttonRefreshSet.Enabled = false;
            this.buttonRefreshSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRefreshSet.Location = new System.Drawing.Point(290, 225);
            this.buttonRefreshSet.Name = "buttonRefreshSet";
            this.buttonRefreshSet.Size = new System.Drawing.Size(110, 38);
            this.buttonRefreshSet.TabIndex = 7;
            this.buttonRefreshSet.Text = "Обновить";
            this.buttonRefreshSet.UseVisualStyleBackColor = true;
            this.buttonRefreshSet.Click += new System.EventHandler(this.buttonRefreshSet_Click);
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
            this.labelSet.Location = new System.Drawing.Point(120, 178);
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
            // belongInt
            // 
            this.belongInt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.belongInt.Location = new System.Drawing.Point(25, 649);
            this.belongInt.MaxLength = 0;
            this.belongInt.Name = "belongInt";
            this.belongInt.Size = new System.Drawing.Size(106, 37);
            this.belongInt.TabIndex = 28;
            this.belongInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.belongInt.TextChanged += new System.EventHandler(this.CalculateBelongs);
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
            // inclusionSet2
            // 
            this.inclusionSet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inclusionSet2.FormattingEnabled = true;
            this.inclusionSet2.Location = new System.Drawing.Point(172, 592);
            this.inclusionSet2.MaxLength = 1;
            this.inclusionSet2.Name = "inclusionSet2";
            this.inclusionSet2.Size = new System.Drawing.Size(106, 38);
            this.inclusionSet2.Sorted = true;
            this.inclusionSet2.TabIndex = 26;
            this.inclusionSet2.SelectedIndexChanged += new System.EventHandler(this.CalculateInclusion);
            this.inclusionSet2.TextUpdate += new System.EventHandler(this.CalculateInclusion);
            // 
            // inclusionSet1
            // 
            this.inclusionSet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inclusionSet1.FormattingEnabled = true;
            this.inclusionSet1.Location = new System.Drawing.Point(25, 593);
            this.inclusionSet1.MaxLength = 1;
            this.inclusionSet1.Name = "inclusionSet1";
            this.inclusionSet1.Size = new System.Drawing.Size(106, 38);
            this.inclusionSet1.Sorted = true;
            this.inclusionSet1.TabIndex = 25;
            this.inclusionSet1.SelectedIndexChanged += new System.EventHandler(this.CalculateInclusion);
            this.inclusionSet1.TextUpdate += new System.EventHandler(this.CalculateInclusion);
            // 
            // belongSet
            // 
            this.belongSet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.belongSet.FormattingEnabled = true;
            this.belongSet.Location = new System.Drawing.Point(172, 648);
            this.belongSet.MaxLength = 1;
            this.belongSet.Name = "belongSet";
            this.belongSet.Size = new System.Drawing.Size(106, 38);
            this.belongSet.Sorted = true;
            this.belongSet.TabIndex = 29;
            this.belongSet.SelectedIndexChanged += new System.EventHandler(this.CalculateBelongs);
            this.belongSet.TextUpdate += new System.EventHandler(this.CalculateBelongs);
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
            // inclusionResult
            // 
            this.inclusionResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inclusionResult.Location = new System.Drawing.Point(319, 594);
            this.inclusionResult.Name = "inclusionResult";
            this.inclusionResult.ReadOnly = true;
            this.inclusionResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.inclusionResult.Size = new System.Drawing.Size(106, 37);
            this.inclusionResult.TabIndex = 27;
            // 
            // belongsResult
            // 
            this.belongsResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.belongsResult.Location = new System.Drawing.Point(319, 648);
            this.belongsResult.Name = "belongsResult";
            this.belongsResult.ReadOnly = true;
            this.belongsResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.belongsResult.Size = new System.Drawing.Size(106, 37);
            this.belongsResult.TabIndex = 30;
            // 
            // unionResult
            // 
            this.unionResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unionResult.Location = new System.Drawing.Point(319, 317);
            this.unionResult.Name = "unionResult";
            this.unionResult.ReadOnly = true;
            this.unionResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.unionResult.Size = new System.Drawing.Size(575, 37);
            this.unionResult.TabIndex = 13;
            this.unionResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // unionSet1
            // 
            this.unionSet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unionSet1.FormattingEnabled = true;
            this.unionSet1.Location = new System.Drawing.Point(25, 316);
            this.unionSet1.MaxLength = 1;
            this.unionSet1.Name = "unionSet1";
            this.unionSet1.Size = new System.Drawing.Size(106, 38);
            this.unionSet1.Sorted = true;
            this.unionSet1.TabIndex = 11;
            this.unionSet1.SelectedIndexChanged += new System.EventHandler(this.CalculateUnion);
            this.unionSet1.TextUpdate += new System.EventHandler(this.CalculateUnion);
            // 
            // unionSet2
            // 
            this.unionSet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unionSet2.FormattingEnabled = true;
            this.unionSet2.Location = new System.Drawing.Point(173, 316);
            this.unionSet2.MaxLength = 1;
            this.unionSet2.Name = "unionSet2";
            this.unionSet2.Size = new System.Drawing.Size(106, 38);
            this.unionSet2.Sorted = true;
            this.unionSet2.TabIndex = 12;
            this.unionSet2.SelectedIndexChanged += new System.EventHandler(this.CalculateUnion);
            this.unionSet2.TextUpdate += new System.EventHandler(this.CalculateUnion);
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
            // additionSet
            // 
            this.additionSet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.additionSet.FormattingEnabled = true;
            this.additionSet.Location = new System.Drawing.Point(173, 539);
            this.additionSet.MaxLength = 1;
            this.additionSet.Name = "additionSet";
            this.additionSet.Size = new System.Drawing.Size(106, 38);
            this.additionSet.Sorted = true;
            this.additionSet.TabIndex = 23;
            this.additionSet.SelectedIndexChanged += new System.EventHandler(this.CalculateAddition);
            this.additionSet.TextUpdate += new System.EventHandler(this.CalculateAddition);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(285, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(630, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "= {                                                                              " +
    "                   }";
            // 
            // additionResult
            // 
            this.additionResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.additionResult.Location = new System.Drawing.Point(319, 540);
            this.additionResult.Name = "additionResult";
            this.additionResult.ReadOnly = true;
            this.additionResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.additionResult.Size = new System.Drawing.Size(575, 37);
            this.additionResult.TabIndex = 24;
            this.additionResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(137, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(777, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "⋃                      = {                                                       " +
    "                                          }";
            // 
            // crossSet2
            // 
            this.crossSet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crossSet2.FormattingEnabled = true;
            this.crossSet2.Location = new System.Drawing.Point(173, 372);
            this.crossSet2.MaxLength = 1;
            this.crossSet2.Name = "crossSet2";
            this.crossSet2.Size = new System.Drawing.Size(106, 38);
            this.crossSet2.Sorted = true;
            this.crossSet2.TabIndex = 15;
            this.crossSet2.SelectedIndexChanged += new System.EventHandler(this.CalculateCross);
            this.crossSet2.TextUpdate += new System.EventHandler(this.CalculateCross);
            // 
            // crossSet1
            // 
            this.crossSet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crossSet1.FormattingEnabled = true;
            this.crossSet1.Location = new System.Drawing.Point(25, 372);
            this.crossSet1.MaxLength = 1;
            this.crossSet1.Name = "crossSet1";
            this.crossSet1.Size = new System.Drawing.Size(106, 38);
            this.crossSet1.Sorted = true;
            this.crossSet1.TabIndex = 14;
            this.crossSet1.SelectedIndexChanged += new System.EventHandler(this.CalculateCross);
            this.crossSet1.TextUpdate += new System.EventHandler(this.CalculateCross);
            // 
            // crossResult
            // 
            this.crossResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crossResult.Location = new System.Drawing.Point(319, 373);
            this.crossResult.Name = "crossResult";
            this.crossResult.ReadOnly = true;
            this.crossResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.crossResult.Size = new System.Drawing.Size(575, 37);
            this.crossResult.TabIndex = 16;
            this.crossResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(137, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(777, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "∩                      = {                                                       " +
    "                                          }";
            // 
            // diffSet2
            // 
            this.diffSet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diffSet2.FormattingEnabled = true;
            this.diffSet2.Location = new System.Drawing.Point(173, 427);
            this.diffSet2.MaxLength = 1;
            this.diffSet2.Name = "diffSet2";
            this.diffSet2.Size = new System.Drawing.Size(106, 38);
            this.diffSet2.Sorted = true;
            this.diffSet2.TabIndex = 18;
            this.diffSet2.SelectedIndexChanged += new System.EventHandler(this.CalculateDiff);
            this.diffSet2.TextUpdate += new System.EventHandler(this.CalculateDiff);
            // 
            // diffSet1
            // 
            this.diffSet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diffSet1.FormattingEnabled = true;
            this.diffSet1.Location = new System.Drawing.Point(25, 427);
            this.diffSet1.MaxLength = 1;
            this.diffSet1.Name = "diffSet1";
            this.diffSet1.Size = new System.Drawing.Size(106, 38);
            this.diffSet1.Sorted = true;
            this.diffSet1.TabIndex = 17;
            this.diffSet1.SelectedIndexChanged += new System.EventHandler(this.CalculateDiff);
            this.diffSet1.TextUpdate += new System.EventHandler(this.CalculateDiff);
            // 
            // diffResult
            // 
            this.diffResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diffResult.Location = new System.Drawing.Point(319, 428);
            this.diffResult.Name = "diffResult";
            this.diffResult.ReadOnly = true;
            this.diffResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.diffResult.Size = new System.Drawing.Size(575, 37);
            this.diffResult.TabIndex = 19;
            this.diffResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(137, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(776, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = " \\                      = {                                                      " +
    "                                           }";
            // 
            // symmDiffSet2
            // 
            this.symmDiffSet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.symmDiffSet2.FormattingEnabled = true;
            this.symmDiffSet2.Location = new System.Drawing.Point(173, 483);
            this.symmDiffSet2.MaxLength = 1;
            this.symmDiffSet2.Name = "symmDiffSet2";
            this.symmDiffSet2.Size = new System.Drawing.Size(106, 38);
            this.symmDiffSet2.Sorted = true;
            this.symmDiffSet2.TabIndex = 21;
            this.symmDiffSet2.SelectedIndexChanged += new System.EventHandler(this.CalculateSymmDiff);
            this.symmDiffSet2.TextUpdate += new System.EventHandler(this.CalculateSymmDiff);
            // 
            // symmDiffSet1
            // 
            this.symmDiffSet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.symmDiffSet1.FormattingEnabled = true;
            this.symmDiffSet1.Location = new System.Drawing.Point(25, 483);
            this.symmDiffSet1.MaxLength = 1;
            this.symmDiffSet1.Name = "symmDiffSet1";
            this.symmDiffSet1.Size = new System.Drawing.Size(106, 38);
            this.symmDiffSet1.Sorted = true;
            this.symmDiffSet1.TabIndex = 20;
            this.symmDiffSet1.SelectedIndexChanged += new System.EventHandler(this.CalculateSymmDiff);
            this.symmDiffSet1.TextUpdate += new System.EventHandler(this.CalculateSymmDiff);
            // 
            // symmDiffResult
            // 
            this.symmDiffResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.symmDiffResult.Location = new System.Drawing.Point(319, 484);
            this.symmDiffResult.Name = "symmDiffResult";
            this.symmDiffResult.ReadOnly = true;
            this.symmDiffResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.symmDiffResult.Size = new System.Drawing.Size(575, 37);
            this.symmDiffResult.TabIndex = 22;
            this.symmDiffResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(137, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(776, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Δ                      = {                                                       " +
    "                                          }";
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
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(922, 695);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonRandomInit);
            this.Controls.Add(this.symmDiffSet2);
            this.Controls.Add(this.symmDiffSet1);
            this.Controls.Add(this.symmDiffResult);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.diffSet2);
            this.Controls.Add(this.diffSet1);
            this.Controls.Add(this.diffResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.crossSet2);
            this.Controls.Add(this.crossSet1);
            this.Controls.Add(this.crossResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.additionResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.additionSet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.unionSet2);
            this.Controls.Add(this.unionSet1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unionResult);
            this.Controls.Add(this.belongsResult);
            this.Controls.Add(this.inclusionResult);
            this.Controls.Add(this.belongSet);
            this.Controls.Add(this.inclusionSet1);
            this.Controls.Add(this.inclusionSet2);
            this.Controls.Add(this.labelInclusion);
            this.Controls.Add(this.belongInt);
            this.Controls.Add(this.buttonDeleteSet);
            this.Controls.Add(this.textBoxSet);
            this.Controls.Add(this.textBoxUniversuum);
            this.Controls.Add(this.buttonRefreshSet);
            this.Controls.Add(this.comboBoxSet);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonApplyUniversuum);
            this.Controls.Add(this.labelUniversuum);
            this.Controls.Add(this.buttonSaveSet);
            this.Controls.Add(this.labelSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Калькулятор Множеств";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonSaveSet;
        private Label labelUniversuum;
        private Button buttonApplyUniversuum;
        private Button buttonRefresh;
        private ComboBox comboBoxSet;
        private Button buttonRefreshSet;
        private TextBox textBoxUniversuum;
        private TextBox textBoxSet;
        private Label labelSet;
        private Button buttonDeleteSet;
        private Label label1;
        private TextBox belongInt;
        private Label labelInclusion;
        private ComboBox inclusionSet2;
        private ComboBox inclusionSet1;
        private ComboBox belongSet;
        private Label label2;
        private TextBox inclusionResult;
        private TextBox belongsResult;
        private TextBox unionResult;
        private Label label4;
        private Label label5;
        private ComboBox unionSet1;
        private ComboBox unionSet2;
        private Label label6;
        private ComboBox additionSet;
        private Label label7;
        private TextBox additionResult;
        private Label label3;
        private ComboBox crossSet2;
        private ComboBox crossSet1;
        private TextBox crossResult;
        private Label label8;
        private ComboBox diffSet2;
        private ComboBox diffSet1;
        private TextBox diffResult;
        private Label label9;
        private ComboBox symmDiffSet2;
        private ComboBox symmDiffSet1;
        private TextBox symmDiffResult;
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