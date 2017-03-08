namespace SubtitlesSync
{
    partial class MainForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSubtitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.vSplitContainer = new System.Windows.Forms.SplitContainer();
            this.detailsPanelLeft = new System.Windows.Forms.Panel();
            this.detailsPanelRight = new System.Windows.Forms.Panel();
            this.dataGridLeft = new System.Windows.Forms.DataGridView();
            this.dataGridRight = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vSplitContainer)).BeginInit();
            this.vSplitContainer.Panel1.SuspendLayout();
            this.vSplitContainer.Panel2.SuspendLayout();
            this.vSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRight)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 389);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(835, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(835, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSubtitleToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSubtitleToolStripMenuItem
            // 
            this.openSubtitleToolStripMenuItem.Name = "openSubtitleToolStripMenuItem";
            this.openSubtitleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openSubtitleToolStripMenuItem.Text = "Open subtitles";
            this.openSubtitleToolStripMenuItem.Click += new System.EventHandler(this.openSubtitleToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(835, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "Tools";
            // 
            // vSplitContainer
            // 
            this.vSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vSplitContainer.Location = new System.Drawing.Point(0, 49);
            this.vSplitContainer.Name = "vSplitContainer";
            // 
            // vSplitContainer.Panel1
            // 
            this.vSplitContainer.Panel1.Controls.Add(this.dataGridLeft);
            this.vSplitContainer.Panel1.Controls.Add(this.detailsPanelLeft);
            // 
            // vSplitContainer.Panel2
            // 
            this.vSplitContainer.Panel2.Controls.Add(this.dataGridRight);
            this.vSplitContainer.Panel2.Controls.Add(this.detailsPanelRight);
            this.vSplitContainer.Size = new System.Drawing.Size(835, 340);
            this.vSplitContainer.SplitterDistance = 409;
            this.vSplitContainer.TabIndex = 3;
            // 
            // detailsPanelLeft
            // 
            this.detailsPanelLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.detailsPanelLeft.Name = "detailsPanelLeft";
            this.detailsPanelLeft.Size = new System.Drawing.Size(409, 65);
            this.detailsPanelLeft.TabIndex = 0;
            // 
            // detailsPanelRight
            // 
            this.detailsPanelRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsPanelRight.Location = new System.Drawing.Point(0, 0);
            this.detailsPanelRight.Name = "detailsPanelRight";
            this.detailsPanelRight.Size = new System.Drawing.Size(422, 65);
            this.detailsPanelRight.TabIndex = 0;
            // 
            // dataGridLeft
            // 
            this.dataGridLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridLeft.Location = new System.Drawing.Point(0, 65);
            this.dataGridLeft.Name = "dataGridLeft";
            this.dataGridLeft.Size = new System.Drawing.Size(409, 275);
            this.dataGridLeft.TabIndex = 1;
            // 
            // dataGridRight
            // 
            this.dataGridRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRight.Location = new System.Drawing.Point(0, 65);
            this.dataGridRight.Name = "dataGridRight";
            this.dataGridRight.Size = new System.Drawing.Size(422, 275);
            this.dataGridRight.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 411);
            this.Controls.Add(this.vSplitContainer);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Subtitles Syncronizer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.vSplitContainer.Panel1.ResumeLayout(false);
            this.vSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vSplitContainer)).EndInit();
            this.vSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSubtitleToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.SplitContainer vSplitContainer;
        private System.Windows.Forms.DataGridView dataGridLeft;
        private System.Windows.Forms.Panel detailsPanelLeft;
        private System.Windows.Forms.DataGridView dataGridRight;
        private System.Windows.Forms.Panel detailsPanelRight;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

