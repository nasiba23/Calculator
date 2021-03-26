using System.Windows.Forms;

namespace HomeworkLesson19
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._inputTxtBx = new System.Windows.Forms.RichTextBox();
            this._mcBtn = new System.Windows.Forms.Button();
            this._mrBtn = new System.Windows.Forms.Button();
            this._mPlusBtn = new System.Windows.Forms.Button();
            this._mMinusBtn = new System.Windows.Forms.Button();
            this._msBtn = new System.Windows.Forms.Button();
            this._mBtn = new System.Windows.Forms.Button();
            this._percentBtn = new System.Windows.Forms.Button();
            this._rootBtn = new System.Windows.Forms.Button();
            this._squaredBtn = new System.Windows.Forms.Button();
            this._invertBtn = new System.Windows.Forms.Button();
            this._cBtn = new System.Windows.Forms.Button();
            this._eightBtn = new System.Windows.Forms.Button();
            this._xBtn = new System.Windows.Forms.Button();
            this._multiplyBtn = new System.Windows.Forms.Button();
            this._divideBtn = new System.Windows.Forms.Button();
            this._nineBtn = new System.Windows.Forms.Button();
            this._ceBtn = new System.Windows.Forms.Button();
            this._sevenBtn = new System.Windows.Forms.Button();
            this._fourBtn = new System.Windows.Forms.Button();
            this._fiveBtn = new System.Windows.Forms.Button();
            this._sixBtn = new System.Windows.Forms.Button();
            this._minusBtn = new System.Windows.Forms.Button();
            this._oneBtn = new System.Windows.Forms.Button();
            this._twoBtn = new System.Windows.Forms.Button();
            this._threeBtn = new System.Windows.Forms.Button();
            this._plusBtn = new System.Windows.Forms.Button();
            this._signBtn = new System.Windows.Forms.Button();
            this._zeroBtn = new System.Windows.Forms.Button();
            this._pointBtn = new System.Windows.Forms.Button();
            this._equalBtn = new System.Windows.Forms.Button();
            this.operationTxtBx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _inputTxtBx
            // 
            this._inputTxtBx.Location = new System.Drawing.Point(1, 63);
            this._inputTxtBx.Margin = new System.Windows.Forms.Padding(0);
            this._inputTxtBx.Name = "_inputTxtBx";
            this._inputTxtBx.Size = new System.Drawing.Size(510, 111);
            this._inputTxtBx.TabIndex = 0;
            this._inputTxtBx.Text = "";
            // 
            // _mcBtn
            // 
            this._mcBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this._mcBtn.Location = new System.Drawing.Point(1, 177);
            this._mcBtn.Name = "_mcBtn";
            this._mcBtn.Size = new System.Drawing.Size(80, 45);
            this._mcBtn.TabIndex = 1;
            this._mcBtn.UseVisualStyleBackColor = false;
            // 
            // _mrBtn
            // 
            this._mrBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this._mrBtn.Location = new System.Drawing.Point(87, 177);
            this._mrBtn.Name = "_mrBtn";
            this._mrBtn.Size = new System.Drawing.Size(80, 45);
            this._mrBtn.TabIndex = 2;
            this._mrBtn.Text = "MR";
            this._mrBtn.UseVisualStyleBackColor = false;
            this._mrBtn.Click += new System.EventHandler(this._mrBtn_Click);
            // 
            // _mPlusBtn
            // 
            this._mPlusBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this._mPlusBtn.Location = new System.Drawing.Point(173, 177);
            this._mPlusBtn.Name = "_mPlusBtn";
            this._mPlusBtn.Size = new System.Drawing.Size(80, 45);
            this._mPlusBtn.TabIndex = 3;
            this._mPlusBtn.Text = "M+";
            this._mPlusBtn.UseVisualStyleBackColor = false;
            this._mPlusBtn.Click += new System.EventHandler(this._mPlusBtn_Click);
            // 
            // _mMinusBtn
            // 
            this._mMinusBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this._mMinusBtn.Location = new System.Drawing.Point(259, 177);
            this._mMinusBtn.Name = "_mMinusBtn";
            this._mMinusBtn.Size = new System.Drawing.Size(80, 45);
            this._mMinusBtn.TabIndex = 4;
            this._mMinusBtn.Text = "MC";
            this._mMinusBtn.UseVisualStyleBackColor = false;
            this._mMinusBtn.Click += new System.EventHandler(this._mMinusBtn_Click);
            // 
            // _msBtn
            // 
            this._msBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this._msBtn.Location = new System.Drawing.Point(345, 177);
            this._msBtn.Name = "_msBtn";
            this._msBtn.Size = new System.Drawing.Size(80, 45);
            this._msBtn.TabIndex = 5;
            this._msBtn.Text = "MS";
            this._msBtn.UseVisualStyleBackColor = false;
            this._msBtn.Click += new System.EventHandler(this._msBtn_Click);
            // 
            // _mBtn
            // 
            this._mBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this._mBtn.Location = new System.Drawing.Point(431, 177);
            this._mBtn.Name = "_mBtn";
            this._mBtn.Size = new System.Drawing.Size(80, 45);
            this._mBtn.TabIndex = 6;
            this._mBtn.UseVisualStyleBackColor = false;
            // 
            // _percentBtn
            // 
            this._percentBtn.Location = new System.Drawing.Point(1, 228);
            this._percentBtn.Name = "_percentBtn";
            this._percentBtn.Size = new System.Drawing.Size(123, 75);
            this._percentBtn.TabIndex = 7;
            this._percentBtn.Text = "%";
            this._percentBtn.UseVisualStyleBackColor = true;
            this._percentBtn.Click += new System.EventHandler(this._percentBtn_Click);
            // 
            // _rootBtn
            // 
            this._rootBtn.Location = new System.Drawing.Point(130, 228);
            this._rootBtn.Name = "_rootBtn";
            this._rootBtn.Size = new System.Drawing.Size(123, 75);
            this._rootBtn.TabIndex = 8;
            this._rootBtn.Text = "√";
            this._rootBtn.UseVisualStyleBackColor = true;
            this._rootBtn.Click += new System.EventHandler(this._rootBtn_Click);
            // 
            // _squaredBtn
            // 
            this._squaredBtn.Location = new System.Drawing.Point(259, 228);
            this._squaredBtn.Name = "_squaredBtn";
            this._squaredBtn.Size = new System.Drawing.Size(123, 75);
            this._squaredBtn.TabIndex = 9;
            this._squaredBtn.Text = "x²";
            this._squaredBtn.UseVisualStyleBackColor = true;
            this._squaredBtn.Click += new System.EventHandler(this._squaredBtn_Click);
            // 
            // _invertBtn
            // 
            this._invertBtn.Location = new System.Drawing.Point(388, 228);
            this._invertBtn.Name = "_invertBtn";
            this._invertBtn.Size = new System.Drawing.Size(123, 75);
            this._invertBtn.TabIndex = 10;
            this._invertBtn.Text = "1/x";
            this._invertBtn.UseVisualStyleBackColor = true;
            this._invertBtn.Click += new System.EventHandler(this._invertBtn_Click);
            // 
            // _cBtn
            // 
            this._cBtn.Location = new System.Drawing.Point(130, 309);
            this._cBtn.Name = "_cBtn";
            this._cBtn.Size = new System.Drawing.Size(123, 75);
            this._cBtn.TabIndex = 11;
            this._cBtn.Text = "C";
            this._cBtn.UseVisualStyleBackColor = true;
            this._cBtn.Click += new System.EventHandler(this._cBtn_Click);
            // 
            // _eightBtn
            // 
            this._eightBtn.BackColor = System.Drawing.SystemColors.Window;
            this._eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._eightBtn.Location = new System.Drawing.Point(130, 390);
            this._eightBtn.Name = "_eightBtn";
            this._eightBtn.Size = new System.Drawing.Size(123, 75);
            this._eightBtn.TabIndex = 12;
            this._eightBtn.Text = "8";
            this._eightBtn.UseVisualStyleBackColor = false;
            this._eightBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // _xBtn
            // 
            this._xBtn.Location = new System.Drawing.Point(259, 309);
            this._xBtn.Name = "_xBtn";
            this._xBtn.Size = new System.Drawing.Size(123, 75);
            this._xBtn.TabIndex = 13;
            this._xBtn.Text = "<=";
            this._xBtn.UseVisualStyleBackColor = true;
            this._xBtn.Click += new System.EventHandler(this._xBtn_Click);
            // 
            // _multiplyBtn
            // 
            this._multiplyBtn.Location = new System.Drawing.Point(388, 390);
            this._multiplyBtn.Name = "_multiplyBtn";
            this._multiplyBtn.Size = new System.Drawing.Size(123, 75);
            this._multiplyBtn.TabIndex = 14;
            this._multiplyBtn.Text = "*";
            this._multiplyBtn.UseVisualStyleBackColor = true;
            this._multiplyBtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // _divideBtn
            // 
            this._divideBtn.Location = new System.Drawing.Point(388, 309);
            this._divideBtn.Name = "_divideBtn";
            this._divideBtn.Size = new System.Drawing.Size(123, 75);
            this._divideBtn.TabIndex = 15;
            this._divideBtn.Text = "/";
            this._divideBtn.UseVisualStyleBackColor = true;
            this._divideBtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // _nineBtn
            // 
            this._nineBtn.BackColor = System.Drawing.SystemColors.Window;
            this._nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._nineBtn.Location = new System.Drawing.Point(259, 390);
            this._nineBtn.Name = "_nineBtn";
            this._nineBtn.Size = new System.Drawing.Size(123, 75);
            this._nineBtn.TabIndex = 16;
            this._nineBtn.Text = "9";
            this._nineBtn.UseVisualStyleBackColor = false;
            this._nineBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // _ceBtn
            // 
            this._ceBtn.Location = new System.Drawing.Point(1, 309);
            this._ceBtn.Name = "_ceBtn";
            this._ceBtn.Size = new System.Drawing.Size(123, 75);
            this._ceBtn.TabIndex = 17;
            this._ceBtn.Text = "CE";
            this._ceBtn.UseVisualStyleBackColor = true;
            this._ceBtn.Click += new System.EventHandler(this._ceBtn_Click);
            // 
            // _sevenBtn
            // 
            this._sevenBtn.BackColor = System.Drawing.SystemColors.Window;
            this._sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._sevenBtn.Location = new System.Drawing.Point(1, 390);
            this._sevenBtn.Name = "_sevenBtn";
            this._sevenBtn.Size = new System.Drawing.Size(123, 75);
            this._sevenBtn.TabIndex = 18;
            this._sevenBtn.Text = "7";
            this._sevenBtn.UseVisualStyleBackColor = false;
            this._sevenBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // _fourBtn
            // 
            this._fourBtn.BackColor = System.Drawing.SystemColors.Window;
            this._fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._fourBtn.Location = new System.Drawing.Point(1, 471);
            this._fourBtn.Name = "_fourBtn";
            this._fourBtn.Size = new System.Drawing.Size(123, 75);
            this._fourBtn.TabIndex = 19;
            this._fourBtn.Text = "4";
            this._fourBtn.UseVisualStyleBackColor = false;
            this._fourBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // _fiveBtn
            // 
            this._fiveBtn.BackColor = System.Drawing.SystemColors.Window;
            this._fiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._fiveBtn.Location = new System.Drawing.Point(130, 471);
            this._fiveBtn.Name = "_fiveBtn";
            this._fiveBtn.Size = new System.Drawing.Size(123, 75);
            this._fiveBtn.TabIndex = 20;
            this._fiveBtn.Text = "5";
            this._fiveBtn.UseVisualStyleBackColor = false;
            this._fiveBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // _sixBtn
            // 
            this._sixBtn.BackColor = System.Drawing.SystemColors.Window;
            this._sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._sixBtn.Location = new System.Drawing.Point(259, 471);
            this._sixBtn.Name = "_sixBtn";
            this._sixBtn.Size = new System.Drawing.Size(123, 75);
            this._sixBtn.TabIndex = 21;
            this._sixBtn.Text = "6";
            this._sixBtn.UseVisualStyleBackColor = false;
            this._sixBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // _minusBtn
            // 
            this._minusBtn.Location = new System.Drawing.Point(388, 471);
            this._minusBtn.Name = "_minusBtn";
            this._minusBtn.Size = new System.Drawing.Size(123, 75);
            this._minusBtn.TabIndex = 22;
            this._minusBtn.Text = "-";
            this._minusBtn.UseVisualStyleBackColor = true;
            this._minusBtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // _oneBtn
            // 
            this._oneBtn.BackColor = System.Drawing.SystemColors.Window;
            this._oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._oneBtn.Location = new System.Drawing.Point(1, 552);
            this._oneBtn.Name = "_oneBtn";
            this._oneBtn.Size = new System.Drawing.Size(123, 75);
            this._oneBtn.TabIndex = 23;
            this._oneBtn.Text = "1";
            this._oneBtn.UseVisualStyleBackColor = false;
            this._oneBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // _twoBtn
            // 
            this._twoBtn.BackColor = System.Drawing.SystemColors.Window;
            this._twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._twoBtn.Location = new System.Drawing.Point(130, 552);
            this._twoBtn.Name = "_twoBtn";
            this._twoBtn.Size = new System.Drawing.Size(123, 75);
            this._twoBtn.TabIndex = 24;
            this._twoBtn.Text = "2";
            this._twoBtn.UseVisualStyleBackColor = false;
            this._twoBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // _threeBtn
            // 
            this._threeBtn.BackColor = System.Drawing.SystemColors.Window;
            this._threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._threeBtn.Location = new System.Drawing.Point(259, 552);
            this._threeBtn.Name = "_threeBtn";
            this._threeBtn.Size = new System.Drawing.Size(123, 75);
            this._threeBtn.TabIndex = 25;
            this._threeBtn.Text = "3";
            this._threeBtn.UseVisualStyleBackColor = false;
            this._threeBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // _plusBtn
            // 
            this._plusBtn.Location = new System.Drawing.Point(388, 552);
            this._plusBtn.Name = "_plusBtn";
            this._plusBtn.Size = new System.Drawing.Size(123, 75);
            this._plusBtn.TabIndex = 26;
            this._plusBtn.Text = "+";
            this._plusBtn.UseVisualStyleBackColor = true;
            this._plusBtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // _signBtn
            // 
            this._signBtn.Location = new System.Drawing.Point(1, 633);
            this._signBtn.Name = "_signBtn";
            this._signBtn.Size = new System.Drawing.Size(123, 75);
            this._signBtn.TabIndex = 27;
            this._signBtn.Text = "+-";
            this._signBtn.UseVisualStyleBackColor = true;
            this._signBtn.Click += new System.EventHandler(this._signBtn_Click);
            // 
            // _zeroBtn
            // 
            this._zeroBtn.BackColor = System.Drawing.SystemColors.Window;
            this._zeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._zeroBtn.Location = new System.Drawing.Point(130, 633);
            this._zeroBtn.Name = "_zeroBtn";
            this._zeroBtn.Size = new System.Drawing.Size(123, 75);
            this._zeroBtn.TabIndex = 28;
            this._zeroBtn.Text = "0";
            this._zeroBtn.UseVisualStyleBackColor = false;
            this._zeroBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // _pointBtn
            // 
            this._pointBtn.Location = new System.Drawing.Point(259, 633);
            this._pointBtn.Name = "_pointBtn";
            this._pointBtn.Size = new System.Drawing.Size(123, 75);
            this._pointBtn.TabIndex = 29;
            this._pointBtn.Text = ".";
            this._pointBtn.UseVisualStyleBackColor = true;
            this._pointBtn.Click += new System.EventHandler(this._pointBtn_Click);
            // 
            // _equalBtn
            // 
            this._equalBtn.Location = new System.Drawing.Point(388, 633);
            this._equalBtn.Name = "_equalBtn";
            this._equalBtn.Size = new System.Drawing.Size(123, 75);
            this._equalBtn.TabIndex = 30;
            this._equalBtn.Text = "=";
            this._equalBtn.UseVisualStyleBackColor = true;
            this._equalBtn.Click += new System.EventHandler(this._equalBtn_Click);
            // 
            // operationTxtBx
            // 
            this.operationTxtBx.Location = new System.Drawing.Point(1, 4);
            this.operationTxtBx.Margin = new System.Windows.Forms.Padding(0);
            this.operationTxtBx.Name = "operationTxtBx";
            this.operationTxtBx.Size = new System.Drawing.Size(510, 59);
            this.operationTxtBx.TabIndex = 31;
            this.operationTxtBx.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 724);
            this.Controls.Add(this.operationTxtBx);
            this.Controls.Add(this._equalBtn);
            this.Controls.Add(this._pointBtn);
            this.Controls.Add(this._zeroBtn);
            this.Controls.Add(this._signBtn);
            this.Controls.Add(this._plusBtn);
            this.Controls.Add(this._threeBtn);
            this.Controls.Add(this._twoBtn);
            this.Controls.Add(this._oneBtn);
            this.Controls.Add(this._minusBtn);
            this.Controls.Add(this._sixBtn);
            this.Controls.Add(this._fiveBtn);
            this.Controls.Add(this._fourBtn);
            this.Controls.Add(this._sevenBtn);
            this.Controls.Add(this._ceBtn);
            this.Controls.Add(this._nineBtn);
            this.Controls.Add(this._divideBtn);
            this.Controls.Add(this._multiplyBtn);
            this.Controls.Add(this._xBtn);
            this.Controls.Add(this._eightBtn);
            this.Controls.Add(this._cBtn);
            this.Controls.Add(this._invertBtn);
            this.Controls.Add(this._squaredBtn);
            this.Controls.Add(this._rootBtn);
            this.Controls.Add(this._percentBtn);
            this.Controls.Add(this._mBtn);
            this.Controls.Add(this._msBtn);
            this.Controls.Add(this._mMinusBtn);
            this.Controls.Add(this._mPlusBtn);
            this.Controls.Add(this._mrBtn);
            this.Controls.Add(this._mcBtn);
            this.Controls.Add(this._inputTxtBx);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox operationTxtBx;

        private RichTextBox _inputTxtBx;
        private Button _mcBtn;
        private Button _mrBtn;
        private Button _mPlusBtn;
        private Button _mMinusBtn;
        private Button _msBtn;
        private Button _mBtn;
        private Button _percentBtn;
        private Button _rootBtn;
        private Button _squaredBtn;
        private Button _invertBtn;
        private Button _cBtn;
        private Button _eightBtn;
        private Button _xBtn;
        private Button _multiplyBtn;
        private Button _divideBtn;
        private Button _nineBtn;
        private Button _ceBtn;
        private Button _sevenBtn;
        private Button _fourBtn;
        private Button _fiveBtn;
        private Button _sixBtn;
        private Button _minusBtn;
        private Button _oneBtn;
        private Button _twoBtn;
        private Button _threeBtn;
        private Button _plusBtn;
        private Button _signBtn;
        private Button _zeroBtn;
        private Button _pointBtn;
        private Button _equalBtn;

        #endregion
    }
}