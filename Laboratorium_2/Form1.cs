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

        public delegate string ActiveStatus(string activeStatus);
        private string strStatus(string status) => activeMethodLabel.Text = status;


        public delegate double Operation(double x);
        private double Square(double x) => x * x;
        private double Root(double x) => Math.Sqrt(x);
        private double Reverse(double x) => 1 / x;


        public double[] NumberCollection(double[] tab, Operation op)
        {
            double[] tab2 = new double[tab.Length];
            for(int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = op(tab[i]);
            }
            return tab2;
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
                    double[] outputTable = NumberCollection(table, Square);
                    for(int i = 0; i < outputTable.Length; i++)
                    {
                        outputBox.Text += outputTable[i] + " ";
                    }
                }
                else if (ifRoot)
                {
                    double[] outputTable = NumberCollection(table, Root);
                    for (int i = 0; i < outputTable.Length; i++)
                    {
                        outputBox.Text += outputTable[i] + " ";
                    }
                }
                else if (ifReverse)
                {
                    double[] outputTable = NumberCollection(table, Reverse);
                    for (int i = 0; i < outputTable.Length; i++)
                    {
                        outputBox.Text += outputTable[i] + " ";
                    }
                }
            }
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            ActiveStatus activeStatus = strStatus;
            activeStatus("Square");
            ifSquare = true;
            ifRoot = false;
            ifReverse = false;
        }

        private void rootButton_Click(object sender, EventArgs e)
        {
            ActiveStatus activeStatus = strStatus;
            activeStatus("Root");
            ifRoot = true;
            ifSquare = false;
            ifReverse = false;
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            ActiveStatus activeStatus = strStatus;
            activeStatus("Reverse");
            ifReverse = true;
            ifSquare = false;
            ifRoot = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
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
