namespace MPServer_v01.dv
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PIDg_tbox = new System.Windows.Forms.TextBox();
            this.START_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PIDk_tbox = new System.Windows.Forms.TextBox();
            this.PIDp_tbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gamma_tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ksi_tbox = new System.Windows.Forms.TextBox();
            this.phi_tbox = new System.Windows.Forms.TextBox();
            this.STOP_btn = new System.Windows.Forms.Button();
            this.setPID_btn = new System.Windows.Forms.Button();
            this.setAngle_btn = new System.Windows.Forms.Button();
            this.ABORT_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.M1pwd_tbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.M2pwd_tbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.M4pwd_tbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.M3pwd_tbox = new System.Windows.Forms.TextBox();
            this.GPpwd_tbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.setDrive_btn = new System.Windows.Forms.Button();
            this.log_pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.log_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // PIDg_tbox
            // 
            this.PIDg_tbox.Location = new System.Drawing.Point(104, 47);
            this.PIDg_tbox.Name = "PIDg_tbox";
            this.PIDg_tbox.Size = new System.Drawing.Size(163, 20);
            this.PIDg_tbox.TabIndex = 0;
            this.PIDg_tbox.TextChanged += new System.EventHandler(this.PIDg_tbox_TextChanged);
            // 
            // START_btn
            // 
            this.START_btn.Location = new System.Drawing.Point(12, 12);
            this.START_btn.Name = "START_btn";
            this.START_btn.Size = new System.Drawing.Size(75, 23);
            this.START_btn.TabIndex = 1;
            this.START_btn.Text = "START";
            this.START_btn.UseVisualStyleBackColor = true;
            this.START_btn.Click += new System.EventHandler(this.START_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PID_gamma:";
            // 
            // PIDk_tbox
            // 
            this.PIDk_tbox.Location = new System.Drawing.Point(104, 75);
            this.PIDk_tbox.Name = "PIDk_tbox";
            this.PIDk_tbox.Size = new System.Drawing.Size(163, 20);
            this.PIDk_tbox.TabIndex = 3;
            // 
            // PIDp_tbox
            // 
            this.PIDp_tbox.Location = new System.Drawing.Point(104, 101);
            this.PIDp_tbox.Name = "PIDp_tbox";
            this.PIDp_tbox.Size = new System.Drawing.Size(163, 20);
            this.PIDp_tbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PID_ksi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PID_phi:";
            // 
            // gamma_tbox
            // 
            this.gamma_tbox.Location = new System.Drawing.Point(104, 142);
            this.gamma_tbox.Name = "gamma_tbox";
            this.gamma_tbox.Size = new System.Drawing.Size(100, 20);
            this.gamma_tbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "gamma/тангаж:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ksi/крен:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "phi/рыск.:";
            // 
            // ksi_tbox
            // 
            this.ksi_tbox.Location = new System.Drawing.Point(104, 168);
            this.ksi_tbox.Name = "ksi_tbox";
            this.ksi_tbox.Size = new System.Drawing.Size(100, 20);
            this.ksi_tbox.TabIndex = 11;
            // 
            // phi_tbox
            // 
            this.phi_tbox.Location = new System.Drawing.Point(104, 194);
            this.phi_tbox.Name = "phi_tbox";
            this.phi_tbox.Size = new System.Drawing.Size(100, 20);
            this.phi_tbox.TabIndex = 12;
            // 
            // STOP_btn
            // 
            this.STOP_btn.Location = new System.Drawing.Point(93, 12);
            this.STOP_btn.Name = "STOP_btn";
            this.STOP_btn.Size = new System.Drawing.Size(75, 23);
            this.STOP_btn.TabIndex = 13;
            this.STOP_btn.Text = "STOP";
            this.STOP_btn.UseVisualStyleBackColor = true;
            this.STOP_btn.Click += new System.EventHandler(this.STOP_btn_Click);
            // 
            // setPID_btn
            // 
            this.setPID_btn.Location = new System.Drawing.Point(273, 47);
            this.setPID_btn.Name = "setPID_btn";
            this.setPID_btn.Size = new System.Drawing.Size(52, 74);
            this.setPID_btn.TabIndex = 14;
            this.setPID_btn.Text = "SET PIDs";
            this.setPID_btn.UseVisualStyleBackColor = true;
            this.setPID_btn.Click += new System.EventHandler(this.setPID_btn_Click);
            // 
            // setAngle_btn
            // 
            this.setAngle_btn.Location = new System.Drawing.Point(239, 140);
            this.setAngle_btn.Name = "setAngle_btn";
            this.setAngle_btn.Size = new System.Drawing.Size(86, 74);
            this.setAngle_btn.TabIndex = 15;
            this.setAngle_btn.Text = "SET ANGLEs";
            this.setAngle_btn.UseVisualStyleBackColor = true;
            this.setAngle_btn.Click += new System.EventHandler(this.setAngle_btn_Click);
            // 
            // ABORT_btn
            // 
            this.ABORT_btn.Location = new System.Drawing.Point(174, 12);
            this.ABORT_btn.Name = "ABORT_btn";
            this.ABORT_btn.Size = new System.Drawing.Size(93, 23);
            this.ABORT_btn.TabIndex = 17;
            this.ABORT_btn.Text = "!!!ABORT!!!";
            this.ABORT_btn.UseVisualStyleBackColor = true;
            this.ABORT_btn.Click += new System.EventHandler(this.ABORT_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "M1:";
            // 
            // M1pwd_tbox
            // 
            this.M1pwd_tbox.Location = new System.Drawing.Point(45, 241);
            this.M1pwd_tbox.Name = "M1pwd_tbox";
            this.M1pwd_tbox.Size = new System.Drawing.Size(100, 20);
            this.M1pwd_tbox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "M2:";
            // 
            // M2pwd_tbox
            // 
            this.M2pwd_tbox.Location = new System.Drawing.Point(63, 345);
            this.M2pwd_tbox.Name = "M2pwd_tbox";
            this.M2pwd_tbox.Size = new System.Drawing.Size(100, 20);
            this.M2pwd_tbox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "M4:";
            // 
            // M4pwd_tbox
            // 
            this.M4pwd_tbox.Location = new System.Drawing.Point(200, 241);
            this.M4pwd_tbox.Name = "M4pwd_tbox";
            this.M4pwd_tbox.Size = new System.Drawing.Size(100, 20);
            this.M4pwd_tbox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "M3:";
            // 
            // M3pwd_tbox
            // 
            this.M3pwd_tbox.Location = new System.Drawing.Point(200, 345);
            this.M3pwd_tbox.Name = "M3pwd_tbox";
            this.M3pwd_tbox.Size = new System.Drawing.Size(100, 20);
            this.M3pwd_tbox.TabIndex = 25;
            // 
            // GPpwd_tbox
            // 
            this.GPpwd_tbox.Location = new System.Drawing.Point(135, 286);
            this.GPpwd_tbox.Name = "GPpwd_tbox";
            this.GPpwd_tbox.Size = new System.Drawing.Size(100, 20);
            this.GPpwd_tbox.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "POWER:";
            // 
            // setDrive_btn
            // 
            this.setDrive_btn.Location = new System.Drawing.Point(17, 385);
            this.setDrive_btn.Name = "setDrive_btn";
            this.setDrive_btn.Size = new System.Drawing.Size(283, 60);
            this.setDrive_btn.TabIndex = 28;
            this.setDrive_btn.Text = "button1";
            this.setDrive_btn.UseVisualStyleBackColor = true;
            this.setDrive_btn.Click += new System.EventHandler(this.setDrive_btn_Click);
            // 
            // log_pbox
            // 
            this.log_pbox.Location = new System.Drawing.Point(331, 12);
            this.log_pbox.Name = "log_pbox";
            this.log_pbox.Size = new System.Drawing.Size(391, 202);
            this.log_pbox.TabIndex = 29;
            this.log_pbox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 481);
            this.Controls.Add(this.log_pbox);
            this.Controls.Add(this.setDrive_btn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GPpwd_tbox);
            this.Controls.Add(this.M3pwd_tbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.M4pwd_tbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.M2pwd_tbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.M1pwd_tbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ABORT_btn);
            this.Controls.Add(this.setAngle_btn);
            this.Controls.Add(this.setPID_btn);
            this.Controls.Add(this.STOP_btn);
            this.Controls.Add(this.phi_tbox);
            this.Controls.Add(this.ksi_tbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gamma_tbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PIDp_tbox);
            this.Controls.Add(this.PIDk_tbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.START_btn);
            this.Controls.Add(this.PIDg_tbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.log_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PIDg_tbox;
        private System.Windows.Forms.Button START_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PIDk_tbox;
        private System.Windows.Forms.TextBox PIDp_tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gamma_tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ksi_tbox;
        private System.Windows.Forms.TextBox phi_tbox;
        private System.Windows.Forms.Button STOP_btn;
        private System.Windows.Forms.Button setPID_btn;
        private System.Windows.Forms.Button setAngle_btn;
        private System.Windows.Forms.Button ABORT_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox M1pwd_tbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox M2pwd_tbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox M4pwd_tbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox M3pwd_tbox;
        private System.Windows.Forms.TextBox GPpwd_tbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button setDrive_btn;
        private System.Windows.Forms.PictureBox log_pbox;
    }
}

