using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkLesson19
{
    public partial class Form1 : Form
    {
        private bool _isEqualClicked;
        private bool _isPointClicked;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void numberBtn_Click(object sender, EventArgs e)
        {
            if (_isEqualClicked)
            {
                _inputTxtBx.Text = "";
            }
            var op = sender as Button;
            _inputTxtBx.Text += op.Text;
        }

        private void _pointBtn_Click(object sender, EventArgs e)
        {
            if (_isPointClicked)
            {
                return;
            }
            _inputTxtBx.Text += ".";
            _isPointClicked = true;
        }

        private void _signBtn_Click(object sender, EventArgs e)
        {
            if (_inputTxtBx.Text.Contains("-"))
            {
                _inputTxtBx.Text = _inputTxtBx.Text.Remove(0, 1);
            }
            else
            {
                _inputTxtBx.Text = "-" + _inputTxtBx.Text;
            }
        }
        private void operator_Click(object sender, EventArgs e)
        {
            _isEqualClicked = false;
            var op = sender as Button;
            operationTxtBx.Text += $"{_inputTxtBx.Text} {op.Text} ";
            //TODO: сделать так, чтобы текст инпута умножал при каждом нажатии *
            _inputTxtBx.Text = "";
        }
        private void _percentBtn_Click(object sender, EventArgs e)
        {
            _isEqualClicked = false;
            var temp = operationTxtBx.Text;
            if (!string.IsNullOrEmpty(operationTxtBx.Text.LastOrDefault(Char.IsPunctuation).ToString()))
            {
                temp = operationTxtBx.Text.Remove(operationTxtBx.Text.Length - 2, 1);
            }
            var dt = new DataTable();
            var opResult = dt.Compute(temp, "");
            var result = double.Parse(opResult.ToString()) * 100 / double.Parse(_inputTxtBx.Text);
            operationTxtBx.Text += result.ToString();
            _inputTxtBx.Text = "";
        }

        private void _equalBtn_Click(object sender, EventArgs e)
        {
            if (_inputTxtBx.Text.Length > 0)
            {
                operationTxtBx.Text += _inputTxtBx.Text;
            }
            if ((operationTxtBx.Text.Select(ch => char.IsPunctuation(ch)).LastOrDefault()));
            {
                operationTxtBx.Text = operationTxtBx.Text.Remove(operationTxtBx.Text.Length - 2, 1);
            }
            var dt = new DataTable();
            var result = dt.Compute(operationTxtBx.Text, "");
            _inputTxtBx.Text = result.ToString();
            operationTxtBx.Text = "";
            _isEqualClicked = true;
        }
    }
}