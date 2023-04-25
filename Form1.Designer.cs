namespace slide_show
{
    partial class Image_view
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
            this.prev_file = new System.Windows.Forms.Button();
            this.next_file = new System.Windows.Forms.Button();
            this.departure = new System.Windows.Forms.Button();
            this.pict_box = new System.Windows.Forms.PictureBox();
            this.loading = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pict_box)).BeginInit();
            this.SuspendLayout();
            // 
            // prev_file
            // 
            this.prev_file.Location = new System.Drawing.Point(188, 390);
            this.prev_file.Name = "prev_file";
            this.prev_file.Size = new System.Drawing.Size(82, 48);
            this.prev_file.TabIndex = 1;
            this.prev_file.Text = "предыдущий файл";
            this.prev_file.UseVisualStyleBackColor = true;
            this.prev_file.Click += new System.EventHandler(this.prev_file_Click);
            // 
            // next_file
            // 
            this.next_file.Location = new System.Drawing.Point(439, 390);
            this.next_file.Name = "next_file";
            this.next_file.Size = new System.Drawing.Size(75, 48);
            this.next_file.TabIndex = 3;
            this.next_file.Text = "следующий файл";
            this.next_file.UseVisualStyleBackColor = true;
            this.next_file.Click += new System.EventHandler(this.next_file_Click);
            // 
            // departure
            // 
            this.departure.Location = new System.Drawing.Point(308, 386);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(75, 23);
            this.departure.TabIndex = 4;
            this.departure.Text = "сохранение";
            this.departure.UseVisualStyleBackColor = true;
            this.departure.Click += new System.EventHandler(this.departure_Click);
            // 
            // pict_box
            // 
            this.pict_box.Location = new System.Drawing.Point(49, 42);
            this.pict_box.Name = "pict_box";
            this.pict_box.Size = new System.Drawing.Size(681, 320);
            this.pict_box.TabIndex = 5;
            this.pict_box.TabStop = false;
            this.pict_box.Paint += new System.Windows.Forms.PaintEventHandler(this.pict_box_Paint);
            // 
            // loading
            // 
            this.loading.Location = new System.Drawing.Point(308, 415);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(75, 23);
            this.loading.TabIndex = 2;
            this.loading.Text = "загрузка";
            this.loading.UseVisualStyleBackColor = true;
            this.loading.Click += new System.EventHandler(this.loading_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(579, 405);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 6;
            this.label.Text = "label1";
            // 
            // Image_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pict_box);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.next_file);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.prev_file);
            this.Name = "Image_view";
            this.Text = "image view";
            ((System.ComponentModel.ISupportInitialize)(this.pict_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button prev_file;
        private System.Windows.Forms.Button next_file;
        private System.Windows.Forms.Button departure;
        private System.Windows.Forms.PictureBox pict_box;
        private System.Windows.Forms.Button loading;
        private System.Windows.Forms.Label label;
    }
}

