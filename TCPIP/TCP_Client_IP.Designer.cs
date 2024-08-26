namespace TCPIP
{
    partial class TCP_Client_IP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 59);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "سرور :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 247);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "پیغام :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(28, 18);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(493, 20);
            this.txtname.TabIndex = 3;
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(28, 59);
            this.txtserver.Name = "txtserver";
            this.txtserver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtserver.Size = new System.Drawing.Size(493, 20);
            this.txtserver.TabIndex = 4;
            this.txtserver.Text = "127.0.0.1:9000";
            // 
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(28, 96);
            this.txtinfo.Multiline = true;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(493, 130);
            this.txtinfo.TabIndex = 5;
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(28, 244);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(493, 20);
            this.txtmessage.TabIndex = 6;
            // 
            // btnconnect
            // 
            this.btnconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnconnect.Location = new System.Drawing.Point(28, 277);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(75, 37);
            this.btnconnect.TabIndex = 7;
            this.btnconnect.Text = "اتصال";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // btnsend
            // 
            this.btnsend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsend.Location = new System.Drawing.Point(119, 277);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 37);
            this.btnsend.TabIndex = 8;
            this.btnsend.Text = "ارسال";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // TCP_Client_IP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 318);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TCP_Client_IP";
            this.Text = "TCP_Client_IP";
            this.Load += new System.EventHandler(this.TCP_Client_IP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Button btnsend;
    }
}