using System;
using System.Windows.Forms;

namespace Asssignment1
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
            this.IconPanel = new System.Windows.Forms.Panel();
            this.StartDrawingLabelButton = new System.Windows.Forms.Button();
            this.StopDrawingLabelButton = new System.Windows.Forms.Button();
            this.StartDrawingIconButton = new System.Windows.Forms.Button();
            this.StopDrawingIconButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OpenSongButton = new System.Windows.Forms.Button();
            this.PlaySongButton = new System.Windows.Forms.Button();
            this.StopSongButton = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PauseSongButton = new System.Windows.Forms.Button();
            this.FixedSongText = new System.Windows.Forms.Label();
            this.CurrentSongText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IconPanel
            // 
            this.IconPanel.Location = new System.Drawing.Point(246, 211);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(200, 190);
            this.IconPanel.TabIndex = 1;
            this.IconPanel.Visible = false;
            // 
            // StartDrawingLabelButton
            // 
            this.StartDrawingLabelButton.Location = new System.Drawing.Point(12, 182);
            this.StartDrawingLabelButton.Name = "StartDrawingLabelButton";
            this.StartDrawingLabelButton.Size = new System.Drawing.Size(95, 23);
            this.StartDrawingLabelButton.TabIndex = 2;
            this.StartDrawingLabelButton.Text = "Start";
            this.StartDrawingLabelButton.UseVisualStyleBackColor = true;
            this.StartDrawingLabelButton.Click += new System.EventHandler(this.StartDrawingLabelButton_Click);
            // 
            // StopDrawingLabelButton
            // 
            this.StopDrawingLabelButton.Location = new System.Drawing.Point(120, 182);
            this.StopDrawingLabelButton.Name = "StopDrawingLabelButton";
            this.StopDrawingLabelButton.Size = new System.Drawing.Size(95, 23);
            this.StopDrawingLabelButton.TabIndex = 3;
            this.StopDrawingLabelButton.Text = "Stop";
            this.StopDrawingLabelButton.UseVisualStyleBackColor = true;
            this.StopDrawingLabelButton.Click += new System.EventHandler(this.StopDrawingLabelButton_Click);
            // 
            // StartDrawingIconButton
            // 
            this.StartDrawingIconButton.Location = new System.Drawing.Point(246, 182);
            this.StartDrawingIconButton.Name = "StartDrawingIconButton";
            this.StartDrawingIconButton.Size = new System.Drawing.Size(95, 23);
            this.StartDrawingIconButton.TabIndex = 4;
            this.StartDrawingIconButton.Text = "Start";
            this.StartDrawingIconButton.UseVisualStyleBackColor = true;
            this.StartDrawingIconButton.Click += new System.EventHandler(this.StartDrawingIconButton_Click);
            // 
            // StopDrawingIconButton
            // 
            this.StopDrawingIconButton.Location = new System.Drawing.Point(354, 182);
            this.StopDrawingIconButton.Name = "StopDrawingIconButton";
            this.StopDrawingIconButton.Size = new System.Drawing.Size(95, 23);
            this.StopDrawingIconButton.TabIndex = 5;
            this.StopDrawingIconButton.Text = "Stop";
            this.StopDrawingIconButton.UseVisualStyleBackColor = true;
            this.StopDrawingIconButton.Click += new System.EventHandler(this.StopDrawingIconButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "fdsafsda";
            // 
            // OpenSongButton
            // 
            this.OpenSongButton.Location = new System.Drawing.Point(12, 61);
            this.OpenSongButton.Name = "OpenSongButton";
            this.OpenSongButton.Size = new System.Drawing.Size(95, 23);
            this.OpenSongButton.TabIndex = 6;
            this.OpenSongButton.Text = "Open...";
            this.OpenSongButton.UseVisualStyleBackColor = true;
            this.OpenSongButton.Click += new System.EventHandler(this.OpenSongButton_Click);
            // 
            // PlaySongButton
            // 
            this.PlaySongButton.Location = new System.Drawing.Point(113, 61);
            this.PlaySongButton.Name = "PlaySongButton";
            this.PlaySongButton.Size = new System.Drawing.Size(95, 23);
            this.PlaySongButton.TabIndex = 7;
            this.PlaySongButton.Text = "Play";
            this.PlaySongButton.UseVisualStyleBackColor = true;
            this.PlaySongButton.Click += new System.EventHandler(this.PlaySongButton_Click);
            // 
            // StopSongButton
            // 
            this.StopSongButton.Location = new System.Drawing.Point(315, 61);
            this.StopSongButton.Name = "StopSongButton";
            this.StopSongButton.Size = new System.Drawing.Size(95, 23);
            this.StopSongButton.TabIndex = 8;
            this.StopSongButton.Text = "Stop";
            this.StopSongButton.UseVisualStyleBackColor = true;
            this.StopSongButton.Click += new System.EventHandler(this.StopSongButton_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = "MP3 files *.mp3|";
            this.FileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialog_FileOk);
            // 
            // PauseSongButton
            // 
            this.PauseSongButton.Location = new System.Drawing.Point(214, 61);
            this.PauseSongButton.Name = "PauseSongButton";
            this.PauseSongButton.Size = new System.Drawing.Size(95, 23);
            this.PauseSongButton.TabIndex = 9;
            this.PauseSongButton.Text = "Pause";
            this.PauseSongButton.UseVisualStyleBackColor = true;
            this.PauseSongButton.Click += new System.EventHandler(this.PauseSongButton_Click);
            // 
            // FixedSongText
            // 
            this.FixedSongText.AutoSize = true;
            this.FixedSongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixedSongText.Location = new System.Drawing.Point(8, 9);
            this.FixedSongText.Name = "FixedSongText";
            this.FixedSongText.Size = new System.Drawing.Size(152, 22);
            this.FixedSongText.TabIndex = 10;
            this.FixedSongText.Text = "Currently Playing:";
            // 
            // CurrentSongText
            // 
            this.CurrentSongText.AutoSize = true;
            this.CurrentSongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSongText.Location = new System.Drawing.Point(166, 9);
            this.CurrentSongText.Name = "CurrentSongText";
            this.CurrentSongText.Size = new System.Drawing.Size(0, 22);
            this.CurrentSongText.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 412);
            this.Controls.Add(this.CurrentSongText);
            this.Controls.Add(this.FixedSongText);
            this.Controls.Add(this.PauseSongButton);
            this.Controls.Add(this.StopSongButton);
            this.Controls.Add(this.PlaySongButton);
            this.Controls.Add(this.OpenSongButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopDrawingIconButton);
            this.Controls.Add(this.StartDrawingIconButton);
            this.Controls.Add(this.StopDrawingLabelButton);
            this.Controls.Add(this.StartDrawingLabelButton);
            this.Controls.Add(this.IconPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel IconPanel;
        private Button StartDrawingLabelButton;
        private Button StopDrawingLabelButton;
        private Button StartDrawingIconButton;
        private Button StopDrawingIconButton;
        public Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button OpenSongButton;
        private Button PlaySongButton;
        private Button StopSongButton;
        private OpenFileDialog FileDialog;
        private Button PauseSongButton;
        private Label FixedSongText;
        private Label CurrentSongText;
    }
}

