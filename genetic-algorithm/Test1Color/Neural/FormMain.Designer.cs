namespace Neural
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btWhite = new System.Windows.Forms.Button();
            this.btBlack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btTeach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btWhite);
            this.groupBox1.Controls.Add(this.btBlack);
            this.groupBox1.Location = new System.Drawing.Point(121, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подать";
            // 
            // btWhite
            // 
            this.btWhite.Location = new System.Drawing.Point(6, 48);
            this.btWhite.Name = "btWhite";
            this.btWhite.Size = new System.Drawing.Size(75, 23);
            this.btWhite.TabIndex = 1;
            this.btWhite.Text = "Белый";
            this.btWhite.UseVisualStyleBackColor = true;
            // 
            // btBlack
            // 
            this.btBlack.Location = new System.Drawing.Point(6, 19);
            this.btBlack.Name = "btBlack";
            this.btBlack.Size = new System.Drawing.Size(75, 23);
            this.btBlack.TabIndex = 0;
            this.btBlack.Text = "Черный";
            this.btBlack.UseVisualStyleBackColor = true;
            this.btBlack.Click += new System.EventHandler(this.btBlack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Подан:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btTeach
            // 
            this.btTeach.Location = new System.Drawing.Point(12, 12);
            this.btTeach.Name = "btTeach";
            this.btTeach.Size = new System.Drawing.Size(75, 23);
            this.btTeach.TabIndex = 5;
            this.btTeach.Text = "Обучение";
            this.btTeach.UseVisualStyleBackColor = true;
            this.btTeach.Click += new System.EventHandler(this.btTeach_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 151);
            this.Controls.Add(this.btTeach);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Нейронная сеть - Распознование цвета";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btWhite;
        private System.Windows.Forms.Button btBlack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btTeach;
    }
}

