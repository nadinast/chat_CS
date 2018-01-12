namespace MultiThreadClient
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
            this.greetingLabel = new System.Windows.Forms.Label();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.response = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.ForeColor = System.Drawing.Color.Transparent;
            this.greetingLabel.Location = new System.Drawing.Point(80, 31);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(376, 55);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Hello user!";
            // 
            // chatBox
            // 
            this.chatBox.Enabled = false;
            this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBox.Location = new System.Drawing.Point(85, 89);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatBox.Size = new System.Drawing.Size(371, 189);
            this.chatBox.TabIndex = 1;
            this.chatBox.TextChanged += new System.EventHandler(this.chatBox_TextChanged);
            // 
            // sendButton
            // 
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sendButton.FlatAppearance.BorderSize = 2;
            this.sendButton.Location = new System.Drawing.Point(351, 284);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(105, 41);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(85, 284);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(260, 86);
            this.messageBox.TabIndex = 3;
            this.messageBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // response
            // 
            this.response.Location = new System.Drawing.Point(351, 331);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(105, 39);
            this.response.TabIndex = 4;
            this.response.Text = "Resp";
            this.response.UseVisualStyleBackColor = true;
            this.response.Click += new System.EventHandler(this.response_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(537, 398);
            this.Controls.Add(this.response);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.greetingLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button response;
    }
}

