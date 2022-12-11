using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SetCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Univers = new Universum();
            firstOperandKey = "";
            secondOperandKey = "";
            setAct = null;
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
                Regex regexNumber = new Regex("^ *[1-9][0-9]* *$");
                Regex regexRange = new Regex("^ *[1-9][0-9]* *- *[1-9][0-9]* *$");
                for (int i = 0; i < strNumbers.Length; ++i)
                {
                    if (!regexNumber.IsMatch(strNumbers[i]) && !regexRange.IsMatch(strNumbers[i]))
                    {
                        throw new Exception("Ошибка задания множества");
                    }
                    strNumbers[i] = strNumbers[i].Replace(" ", "");
                }
                for (int i = 0; i < strNumbers.Length; ++i)
                {
                    if (regexNumber.IsMatch(strNumbers[i]))
                    {
                        FuncTool.IgnoreExc<ArgumentException>(() => set.AddItem(Int32.Parse(strNumbers[i])));
                    }
                    else
                    {
                        string[] tmp = strNumbers[i].Split("-");
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
                }
            }
            return set;
        }

        private void comboBoxChooseSet_TextUpdate(object sender, EventArgs e)
        {
            string key = comboBoxChooseSet.Text;
            if (Univers.ContainsKey(key))
                textBoxSet.Text = Univers[key].ToStrOnlyItems();
            else
                textBoxSet.Text = "";
        }

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
                }
                else
                {
                    Univers.ReplaceItemsFrom(set);
                    Univers.Sort();
                    MessageBox.Show("Универсуум успешно изменен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxUniversuum.Text = Univers.ToStrOnlyItems();
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
            string key = comboBoxChooseSet.Text;
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
                    MessageBox.Show($"Множество {key} успешно изменено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Univers.AddVariableSet(key, set);
                    Univers[key].Sort();
                    MessageBox.Show($"Множество {key} успешно сохранено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxChooseSet.Items.Add(key);
                    comboBoxChooseBelongSet.Items.Add(key);
                    comboBoxChooseInclSet1.Items.Add(key);
                    comboBoxChooseInclSet2.Items.Add(key);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Сначала введите имя множества", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void comboBoxChooseSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSet.Text = Univers[comboBoxChooseSet.Text].ToStrOnlyItems();
        }

        private void buttonResetSet_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseSet.Text == "")
            {
                MessageBox.Show("Сначала выберите множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Univers.ContainsKey(comboBoxChooseSet.Text))
            {
                MessageBox.Show("Сначала сохраните множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxSet.Text = Univers[comboBoxChooseSet.Text].ToStrOnlyItems();
            }
        }

        private void buttonDeleteSet_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseSet.Text == "" || !Univers.ContainsKey(comboBoxChooseSet.Text))
            {
                MessageBox.Show("Сначала выберите или сохраните множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Univers.RemoveVariableSet(comboBoxChooseSet.Text);
            }
        }

        #endregion

        #region textBox KeyDown

        private void textBoxUniversuum_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBoxUniversuum.Focused)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.buttonApply_Click(sender, e);
                }
            }
        }

        private void textBoxSet_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBoxSet.Focused && e.KeyCode == Keys.Enter)
            {
                this.buttonSaveSet_Click(sender, e);
            }
        }

        #endregion

        #region Set Actions

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseSet.Text == "" || !Univers.ContainsKey(comboBoxChooseSet.Text))
            {
                MessageBox.Show("Сначала выберите или сохраните множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxSet.Text = Univers[comboBoxChooseSet.Text].Addition().ToStrOnlyItems();
                comboBoxChooseSet.Text = "";
            }
        }

        private void buttonUnion_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseSet.Text == "" || !Univers.ContainsKey(comboBoxChooseSet.Text))
            {
                MessageBox.Show("Сначала выберите или сохраните множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxChoosenAct.Text = buttonUnion.Text;
                setAct = (Set set1, Set set2) => Set.Union(set1, set2); 
                firstOperandKey = comboBoxChooseSet.Text;
                textBoxSet.Text = "";
                comboBoxChooseSet.Text = "";
            }
        }

        private void buttonCross_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseSet.Text == "" || !Univers.ContainsKey(comboBoxChooseSet.Text))
            {
                MessageBox.Show("Сначала выберите или сохраните множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxChoosenAct.Text = buttonCross.Text;
                setAct = (Set set1, Set set2) => Set.Cross(set1, set2);
                firstOperandKey = comboBoxChooseSet.Text;
                textBoxSet.Text = "";
                comboBoxChooseSet.Text = "";
            }
        }

        private void buttonDiff_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseSet.Text == "" || !Univers.ContainsKey(comboBoxChooseSet.Text))
            {
                MessageBox.Show("Сначала выберите или сохраните множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxChoosenAct.Text = buttonDiff.Text;
                setAct = (Set set1, Set set2) => Set.Diff(set1, set2);
                firstOperandKey = comboBoxChooseSet.Text;
                textBoxSet.Text = "";
                comboBoxChooseSet.Text = "";
            }
        }

        private void buttonSymmDiff_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseSet.Text == "" || !Univers.ContainsKey(comboBoxChooseSet.Text))
            {
                MessageBox.Show("Сначала выберите или сохраните множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxChoosenAct.Text = buttonSymmDiff.Text;
                setAct = (Set set1, Set set2) => Set.SymDiff(set1, set2);
                firstOperandKey = comboBoxChooseSet.Text;
                textBoxSet.Text = "";
                comboBoxChooseSet.Text = "";
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseSet.Text == "" || !Univers.ContainsKey(comboBoxChooseSet.Text))
            {
                MessageBox.Show("Сначала выберите или сохраните множество", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxChoosenAct.Text = "";
                secondOperandKey = comboBoxChooseSet.Text;
                comboBoxChooseSet.Text = "";
                Set result = setAct(Univers[firstOperandKey], Univers[secondOperandKey]);
                setAct = null;
                result.Sort();
                textBoxSet.Text = result.ToStrOnlyItems();
            }
        }

        #endregion

        #region Inclusion

        private void comboBoxChooseInclSet1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxInclusionResult.Text = "";
            string key1 = comboBoxChooseInclSet1.Text;
            string key2 = comboBoxChooseInclSet2.Text;
            if (Univers.ContainsKey(key1) && Univers.ContainsKey(key2))
                textBoxInclusionResult.Text = Univers[key1].Inclusion(Univers[key2]).ToString();
        }

        private void comboBoxChooseInclSet2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChooseInclSet1_SelectedIndexChanged(sender, e);
        }

        private void comboBoxChooseInclSet2_TextUpdate(object sender, EventArgs e)
        {
            comboBoxChooseInclSet1_SelectedIndexChanged(sender, e);
        }

        private void comboBoxChooseInclSet1_TextUpdate(object sender, EventArgs e)
        {
            comboBoxChooseInclSet1_SelectedIndexChanged(sender, e);
        }

        #endregion

        #region Belongs

        private void comboBoxChooseBelongSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxBelongsResult.Text = "";
            string key = comboBoxChooseBelongSet.Text;
            bool isInt = Int32.TryParse(textBoxBelongInt.Text, out int number);
            if (Univers.ContainsKey(key) && isInt)
                textBoxBelongsResult.Text = number.Belongs(Univers[key]).ToString();
        }

        private void textBoxBelongInt_TextChanged(object sender, EventArgs e)
        {
            comboBoxChooseBelongSet_SelectedIndexChanged(sender, e);
        }

        private void comboBoxChooseBelongSet_TextUpdate(object sender, EventArgs e)
        {
            comboBoxChooseBelongSet_SelectedIndexChanged(sender, e);
        }

        #endregion
    }
}