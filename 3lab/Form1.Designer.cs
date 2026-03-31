namespace _3lab
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
            cmbOperation = new ComboBox();
            txtFirst = new TextBox();
            txtSecond = new TextBox();
            txtResult = new TextBox();
            cmbFirstType = new ComboBox();
            cmbSecondType = new ComboBox();
            cmbResultType = new ComboBox();
            SuspendLayout();
            // 
            // cmbOperation
            // 
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "+", "-" });
            cmbOperation.Location = new Point(62, 88);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(68, 28);
            cmbOperation.TabIndex = 0;
            cmbOperation.Text = "+";
            cmbOperation.SelectedIndexChanged += cmbOperation_SelectedIndexChanged;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(168, 66);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(125, 27);
            txtFirst.TabIndex = 1;
            txtFirst.TextChanged += txtFirst_TextChanged;
            // 
            // txtSecond
            // 
            txtSecond.Location = new Point(168, 112);
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(125, 27);
            txtSecond.TabIndex = 2;
            txtSecond.TextChanged += txtSecond_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(62, 160);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(231, 27);
            txtResult.TabIndex = 3;
            // 
            // cmbFirstType
            // 
            cmbFirstType.FormattingEnabled = true;
            cmbFirstType.Location = new Point(310, 66);
            cmbFirstType.Name = "cmbFirstType";
            cmbFirstType.Size = new Size(45, 28);
            cmbFirstType.TabIndex = 4;
            cmbFirstType.SelectedIndexChanged += cmbFirstType_SelectedIndexChanged;
            // 
            // cmbSecondType
            // 
            cmbSecondType.FormattingEnabled = true;
            cmbSecondType.Location = new Point(310, 112);
            cmbSecondType.Name = "cmbSecondType";
            cmbSecondType.Size = new Size(45, 28);
            cmbSecondType.TabIndex = 5;
            cmbSecondType.SelectedIndexChanged += cmbSecondType_SelectedIndexChanged;
            // 
            // cmbResultType
            // 
            cmbResultType.FormattingEnabled = true;
            cmbResultType.Location = new Point(310, 159);
            cmbResultType.Name = "cmbResultType";
            cmbResultType.Size = new Size(45, 28);
            cmbResultType.TabIndex = 6;
            cmbResultType.SelectedIndexChanged += cmbResultType_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 242);
            Controls.Add(cmbResultType);
            Controls.Add(cmbSecondType);
            Controls.Add(cmbFirstType);
            Controls.Add(txtResult);
            Controls.Add(txtSecond);
            Controls.Add(txtFirst);
            Controls.Add(cmbOperation);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperation;
        private TextBox txtFirst;
        private TextBox txtSecond;
        private TextBox txtResult;
        private ComboBox cmbFirstType;
        private ComboBox cmbSecondType;
        private ComboBox cmbResultType;
    }
}
