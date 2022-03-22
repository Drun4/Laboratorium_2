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
        bool ifControlOn;
        Operation operations = null;

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
                outputBox.Text = operations(double.Parse(inputBox.Text)).ToString();
            }
            else if(ifControlOn)
            {
                string[] inputs = inputBox.Text.Split(' ');
                double[] table = new double[inputs.Length];
                for(int i = 0; i < table.Length; i++)
                {
                    table[i] = double.Parse(inputs[i]);
                }

                outputBox.Text = "";
                double[] outputTable = NumberCollection(table, operations);
                for(int i = 0; i < outputTable.Length; i++)
                {
                    outputBox.Text += outputTable[i] + " ";
                }
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            ChangingMethods changingMethods = null;
            BackToInitialMethods backToInitialMethods = null;

            if (backgroundCheck.CheckState == CheckState.Checked)
            {
                changingMethods += ChangeBackColor;
            }
            else
            {
                backToInitialMethods += InitialBackColor;
            }
            if (fontColorCheck.CheckState == CheckState.Checked)
            {
                changingMethods += ChangeFontColor;
            }
            else
            {
                backToInitialMethods += InitialFontColor;
            }
            if (fontCheck.CheckState == CheckState.Checked)
            {
                changingMethods += ChangeFont;
            }
            else
            {
                backToInitialMethods += InitialFont;
            }

            if(changingMethods != null)
            {
                changingMethods();
            }
            if (backToInitialMethods != null)
            {
                backToInitialMethods();
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
            operations += Square;
        }

        private void rootButton_Click(object sender, EventArgs e)
        {
            activeMethodLabel.Text = "Root";
            operations += Root;
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            activeMethodLabel.Text = "Reverse";
            operations += Reverse;
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
    }
}
