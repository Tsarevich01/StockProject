namespace StockProjectView
{
    partial class FormStock
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
            this.textBoxSumInNDS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxBarcode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxSumInNDS
            // 
            this.textBoxSumInNDS.Location = new System.Drawing.Point(12, 203);
            this.textBoxSumInNDS.Name = "textBoxSumInNDS";
            this.textBoxSumInNDS.Size = new System.Drawing.Size(192, 20);
            this.textBoxSumInNDS.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Сумма с НДС";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(12, 158);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(192, 20);
            this.textBoxSum.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Сумма";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(12, 115);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(192, 20);
            this.textBoxCount.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Штрихкод";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название";
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(12, 28);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(192, 21);
            this.comboBoxName.TabIndex = 22;
            // 
            // comboBoxBarcode
            // 
            this.comboBoxBarcode.FormattingEnabled = true;
            this.comboBoxBarcode.Location = new System.Drawing.Point(12, 74);
            this.comboBoxBarcode.Name = "comboBoxBarcode";
            this.comboBoxBarcode.Size = new System.Drawing.Size(192, 21);
            this.comboBoxBarcode.TabIndex = 22;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 244);
            this.Controls.Add(this.comboBoxBarcode);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.textBoxSumInNDS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStock";
            this.Text = "Добавление на склад";
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSumInNDS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxBarcode;
    }
}