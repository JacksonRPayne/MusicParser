namespace MusicParser
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tempoTrack = new System.Windows.Forms.TrackBar();
            this.tempoLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tempoTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.Location = new System.Drawing.Point(12, 70);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tempoTrack
            // 
            this.tempoTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tempoTrack.Location = new System.Drawing.Point(93, 70);
            this.tempoTrack.Maximum = 300;
            this.tempoTrack.Minimum = 45;
            this.tempoTrack.Name = "tempoTrack";
            this.tempoTrack.Size = new System.Drawing.Size(104, 45);
            this.tempoTrack.TabIndex = 2;
            this.tempoTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tempoTrack.Value = 45;
            this.tempoTrack.ValueChanged += new System.EventHandler(this.tempoTrack_ValueChanged);
            // 
            // tempoLabel
            // 
            this.tempoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tempoLabel.AutoSize = true;
            this.tempoLabel.Location = new System.Drawing.Point(93, 54);
            this.tempoLabel.Name = "tempoLabel";
            this.tempoLabel.Size = new System.Drawing.Size(58, 13);
            this.tempoLabel.TabIndex = 3;
            this.tempoLabel.Text = "Tempo: 45";
            // 
            // fileLabel
            // 
            this.fileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(93, 12);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(26, 13);
            this.fileLabel.TabIndex = 4;
            this.fileLabel.Text = "File:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 105);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.tempoLabel);
            this.Controls.Add(this.tempoTrack);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Music Parser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tempoTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TrackBar tempoTrack;
        private System.Windows.Forms.Label tempoLabel;
        private System.Windows.Forms.Label fileLabel;
    }
}

