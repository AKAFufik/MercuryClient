namespace MercuryClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonDamping = new System.Windows.Forms.Button();
            this.buttonVSD = new System.Windows.Forms.Button();
            this.buttonServer = new System.Windows.Forms.Button();
            this.buttonBatch = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.buttonAttach = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.panelName.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.buttonDamping);
            this.panelMenu.Controls.Add(this.buttonVSD);
            this.panelMenu.Controls.Add(this.buttonServer);
            this.panelMenu.Controls.Add(this.buttonBatch);
            this.panelMenu.Controls.Add(this.buttonMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(319, 705);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonDamping
            // 
            this.buttonDamping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDamping.ForeColor = System.Drawing.Color.Navy;
            this.buttonDamping.Image = global::MercuryClient.Properties.Resources.icons8_товар_50;
            this.buttonDamping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDamping.Location = new System.Drawing.Point(0, 267);
            this.buttonDamping.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDamping.Name = "buttonDamping";
            this.buttonDamping.Size = new System.Drawing.Size(220, 50);
            this.buttonDamping.TabIndex = 5;
            this.buttonDamping.Text = "Гашение";
            this.buttonDamping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDamping.UseVisualStyleBackColor = true;
            this.buttonDamping.Click += new System.EventHandler(this.buttonDamping_Click);
            // 
            // buttonVSD
            // 
            this.buttonVSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVSD.ForeColor = System.Drawing.Color.Navy;
            this.buttonVSD.Image = global::MercuryClient.Properties.Resources.icons8_документы_50;
            this.buttonVSD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVSD.Location = new System.Drawing.Point(0, 213);
            this.buttonVSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVSD.Name = "buttonVSD";
            this.buttonVSD.Size = new System.Drawing.Size(220, 50);
            this.buttonVSD.TabIndex = 4;
            this.buttonVSD.Text = "ВСД";
            this.buttonVSD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonVSD.UseVisualStyleBackColor = true;
            this.buttonVSD.Click += new System.EventHandler(this.buttonVSD_Click);
            // 
            // buttonServer
            // 
            this.buttonServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonServer.ForeColor = System.Drawing.Color.Navy;
            this.buttonServer.Image = global::MercuryClient.Properties.Resources.icons8_чат_50;
            this.buttonServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServer.Location = new System.Drawing.Point(0, 386);
            this.buttonServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonServer.Name = "buttonServer";
            this.buttonServer.Size = new System.Drawing.Size(220, 50);
            this.buttonServer.TabIndex = 3;
            this.buttonServer.Text = "Чат";
            this.buttonServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonServer.UseVisualStyleBackColor = true;
            this.buttonServer.Click += new System.EventHandler(this.buttonServer_Click);
            // 
            // buttonBatch
            // 
            this.buttonBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBatch.ForeColor = System.Drawing.Color.Navy;
            this.buttonBatch.Image = global::MercuryClient.Properties.Resources.icons8_журнал_50;
            this.buttonBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBatch.Location = new System.Drawing.Point(0, 159);
            this.buttonBatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBatch.Name = "buttonBatch";
            this.buttonBatch.Size = new System.Drawing.Size(220, 50);
            this.buttonBatch.TabIndex = 2;
            this.buttonBatch.Text = "Журнал";
            this.buttonBatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBatch.UseVisualStyleBackColor = true;
            this.buttonBatch.Click += new System.EventHandler(this.buttonBatch_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(21, 22);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "-";
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView.Location = new System.Drawing.Point(103, 50);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1265, 494);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxSearch.Location = new System.Drawing.Point(38, 6);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(328, 22);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.Controls.Add(this.pictureBoxSearch);
            this.flowLayoutPanel.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanel.Location = new System.Drawing.Point(757, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(495, 46);
            this.flowLayoutPanel.TabIndex = 4;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = global::MercuryClient.Properties.Resources.icons8_поиск_25;
            this.pictureBoxSearch.InitialImage = null;
            this.pictureBoxSearch.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(29, 30);
            this.pictureBoxSearch.TabIndex = 3;
            this.pictureBoxSearch.TabStop = false;
            // 
            // panelName
            // 
            this.panelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelName.Controls.Add(this.labelName);
            this.panelName.Location = new System.Drawing.Point(513, 0);
            this.panelName.Margin = new System.Windows.Forms.Padding(4);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(240, 46);
            this.panelName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(21, 11);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 25);
            this.labelName.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.buttonAttach);
            this.groupBox.Controls.Add(this.buttonMerge);
            this.groupBox.Controls.Add(this.textBoxSecond);
            this.groupBox.Controls.Add(this.textBoxFirst);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.ForeColor = System.Drawing.Color.Navy;
            this.groupBox.Location = new System.Drawing.Point(559, 557);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(808, 136);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Объединение / Присоединение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первая продукция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вторая продукция";
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(198, 34);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(394, 27);
            this.textBoxFirst.TabIndex = 2;
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(198, 64);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(394, 27);
            this.textBoxSecond.TabIndex = 3;
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(625, 25);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(175, 39);
            this.buttonMerge.TabIndex = 4;
            this.buttonMerge.Text = "Объединенить";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // buttonAttach
            // 
            this.buttonAttach.Location = new System.Drawing.Point(625, 70);
            this.buttonAttach.Name = "buttonAttach";
            this.buttonAttach.Size = new System.Drawing.Size(175, 42);
            this.buttonAttach.TabIndex = 5;
            this.buttonAttach.Text = "Присоединенить";
            this.buttonAttach.UseVisualStyleBackColor = true;
            this.buttonAttach.Click += new System.EventHandler(this.buttonAttach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1379, 705);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1000, 606);
            this.Name = "Form1";
            this.Text = "MercuryClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonBatch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonServer;
        private System.Windows.Forms.Button buttonVSD;
        private System.Windows.Forms.Button buttonDamping;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.Button buttonAttach;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.TextBox textBoxSecond;
    }
}

