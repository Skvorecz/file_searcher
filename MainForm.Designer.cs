namespace FileSearcher
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insideTextTextBox = new System.Windows.Forms.TextBox();
            this.searchPatternTextBox = new System.Windows.Forms.TextBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultTreeView = new System.Windows.Forms.TreeView();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.CurrentFileStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.pauseToolButton = new System.Windows.Forms.ToolStripButton();
            this.continueToolButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolButton = new System.Windows.Forms.ToolStripButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.elapsedTimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.filesFoundStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.insideTextTextBox);
            this.groupBox1.Controls.Add(this.searchPatternTextBox);
            this.groupBox1.Controls.Add(this.PathTextBox);
            this.groupBox1.Location = new System.Drawing.Point(260, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Text inside:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File name mask:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // insideTextTextBox
            // 
            this.insideTextTextBox.AcceptsReturn = true;
            this.insideTextTextBox.Location = new System.Drawing.Point(10, 195);
            this.insideTextTextBox.Multiline = true;
            this.insideTextTextBox.Name = "insideTextTextBox";
            this.insideTextTextBox.Size = new System.Drawing.Size(235, 45);
            this.insideTextTextBox.TabIndex = 4;
            // 
            // searchPatternTextBox
            // 
            this.searchPatternTextBox.Location = new System.Drawing.Point(10, 125);
            this.searchPatternTextBox.Name = "searchPatternTextBox";
            this.searchPatternTextBox.Size = new System.Drawing.Size(235, 20);
            this.searchPatternTextBox.TabIndex = 3;
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(10, 55);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(235, 20);
            this.PathTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(355, 365);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ResultTreeView
            // 
            this.ResultTreeView.Location = new System.Drawing.Point(15, 40);
            this.ResultTreeView.Name = "ResultTreeView";
            this.ResultTreeView.Size = new System.Drawing.Size(205, 315);
            this.ResultTreeView.TabIndex = 2;
            this.ResultTreeView.TabStop = false;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentFileStatusLabel});
            this.statusStrip2.Location = new System.Drawing.Point(0, 424);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip2.Size = new System.Drawing.Size(574, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 6;
            // 
            // CurrentFileStatusLabel
            // 
            this.CurrentFileStatusLabel.Name = "CurrentFileStatusLabel";
            this.CurrentFileStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CurrentFileStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.CurrentFileStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolButton,
            this.continueToolButton,
            this.stopToolButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(574, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // pauseToolButton
            // 
            this.pauseToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseToolButton.Image = global::FileSearcher.Properties.Resources.pauseButton;
            this.pauseToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseToolButton.Name = "pauseToolButton";
            this.pauseToolButton.Size = new System.Drawing.Size(23, 22);
            this.pauseToolButton.Text = "toolStripButton1";
            this.pauseToolButton.Click += new System.EventHandler(this.pauseToolButton_Click);
            // 
            // continueToolButton
            // 
            this.continueToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.continueToolButton.Image = global::FileSearcher.Properties.Resources.continueButton;
            this.continueToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.continueToolButton.Name = "continueToolButton";
            this.continueToolButton.Size = new System.Drawing.Size(23, 22);
            this.continueToolButton.Text = "Continue";
            this.continueToolButton.Click += new System.EventHandler(this.continueToolButton_Click);
            // 
            // stopToolButton
            // 
            this.stopToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopToolButton.Image = global::FileSearcher.Properties.Resources.stopButton;
            this.stopToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolButton.Name = "stopToolButton";
            this.stopToolButton.Size = new System.Drawing.Size(23, 22);
            this.stopToolButton.Text = "toolStripButton3";
            this.stopToolButton.Click += new System.EventHandler(this.stoplStripButton_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elapsedTimeStatusLabel,
            this.filesFoundStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(574, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip2";
            // 
            // elapsedTimeStatusLabel
            // 
            this.elapsedTimeStatusLabel.Name = "elapsedTimeStatusLabel";
            this.elapsedTimeStatusLabel.Size = new System.Drawing.Size(49, 17);
            this.elapsedTimeStatusLabel.Text = "00:00:00";
            // 
            // filesFoundStatusLabel
            // 
            this.filesFoundStatusLabel.Name = "filesFoundStatusLabel";
            this.filesFoundStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filesFoundStatusLabel.Size = new System.Drawing.Size(44, 17);
            this.filesFoundStatusLabel.Text = "Found:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 446);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.ResultTreeView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "FileSearcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchPatternTextBox;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.TextBox insideTextTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TreeView ResultTreeView;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton pauseToolButton;
        private System.Windows.Forms.ToolStripButton continueToolButton;
        private System.Windows.Forms.ToolStripButton stopToolButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel filesFoundStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel elapsedTimeStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel CurrentFileStatusLabel;
    }
}

