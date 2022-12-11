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
            this.components = new System.ComponentModel.Container();
            this.buttonUnion = new System.Windows.Forms.Button();
            this.buttonCross = new System.Windows.Forms.Button();
            this.buttonSymmDiff = new System.Windows.Forms.Button();
            this.buttonDiff = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonSaveSet = new System.Windows.Forms.Button();
            this.labelUniversuum = new System.Windows.Forms.Label();
            this.buttonApplyUniversuum = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxChooseSet = new System.Windows.Forms.ComboBox();
            this.buttonResetSet = new System.Windows.Forms.Button();
            this.textBoxUniversuum = new System.Windows.Forms.TextBox();
            this.textBoxSet = new System.Windows.Forms.TextBox();
            this.labelSet = new System.Windows.Forms.Label();
            this.buttonDeleteSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBelongInt = new System.Windows.Forms.TextBox();
            this.labelInclusion = new System.Windows.Forms.Label();
            this.comboBoxChooseInclSet2 = new System.Windows.Forms.ComboBox();
            this.comboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxChooseInclSet1 = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseBelongSet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInclusionResult = new System.Windows.Forms.TextBox();
            this.textBoxBelongsResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxChoosenAct = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUnion
            // 
            this.buttonUnion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUnion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUnion.Location = new System.Drawing.Point(19, 303);
            this.buttonUnion.Name = "buttonUnion";
            this.buttonUnion.Size = new System.Drawing.Size(50, 50);
            this.buttonUnion.TabIndex = 0;
            this.buttonUnion.Text = "⋃";
            this.buttonUnion.UseVisualStyleBackColor = true;
            this.buttonUnion.Click += new System.EventHandler(this.buttonUnion_Click);
            // 
            // buttonCross
            // 
            this.buttonCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCross.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCross.Location = new System.Drawing.Point(75, 303);
            this.buttonCross.Name = "buttonCross";
            this.buttonCross.Size = new System.Drawing.Size(50, 50);
            this.buttonCross.TabIndex = 1;
            this.buttonCross.Text = "∩";
            this.buttonCross.UseVisualStyleBackColor = true;
            this.buttonCross.Click += new System.EventHandler(this.buttonCross_Click);
            // 
            // buttonSymmDiff
            // 
            this.buttonSymmDiff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSymmDiff.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSymmDiff.Location = new System.Drawing.Point(187, 303);
            this.buttonSymmDiff.Name = "buttonSymmDiff";
            this.buttonSymmDiff.Size = new System.Drawing.Size(50, 50);
            this.buttonSymmDiff.TabIndex = 2;
            this.buttonSymmDiff.Text = "Δ";
            this.buttonSymmDiff.UseVisualStyleBackColor = true;
            this.buttonSymmDiff.Click += new System.EventHandler(this.buttonSymmDiff_Click);
            // 
            // buttonDiff
            // 
            this.buttonDiff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDiff.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDiff.Location = new System.Drawing.Point(131, 303);
            this.buttonDiff.Name = "buttonDiff";
            this.buttonDiff.Size = new System.Drawing.Size(50, 50);
            this.buttonDiff.TabIndex = 3;
            this.buttonDiff.Text = "/";
            this.buttonDiff.UseVisualStyleBackColor = true;
            this.buttonDiff.Click += new System.EventHandler(this.buttonDiff_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddition.Location = new System.Drawing.Point(243, 303);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(50, 50);
            this.buttonAddition.TabIndex = 4;
            this.buttonAddition.Text = "x̄";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.buttonAddition_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(19, 359);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(274, 50);
            this.buttonEquals.TabIndex = 9;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonSaveSet
            // 
            this.buttonSaveSet.Location = new System.Drawing.Point(778, 132);
            this.buttonSaveSet.Name = "buttonSaveSet";
            this.buttonSaveSet.Size = new System.Drawing.Size(38, 38);
            this.buttonSaveSet.TabIndex = 12;
            this.buttonSaveSet.Text = "✓";
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
            this.labelUniversuum.TabIndex = 14;
            this.labelUniversuum.Text = "U = {                                                                          }";
            // 
            // buttonApplyUniversuum
            // 
            this.buttonApplyUniversuum.Location = new System.Drawing.Point(778, 49);
            this.buttonApplyUniversuum.Name = "buttonApplyUniversuum";
            this.buttonApplyUniversuum.Size = new System.Drawing.Size(38, 38);
            this.buttonApplyUniversuum.TabIndex = 16;
            this.buttonApplyUniversuum.Text = "✓";
            this.buttonApplyUniversuum.UseVisualStyleBackColor = true;
            this.buttonApplyUniversuum.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(824, 49);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(38, 38);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "⮌";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxChooseSet
            // 
            this.comboBoxChooseSet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChooseSet.FormattingEnabled = true;
            this.comboBoxChooseSet.Location = new System.Drawing.Point(19, 134);
            this.comboBoxChooseSet.Name = "comboBoxChooseSet";
            this.comboBoxChooseSet.Size = new System.Drawing.Size(106, 38);
            this.comboBoxChooseSet.Sorted = true;
            this.comboBoxChooseSet.TabIndex = 19;
            this.comboBoxChooseSet.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseSet_SelectedIndexChanged);
            this.comboBoxChooseSet.TextUpdate += new System.EventHandler(this.comboBoxChooseSet_TextUpdate);
            // 
            // buttonResetSet
            // 
            this.buttonResetSet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResetSet.Location = new System.Drawing.Point(824, 132);
            this.buttonResetSet.Name = "buttonResetSet";
            this.buttonResetSet.Size = new System.Drawing.Size(38, 38);
            this.buttonResetSet.TabIndex = 20;
            this.buttonResetSet.Text = "⮌";
            this.buttonResetSet.UseVisualStyleBackColor = true;
            this.buttonResetSet.Click += new System.EventHandler(this.buttonResetSet_Click);
            // 
            // textBoxUniversuum
            // 
            this.textBoxUniversuum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUniversuum.Location = new System.Drawing.Point(174, 49);
            this.textBoxUniversuum.Name = "textBoxUniversuum";
            this.textBoxUniversuum.Size = new System.Drawing.Size(575, 37);
            this.textBoxUniversuum.TabIndex = 21;
            this.textBoxUniversuum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUniversuum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUniversuum_KeyDown);
            // 
            // textBoxSet
            // 
            this.textBoxSet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSet.Location = new System.Drawing.Point(174, 135);
            this.textBoxSet.Name = "textBoxSet";
            this.textBoxSet.Size = new System.Drawing.Size(575, 37);
            this.textBoxSet.TabIndex = 23;
            this.textBoxSet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSet_KeyDown);
            // 
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSet.Location = new System.Drawing.Point(120, 133);
            this.labelSet.Name = "labelSet";
            this.labelSet.Size = new System.Drawing.Size(652, 38);
            this.labelSet.TabIndex = 22;
            this.labelSet.Text = " = {                                                                         }";
            // 
            // buttonDeleteSet
            // 
            this.buttonDeleteSet.Location = new System.Drawing.Point(866, 132);
            this.buttonDeleteSet.Name = "buttonDeleteSet";
            this.buttonDeleteSet.Size = new System.Drawing.Size(38, 38);
            this.buttonDeleteSet.TabIndex = 24;
            this.buttonDeleteSet.Text = "X";
            this.buttonDeleteSet.UseVisualStyleBackColor = true;
            this.buttonDeleteSet.Click += new System.EventHandler(this.buttonDeleteSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Операции с множествами:";
            // 
            // textBoxBelongInt
            // 
            this.textBoxBelongInt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBelongInt.Location = new System.Drawing.Point(504, 373);
            this.textBoxBelongInt.Name = "textBoxBelongInt";
            this.textBoxBelongInt.Size = new System.Drawing.Size(106, 37);
            this.textBoxBelongInt.TabIndex = 26;
            this.textBoxBelongInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBelongInt.TextChanged += new System.EventHandler(this.textBoxBelongInt_TextChanged);
            // 
            // labelInclusion
            // 
            this.labelInclusion.AutoSize = true;
            this.labelInclusion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInclusion.Location = new System.Drawing.Point(616, 320);
            this.labelInclusion.Name = "labelInclusion";
            this.labelInclusion.Size = new System.Drawing.Size(176, 30);
            this.labelInclusion.TabIndex = 27;
            this.labelInclusion.Text = "⊆                      =";
            // 
            // comboBoxChooseInclSet2
            // 
            this.comboBoxChooseInclSet2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChooseInclSet2.FormattingEnabled = true;
            this.comboBoxChooseInclSet2.Location = new System.Drawing.Point(651, 316);
            this.comboBoxChooseInclSet2.Name = "comboBoxChooseInclSet2";
            this.comboBoxChooseInclSet2.Size = new System.Drawing.Size(106, 38);
            this.comboBoxChooseInclSet2.Sorted = true;
            this.comboBoxChooseInclSet2.TabIndex = 28;
            this.comboBoxChooseInclSet2.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseInclSet2_SelectedIndexChanged);
            this.comboBoxChooseInclSet2.TextUpdate += new System.EventHandler(this.comboBoxChooseInclSet2_TextUpdate);
            // 
            // comboBoxBindingSource
            // 
            this.comboBoxBindingSource.DataSource = typeof(System.Windows.Forms.ComboBox);
            // 
            // comboBoxChooseInclSet1
            // 
            this.comboBoxChooseInclSet1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChooseInclSet1.FormattingEnabled = true;
            this.comboBoxChooseInclSet1.Location = new System.Drawing.Point(504, 317);
            this.comboBoxChooseInclSet1.Name = "comboBoxChooseInclSet1";
            this.comboBoxChooseInclSet1.Size = new System.Drawing.Size(106, 38);
            this.comboBoxChooseInclSet1.Sorted = true;
            this.comboBoxChooseInclSet1.TabIndex = 29;
            this.comboBoxChooseInclSet1.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseInclSet1_SelectedIndexChanged);
            this.comboBoxChooseInclSet1.TextUpdate += new System.EventHandler(this.comboBoxChooseInclSet1_TextUpdate);
            // 
            // comboBoxChooseBelongSet
            // 
            this.comboBoxChooseBelongSet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChooseBelongSet.FormattingEnabled = true;
            this.comboBoxChooseBelongSet.Location = new System.Drawing.Point(651, 372);
            this.comboBoxChooseBelongSet.Name = "comboBoxChooseBelongSet";
            this.comboBoxChooseBelongSet.Size = new System.Drawing.Size(106, 38);
            this.comboBoxChooseBelongSet.Sorted = true;
            this.comboBoxChooseBelongSet.TabIndex = 30;
            this.comboBoxChooseBelongSet.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseBelongSet_SelectedIndexChanged);
            this.comboBoxChooseBelongSet.TextUpdate += new System.EventHandler(this.comboBoxChooseBelongSet_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(618, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "∈                      =";
            // 
            // textBoxInclusionResult
            // 
            this.textBoxInclusionResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInclusionResult.Location = new System.Drawing.Point(798, 318);
            this.textBoxInclusionResult.Name = "textBoxInclusionResult";
            this.textBoxInclusionResult.ReadOnly = true;
            this.textBoxInclusionResult.Size = new System.Drawing.Size(106, 37);
            this.textBoxInclusionResult.TabIndex = 34;
            // 
            // textBoxBelongsResult
            // 
            this.textBoxBelongsResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBelongsResult.Location = new System.Drawing.Point(798, 372);
            this.textBoxBelongsResult.Name = "textBoxBelongsResult";
            this.textBoxBelongsResult.ReadOnly = true;
            this.textBoxBelongsResult.Size = new System.Drawing.Size(106, 37);
            this.textBoxBelongsResult.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(338, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 30);
            this.label3.TabIndex = 36;
            this.label3.Text = "Сейчас выбрана операция:";
            // 
            // textBoxChoosenAct
            // 
            this.textBoxChoosenAct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxChoosenAct.Location = new System.Drawing.Point(174, 230);
            this.textBoxChoosenAct.Name = "textBoxChoosenAct";
            this.textBoxChoosenAct.ReadOnly = true;
            this.textBoxChoosenAct.Size = new System.Drawing.Size(575, 37);
            this.textBoxChoosenAct.TabIndex = 37;
            this.textBoxChoosenAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(778, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 38;
            this.button1.Text = "Сбросить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(415, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "Множества:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(415, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 30);
            this.label5.TabIndex = 40;
            this.label5.Text = "Универсум:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxChoosenAct);
            this.Controls.Add(this.textBoxBelongsResult);
            this.Controls.Add(this.textBoxInclusionResult);
            this.Controls.Add(this.comboBoxChooseBelongSet);
            this.Controls.Add(this.comboBoxChooseInclSet1);
            this.Controls.Add(this.comboBoxChooseInclSet2);
            this.Controls.Add(this.labelInclusion);
            this.Controls.Add(this.textBoxBelongInt);
            this.Controls.Add(this.buttonDeleteSet);
            this.Controls.Add(this.textBoxSet);
            this.Controls.Add(this.textBoxUniversuum);
            this.Controls.Add(this.buttonResetSet);
            this.Controls.Add(this.comboBoxChooseSet);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonApplyUniversuum);
            this.Controls.Add(this.labelUniversuum);
            this.Controls.Add(this.buttonSaveSet);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.buttonDiff);
            this.Controls.Add(this.buttonSymmDiff);
            this.Controls.Add(this.buttonCross);
            this.Controls.Add(this.buttonUnion);
            this.Controls.Add(this.labelSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "3";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonUnion;
        private Button buttonCross;
        private Button buttonSymmDiff;
        private Button buttonDiff;
        private Button buttonAddition;
        private Button buttonEquals;
        private Button buttonSaveSet;
        private Label labelUniversuum;
        private Button buttonApplyUniversuum;
        private Button buttonReset;
        private ComboBox comboBoxChooseSet;
        private Button buttonResetSet;
        private TextBox textBoxUniversuum;
        private TextBox textBoxSet;
        private Label labelSet;
        private Button buttonDeleteSet;

        Universum Univers;
        string firstOperandKey;
        string secondOperandKey;
        delegate Set Action(Set set1, Set set2);
        Action setAct;
        private Label label1;
        private TextBox textBoxBelongInt;
        private Label labelInclusion;
        private ComboBox comboBoxChooseInclSet2;
        private BindingSource comboBoxBindingSource;
        private ComboBox comboBoxChooseInclSet1;
        private ComboBox comboBoxChooseBelongSet;
        private Label label2;
        private TextBox textBoxInclusionResult;
        private TextBox textBoxBelongsResult;
        private Label label3;
        private TextBox textBoxChoosenAct;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}