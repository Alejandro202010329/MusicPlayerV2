namespace MusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.track_list = new System.Windows.Forms.ListBox();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_tarck_end = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl_song_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_preview.Location = new System.Drawing.Point(12, 328);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(92, 30);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.Text = "Anterior";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_next.Location = new System.Drawing.Point(110, 328);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(92, 30);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Siguiente";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_play.Location = new System.Drawing.Point(208, 328);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(92, 30);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Reproducir";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_pause.Location = new System.Drawing.Point(306, 328);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(92, 30);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pausar";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_stop.Location = new System.Drawing.Point(407, 328);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(92, 30);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Detener";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_open
            // 
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_open.Location = new System.Drawing.Point(505, 328);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(272, 30);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "Abrir";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.track_list.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 16;
            this.track_list.Location = new System.Drawing.Point(237, 68);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(444, 212);
            this.track_list.TabIndex = 6;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // pic_art
            // 
            this.pic_art.Image = ((System.Drawing.Image)(resources.GetObject("pic_art.Image")));
            this.pic_art.Location = new System.Drawing.Point(15, 68);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(216, 212);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 7;
            this.pic_art.TabStop = false;
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(16, 300);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(761, 10);
            this.p_bar.TabIndex = 8;
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(707, 68);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(56, 197);
            this.track_volume.TabIndex = 10;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(687, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volumen";
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_track_start.Location = new System.Drawing.Point(12, 16);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(124, 46);
            this.lbl_track_start.TabIndex = 12;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_tarck_end
            // 
            this.lbl_tarck_end.AutoSize = true;
            this.lbl_tarck_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tarck_end.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tarck_end.Location = new System.Drawing.Point(662, 16);
            this.lbl_tarck_end.Name = "lbl_tarck_end";
            this.lbl_tarck_end.Size = new System.Drawing.Size(124, 46);
            this.lbl_tarck_end.TabIndex = 13;
            this.lbl_tarck_end.Text = "00:00";
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(786, 62);
            this.player.TabIndex = 9;
            this.player.Visible = false;
            // 
            // lbl_song_name
            // 
            this.lbl_song_name.AutoSize = true;
            this.lbl_song_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_song_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_song_name.Location = new System.Drawing.Point(298, 16);
            this.lbl_song_name.Name = "lbl_song_name";
            this.lbl_song_name.Size = new System.Drawing.Size(118, 46);
            this.lbl_song_name.TabIndex = 14;
            this.lbl_song_name.Text = "Song";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(786, 375);
            this.Controls.Add(this.lbl_song_name);
            this.Controls.Add(this.lbl_tarck_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.ProgressBar p_bar;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_tarck_end;
        private System.Windows.Forms.Label lbl_song_name;
    }
}

