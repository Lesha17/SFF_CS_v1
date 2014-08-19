namespace Same_Files_Finder_CS_v1
{
    partial class Select_mask_form
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
            this.masks_tb = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.videos_gb = new System.Windows.Forms.GroupBox();
            this.documents_gb = new System.Windows.Forms.GroupBox();
            this.audio_gb = new System.Windows.Forms.GroupBox();
            this.images_gb = new System.Windows.Forms.GroupBox();
            this.videos_btn = new System.Windows.Forms.Button();
            this.documents_btn = new System.Windows.Forms.Button();
            this.music_btn = new System.Windows.Forms.Button();
            this.images_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.videos_gb.SuspendLayout();
            this.documents_gb.SuspendLayout();
            this.audio_gb.SuspendLayout();
            this.images_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // masks_tb
            // 
            this.masks_tb.Location = new System.Drawing.Point(12, 12);
            this.masks_tb.Name = "masks_tb";
            this.masks_tb.Size = new System.Drawing.Size(218, 20);
            this.masks_tb.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.videos_gb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.documents_gb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.audio_gb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.images_gb, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 340);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // videos_gb
            // 
            this.videos_gb.Controls.Add(this.videos_btn);
            this.videos_gb.Location = new System.Drawing.Point(152, 3);
            this.videos_gb.Name = "videos_gb";
            this.videos_gb.Size = new System.Drawing.Size(143, 158);
            this.videos_gb.TabIndex = 1;
            this.videos_gb.TabStop = false;
            this.videos_gb.Tag = "*.avi *.mpeg *.mp2 *.mp4 *.mkv *.flv ";
            this.videos_gb.Text = "Видеофайлы";
            // 
            // documents_gb
            // 
            this.documents_gb.Controls.Add(this.documents_btn);
            this.documents_gb.Location = new System.Drawing.Point(152, 173);
            this.documents_gb.Name = "documents_gb";
            this.documents_gb.Size = new System.Drawing.Size(143, 164);
            this.documents_gb.TabIndex = 3;
            this.documents_gb.TabStop = false;
            this.documents_gb.Tag = "*.pdf *.djvu *.doc *.docx *.xls *.xl *.ppt *.pptx";
            this.documents_gb.Text = "Документы";
            // 
            // audio_gb
            // 
            this.audio_gb.Controls.Add(this.music_btn);
            this.audio_gb.Location = new System.Drawing.Point(3, 173);
            this.audio_gb.Name = "audio_gb";
            this.audio_gb.Size = new System.Drawing.Size(143, 164);
            this.audio_gb.TabIndex = 2;
            this.audio_gb.TabStop = false;
            this.audio_gb.Tag = "*.mp3 *.vaw *.vawe";
            this.audio_gb.Text = "Аудиофайлы";
            // 
            // images_gb
            // 
            this.images_gb.Controls.Add(this.images_btn);
            this.images_gb.Location = new System.Drawing.Point(3, 3);
            this.images_gb.Name = "images_gb";
            this.images_gb.Size = new System.Drawing.Size(143, 164);
            this.images_gb.TabIndex = 0;
            this.images_gb.TabStop = false;
            this.images_gb.Tag = "*.jpg *.jpeg  *.png *.bmp *.gif";
            this.images_gb.Text = "Изображения";
            // 
            // videos_btn
            // 
            this.videos_btn.Image = global::Same_Files_Finder_CS_v1.Properties.Resources.Video1;
            this.videos_btn.Location = new System.Drawing.Point(7, 20);
            this.videos_btn.Name = "videos_btn";
            this.videos_btn.Size = new System.Drawing.Size(130, 138);
            this.videos_btn.TabIndex = 0;
            this.videos_btn.Tag = "*.avi *.mpeg *.mp2 *.mp4 *.mkv ";
            this.videos_btn.UseVisualStyleBackColor = true;
            this.videos_btn.Click += new System.EventHandler(this.videos_btn_Click);
            // 
            // documents_btn
            // 
            this.documents_btn.Image = global::Same_Files_Finder_CS_v1.Properties.Resources.my_document;
            this.documents_btn.Location = new System.Drawing.Point(7, 20);
            this.documents_btn.Name = "documents_btn";
            this.documents_btn.Size = new System.Drawing.Size(130, 144);
            this.documents_btn.TabIndex = 0;
            this.documents_btn.Tag = "*.pdf *.djvu *.doc *.docx *.xls *.xl *.ppt *.pptx";
            this.documents_btn.UseVisualStyleBackColor = true;
            this.documents_btn.Click += new System.EventHandler(this.documents_btn_Click);
            // 
            // music_btn
            // 
            this.music_btn.Image = global::Same_Files_Finder_CS_v1.Properties.Resources.blue_music_icon;
            this.music_btn.Location = new System.Drawing.Point(7, 20);
            this.music_btn.Name = "music_btn";
            this.music_btn.Size = new System.Drawing.Size(130, 144);
            this.music_btn.TabIndex = 0;
            this.music_btn.Tag = "*.mp3 *.wav";
            this.music_btn.UseVisualStyleBackColor = true;
            this.music_btn.Click += new System.EventHandler(this.music_btn_Click);
            // 
            // images_btn
            // 
            this.images_btn.Image = global::Same_Files_Finder_CS_v1.Properties.Resources.IPhoto_Icon;
            this.images_btn.Location = new System.Drawing.Point(6, 19);
            this.images_btn.Name = "images_btn";
            this.images_btn.Size = new System.Drawing.Size(131, 139);
            this.images_btn.TabIndex = 0;
            this.images_btn.Tag = "*.jpg *.jpeg *.bmp *.gif";
            this.images_btn.UseVisualStyleBackColor = true;
            this.images_btn.Click += new System.EventHandler(this.images_btn_Click);
            // 
            // Select_mask_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(319, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.masks_tb);
            this.Name = "Select_mask_form";
            this.Text = "Выбор типа файлов";
            this.Icon = global::Same_Files_Finder_CS_v1.Properties.Resources.favicon;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.videos_gb.ResumeLayout(false);
            this.documents_gb.ResumeLayout(false);
            this.audio_gb.ResumeLayout(false);
            this.images_gb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox masks_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox videos_gb;
        private System.Windows.Forms.GroupBox documents_gb;
        private System.Windows.Forms.GroupBox audio_gb;
        private System.Windows.Forms.GroupBox images_gb;
        private System.Windows.Forms.Button videos_btn;
        private System.Windows.Forms.Button images_btn;
        private System.Windows.Forms.Button music_btn;
        private System.Windows.Forms.Button documents_btn;
    }
}