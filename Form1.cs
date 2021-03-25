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

        private void _btn_Click(object sender, EventArgs e)
        {
            if (_isEqualClicked)
            {
                _inputTxtBx.Text = "";
            }
            var a = sender as Button;
            _inputTxtBx.Text += a.Text;
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

        private void _plusBtn_Click(object sender, EventArgs e)
        {
            _isEqualClicked = false;
            operationTxtBx.Text += _inputTxtBx.Text + " + ";
            //TODO: сделать так, чтобы текст инпута плюсовался при каждом нажатии +
            _inputTxtBx.Text = "";
        }

        private void _equalBtn_Click(object sender, EventArgs e)
        {
            if (_inputTxtBx.Text.Length > 0)
            {
                operationTxtBx.Text += _inputTxtBx.Text;
            }

            if (!string.IsNullOrEmpty(operationTxtBx.Text.LastOrDefault(Char.IsPunctuation).ToString()))
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