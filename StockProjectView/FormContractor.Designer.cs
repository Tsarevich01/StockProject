namespace StockProjectView
{
    partial class FormContractor
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
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComponentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLegalAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(12, 70);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(192, 20);
            this.textBoxCode.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Код";
            // 
            // textBoxComponentName
            // 
            this.textBoxComponentName.Location = new System.Drawing.Point(12, 27);
            this.textBoxComponentName.Name = "textBoxComponentName";
            this.textBoxComponentName.Size = new System.Drawing.Size(192, 20);
            this.textBoxComponentName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // textBoxConact
            // 
            this.textBoxConact.Location = new System.Drawing.Point(12, 156);
            this.textBoxConact.Name = "textBoxConact";
            this.textBoxConact.Size = new System.Drawing.Size(192, 20);
            this.textBoxConact.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Контакты";
            // 
            // textBoxLegalAdres
            // 
            this.textBoxLegalAdres.Location = new System.Drawing.Point(12, 113);
            this.textBoxLegalAdres.Name = "textBoxLegalAdres";
            this.textBoxLegalAdres.Size = new System.Drawing.Size(192, 20);
            this.textBoxLegalAdres.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Юридический адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 201);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(192, 20);
            this.textBoxEmail.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(126, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(45, 227);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 257);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxConact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLegalAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxComponentName);
            this.Controls.Add(this.label1);
            this.Name = "FormContractor";
            this.Text = "Поставщик";
            this.Load += new System.EventHandler(this.FormContractor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxComponentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLegalAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}