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
            this.pChosenOne = new System.Windows.Forms.Panel();
            this.lbColorSelection = new System.Windows.Forms.Label();
            this.logText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.pChosenOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // btColorSelection
            // 
            this.btColorSelection.Location = new System.Drawing.Point(88, 148);
            this.btColorSelection.Name = "btColorSelection";
            this.btColorSelection.Size = new System.Drawing.Size(110, 23);
            this.btColorSelection.TabIndex = 0;
            this.btColorSelection.Text = "Выбор цвета";
            this.btColorSelection.UseVisualStyleBackColor = true;
            this.btColorSelection.Click += new System.EventHandler(this.button1_Click);
            // 
            // pChosenOne
            // 
            this.pChosenOne.Controls.Add(this.lbColorSelection);
            this.pChosenOne.Location = new System.Drawing.Point(42, 42);
            this.pChosenOne.Name = "pChosenOne";
            this.pChosenOne.Size = new System.Drawing.Size(200, 100);
            this.pChosenOne.TabIndex = 2;
            // 
            // lbColorSelection
            // 
            this.lbColorSelection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbColorSelection.AutoSize = true;
            this.lbColorSelection.Location = new System.Drawing.Point(60, 40);
            this.lbColorSelection.Name = "lbColorSelection";
            this.lbColorSelection.Size = new System.Drawing.Size(83, 13);
            this.lbColorSelection.TabIndex = 0;
            this.lbColorSelection.Text = "Выберите цвет";
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 698);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.pChosenOne);
            this.Controls.Add(this.btColorSelection);
            this.Name = "FormMain";
            this.Text = "Генетический алгоритм - Подбор цвета";
            this.pChosenOne.ResumeLayout(false);
            this.pChosenOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btColorSelection;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel pChosenOne;
        private System.Windows.Forms.RichTextBox logText;
        private System.Windows.Forms.Label lbColorSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResult;
    }
}

