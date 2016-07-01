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
            this.btGray = new System.Windows.Forms.Button();
            this.btWhite = new System.Windows.Forms.Button();
            this.btBlack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBlack = new System.Windows.Forms.TextBox();
            this.btTeach = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbWhite = new System.Windows.Forms.TextBox();
            this.tbGray = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGray);
            this.groupBox1.Controls.Add(this.btWhite);
            this.groupBox1.Controls.Add(this.btBlack);
            this.groupBox1.Location = new System.Drawing.Point(19, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подать";
            // 
            // btGray
            // 
            this.btGray.Location = new System.Drawing.Point(6, 48);
            this.btGray.Name = "btGray";
            this.btGray.Size = new System.Drawing.Size(75, 23);
            this.btGray.TabIndex = 2;
            this.btGray.Text = "Серый";
            this.btGray.UseVisualStyleBackColor = true;
            this.btGray.Click += new System.EventHandler(this.btGray_Click);
            // 
            // btWhite
            // 
            this.btWhite.Location = new System.Drawing.Point(6, 76);
            this.btWhite.Name = "btWhite";
            this.btWhite.Size = new System.Drawing.Size(75, 23);
            this.btWhite.TabIndex = 1;
            this.btWhite.Text = "Белый";
            this.btWhite.UseVisualStyleBackColor = true;
            this.btWhite.Click += new System.EventHandler(this.btWhite_Click);
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
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вероятности";
            // 
            // tbBlack
            // 
            this.tbBlack.Location = new System.Drawing.Point(65, 33);
            this.tbBlack.Name = "tbBlack";
            this.tbBlack.ReadOnly = true;
            this.tbBlack.Size = new System.Drawing.Size(131, 20);
            this.tbBlack.TabIndex = 4;
            // 
            // btTeach
            // 
            this.btTeach.Location = new System.Drawing.Point(25, 12);
            this.btTeach.Name = "btTeach";
            this.btTeach.Size = new System.Drawing.Size(75, 23);
            this.btTeach.TabIndex = 5;
            this.btTeach.Text = "Обучение";
            this.btTeach.UseVisualStyleBackColor = true;
            this.btTeach.Click += new System.EventHandler(this.btTeach_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btTeach);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbWhite);
            this.splitContainer1.Panel2.Controls.Add(this.tbGray);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tbBlack);
            this.splitContainer1.Size = new System.Drawing.Size(334, 240);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 6;
            // 
            // tbWhite
            // 
            this.tbWhite.Location = new System.Drawing.Point(65, 82);
            this.tbWhite.Name = "tbWhite";
            this.tbWhite.ReadOnly = true;
            this.tbWhite.Size = new System.Drawing.Size(131, 20);
            this.tbWhite.TabIndex = 9;
            // 
            // tbGray
            // 
            this.tbGray.Location = new System.Drawing.Point(65, 57);
            this.tbGray.Name = "tbGray";
            this.tbGray.ReadOnly = true;
            this.tbGray.Size = new System.Drawing.Size(131, 20);
            this.tbGray.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Белый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Серый";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Черный";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 240);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.Text = "Нейронная сеть - Распознование цвета";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btWhite;
        private System.Windows.Forms.Button btBlack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBlack;
        private System.Windows.Forms.Button btTeach;
        private System.Windows.Forms.Button btGray;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbWhite;
        private System.Windows.Forms.TextBox tbGray;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

