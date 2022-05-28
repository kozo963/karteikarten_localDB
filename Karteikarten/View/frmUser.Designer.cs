namespace Karteikarten.View
{
    partial class frmUser
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbATxt = new System.Windows.Forms.TextBox();
            this.pbAImg = new System.Windows.Forms.PictureBox();
            this.tbQTxt = new System.Windows.Forms.TextBox();
            this.pbQImg = new System.Windows.Forms.PictureBox();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalQ = new System.Windows.Forms.Label();
            this.lblCorrectA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(811, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Answer Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Answer Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Question Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Question Image";
            // 
            // tbATxt
            // 
            this.tbATxt.Location = new System.Drawing.Point(604, 356);
            this.tbATxt.Multiline = true;
            this.tbATxt.Name = "tbATxt";
            this.tbATxt.ReadOnly = true;
            this.tbATxt.Size = new System.Drawing.Size(484, 276);
            this.tbATxt.TabIndex = 28;
            // 
            // pbAImg
            // 
            this.pbAImg.Location = new System.Drawing.Point(93, 356);
            this.pbAImg.Name = "pbAImg";
            this.pbAImg.Size = new System.Drawing.Size(484, 276);
            this.pbAImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAImg.TabIndex = 27;
            this.pbAImg.TabStop = false;
            // 
            // tbQTxt
            // 
            this.tbQTxt.Location = new System.Drawing.Point(604, 40);
            this.tbQTxt.Multiline = true;
            this.tbQTxt.Name = "tbQTxt";
            this.tbQTxt.ReadOnly = true;
            this.tbQTxt.Size = new System.Drawing.Size(484, 276);
            this.tbQTxt.TabIndex = 26;
            // 
            // pbQImg
            // 
            this.pbQImg.Location = new System.Drawing.Point(93, 40);
            this.pbQImg.Name = "pbQImg";
            this.pbQImg.Size = new System.Drawing.Size(484, 276);
            this.pbQImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQImg.TabIndex = 25;
            this.pbQImg.TabStop = false;
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAnswer.Location = new System.Drawing.Point(1115, 356);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(137, 50);
            this.btnShowAnswer.TabIndex = 33;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.BackColor = System.Drawing.Color.Lime;
            this.btnCorrect.Location = new System.Drawing.Point(1115, 593);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(67, 39);
            this.btnCorrect.TabIndex = 34;
            this.btnCorrect.Text = "✔";
            this.btnCorrect.UseVisualStyleBackColor = false;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1115, 638);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 39);
            this.btnNext.TabIndex = 36;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.BackColor = System.Drawing.Color.Red;
            this.btnFalse.Location = new System.Drawing.Point(1185, 593);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(67, 39);
            this.btnFalse.TabIndex = 37;
            this.btnFalse.Text = "❌";
            this.btnFalse.UseVisualStyleBackColor = false;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(27, 638);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 39);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1111, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Questions:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1111, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Correct Answers";
            // 
            // lblTotalQ
            // 
            this.lblTotalQ.AutoSize = true;
            this.lblTotalQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQ.Location = new System.Drawing.Point(1111, 70);
            this.lblTotalQ.Name = "lblTotalQ";
            this.lblTotalQ.Size = new System.Drawing.Size(18, 20);
            this.lblTotalQ.TabIndex = 42;
            this.lblTotalQ.Text = "0";
            // 
            // lblCorrectA
            // 
            this.lblCorrectA.AutoSize = true;
            this.lblCorrectA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectA.Location = new System.Drawing.Point(1111, 153);
            this.lblCorrectA.Name = "lblCorrectA";
            this.lblCorrectA.Size = new System.Drawing.Size(18, 20);
            this.lblCorrectA.TabIndex = 43;
            this.lblCorrectA.Text = "0";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 689);
            this.Controls.Add(this.lblCorrectA);
            this.Controls.Add(this.lblTotalQ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbATxt);
            this.Controls.Add(this.pbAImg);
            this.Controls.Add(this.tbQTxt);
            this.Controls.Add(this.pbQImg);
            this.Name = "frmUser";
            this.Text = "Learning";
            ((System.ComponentModel.ISupportInitialize)(this.pbAImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbATxt;
        private System.Windows.Forms.PictureBox pbAImg;
        private System.Windows.Forms.TextBox tbQTxt;
        private System.Windows.Forms.PictureBox pbQImg;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalQ;
        private System.Windows.Forms.Label lblCorrectA;
    }
}