﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        double value, result = 0;
        string operation = "";        
        bool operationPressed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "0":
                    backspace.PerformClick();
                    zero.PerformClick();
                    break;
                case "1":
                    backspace.PerformClick();
                    one.PerformClick();
                    break;
                case "2":
                    backspace.PerformClick();
                    two.PerformClick();
                    break;
                case "3":
                    backspace.PerformClick();
                    three.PerformClick();
                    break;
                case "4":
                    backspace.PerformClick();
                    four.PerformClick();
                    break;
                case "5":
                    backspace.PerformClick();
                    five.PerformClick();
                    break;
                case "6":
                    //six.PerformClick();
                    break;
                case "7":
                    //seven.PerformClick();
                    break;
                case "8":
                    //eight.PerformClick();
                    break;
                case "9":
                    //nine.PerformClick();
                    break;
                case ".":
                    //point.PerformClick();
                    break;
                case "+":
                    //addition.PerformClick();
                    break;
                case "-":
                    //subtract.PerformClick();
                    break;
                case "*":
                    //multiply.PerformClick();
                    break;
                case "/":
                    //divide.PerformClick();
                    break;
                case "ENTER":
                    //equals.PerformClick();
                    break;
                deault:
                    break;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((tB1.Text == "0") || operationPressed)
            {
                tB1.Clear();
            }
            operationPressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!tB1.Text.Contains("."))
                {
                    tB1.Text = tB1.Text + b.Text;
                }
            }
            else
            {
                tB1.Text = tB1.Text + b.Text;
            }
            this.Focus();
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (tB1.Text.Length == 1)
            {
                tB1.Text = "0";
            }
            else
            {
                tB1.Text = tB1.Text.Substring(0, tB1.Text.Length - 1);
                value = double.Parse(tB1.Text);
            }
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            tB1.Text = "0";            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tB1.Text = "0";            
            operation = "";
            value = 0;
            lbl1.Text = "";
        }

        private void inverse_Click(object sender, EventArgs e)
        {
            value = double.Parse(tB1.Text);            
            tB1.Text = (1 / value).ToString();
            operationPressed = false;
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            value = double.Parse(tB1.Text);
            tB1.Text = (-1 * value).ToString();
            operationPressed = false;
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            value = double.Parse(tB1.Text);
            tB1.Text = Math.Sqrt(value).ToString();
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                equals.PerformClick();
                operationPressed = true;
                operation = b.Text;
                lbl1.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = double.Parse(tB1.Text);
                operationPressed = true;
                lbl1.Text = value + " " + operation;
            }
        }        

        private void equals_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                value = double.Parse(tB1.Text);
                tB1.Text = Math.Sqrt(value).ToString();
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        tB1.Text = (value + double.Parse(tB1.Text)).ToString();                        
                        break;
                    case "-":
                        tB1.Text = (value - double.Parse(tB1.Text)).ToString();
                        break;
                    case "*":
                        tB1.Text = (value * double.Parse(tB1.Text)).ToString();
                        break;
                    case "/":
                        tB1.Text = (value / double.Parse(tB1.Text)).ToString();
                        break;
                    case "%":
                        tB1.Text = (value % double.Parse(tB1.Text)).ToString();
                        break;
                    default:
                        break;
                }                
            }
            value = double.Parse(tB1.Text);
        }
    }
}
