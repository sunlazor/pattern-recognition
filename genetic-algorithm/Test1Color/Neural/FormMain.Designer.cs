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
            this.tbBlack = new System.Windows.Forms.TextBox();
            this.btTeach = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbWhite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btRed = new System.Windows.Forms.Button();
            this.btOrange = new System.Windows.Forms.Button();
            this.btYellow = new System.Windows.Forms.Button();
            this.btGreen = new System.Windows.Forms.Button();
            this.btLightBlue = new System.Windows.Forms.Button();
            this.btBlue = new System.Windows.Forms.Button();
            this.btViolette = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbOrange = new System.Windows.Forms.TextBox();
            this.tbYellow = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.tbLightBlue = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.tbViolette = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btViolette);
            this.groupBox1.Controls.Add(this.btBlue);
            this.groupBox1.Controls.Add(this.btLightBlue);
            this.groupBox1.Controls.Add(this.btGreen);
            this.groupBox1.Controls.Add(this.btYellow);
            this.groupBox1.Controls.Add(this.btOrange);
            this.groupBox1.Controls.Add(this.btRed);
            this.groupBox1.Controls.Add(this.btWhite);
            this.groupBox1.Controls.Add(this.btBlack);
            this.groupBox1.Location = new System.Drawing.Point(19, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подать";
            // 
            // btWhite
            // 
            this.btWhite.Location = new System.Drawing.Point(6, 251);
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
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вероятности";
            // 
            // tbBlack
            // 
            this.tbBlack.Location = new System.Drawing.Point(99, 92);
            this.tbBlack.Name = "tbBlack";
            this.tbBlack.ReadOnly = true;
            this.tbBlack.Size = new System.Drawing.Size(97, 20);
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
            this.splitContainer1.Panel2.Controls.Add(this.tbViolette);
            this.splitContainer1.Panel2.Controls.Add(this.tbBlue);
            this.splitContainer1.Panel2.Controls.Add(this.tbLightBlue);
            this.splitContainer1.Panel2.Controls.Add(this.tbGreen);
            this.splitContainer1.Panel2.Controls.Add(this.tbYellow);
            this.splitContainer1.Panel2.Controls.Add(this.tbOrange);
            this.splitContainer1.Panel2.Controls.Add(this.tbRed);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbWhite);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tbBlack);
            this.splitContainer1.Size = new System.Drawing.Size(334, 383);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 6;
            // 
            // tbWhite
            // 
            this.tbWhite.Location = new System.Drawing.Point(99, 296);
            this.tbWhite.Name = "tbWhite";
            this.tbWhite.ReadOnly = true;
            this.tbWhite.Size = new System.Drawing.Size(97, 20);
            this.tbWhite.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Белый";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Черный";
            // 
            // btRed
            // 
            this.btRed.Location = new System.Drawing.Point(6, 48);
            this.btRed.Name = "btRed";
            this.btRed.Size = new System.Drawing.Size(75, 23);
            this.btRed.TabIndex = 2;
            this.btRed.Text = "Красный";
            this.btRed.UseVisualStyleBackColor = true;
            this.btRed.Click += new System.EventHandler(this.btRed_Click);
            // 
            // btOrange
            // 
            this.btOrange.Location = new System.Drawing.Point(6, 77);
            this.btOrange.Name = "btOrange";
            this.btOrange.Size = new System.Drawing.Size(75, 23);
            this.btOrange.TabIndex = 3;
            this.btOrange.Text = "Оранжевый";
            this.btOrange.UseVisualStyleBackColor = true;
            this.btOrange.Click += new System.EventHandler(this.btOrange_Click);
            // 
            // btYellow
            // 
            this.btYellow.Location = new System.Drawing.Point(6, 106);
            this.btYellow.Name = "btYellow";
            this.btYellow.Size = new System.Drawing.Size(75, 23);
            this.btYellow.TabIndex = 4;
            this.btYellow.Text = "Желтый";
            this.btYellow.UseVisualStyleBackColor = true;
            this.btYellow.Click += new System.EventHandler(this.btYellow_Click);
            // 
            // btGreen
            // 
            this.btGreen.Location = new System.Drawing.Point(6, 135);
            this.btGreen.Name = "btGreen";
            this.btGreen.Size = new System.Drawing.Size(75, 23);
            this.btGreen.TabIndex = 5;
            this.btGreen.Text = "Зеленый";
            this.btGreen.UseVisualStyleBackColor = true;
            this.btGreen.Click += new System.EventHandler(this.btGreen_Click);
            // 
            // btLightBlue
            // 
            this.btLightBlue.Location = new System.Drawing.Point(6, 164);
            this.btLightBlue.Name = "btLightBlue";
            this.btLightBlue.Size = new System.Drawing.Size(75, 23);
            this.btLightBlue.TabIndex = 6;
            this.btLightBlue.Text = "Голубой";
            this.btLightBlue.UseVisualStyleBackColor = true;
            this.btLightBlue.Click += new System.EventHandler(this.btLightBlue_Click);
            // 
            // btBlue
            // 
            this.btBlue.Location = new System.Drawing.Point(6, 193);
            this.btBlue.Name = "btBlue";
            this.btBlue.Size = new System.Drawing.Size(75, 23);
            this.btBlue.TabIndex = 7;
            this.btBlue.Text = "Синий";
            this.btBlue.UseVisualStyleBackColor = true;
            this.btBlue.Click += new System.EventHandler(this.btBlue_Click);
            // 
            // btViolette
            // 
            this.btViolette.Location = new System.Drawing.Point(6, 222);
            this.btViolette.Name = "btViolette";
            this.btViolette.Size = new System.Drawing.Size(75, 23);
            this.btViolette.TabIndex = 8;
            this.btViolette.Text = "Фиолетовый";
            this.btViolette.UseVisualStyleBackColor = true;
            this.btViolette.Click += new System.EventHandler(this.btViolette_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Красный";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Оранжевый";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Желтый";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Зеленый";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Голубой";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Синий";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Фиолетовый";
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(99, 118);
            this.tbRed.Name = "tbRed";
            this.tbRed.ReadOnly = true;
            this.tbRed.Size = new System.Drawing.Size(97, 20);
            this.tbRed.TabIndex = 17;
            // 
            // tbOrange
            // 
            this.tbOrange.Location = new System.Drawing.Point(99, 142);
            this.tbOrange.Name = "tbOrange";
            this.tbOrange.ReadOnly = true;
            this.tbOrange.Size = new System.Drawing.Size(97, 20);
            this.tbOrange.TabIndex = 18;
            // 
            // tbYellow
            // 
            this.tbYellow.Location = new System.Drawing.Point(99, 167);
            this.tbYellow.Name = "tbYellow";
            this.tbYellow.ReadOnly = true;
            this.tbYellow.Size = new System.Drawing.Size(97, 20);
            this.tbYellow.TabIndex = 19;
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(99, 193);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.ReadOnly = true;
            this.tbGreen.Size = new System.Drawing.Size(97, 20);
            this.tbGreen.TabIndex = 20;
            // 
            // tbLightBlue
            // 
            this.tbLightBlue.Location = new System.Drawing.Point(99, 218);
            this.tbLightBlue.Name = "tbLightBlue";
            this.tbLightBlue.ReadOnly = true;
            this.tbLightBlue.Size = new System.Drawing.Size(97, 20);
            this.tbLightBlue.TabIndex = 21;
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(99, 244);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.ReadOnly = true;
            this.tbBlue.Size = new System.Drawing.Size(97, 20);
            this.tbBlue.TabIndex = 22;
            // 
            // tbViolette
            // 
            this.tbViolette.Location = new System.Drawing.Point(99, 270);
            this.tbViolette.Name = "tbViolette";
            this.tbViolette.ReadOnly = true;
            this.tbViolette.Size = new System.Drawing.Size(97, 20);
            this.tbViolette.TabIndex = 23;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 383);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbWhite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btViolette;
        private System.Windows.Forms.Button btBlue;
        private System.Windows.Forms.Button btLightBlue;
        private System.Windows.Forms.Button btGreen;
        private System.Windows.Forms.Button btYellow;
        private System.Windows.Forms.Button btOrange;
        private System.Windows.Forms.Button btRed;
        private System.Windows.Forms.TextBox tbViolette;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.TextBox tbLightBlue;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.TextBox tbYellow;
        private System.Windows.Forms.TextBox tbOrange;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

