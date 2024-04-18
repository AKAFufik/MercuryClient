namespace MercuryClient
{
    partial class Server
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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxMessage.Location = new System.Drawing.Point(13, 47);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(639, 415);
            this.textBoxMessage.TabIndex = 0;
            // 
            // button_Open
            // 
            this.button_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Open.Location = new System.Drawing.Point(13, 489);
            this.button_Open.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(109, 36);
            this.button_Open.TabIndex = 1;
            this.button_Open.Text = "Открыть";
            this.button_Open.UseVisualStyleBackColor = false;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Close.Location = new System.Drawing.Point(166, 489);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(105, 36);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(13, 16);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(53, 20);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "label1";
            this.labelStatus.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 553);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textBoxMessage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(680, 600);
            this.MinimumSize = new System.Drawing.Size(680, 600);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label labelStatus;
    }
}