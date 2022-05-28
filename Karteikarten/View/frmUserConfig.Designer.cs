namespace Karteikarten.View
{
    partial class frmUserConfig
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
            this.cbl = new System.Windows.Forms.CheckedListBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbNum = new System.Windows.Forms.RadioButton();
            this.txtQNumber = new System.Windows.Forms.TextBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbl
            // 
            this.cbl.CheckOnClick = true;
            this.cbl.FormattingEnabled = true;
            this.cbl.Location = new System.Drawing.Point(29, 25);
            this.cbl.Name = "cbl";
            this.cbl.Size = new System.Drawing.Size(194, 169);
            this.cbl.TabIndex = 0;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(269, 25);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(86, 17);
            this.rbAll.TabIndex = 1;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All Questions";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbNum
            // 
            this.rbNum.AutoSize = true;
            this.rbNum.Location = new System.Drawing.Point(269, 48);
            this.rbNum.Name = "rbNum";
            this.rbNum.Size = new System.Drawing.Size(106, 17);
            this.rbNum.TabIndex = 2;
            this.rbNum.TabStop = true;
            this.rbNum.Text = "Specific Number:";
            this.rbNum.UseVisualStyleBackColor = true;
            this.rbNum.CheckedChanged += new System.EventHandler(this.rbNum_CheckedChanged);
            // 
            // txtQNumber
            // 
            this.txtQNumber.Location = new System.Drawing.Point(380, 48);
            this.txtQNumber.Name = "txtQNumber";
            this.txtQNumber.Size = new System.Drawing.Size(100, 20);
            this.txtQNumber.TabIndex = 3;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(29, 204);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 4;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.Location = new System.Drawing.Point(148, 204);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeselectAll.TabIndex = 5;
            this.btnDeselectAll.Text = "Deselect All";
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(29, 249);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(405, 249);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Themen To learn";
            // 
            // frmUserConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeselectAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.txtQNumber);
            this.Controls.Add(this.rbNum);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.cbl);
            this.Name = "frmUserConfig";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbl;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbNum;
        private System.Windows.Forms.TextBox txtQNumber;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
    }
}