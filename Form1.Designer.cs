namespace UDPClientServer
{
    partial class Form1
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
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReceivePort = new System.Windows.Forms.TextBox();
            this.tbSendPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSendIP = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbSendMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbReceiveIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(127, 155);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receive port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Send port:";
            // 
            // tbReceivePort
            // 
            this.tbReceivePort.Location = new System.Drawing.Point(86, 12);
            this.tbReceivePort.Name = "tbReceivePort";
            this.tbReceivePort.Size = new System.Drawing.Size(116, 20);
            this.tbReceivePort.TabIndex = 3;
            this.tbReceivePort.Text = "5000";
            // 
            // tbSendPort
            // 
            this.tbSendPort.Location = new System.Drawing.Point(86, 74);
            this.tbSendPort.Name = "tbSendPort";
            this.tbSendPort.Size = new System.Drawing.Size(116, 20);
            this.tbSendPort.TabIndex = 4;
            this.tbSendPort.Text = "5001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Send IP:";
            // 
            // tbSendIP
            // 
            this.tbSendIP.Location = new System.Drawing.Point(86, 100);
            this.tbSendIP.Name = "tbSendIP";
            this.tbSendIP.Size = new System.Drawing.Size(116, 20);
            this.tbSendIP.TabIndex = 6;
            this.tbSendIP.Text = "192.168.61.89";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(208, 12);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(198, 166);
            this.tbLog.TabIndex = 8;
            this.tbLog.Text = "LOG:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(28, 155);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbSendMessage
            // 
            this.tbSendMessage.Location = new System.Drawing.Point(86, 126);
            this.tbSendMessage.Name = "tbSendMessage";
            this.tbSendMessage.Size = new System.Drawing.Size(116, 20);
            this.tbSendMessage.TabIndex = 10;
            this.tbSendMessage.Text = "Hello from Windows";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Send text:";
            // 
            // tbReceiveIP
            // 
            this.tbReceiveIP.Location = new System.Drawing.Point(86, 38);
            this.tbReceiveIP.Name = "tbReceiveIP";
            this.tbReceiveIP.Size = new System.Drawing.Size(116, 20);
            this.tbReceiveIP.TabIndex = 12;
            this.tbReceiveIP.Text = "192.168.61.32";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Receive IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 189);
            this.Controls.Add(this.tbReceiveIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSendMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbSendIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSendPort);
            this.Controls.Add(this.tbReceivePort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "UDP Client/Server Demo - Şamil Korkmaz, June 2022";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReceivePort;
        private System.Windows.Forms.TextBox tbSendPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSendIP;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbSendMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbReceiveIP;
        private System.Windows.Forms.Label label5;
    }
}

