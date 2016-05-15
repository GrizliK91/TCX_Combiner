namespace TCX_Combiner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_load_endo = new System.Windows.Forms.Button();
            this.button_load_garmin = new System.Windows.Forms.Button();
            this.button_combine = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.listBox_endo = new System.Windows.Forms.ListBox();
            this.listBox_garm = new System.Windows.Forms.ListBox();
            this.listBox_output = new System.Windows.Forms.ListBox();
            this.label_count_heart = new System.Windows.Forms.Label();
            this.label_count_time = new System.Windows.Forms.Label();
            this.button_clear_endo = new System.Windows.Forms.Button();
            this.button_clear_garm = new System.Windows.Forms.Button();
            this.button_clear_combine = new System.Windows.Forms.Button();
            this.label_dragndrop1 = new System.Windows.Forms.Label();
            this.label_dragndrop2 = new System.Windows.Forms.Label();
            this.label_about = new System.Windows.Forms.Label();
            this.button_save_heart_rate_only = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_load_endo
            // 
            this.button_load_endo.Location = new System.Drawing.Point(12, 12);
            this.button_load_endo.Name = "button_load_endo";
            this.button_load_endo.Size = new System.Drawing.Size(140, 23);
            this.button_load_endo.TabIndex = 1;
            this.button_load_endo.Text = "Endomondo TCX Load";
            this.button_load_endo.UseVisualStyleBackColor = true;
            this.button_load_endo.Click += new System.EventHandler(this.button_load_endo_Click);
            // 
            // button_load_garmin
            // 
            this.button_load_garmin.Location = new System.Drawing.Point(347, 12);
            this.button_load_garmin.Name = "button_load_garmin";
            this.button_load_garmin.Size = new System.Drawing.Size(140, 23);
            this.button_load_garmin.TabIndex = 3;
            this.button_load_garmin.Text = "Garmin TCX Load";
            this.button_load_garmin.UseVisualStyleBackColor = true;
            this.button_load_garmin.Click += new System.EventHandler(this.button_load_garmin_Click);
            // 
            // button_combine
            // 
            this.button_combine.Enabled = false;
            this.button_combine.Location = new System.Drawing.Point(685, 12);
            this.button_combine.Name = "button_combine";
            this.button_combine.Size = new System.Drawing.Size(140, 23);
            this.button_combine.TabIndex = 8;
            this.button_combine.Text = "Combine";
            this.button_combine.UseVisualStyleBackColor = true;
            this.button_combine.Click += new System.EventHandler(this.button_combine_Click);
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(685, 493);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(318, 27);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "Save file";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // listBox_endo
            // 
            this.listBox_endo.AllowDrop = true;
            this.listBox_endo.FormattingEnabled = true;
            this.listBox_endo.Location = new System.Drawing.Point(12, 41);
            this.listBox_endo.Name = "listBox_endo";
            this.listBox_endo.Size = new System.Drawing.Size(318, 446);
            this.listBox_endo.TabIndex = 15;
            this.listBox_endo.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_endo_DragDrop);
            this.listBox_endo.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_endo_DragEnter);
            // 
            // listBox_garm
            // 
            this.listBox_garm.AllowDrop = true;
            this.listBox_garm.FormattingEnabled = true;
            this.listBox_garm.Location = new System.Drawing.Point(347, 41);
            this.listBox_garm.Name = "listBox_garm";
            this.listBox_garm.Size = new System.Drawing.Size(318, 446);
            this.listBox_garm.TabIndex = 16;
            this.listBox_garm.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_garm_DragDrop);
            this.listBox_garm.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_garm_DragEnter);
            // 
            // listBox_output
            // 
            this.listBox_output.FormattingEnabled = true;
            this.listBox_output.Location = new System.Drawing.Point(685, 41);
            this.listBox_output.Name = "listBox_output";
            this.listBox_output.Size = new System.Drawing.Size(318, 446);
            this.listBox_output.TabIndex = 17;
            // 
            // label_count_heart
            // 
            this.label_count_heart.AutoSize = true;
            this.label_count_heart.Location = new System.Drawing.Point(347, 493);
            this.label_count_heart.Name = "label_count_heart";
            this.label_count_heart.Size = new System.Drawing.Size(67, 13);
            this.label_count_heart.TabIndex = 18;
            this.label_count_heart.Text = "Count Heart:";
            // 
            // label_count_time
            // 
            this.label_count_time.AutoSize = true;
            this.label_count_time.Location = new System.Drawing.Point(347, 510);
            this.label_count_time.Name = "label_count_time";
            this.label_count_time.Size = new System.Drawing.Size(64, 13);
            this.label_count_time.TabIndex = 19;
            this.label_count_time.Text = "Count Time:";
            // 
            // button_clear_endo
            // 
            this.button_clear_endo.Enabled = false;
            this.button_clear_endo.Location = new System.Drawing.Point(190, 12);
            this.button_clear_endo.Name = "button_clear_endo";
            this.button_clear_endo.Size = new System.Drawing.Size(140, 23);
            this.button_clear_endo.TabIndex = 20;
            this.button_clear_endo.Text = "Clear";
            this.button_clear_endo.UseVisualStyleBackColor = true;
            this.button_clear_endo.Click += new System.EventHandler(this.button_clear_endo_Click);
            // 
            // button_clear_garm
            // 
            this.button_clear_garm.Enabled = false;
            this.button_clear_garm.Location = new System.Drawing.Point(525, 12);
            this.button_clear_garm.Name = "button_clear_garm";
            this.button_clear_garm.Size = new System.Drawing.Size(140, 23);
            this.button_clear_garm.TabIndex = 21;
            this.button_clear_garm.Text = "Clear";
            this.button_clear_garm.UseVisualStyleBackColor = true;
            this.button_clear_garm.Click += new System.EventHandler(this.button_clear_garm_Click);
            // 
            // button_clear_combine
            // 
            this.button_clear_combine.Enabled = false;
            this.button_clear_combine.Location = new System.Drawing.Point(863, 12);
            this.button_clear_combine.Name = "button_clear_combine";
            this.button_clear_combine.Size = new System.Drawing.Size(140, 23);
            this.button_clear_combine.TabIndex = 22;
            this.button_clear_combine.Text = "Clear";
            this.button_clear_combine.UseVisualStyleBackColor = true;
            this.button_clear_combine.Click += new System.EventHandler(this.button_clear_combine_Click);
            // 
            // label_dragndrop1
            // 
            this.label_dragndrop1.AutoSize = true;
            this.label_dragndrop1.BackColor = System.Drawing.SystemColors.Window;
            this.label_dragndrop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dragndrop1.Location = new System.Drawing.Point(46, 240);
            this.label_dragndrop1.Name = "label_dragndrop1";
            this.label_dragndrop1.Size = new System.Drawing.Size(226, 24);
            this.label_dragndrop1.TabIndex = 23;
            this.label_dragndrop1.Text = "Drop here to load your file";
            // 
            // label_dragndrop2
            // 
            this.label_dragndrop2.AutoSize = true;
            this.label_dragndrop2.BackColor = System.Drawing.SystemColors.Window;
            this.label_dragndrop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dragndrop2.Location = new System.Drawing.Point(387, 240);
            this.label_dragndrop2.Name = "label_dragndrop2";
            this.label_dragndrop2.Size = new System.Drawing.Size(226, 24);
            this.label_dragndrop2.TabIndex = 24;
            this.label_dragndrop2.Text = "Drop here to load your file";
            // 
            // label_about
            // 
            this.label_about.AutoSize = true;
            this.label_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_about.ForeColor = System.Drawing.Color.Blue;
            this.label_about.Location = new System.Drawing.Point(9, 505);
            this.label_about.Name = "label_about";
            this.label_about.Size = new System.Drawing.Size(38, 15);
            this.label_about.TabIndex = 25;
            this.label_about.Text = "About";
            this.label_about.Click += new System.EventHandler(this.label_about_Click);
            // 
            // button_save_heart_rate_only
            // 
            this.button_save_heart_rate_only.Enabled = false;
            this.button_save_heart_rate_only.Location = new System.Drawing.Point(525, 493);
            this.button_save_heart_rate_only.Name = "button_save_heart_rate_only";
            this.button_save_heart_rate_only.Size = new System.Drawing.Size(140, 27);
            this.button_save_heart_rate_only.TabIndex = 26;
            this.button_save_heart_rate_only.Text = "Save heart rate file";
            this.button_save_heart_rate_only.UseVisualStyleBackColor = true;
            this.button_save_heart_rate_only.Click += new System.EventHandler(this.button_save_heart_rate_only_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 532);
            this.Controls.Add(this.button_save_heart_rate_only);
            this.Controls.Add(this.label_about);
            this.Controls.Add(this.label_dragndrop2);
            this.Controls.Add(this.label_dragndrop1);
            this.Controls.Add(this.button_clear_combine);
            this.Controls.Add(this.button_clear_garm);
            this.Controls.Add(this.button_clear_endo);
            this.Controls.Add(this.label_count_time);
            this.Controls.Add(this.label_count_heart);
            this.Controls.Add(this.listBox_output);
            this.Controls.Add(this.listBox_garm);
            this.Controls.Add(this.listBox_endo);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_combine);
            this.Controls.Add(this.button_load_garmin);
            this.Controls.Add(this.button_load_endo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TCX Combiner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_load_endo;
        private System.Windows.Forms.Button button_load_garmin;
        private System.Windows.Forms.Button button_combine;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ListBox listBox_endo;
        private System.Windows.Forms.ListBox listBox_garm;
        private System.Windows.Forms.ListBox listBox_output;
        private System.Windows.Forms.Label label_count_heart;
        private System.Windows.Forms.Label label_count_time;
        private System.Windows.Forms.Button button_clear_endo;
        private System.Windows.Forms.Button button_clear_garm;
        private System.Windows.Forms.Button button_clear_combine;
        private System.Windows.Forms.Label label_dragndrop1;
        private System.Windows.Forms.Label label_dragndrop2;
        private System.Windows.Forms.Label label_about;
        private System.Windows.Forms.Button button_save_heart_rate_only;
    }
}

