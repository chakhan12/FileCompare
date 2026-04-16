namespace FileCompare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panel6 = new Panel();
            lvwLeftDir = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel5 = new Panel();
            txtLeftDir = new TextBox();
            btnLeftDir = new Button();
            panel1 = new Panel();
            btnCopyFromLeft = new Button();
            lblAppName = new Label();
            panel4 = new Panel();
            lvwrightDir = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            panel3 = new Panel();
            btnCopyFromRight = new Button();
            txtRightDir = new TextBox();
            panel2 = new Panel();
            btnRightDir = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel6);
            splitContainer1.Panel1.Controls.Add(panel5);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1023, 513);
            splitContainer1.SplitterDistance = 520;
            splitContainer1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(lvwLeftDir);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 250);
            panel6.Name = "panel6";
            panel6.Size = new Size(520, 263);
            panel6.TabIndex = 2;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwLeftDir.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Location = new Point(0, 0);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(520, 263);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.View = View.Details;
            lvwLeftDir.SelectedIndexChanged += lvwLeftDir_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "이름";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "크기";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "수정";
            columnHeader3.Width = 160;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtLeftDir);
            panel5.Controls.Add(btnLeftDir);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 125);
            panel5.Name = "panel5";
            panel5.Size = new Size(520, 125);
            panel5.TabIndex = 1;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Location = new Point(12, 70);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(348, 27);
            txtLeftDir.TabIndex = 2;
            txtLeftDir.TextChanged += txtLeftDir_TextChanged;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Right;
            btnLeftDir.Font = new Font("맑은 고딕", 12F);
            btnLeftDir.ForeColor = Color.Black;
            btnLeftDir.Location = new Point(400, 56);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(107, 48);
            btnLeftDir.TabIndex = 2;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyFromLeft);
            panel1.Controls.Add(lblAppName);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 125);
            panel1.TabIndex = 0;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCopyFromLeft.Font = new Font("맑은 고딕", 12F);
            btnCopyFromLeft.ForeColor = Color.Black;
            btnCopyFromLeft.Location = new Point(400, 57);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(107, 39);
            btnCopyFromLeft.TabIndex = 3;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(12, 24);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(301, 62);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "File compare";
            // 
            // panel4
            // 
            panel4.Controls.Add(lvwrightDir);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 250);
            panel4.Name = "panel4";
            panel4.Size = new Size(499, 263);
            panel4.TabIndex = 2;
            // 
            // lvwrightDir
            // 
            lvwrightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwrightDir.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            lvwrightDir.FullRowSelect = true;
            lvwrightDir.GridLines = true;
            lvwrightDir.Location = new Point(0, 0);
            lvwrightDir.Name = "lvwrightDir";
            lvwrightDir.Size = new Size(499, 263);
            lvwrightDir.TabIndex = 0;
            lvwrightDir.UseCompatibleStateImageBehavior = false;
            lvwrightDir.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "이름";
            columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "크기";
            columnHeader5.TextAlign = HorizontalAlignment.Right;
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "수정";
            columnHeader6.Width = 160;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRightDir);
            panel3.Controls.Add(txtRightDir);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 125);
            panel3.TabIndex = 1;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Anchor = AnchorStyles.Right;
            btnCopyFromRight.Font = new Font("맑은 고딕", 12F);
            btnCopyFromRight.Location = new Point(57, 57);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(107, 39);
            btnCopyFromRight.TabIndex = 4;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            btnCopyFromRight.Click += btnCopyFromRight_Click;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Location = new Point(19, 70);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(308, 27);
            txtRightDir.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCopyFromRight);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(499, 125);
            panel2.TabIndex = 0;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Left;
            btnRightDir.Font = new Font("맑은 고딕", 12F);
            btnRightDir.Location = new Point(368, 56);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(107, 48);
            btnRightDir.TabIndex = 3;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 513);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtLeftDir;
        private Button btnLeftDir;
        private Label lblAppName;
        private TextBox txtRightDir;
        private Button btnCopyFromLeft;
        private Button btnCopyFromRight;
        private Button btnRightDir;
        private ListView lvwLeftDir;
        private ListView lvwrightDir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
