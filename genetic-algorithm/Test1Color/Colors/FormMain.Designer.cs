namespace Colors
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
            this.btColorSelection = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logText = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panGraph = new System.Windows.Forms.Panel();
            this.btFind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btColorSelection
            // 
            this.btColorSelection.Location = new System.Drawing.Point(88, 258);
            this.btColorSelection.Name = "btColorSelection";
            this.btColorSelection.Size = new System.Drawing.Size(110, 23);
            this.btColorSelection.TabIndex = 0;
            this.btColorSelection.Text = "Выбор цвета";
            this.btColorSelection.UseVisualStyleBackColor = true;
            this.btColorSelection.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите цвет";
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(730, 42);
            this.logText.Name = "logText";
            this.logText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.logText.Size = new System.Drawing.Size(411, 627);
            this.logText.TabIndex = 3;
            this.logText.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(366, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Результирующий цвет";
            // 
            // panGraph
            // 
            this.panGraph.Location = new System.Drawing.Point(12, 412);
            this.panGraph.Name = "panGraph";
            this.panGraph.Size = new System.Drawing.Size(700, 257);
            this.panGraph.TabIndex = 5;
            // 
            // btFind
            // 
            this.btFind.Enabled = false;
            this.btFind.Location = new System.Drawing.Point(269, 82);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 6;
            this.btFind.Text = "Найти цвет";
            this.btFind.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(890, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Лог работы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(212, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Приближение особей к эталону";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.panGraph);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btColorSelection);
            this.Name = "FormMain";
            this.Text = "Генетический алгоритм - Подбор цвета";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btColorSelection;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox logText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panGraph;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

