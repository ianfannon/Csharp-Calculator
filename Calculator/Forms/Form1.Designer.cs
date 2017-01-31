namespace Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(9, 76);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(45, 45);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.button_click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(60, 76);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(45, 45);
            this.btnEight.TabIndex = 1;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.button_click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(111, 76);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(45, 45);
            this.btnNine.TabIndex = 2;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.button_click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(190, 76);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(45, 45);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.operator_click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(241, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 45);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(241, 127);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(190, 127);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(45, 45);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(111, 127);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(45, 45);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.button_click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(60, 127);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(45, 45);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.button_click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(9, 127);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(45, 45);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.button_click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(190, 178);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(45, 45);
            this.btnSubtract.TabIndex = 13;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.operator_click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(111, 178);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(45, 45);
            this.btnThree.TabIndex = 12;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.button_click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(60, 178);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(45, 45);
            this.btnTwo.TabIndex = 11;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.button_click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(9, 178);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(45, 45);
            this.btnOne.TabIndex = 10;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.button_click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(241, 178);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(45, 96);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(190, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 47);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.operator_click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(111, 229);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(45, 45);
            this.btnDecimal.TabIndex = 17;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.button_click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(9, 229);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(96, 45);
            this.btnZero.TabIndex = 15;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.button_click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 41);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(278, 29);
            this.txtDisplay.TabIndex = 20;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.BackColor = System.Drawing.SystemColors.Window;
            this.txtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtLabel.Location = new System.Drawing.Point(12, 9);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(0, 24);
            this.txtLabel.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 283);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label txtLabel;
    }
}

