namespace TCPServer
{
    partial class TCP_Server_IP
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
            this.lstip = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstip
            // 
            this.lstip.FormattingEnabled = true;
            this.lstip.Location = new System.Drawing.Point(33, 62);
            this.lstip.Name = "lstip";
            this.lstip.Size = new System.Drawing.Size(184, 160);
            this.lstip.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "کاربران :";
            // 
            // btnsend
            // 
            this.btnsend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsend.Location = new System.Drawing.Point(355, 243);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 37);
            this.btnsend.TabIndex = 24;
            this.btnsend.Text = "ارسال";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btnstart
            // 
            this.btnstart.ForeColor = System.Drawing.Color.Blue;
            this.btnstart.Location = new System.Drawing.Point(274, 243);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 37);
            this.btnstart.TabIndex = 23;
            this.btnstart.Text = "شروع";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(276, 210);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmessage.Size = new System.Drawing.Size(260, 20);
            this.txtmessage.TabIndex = 22;
            // 
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(276, 62);
            this.txtinfo.Multiline = true;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.ReadOnly = true;
            this.txtinfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtinfo.Size = new System.Drawing.Size(260, 130);
            this.txtinfo.TabIndex = 21;
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(276, 25);
            this.txtserver.Name = "txtserver";
            this.txtserver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtserver.Size = new System.Drawing.Size(260, 20);
            this.txtserver.TabIndex = 20;
            this.txtserver.Text = "127.0.0.1:9000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 213);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "پیغام :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 25);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "سرور :";
            // 
            // TCP_Server_IP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 305);
            this.Controls.Add(this.lstip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "TCP_Server_IP";
            this.Text = "TCP_Server_IP";
            this.Load += new System.EventHandler(this.TCP_Server_IP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}