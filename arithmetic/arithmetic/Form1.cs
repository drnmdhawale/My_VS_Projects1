﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int integerAnswer;
            
            firstNumber = 10;
            secondNumber = 32;

            integerAnswer = firstNumber + secondNumber;

            MessageBox.Show(integerAnswer.ToString());
        }

        private void btnAddFloats_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float floatAnswer;
            
            firstNumber = 10.5F;
            secondNumber = 32.4F;

            floatAnswer = firstNumber + secondNumber;

            MessageBox.Show(floatAnswer.ToString());

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int answerSubtract;
            answerSubtract = 50 - 25;
            MessageBox.Show(answerSubtract.ToString());
        }

        private void btnMixed_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int answer;

            firstNumber = 100;
            secondNumber = 75;
            thirdNumber = 50;

            answer = firstNumber + secondNumber;
            MessageBox.Show(answer.ToString());

            answer = firstNumber + secondNumber - thirdNumber;
            MessageBox.Show(answer.ToString());

            answer = (100 + 75) * 50;
            MessageBox.Show(answer.ToString());

            answer = (100 + 75) / 50;
            MessageBox.Show(answer.ToString());
        }
    }
}
