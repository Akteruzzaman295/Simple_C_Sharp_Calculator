
namespace Simple_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLeftOperand = new System.Windows.Forms.TextBox();
            this.txtRightOperand = new System.Windows.Forms.TextBox();
            this.txtExpretion = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdModu = new System.Windows.Forms.RadioButton();
            this.rdDiv = new System.Windows.Forms.RadioButton();
            this.rdMul = new System.Windows.Forms.RadioButton();
            this.rdSub = new System.Windows.Forms.RadioButton();
            this.rdAdd = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left Operand :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Right Operand :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Expression :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Result :";
            // 
            // txtLeftOperand
            // 
            this.txtLeftOperand.Location = new System.Drawing.Point(49, 66);
            this.txtLeftOperand.Name = "txtLeftOperand";
            this.txtLeftOperand.Size = new System.Drawing.Size(179, 20);
            this.txtLeftOperand.TabIndex = 0;
            // 
            // txtRightOperand
            // 
            this.txtRightOperand.Location = new System.Drawing.Point(379, 66);
            this.txtRightOperand.Name = "txtRightOperand";
            this.txtRightOperand.Size = new System.Drawing.Size(179, 20);
            this.txtRightOperand.TabIndex = 1;
            // 
            // txtExpretion
            // 
            this.txtExpretion.Location = new System.Drawing.Point(212, 429);
            this.txtExpretion.Name = "txtExpretion";
            this.txtExpretion.ReadOnly = true;
            this.txtExpretion.Size = new System.Drawing.Size(190, 20);
            this.txtExpretion.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(212, 484);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(190, 20);
            this.txtResult.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdModu);
            this.groupBox1.Controls.Add(this.rdDiv);
            this.groupBox1.Controls.Add(this.rdMul);
            this.groupBox1.Controls.Add(this.rdSub);
            this.groupBox1.Controls.Add(this.rdAdd);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(187, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 223);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operators :";
            // 
            // rdModu
            // 
            this.rdModu.AutoSize = true;
            this.rdModu.Location = new System.Drawing.Point(83, 163);
            this.rdModu.Name = "rdModu";
            this.rdModu.Size = new System.Drawing.Size(42, 27);
            this.rdModu.TabIndex = 0;
            this.rdModu.TabStop = true;
            this.rdModu.Text = "%";
            this.rdModu.UseVisualStyleBackColor = true;
            this.rdModu.CheckedChanged += new System.EventHandler(this.rdModu_CheckedChanged);
            // 
            // rdDiv
            // 
            this.rdDiv.AutoSize = true;
            this.rdDiv.Location = new System.Drawing.Point(83, 130);
            this.rdDiv.Name = "rdDiv";
            this.rdDiv.Size = new System.Drawing.Size(36, 27);
            this.rdDiv.TabIndex = 0;
            this.rdDiv.TabStop = true;
            this.rdDiv.Text = "/";
            this.rdDiv.UseVisualStyleBackColor = true;
            this.rdDiv.CheckedChanged += new System.EventHandler(this.rdDiv_CheckedChanged);
            // 
            // rdMul
            // 
            this.rdMul.AutoSize = true;
            this.rdMul.Location = new System.Drawing.Point(83, 97);
            this.rdMul.Name = "rdMul";
            this.rdMul.Size = new System.Drawing.Size(37, 27);
            this.rdMul.TabIndex = 0;
            this.rdMul.TabStop = true;
            this.rdMul.Text = "*";
            this.rdMul.UseVisualStyleBackColor = true;
            this.rdMul.CheckedChanged += new System.EventHandler(this.rdMul_CheckedChanged);
            // 
            // rdSub
            // 
            this.rdSub.AutoSize = true;
            this.rdSub.Location = new System.Drawing.Point(83, 64);
            this.rdSub.Name = "rdSub";
            this.rdSub.Size = new System.Drawing.Size(34, 27);
            this.rdSub.TabIndex = 0;
            this.rdSub.TabStop = true;
            this.rdSub.Text = "-";
            this.rdSub.UseVisualStyleBackColor = true;
            this.rdSub.CheckedChanged += new System.EventHandler(this.rdSub_CheckedChanged);
            // 
            // rdAdd
            // 
            this.rdAdd.AutoSize = true;
            this.rdAdd.Location = new System.Drawing.Point(83, 31);
            this.rdAdd.Name = "rdAdd";
            this.rdAdd.Size = new System.Drawing.Size(37, 27);
            this.rdAdd.TabIndex = 0;
            this.rdAdd.TabStop = true;
            this.rdAdd.Text = "+";
            this.rdAdd.UseVisualStyleBackColor = true;
            this.rdAdd.CheckedChanged += new System.EventHandler(this.rdAdd_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(77, 365);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 31);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 519);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtExpretion);
            this.Controls.Add(this.txtRightOperand);
            this.Controls.Add(this.txtLeftOperand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLeftOperand;
        private System.Windows.Forms.TextBox txtRightOperand;
        private System.Windows.Forms.TextBox txtExpretion;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdModu;
        private System.Windows.Forms.RadioButton rdDiv;
        private System.Windows.Forms.RadioButton rdMul;
        private System.Windows.Forms.RadioButton rdSub;
        private System.Windows.Forms.RadioButton rdAdd;
        private System.Windows.Forms.Button btnCalculate;
    }
}

