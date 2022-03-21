using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorium_2
{
    public partial class Form1 : Form
    {
        bool ifSquare;
        bool ifRoot;
        bool ifReverse;
        bool ifControlOn;

        public delegate double Operation(double x);
        private double Square(double x) => x * x;
        private double Root(double x) => Math.Sqrt(x);
        private double Reverse(double x) => 1 / x;

        public delegate void ChangingMethods();
        private void ChangeBackColor() => BackColor = SystemColors.ActiveCaption;
        private void ChangeFontColor() => inputBox.ForeColor = Color.Blue;
        private void ChangeFont() => inputBox.Font = new Font(inputBox.Font.Name, DefaultFont.Size, FontStyle.Italic);

        public delegate void BackToInitialMethods();
        private void InitialBackColor() => BackColor = SystemColors.InactiveCaption;
        private void InitialFontColor() => inputBox.ForeColor = DefaultForeColor;
        private void InitialFont() => inputBox.Font = DefaultFont;

        public double[] NumberCollection(double[] tab, Operation op)
        {
            double[] tab2 = new double[tab.Length];
            for(int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = op(tab[i]);
            }
            return tab2;
        }

        public delegate bool SortMethods(string s1, string s2);
        static public string[] BubbleSort(string[] table, SortMethods compare)
        {
            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 1; j < table.Length - i; j++)
                {
                    if (compare(table[j], table[j - 1]))
                    {
                        string AuxTable = table[j];
                        table[j] = table[j - 1];
                        table[j - 1] = AuxTable;
                    }
                }
            }
            return table;
        }
        static public bool Compare(string s1, string s2)
        {
            try
            {
                double symbol1 = double.Parse(s1);
                double symbol2 = double.Parse(s2);
                if (symbol1 < symbol2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                char symbol1 = s1[0];
                char symbol2 = s2[0];
                if (symbol1 < symbol2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void showValueButton_Click(object sender, EventArgs e)
        {
            if (!ifControlOn)
            {
                Operation[] operations = new Operation[3];
                operations[0] = Square;
                operations[1] = Root;
                operations[2] = Reverse;

                if (ifSquare)
                {
                    outputBox.Text = operations[0](double.Parse(inputBox.Text)).ToString();
                }
                else if (ifRoot)
                {
                    outputBox.Text = operations[1](double.Parse(inputBox.Text)).ToString();
                }
                else if (ifReverse)
                {
                    outputBox.Text = operations[2](double.Parse(inputBox.Text)).ToString();
                }
            }
            else if(ifControlOn)
            {
                string[] inputs = inputBox.Text.Split(' ');
                double[] table = new double[inputs.Length];
                for(int i = 0; i < table.Length; i++)
                {
                    table[i] = double.Parse(inputs[i]);
                }
                if (ifSquare)
                {
                    outputBox.Text = "";
                    double[] outputTable = NumberCollection(table, Square);
                    for(int i = 0; i < outputTable.Length; i++)
                    {
                        outputBox.Text += outputTable[i] + " ";
                    }
                }
                else if (ifRoot)
                {
                    outputBox.Text = "";
                    double[] outputTable = NumberCollection(table, Root);
                    for (int i = 0; i < outputTable.Length; i++)
                    {
                        outputBox.Text += outputTable[i] + " ";
                    }
                }
                else if (ifReverse)
                {
                    outputBox.Text = "";
                    double[] outputTable = NumberCollection(table, Reverse);
                    for (int i = 0; i < outputTable.Length; i++)
                    {
                        outputBox.Text += outputTable[i] + " ";
                    }
                }
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            ChangingMethods[] changingMethods = new ChangingMethods[3];
            changingMethods[0] = ChangeBackColor;
            changingMethods[1] = ChangeFontColor;
            changingMethods[2] = ChangeFont;

            BackToInitialMethods[] backToInitialMethods = new BackToInitialMethods[3];
            backToInitialMethods[0] = InitialBackColor;
            backToInitialMethods[1] = InitialFontColor;
            backToInitialMethods[2] = InitialFont;
            if (backgroundCheck.CheckState == CheckState.Checked)
            {
                changingMethods[0]();
            }
            else
            {
                backToInitialMethods[0]();
            }
            if (fontColorCheck.CheckState == CheckState.Checked)
            {
                changingMethods[1]();
            }
            else
            {
                backToInitialMethods[1]();
            }
            if (fontCheck.CheckState == CheckState.Checked)
            {
                changingMethods[2]();
            }
            else
            {
                backToInitialMethods[2]();
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            activeMethodLabel.Text = "";
            string[] sortedTable = inputBox.Text.Split(' ');
            SortMethods compare = Compare;
            BubbleSort(sortedTable, compare);
            for (int i = 0; i < sortedTable.Length; i++)
            {
                outputBox.Text += sortedTable[i] + " ";
            }
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            activeMethodLabel.Text = "Square";
            ifSquare = true;
            ifRoot = false;
            ifReverse = false;
        }

        private void rootButton_Click(object sender, EventArgs e)
        {
            activeMethodLabel.Text = "Root";
            ifRoot = true;
            ifSquare = false;
            ifReverse = false;
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            activeMethodLabel.Text = "Reverse";
            ifReverse = true;
            ifSquare = false;
            ifRoot = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
        }

        private void clearInput_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.ControlKey)
            {
                ifControlOn = true;
                ctrlStatusLabel.Text = "On";
                ctrlStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                ifControlOn = false;
                ctrlStatusLabel.Text = "Off";
                ctrlStatusLabel.ForeColor = Color.Red;
            }
        }
        int nr = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            nr++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Click += button1_Click; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Click -= button1_Click;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            outputBox.Text = nr.ToString();
        }
    }
}
