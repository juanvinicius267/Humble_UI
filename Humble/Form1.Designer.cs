namespace Humble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.axVideoChatSender1 = new AxVideoChatSenderLib.AxVideoChatSender();
            this.axVideoChatReceiver1 = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Frente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 663);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Trás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 610);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Esquerda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 610);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Direita";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(408, 494);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "Frear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(34, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 32);
            this.button6.TabIndex = 7;
            this.button6.Text = "Connect";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(398, 353);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 28);
            this.button7.TabIndex = 8;
            this.button7.Text = "Listen";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // axVideoChatSender1
            // 
            this.axVideoChatSender1.Enabled = true;
            this.axVideoChatSender1.Location = new System.Drawing.Point(31, 28);
            this.axVideoChatSender1.Name = "axVideoChatSender1";
            this.axVideoChatSender1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatSender1.OcxState")));
            this.axVideoChatSender1.Size = new System.Drawing.Size(350, 273);
            this.axVideoChatSender1.TabIndex = 9;
            this.axVideoChatSender1.SendStream += new AxVideoChatSenderLib._DvideochatEvents_SendStreamEventHandler(this.axVideoChatSender1_SendStream);
            // 
            // axVideoChatReceiver1
            // 
            this.axVideoChatReceiver1.Enabled = true;
            this.axVideoChatReceiver1.Location = new System.Drawing.Point(433, 30);
            this.axVideoChatReceiver1.Name = "axVideoChatReceiver1";
            this.axVideoChatReceiver1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatReceiver1.OcxState")));
            this.axVideoChatReceiver1.Size = new System.Drawing.Size(370, 270);
            this.axVideoChatReceiver1.TabIndex = 10;
            this.axVideoChatReceiver1.OnNewUserConnection += new AxVideoChatReceiverLib._DVideoChatReceiverEvents_OnNewUserConnectionEventHandler(this.axVideoChatReceiver1_OnNewUserConnection);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 727);
            this.Controls.Add(this.axVideoChatReceiver1);
            this.Controls.Add(this.axVideoChatSender1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private AxVideoChatSenderLib.AxVideoChatSender axVideoChatSender1;
        private AxVideoChatReceiverLib.AxVideoChatReceiver axVideoChatReceiver1;
    }
}

