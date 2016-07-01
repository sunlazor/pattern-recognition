namespace Genetic
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.logText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbGradation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btColorSelection
            // 
            this.btColorSelection.Location = new System.Drawing.Point(75, 72);
            this.btColorSelection.Name = "btColorSelection";
            this.btColorSelection.Size = new System.Drawing.Size(110, 23);
            this.btColorSelection.TabIndex = 0;
            this.btColorSelection.Text = "Выбор цвета";
            this.btColorSelection.UseVisualStyleBackColor = true;
            this.btColorSelection.Click += new System.EventHandler(this.button1_Click);
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(286, 56);
            this.logText.Name = "logText";
            this.logText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.logText.Size = new System.Drawing.Size(411, 627);
            this.logText.TabIndex = 3;
            this.logText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(446, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Лог работы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество поколений";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(109, 222);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(54, 20);
            this.tbResult.TabIndex = 9;
            // 
            // tbGradation
            // 
            this.tbGradation.Location = new System.Drawing.Point(82, 38);
            this.tbGradation.Name = "tbGradation";
            this.tbGradation.Size = new System.Drawing.Size(100, 20);
            this.tbGradation.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Градация серого";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 698);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGradation);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.btColorSelection);
            this.Name = "FormMain";
            this.Text = "Генетический алгоритм - Подбор цвета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btColorSelection;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.RichTextBox logText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbGradation;
        private System.Windows.Forms.Label label2;
    }
}

