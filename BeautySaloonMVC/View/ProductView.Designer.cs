namespace BeautySaloonMVC.View
{
    partial class ProductView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelActive = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelProductName.Location = new System.Drawing.Point(4, 209);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(350, 45);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Название";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCost
            // 
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelCost.Location = new System.Drawing.Point(5, 254);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(350, 23);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Цена";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCost.Click += new System.EventHandler(this.labelCost_Click);
            // 
            // labelActive
            // 
            this.labelActive.Location = new System.Drawing.Point(3, 277);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(352, 23);
            this.labelActive.TabIndex = 3;
            this.labelActive.Text = "Не активен";
            this.labelActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelActive);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(360, 304);
            this.Load += new System.EventHandler(this.ProductView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelActive;
    }
}
