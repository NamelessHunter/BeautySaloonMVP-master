namespace BeautySaloonMVC
{
    partial class MainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.MainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BottomLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ManuFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSortDesc = new System.Windows.Forms.RadioButton();
            this.radioSortAsc = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ManuFilter);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 51);
            this.panel1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(263, 22);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.AutoSize = true;
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 51);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainLayoutPanel.Size = new System.Drawing.Size(1182, 702);
            this.MainLayoutPanel.TabIndex = 1;
            // 
            // BottomLayoutPanel
            // 
            this.BottomLayoutPanel.Location = new System.Drawing.Point(0, 701);
            this.BottomLayoutPanel.Name = "BottomLayoutPanel";
            this.BottomLayoutPanel.Size = new System.Drawing.Size(1182, 27);
            this.BottomLayoutPanel.TabIndex = 2;
            this.BottomLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BottomLayoutPanel_Paint);
            // 
            // ManuFilter
            // 
            this.ManuFilter.FormattingEnabled = true;
            this.ManuFilter.Items.AddRange(new object[] {
            "Все элементы"});
            this.ManuFilter.Location = new System.Drawing.Point(814, 12);
            this.ManuFilter.Name = "ManuFilter";
            this.ManuFilter.Size = new System.Drawing.Size(356, 24);
            this.ManuFilter.TabIndex = 1;
            this.ManuFilter.SelectedIndexChanged += new System.EventHandler(this.ManuFilter_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSortDesc);
            this.groupBox1.Controls.Add(this.radioSortAsc);
            this.groupBox1.Location = new System.Drawing.Point(282, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(199, 39);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioSortDesc
            // 
            this.radioSortDesc.AutoSize = true;
            this.radioSortDesc.Location = new System.Drawing.Point(119, 14);
            this.radioSortDesc.Margin = new System.Windows.Forms.Padding(4);
            this.radioSortDesc.Name = "radioSortDesc";
            this.radioSortDesc.Size = new System.Drawing.Size(65, 21);
            this.radioSortDesc.TabIndex = 1;
            this.radioSortDesc.TabStop = true;
            this.radioSortDesc.Text = "убыв.";
            this.radioSortDesc.UseVisualStyleBackColor = true;
            this.radioSortDesc.CheckedChanged += new System.EventHandler(this.radioSortDesc_CheckedChanged);
            // 
            // radioSortAsc
            // 
            this.radioSortAsc.AutoSize = true;
            this.radioSortAsc.Location = new System.Drawing.Point(9, 15);
            this.radioSortAsc.Margin = new System.Windows.Forms.Padding(4);
            this.radioSortAsc.Name = "radioSortAsc";
            this.radioSortAsc.Size = new System.Drawing.Size(63, 21);
            this.radioSortAsc.TabIndex = 0;
            this.radioSortAsc.TabStop = true;
            this.radioSortAsc.Text = "возр.";
            this.radioSortAsc.UseVisualStyleBackColor = true;
            this.radioSortAsc.CheckedChanged += new System.EventHandler(this.radioSortAsc_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1182, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(489, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BottomLayoutPanel);
            this.Controls.Add(this.MainLayoutPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Егор Фисташкин";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.FlowLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel BottomLayoutPanel;
        private System.Windows.Forms.ComboBox ManuFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSortDesc;
        private System.Windows.Forms.RadioButton radioSortAsc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonAdd;
    }
}

