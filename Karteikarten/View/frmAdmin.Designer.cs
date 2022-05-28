namespace Karteikarten.View
{
    partial class frmAdmin
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
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cbThema = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbATxt = new System.Windows.Forms.TextBox();
            this.btnAImg = new System.Windows.Forms.Button();
            this.pbAImg = new System.Windows.Forms.PictureBox();
            this.tbQTxt = new System.Windows.Forms.TextBox();
            this.pbQImg = new System.Windows.Forms.PictureBox();
            this.btnQImg = new System.Windows.Forms.Button();
            this.tabThema = new System.Windows.Forms.TabPage();
            this.cbThema_t = new System.Windows.Forms.ComboBox();
            this.txtThema = new System.Windows.Forms.TextBox();
            this.btnInsertThema = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabController.SuspendLayout();
            this.tabInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQImg)).BeginInit();
            this.tabThema.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabInsert);
            this.tabController.Controls.Add(this.tabThema);
            this.tabController.ItemSize = new System.Drawing.Size(10, 18);
            this.tabController.Location = new System.Drawing.Point(12, 12);
            this.tabController.Name = "tabController";
            this.tabController.Padding = new System.Drawing.Point(310, 3);
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1240, 639);
            this.tabController.TabIndex = 0;
            // 
            // tabInsert
            // 
            this.tabInsert.Controls.Add(this.label5);
            this.tabInsert.Controls.Add(this.cbThema);
            this.tabInsert.Controls.Add(this.label4);
            this.tabInsert.Controls.Add(this.label3);
            this.tabInsert.Controls.Add(this.label2);
            this.tabInsert.Controls.Add(this.label1);
            this.tabInsert.Controls.Add(this.tbATxt);
            this.tabInsert.Controls.Add(this.btnAImg);
            this.tabInsert.Controls.Add(this.pbAImg);
            this.tabInsert.Controls.Add(this.tbQTxt);
            this.tabInsert.Controls.Add(this.pbQImg);
            this.tabInsert.Controls.Add(this.btnQImg);
            this.tabInsert.Location = new System.Drawing.Point(4, 22);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsert.Size = new System.Drawing.Size(1232, 613);
            this.tabInsert.TabIndex = 0;
            this.tabInsert.Text = "Karte";
            this.tabInsert.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1149, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Thema";
            // 
            // cbThema
            // 
            this.cbThema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThema.FormattingEnabled = true;
            this.cbThema.Location = new System.Drawing.Point(1109, 41);
            this.cbThema.Name = "cbThema";
            this.cbThema.Size = new System.Drawing.Size(120, 21);
            this.cbThema.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(828, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Answer Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Answer Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(828, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Question Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Question Image";
            // 
            // tbATxt
            // 
            this.tbATxt.Location = new System.Drawing.Point(621, 327);
            this.tbATxt.Multiline = true;
            this.tbATxt.Name = "tbATxt";
            this.tbATxt.Size = new System.Drawing.Size(484, 276);
            this.tbATxt.TabIndex = 20;
            // 
            // btnAImg
            // 
            this.btnAImg.Location = new System.Drawing.Point(12, 316);
            this.btnAImg.Name = "btnAImg";
            this.btnAImg.Size = new System.Drawing.Size(92, 23);
            this.btnAImg.TabIndex = 19;
            this.btnAImg.Text = "Answer Image";
            this.btnAImg.UseVisualStyleBackColor = true;
            this.btnAImg.Click += new System.EventHandler(this.btnAImg_Click);
            // 
            // pbAImg
            // 
            this.pbAImg.Location = new System.Drawing.Point(110, 327);
            this.pbAImg.Name = "pbAImg";
            this.pbAImg.Size = new System.Drawing.Size(484, 276);
            this.pbAImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAImg.TabIndex = 18;
            this.pbAImg.TabStop = false;
            // 
            // tbQTxt
            // 
            this.tbQTxt.Location = new System.Drawing.Point(621, 22);
            this.tbQTxt.Multiline = true;
            this.tbQTxt.Name = "tbQTxt";
            this.tbQTxt.Size = new System.Drawing.Size(484, 276);
            this.tbQTxt.TabIndex = 17;
            // 
            // pbQImg
            // 
            this.pbQImg.Location = new System.Drawing.Point(110, 22);
            this.pbQImg.Name = "pbQImg";
            this.pbQImg.Size = new System.Drawing.Size(484, 276);
            this.pbQImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQImg.TabIndex = 16;
            this.pbQImg.TabStop = false;
            // 
            // btnQImg
            // 
            this.btnQImg.Location = new System.Drawing.Point(9, 22);
            this.btnQImg.Name = "btnQImg";
            this.btnQImg.Size = new System.Drawing.Size(95, 25);
            this.btnQImg.TabIndex = 15;
            this.btnQImg.Text = "Question Image";
            this.btnQImg.UseVisualStyleBackColor = true;
            this.btnQImg.Click += new System.EventHandler(this.btnQImg_Click);
            // 
            // tabThema
            // 
            this.tabThema.Controls.Add(this.cbThema_t);
            this.tabThema.Controls.Add(this.txtThema);
            this.tabThema.Controls.Add(this.btnInsertThema);
            this.tabThema.Location = new System.Drawing.Point(4, 22);
            this.tabThema.Name = "tabThema";
            this.tabThema.Padding = new System.Windows.Forms.Padding(3);
            this.tabThema.Size = new System.Drawing.Size(1232, 613);
            this.tabThema.TabIndex = 1;
            this.tabThema.Text = "Thema";
            this.tabThema.UseVisualStyleBackColor = true;
            // 
            // cbThema_t
            // 
            this.cbThema_t.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThema_t.FormattingEnabled = true;
            this.cbThema_t.Location = new System.Drawing.Point(746, 263);
            this.cbThema_t.Name = "cbThema_t";
            this.cbThema_t.Size = new System.Drawing.Size(164, 21);
            this.cbThema_t.TabIndex = 5;
            // 
            // txtThema
            // 
            this.txtThema.Location = new System.Drawing.Point(435, 263);
            this.txtThema.Multiline = true;
            this.txtThema.Name = "txtThema";
            this.txtThema.Size = new System.Drawing.Size(305, 87);
            this.txtThema.TabIndex = 4;
            // 
            // btnInsertThema
            // 
            this.btnInsertThema.Location = new System.Drawing.Point(323, 263);
            this.btnInsertThema.Name = "btnInsertThema";
            this.btnInsertThema.Size = new System.Drawing.Size(106, 23);
            this.btnInsertThema.TabIndex = 3;
            this.btnInsertThema.Text = "Insert Thema";
            this.btnInsertThema.UseVisualStyleBackColor = true;
            this.btnInsertThema.Click += new System.EventHandler(this.btnInsertThema_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(531, 653);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 653);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 29);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 689);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabController);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.tabController.ResumeLayout(false);
            this.tabInsert.ResumeLayout(false);
            this.tabInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQImg)).EndInit();
            this.tabThema.ResumeLayout(false);
            this.tabThema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage tabInsert;
        private System.Windows.Forms.TabPage tabThema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbATxt;
        private System.Windows.Forms.Button btnAImg;
        private System.Windows.Forms.PictureBox pbAImg;
        private System.Windows.Forms.TextBox tbQTxt;
        private System.Windows.Forms.PictureBox pbQImg;
        private System.Windows.Forms.Button btnQImg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbThema;
        private System.Windows.Forms.ComboBox cbThema_t;
        private System.Windows.Forms.TextBox txtThema;
        private System.Windows.Forms.Button btnInsertThema;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
    }
}