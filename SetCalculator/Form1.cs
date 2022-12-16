using System.Text.RegularExpressions;

namespace SetCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Univers = new Universum();
            comboBoxes = new ComboBox[]
            {
                comboBoxSet,

                UnionSet1,
                UnionSet2,

                CrossSet1,
                CrossSet2,

                DiffSet1,
                DiffSet2,

                SymmDiffSet1,
                SymmDiffSet2,

                AdditionSet,

                InclusionSet1,
                InclusionSet2,

                BelongSet,
            };
            for (int i = 1; i < comboBoxes.Length; ++i)
            {
                comboBoxes[i].Items.Add("U");
            }
        }

        private Set ParseToSet(string source)
        {
            Set set = new Set();
            string[] strNumbers = source.Split(",");
            if (strNumbers[0] == "")
            {
                return set;
            }
            else
            {
                Regex regexNumber = new Regex("^ *-?[1-9][0-9]* *$");
                Regex regexNull = new Regex("^ *0 *$");
                Regex regexRange = new Regex("^ *-?[1-9][0-9]* *_ *-?[1-9][0-9]* *$");

                for (int i = 0; i < strNumbers.Length; ++i)
                {
                    if (regexNumber.IsMatch(strNumbers[i]) || regexNull.IsMatch(strNumbers[i]))
                    {
                        strNumbers[i] = strNumbers[i].Replace(" ", "");
                        FuncTool.IgnoreExc<ArgumentException>(() => set.AddItem(Int32.Parse(strNumbers[i])));
                    }
                    else if (regexRange.IsMatch(strNumbers[i]))
                    {
                        strNumbers[i] = strNumbers[i].Replace(" ", "");
                        string[] tmp = strNumbers[i].Split("_");
                        int start = Int32.Parse(tmp[0]);
                        int end = Int32.Parse(tmp[1]);
                        if (start > end)
                        {
                            throw new Exception("Ошибка задания множества (неверно задан промежуток)");
                        }
                        else
                        {
                            for (int j = start; j <= end; ++j)
                            {
                                set.AddItem(j);
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Ошибка задания множества");
                    }
                }
            }
            return set;
        }

        #region comboBoxSet Events

        private void EnableSets()
        {
            textBoxSet.Enabled = true;
            buttonSaveSet.Enabled = true;
            buttonResetSet.Enabled = true;
            numericUpDown1.Enabled = true;
            buttonRandomInit.Enabled = true;
            buttonDeleteSet.Enabled = true;
        }

        private void DisableSets()
        {
            textBoxSet.Enabled = false;
            buttonSaveSet.Enabled = false;
            buttonResetSet.Enabled = false;
            numericUpDown1.Enabled = false;
            buttonRandomInit.Enabled = false;
            buttonDeleteSet.Enabled = false;
        }

        private void comboBoxSet_TextUpdate(object sender, EventArgs e)
        {
            if (Univers.ContainsKey(comboBoxSet.Text))
            {
                comboBoxSet_SelectedIndexChanged(sender, e);
            }
            else if (comboBoxSet.Text != "")
            {
                textBoxSet.Text = "";
                EnableSets();
            }
            else
            {
                textBoxSet.Text = "";
                DisableSets();
            }
        }

        private void comboBoxSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSet.Text = Univers[comboBoxSet.Text].ToStrOnlyItems();
            EnableSets();
        }

        #endregion

        #region Universuum buttons

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Set set = new Set();
            try
            {
                set = ParseToSet(textBoxUniversuum.Text);
                if (Univers.Equals(set)) 
                {
                    MessageBox.Show("Универсуум не был изменен", "", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else if (set.IsVoid())
                {
                    Univers.Clear();
                    numericUpDown1.Maximum = Univers.Count;
                    if (Univers.ContainsKey(comboBoxSet.Text))
                    {
                        buttonResetSet_Click(sender, e);
                    }
                    CalculateAll(sender, e);
                    MessageBox.Show("Универсуум успешно изменен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Univers.ReplaceItemsFrom(set);
                    Univers.Sort();
                    numericUpDown1.Maximum = Univers.Count;
                    if (Univers.ContainsKey(comboBoxSet.Text))
                    {
                        buttonResetSet_Click(sender, e);
                    }
                    CalculateAll(sender, e);
                    MessageBox.Show("Универсуум успешно изменен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ошибка задания множества: слишком большое число", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                buttonReset_Click(sender, e);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxUniversuum.Text = Univers.ToStrOnlyItems();
        }

        #endregion

        #region VariableSet buttons

        private void buttonSaveSet_Click(object sender, EventArgs e)
        {
            Set set = new Set();
            string key = comboBoxSet.Text;
            try
            {
                if (key == "")
                    throw new ArgumentNullException();
                if (key == "U")
                    throw new Exception("Недопустимое имя множества: U - универсум");
                set = ParseToSet(textBoxSet.Text);
                if (Univers.ContainsKey(key))
                {
                    Univers[key].ReplaceItemsFrom(set);
                    Univers[key].Sort();
                    CalculateAll(sender, e);
                    MessageBox.Show($"Множество {key} успешно изменено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Univers.AddVariableSet(key, set);
                    Univers[key].Sort();
                    foreach (ComboBox box in comboBoxes)
                    {
                        box.Items.Add(key);
                    }
                    MessageBox.Show($"Множество {key} успешно сохранено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Сначала введите имя множества", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ошибка задания множества: слишком большое число", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Univers.ContainsKey(key))
            {
                textBoxSet.Text = Univers[key].ToStrOnlyItems();
            }
        }

        private void buttonResetSet_Click(object sender, EventArgs e)
        {
            if (comboBoxSet.Text == "")
            {
                MessageBox.Show("Сначала выберите множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Univers.ContainsKey(comboBoxSet.Text))
            {
                MessageBox.Show("Сначала сохраните множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxSet.Text = Univers[comboBoxSet.Text].ToStrOnlyItems();
            }
        }

        private void buttonRandomInit_Click(object sender, EventArgs e)
        {
            Set randSet;
            try
            {
                randSet = Set.RandomInit(Univers, (int)numericUpDown1.Value);
                textBoxSet.Text = randSet.ToStrOnlyItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteSet_Click(object sender, EventArgs e)
        {
            if (comboBoxSet.Text == "" || !Univers.ContainsKey(comboBoxSet.Text))
            {
                MessageBox.Show("Сначала выберите или сохраните множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string key = comboBoxSet.Text;
                Univers.RemoveVariableSet(key);
                for (int i = 0; i < comboBoxes.Length; ++i)
                {
                    comboBoxes[i].Items.Remove(key);
                    if (comboBoxes[i].Text == key)
                    {
                        comboBoxes[i].Text = "";
                    }
                }
                comboBoxSet.Text = "";
                textBoxSet.Text = "";
                CalculateAll(sender, e);
                MessageBox.Show("Множество успешно удалено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region KeyDown

        private void textBoxUniversuum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonApply_Click(sender, e);
            }
        }

        private void textBoxSet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonSaveSet_Click(sender, e);
            }
        }

        #endregion

        #region Set Actions

        private void CalculateAll(object sender, EventArgs e)
        {
            CalculateUnion(sender, e);
            CalculateCross(sender, e);
            CalculateDiff(sender, e);
            CalculateSymmDiff(sender, e);
            CalculateAddition(sender, e);
            CalculateInclusion(sender, e);
            CalculateBelongs(sender, e);
        }

        private void CalculateUnion(object sender, EventArgs e)
        {
            DoAct(ref UnionResult, UnionSet1, UnionSet2, Set.Union);
        }

        private void CalculateCross(object sender, EventArgs e)
        {
            DoAct(ref CrossResult, CrossSet1, CrossSet2, Set.Cross);
        }

        private void CalculateDiff(object sender, EventArgs e)
        {
            DoAct(ref DiffResult, DiffSet1, DiffSet2, Set.Diff);
        }

        private void CalculateSymmDiff(object sender, EventArgs e)
        {
            DoAct(ref SymmDiffResult, SymmDiffSet1, SymmDiffSet2, Set.SymDiff);
        }

        private void CalculateAddition(object sender, EventArgs e)
        {
            DoAct(ref AdditionResult, AdditionSet, Set.Addition);
        }

        private void CalculateInclusion(object sender, EventArgs e)
        {
            DoAct(ref InclusionResult, InclusionSet1, InclusionSet2, Set.Inclusion);
        }

        private void CalculateBelongs(object sender, EventArgs e)
        {
            DoAct(ref BelongsResult, BelongInt, BelongSet, Set.Belongs);
        }

        #endregion

        #region DoAct

        private void DoAct(ref TextBox answer, ComboBox source1, ComboBox source2, BinaryAct action)
        {
            answer.Text = "";
            string key1 = source1.Text;
            string key2 = source2.Text;
            if (Univers.ContainsKey(key1) && Univers.ContainsKey(key2))
            {
                Set set = action(Univers[key1], Univers[key2]);
                set.Sort();
                answer.Text = set.ToStrOnlyItems();
            }
            else if (key1 == "U" && Univers.ContainsKey(key2))
            {
                Set set = action(Univers, Univers[key2]);
                set.Sort();
                answer.Text = set.ToStrOnlyItems();
            }
            else if (Univers.ContainsKey(key1) && key2 == "U")
            {
                Set set = action(Univers[key1], Univers);
                set.Sort();
                answer.Text = set.ToStrOnlyItems();
            }
            else if (key1 == "U" && key2 == "U")
            {
                Set set = action(Univers, Univers);
                set.Sort();
                answer.Text = set.ToStrOnlyItems();
            }
        }

        private void DoAct(ref TextBox answer, ComboBox source, UnaryAct action)
        {
            answer.Text = "";
            string key = source.Text;
            if (Univers.ContainsKey(key))
            {
                Set set = action(Univers[key]);
                set.Sort();
                answer.Text = set.ToStrOnlyItems();
            }
            else if (key == "U")
            {
                {
                    Set set = action(Univers);
                    set.Sort();
                    answer.Text = set.ToStrOnlyItems();
                }
            }
        }

        private void DoAct(ref TextBox answer, ComboBox source1, ComboBox source2, BoolSetSetAct action)
        {
            answer.Text = "";
            string key1 = source1.Text;
            string key2 = source2.Text;
            if (Univers.ContainsKey(key1) && Univers.ContainsKey(key2))
                answer.Text = action(Univers[key1], Univers[key2]).ToString();
            else if (key1 == "U" && Univers.ContainsKey(key2))
                answer.Text = action(Univers, Univers[key2]).ToString();
            else if (Univers.ContainsKey(key1) && key2 == "U")
                answer.Text = action(Univers[key1], Univers).ToString();
            else if (key1 == "U" && key2 == "U")
                answer.Text = action(Univers, Univers).ToString();
        }

        private void DoAct(ref TextBox answer, TextBox source1, ComboBox source2, BoolIntSetAct action)
        {
            answer.Text = "";
            bool isParsed = Int32.TryParse(source1.Text, out int number);
            string key = source2.Text;
            if (Univers.ContainsKey(key) && isParsed)
                answer.Text = action(number, Univers[key]).ToString();
            else if (key == "U" && isParsed)
                answer.Text = action(number, Univers).ToString();
        }

        #endregion
    }
}