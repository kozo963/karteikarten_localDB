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
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCurrentKarte = new System.Windows.Forms.Label();
            this.lblTotalKarte = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdate_UD = new System.Windows.Forms.Button();
            this.btnDelete_UD = new System.Windows.Forms.Button();
            this.btnPreviousUD = new System.Windows.Forms.Button();
            this.btnNextUD = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_Thema_UD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbATxt_UD = new System.Windows.Forms.TextBox();
            this.pbAImg_UD = new System.Windows.Forms.PictureBox();
            this.tbQTxt_UD = new System.Windows.Forms.TextBox();
            this.pbQImg_UD = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAImg_UD = new System.Windows.Forms.Button();
            this.btnQImg_UD = new System.Windows.Forms.Button();
            this.tabController.SuspendLayout();
            this.tabInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQImg)).BeginInit();
            this.tabThema.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAImg_UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQImg_UD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabInsert);
            this.tabController.Controls.Add(this.tabThema);
            this.tabController.Controls.Add(this.tabPage1);
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
            this.tabInsert.Controls.Add(this.btnAdd);
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
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1111, 559);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAImg_UD);
            this.tabPage1.Controls.Add(this.btnQImg_UD);
            this.tabPage1.Controls.Add(this.lblCurrentKarte);
            this.tabPage1.Controls.Add(this.lblTotalKarte);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.btnUpdate_UD);
            this.tabPage1.Controls.Add(this.btnDelete_UD);
            this.tabPage1.Controls.Add(this.btnPreviousUD);
            this.tabPage1.Controls.Add(this.btnNextUD);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cb_Thema_UD);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tbATxt_UD);
            this.tabPage1.Controls.Add(this.pbAImg_UD);
            this.tabPage1.Controls.Add(this.tbQTxt_UD);
            this.tabPage1.Controls.Add(this.pbQImg_UD);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1232, 613);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Karte: Update/Delete";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCurrentKarte
            // 
            this.lblCurrentKarte.AutoSize = true;
            this.lblCurrentKarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentKarte.Location = new System.Drawing.Point(1045, 201);
            this.lblCurrentKarte.Name = "lblCurrentKarte";
            this.lblCurrentKarte.Size = new System.Drawing.Size(18, 20);
            this.lblCurrentKarte.TabIndex = 51;
            this.lblCurrentKarte.Text = "0";
            // 
            // lblTotalKarte
            // 
            this.lblTotalKarte.AutoSize = true;
            this.lblTotalKarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKarte.Location = new System.Drawing.Point(1045, 118);
            this.lblTotalKarte.Name = "lblTotalKarte";
            this.lblTotalKarte.Size = new System.Drawing.Size(18, 20);
            this.lblTotalKarte.TabIndex = 50;
            this.lblTotalKarte.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1045, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Current Karte";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1045, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "Total Karte in this Thema";
            // 
            // btnUpdate_UD
            // 
            this.btnUpdate_UD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_UD.Location = new System.Drawing.Point(1060, 241);
            this.btnUpdate_UD.Name = "btnUpdate_UD";
            this.btnUpdate_UD.Size = new System.Drawing.Size(131, 59);
            this.btnUpdate_UD.TabIndex = 47;
            this.btnUpdate_UD.Text = "Update";
            this.btnUpdate_UD.UseVisualStyleBackColor = true;
            this.btnUpdate_UD.Click += new System.EventHandler(this.btnUpdate_UD_Click);
            // 
            // btnDelete_UD
            // 
            this.btnDelete_UD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_UD.Location = new System.Drawing.Point(1060, 318);
            this.btnDelete_UD.Name = "btnDelete_UD";
            this.btnDelete_UD.Size = new System.Drawing.Size(131, 59);
            this.btnDelete_UD.TabIndex = 46;
            this.btnDelete_UD.Text = "Delete";
            this.btnDelete_UD.UseVisualStyleBackColor = true;
            this.btnDelete_UD.Click += new System.EventHandler(this.btnDelete_UD_Click);
            // 
            // btnPreviousUD
            // 
            this.btnPreviousUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousUD.Location = new System.Drawing.Point(1060, 532);
            this.btnPreviousUD.Name = "btnPreviousUD";
            this.btnPreviousUD.Size = new System.Drawing.Size(80, 29);
            this.btnPreviousUD.TabIndex = 44;
            this.btnPreviousUD.Text = "Previous";
            this.btnPreviousUD.UseVisualStyleBackColor = true;
            this.btnPreviousUD.Click += new System.EventHandler(this.btnPreviousUD_Click);
            // 
            // btnNextUD
            // 
            this.btnNextUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextUD.Location = new System.Drawing.Point(1140, 532);
            this.btnNextUD.Name = "btnNextUD";
            this.btnNextUD.Size = new System.Drawing.Size(75, 29);
            this.btnNextUD.TabIndex = 43;
            this.btnNextUD.Text = "Next";
            this.btnNextUD.UseVisualStyleBackColor = true;
            this.btnNextUD.Click += new System.EventHandler(this.btnNextUD_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1100, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Thema";
            // 
            // cb_Thema_UD
            // 
            this.cb_Thema_UD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Thema_UD.FormattingEnabled = true;
            this.cb_Thema_UD.Location = new System.Drawing.Point(1060, 43);
            this.cb_Thema_UD.Name = "cb_Thema_UD";
            this.cb_Thema_UD.Size = new System.Drawing.Size(120, 21);
            this.cb_Thema_UD.TabIndex = 41;
            this.cb_Thema_UD.SelectedIndexChanged += new System.EventHandler(this.cb_Thema_UD_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(766, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Answer Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Answer Image";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(766, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Question Text";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Question Image";
            // 
            // tbATxt_UD
            // 
            this.tbATxt_UD.Location = new System.Drawing.Point(559, 318);
            this.tbATxt_UD.Multiline = true;
            this.tbATxt_UD.Name = "tbATxt_UD";
            this.tbATxt_UD.Size = new System.Drawing.Size(484, 276);
            this.tbATxt_UD.TabIndex = 36;
            // 
            // pbAImg_UD
            // 
            this.pbAImg_UD.Location = new System.Drawing.Point(48, 318);
            this.pbAImg_UD.Name = "pbAImg_UD";
            this.pbAImg_UD.Size = new System.Drawing.Size(484, 276);
            this.pbAImg_UD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAImg_UD.TabIndex = 35;
            this.pbAImg_UD.TabStop = false;
            // 
            // tbQTxt_UD
            // 
            this.tbQTxt_UD.Location = new System.Drawing.Point(559, 24);
            this.tbQTxt_UD.Multiline = true;
            this.tbQTxt_UD.Name = "tbQTxt_UD";
            this.tbQTxt_UD.Size = new System.Drawing.Size(484, 276);
            this.tbQTxt_UD.TabIndex = 34;
            // 
            // pbQImg_UD
            // 
            this.pbQImg_UD.Location = new System.Drawing.Point(48, 24);
            this.pbQImg_UD.Name = "pbQImg_UD";
            this.pbQImg_UD.Size = new System.Drawing.Size(484, 276);
            this.pbQImg_UD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQImg_UD.TabIndex = 33;
            this.pbQImg_UD.TabStop = false;
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
            // btnAImg_UD
            // 
            this.btnAImg_UD.Location = new System.Drawing.Point(6, 306);
            this.btnAImg_UD.Name = "btnAImg_UD";
            this.btnAImg_UD.Size = new System.Drawing.Size(92, 23);
            this.btnAImg_UD.TabIndex = 53;
            this.btnAImg_UD.Text = "Answer Image";
            this.btnAImg_UD.UseVisualStyleBackColor = true;
            this.btnAImg_UD.Click += new System.EventHandler(this.btnAImg_UD_Click);
            // 
            // btnQImg_UD
            // 
            this.btnQImg_UD.Location = new System.Drawing.Point(3, 6);
            this.btnQImg_UD.Name = "btnQImg_UD";
            this.btnQImg_UD.Size = new System.Drawing.Size(95, 25);
            this.btnQImg_UD.TabIndex = 52;
            this.btnQImg_UD.Text = "Question Image";
            this.btnQImg_UD.UseVisualStyleBackColor = true;
            this.btnQImg_UD.Click += new System.EventHandler(this.btnQImg_UD_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 689);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabController);
            this.Name = "frmAdmin";
            this.Text = "Admin Panel";
            this.tabController.ResumeLayout(false);
            this.tabInsert.ResumeLayout(false);
            this.tabInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQImg)).EndInit();
            this.tabThema.ResumeLayout(false);
            this.tabThema.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAImg_UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQImg_UD)).EndInit();
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUpdate_UD;
        private System.Windows.Forms.Button btnDelete_UD;
        private System.Windows.Forms.Button btnPreviousUD;
        private System.Windows.Forms.Button btnNextUD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_Thema_UD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbATxt_UD;
        private System.Windows.Forms.PictureBox pbAImg_UD;
        private System.Windows.Forms.TextBox tbQTxt_UD;
        private System.Windows.Forms.PictureBox pbQImg_UD;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCurrentKarte;
        private System.Windows.Forms.Label lblTotalKarte;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAImg_UD;
        private System.Windows.Forms.Button btnQImg_UD;
    }
}