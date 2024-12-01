namespace BasitHesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            txtResult = new TextBox();
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(1, 279);
            btnAdd.Margin = new Padding(5, 4, 5, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 28);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = SystemColors.ActiveCaption;
            btnSubtract.Location = new Point(119, 279);
            btnSubtract.Margin = new Padding(5, 4, 5, 4);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(118, 28);
            btnSubtract.TabIndex = 1;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ActiveCaption;
            btnMultiply.Location = new Point(237, 279);
            btnMultiply.Margin = new Padding(5, 4, 5, 4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(118, 28);
            btnMultiply.TabIndex = 2;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ActiveCaption;
            btnDivide.Location = new Point(356, 279);
            btnDivide.Margin = new Padding(5, 4, 5, 4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(118, 28);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // txtNumber1
            // 
            txtNumber1.BackColor = SystemColors.Window;
            txtNumber1.Location = new Point(130, 88);
            txtNumber1.Margin = new Padding(5, 4, 5, 4);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(155, 27);
            txtNumber1.TabIndex = 4;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(130, 160);
            txtNumber2.Margin = new Padding(5, 4, 5, 4);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(155, 27);
            txtNumber2.TabIndex = 5;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(130, 230);
            txtResult.Margin = new Padding(5, 4, 5, 4);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(155, 27);
            txtResult.TabIndex = 6;
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Location = new Point(177, 66);
            lblNumber1.Margin = new Padding(5, 0, 5, 0);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(89, 18);
            lblNumber1.TabIndex = 7;
            lblNumber1.Text = "Number1";

            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Location = new Point(177, 138);
            lblNumber2.Margin = new Padding(5, 0, 5, 0);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(89, 18);
            lblNumber2.TabIndex = 8;
            lblNumber2.Text = "Number2";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(177, 208);
            lblResult.Margin = new Padding(5, 0, 5, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(63, 18);
            lblResult.TabIndex = 9;
            lblResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(491, 395);
            Controls.Add(lblResult);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Controls.Add(txtResult);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private TextBox txtResult;
        private Label lblNumber1;
        private Label lblNumber2;
        private Label lblResult;
    }
}
