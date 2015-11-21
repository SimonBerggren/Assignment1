using System.Windows.Forms;

namespace Asssignment1
{
    partial class DefaultForm
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
            this.label = new System.Windows.Forms.Label();
            this.OpenSongButton = new System.Windows.Forms.Button();
            this.PlaySongButton = new System.Windows.Forms.Button();
            this.StopSongButton = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FixedSongText = new System.Windows.Forms.Label();
            this.CurrentSongLabel = new System.Windows.Forms.Label();
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.ResumeMusicButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IconPanel
            // 
            this.IconPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconPanel.Location = new System.Drawing.Point(214, 158);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(196, 190);
            this.IconPanel.TabIndex = 1;
            this.IconPanel.Visible = false;
            // 
            // StartDrawingLabelButton
            // 
            this.StartDrawingLabelButton.Location = new System.Drawing.Point(12, 128);
            this.StartDrawingLabelButton.Name = "StartDrawingLabelButton";
            this.StartDrawingLabelButton.Size = new System.Drawing.Size(95, 23);
            this.StartDrawingLabelButton.TabIndex = 2;
            this.StartDrawingLabelButton.Text = "Start";
            this.StartDrawingLabelButton.UseVisualStyleBackColor = true;
            this.StartDrawingLabelButton.Click += new System.EventHandler(this.StartDrawingLabelButton_Click);
            // 
            // StopDrawingLabelButton
            // 
            this.StopDrawingLabelButton.Location = new System.Drawing.Point(113, 129);
            this.StopDrawingLabelButton.Name = "StopDrawingLabelButton";
            this.StopDrawingLabelButton.Size = new System.Drawing.Size(95, 23);
            this.StopDrawingLabelButton.TabIndex = 3;
            this.StopDrawingLabelButton.Text = "Stop";
            this.StopDrawingLabelButton.UseVisualStyleBackColor = true;
            this.StopDrawingLabelButton.Click += new System.EventHandler(this.StopDrawingLabelButton_Click);
            // 
            // StartDrawingIconButton
            // 
            this.StartDrawingIconButton.Location = new System.Drawing.Point(214, 129);
            this.StartDrawingIconButton.Name = "StartDrawingIconButton";
            this.StartDrawingIconButton.Size = new System.Drawing.Size(95, 23);
            this.StartDrawingIconButton.TabIndex = 4;
            this.StartDrawingIconButton.Text = "Start";
            this.StartDrawingIconButton.UseVisualStyleBackColor = true;
            this.StartDrawingIconButton.Click += new System.EventHandler(this.StartDrawingIconButton_Click);
            // 
            // StopDrawingIconButton
            // 
            this.StopDrawingIconButton.Location = new System.Drawing.Point(315, 128);
            this.StopDrawingIconButton.Name = "StopDrawingIconButton";
            this.StopDrawingIconButton.Size = new System.Drawing.Size(95, 23);
            this.StopDrawingIconButton.TabIndex = 5;
            this.StopDrawingIconButton.Text = "Stop";
            this.StopDrawingIconButton.UseVisualStyleBackColor = true;
            this.StopDrawingIconButton.Click += new System.EventHandler(this.StopDrawingIconButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(74, 230);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 13);
            this.label.TabIndex = 0;
            this.label.Text = "LabelThread";
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
            this.PlaySongButton.Enabled = false;
            this.PlaySongButton.Location = new System.Drawing.Point(315, 61);
            this.PlaySongButton.Name = "PlaySongButton";
            this.PlaySongButton.Size = new System.Drawing.Size(95, 23);
            this.PlaySongButton.TabIndex = 7;
            this.PlaySongButton.Text = "Replay";
            this.PlaySongButton.UseVisualStyleBackColor = true;
            this.PlaySongButton.Click += new System.EventHandler(this.PlaySongButton_Click);
            // 
            // StopSongButton
            // 
            this.StopSongButton.Enabled = false;
            this.StopSongButton.Location = new System.Drawing.Point(113, 61);
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
            // CurrentSongLabel
            // 
            this.CurrentSongLabel.AutoSize = true;
            this.CurrentSongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSongLabel.Location = new System.Drawing.Point(166, 9);
            this.CurrentSongLabel.Name = "CurrentSongLabel";
            this.CurrentSongLabel.Size = new System.Drawing.Size(0, 22);
            this.CurrentSongLabel.TabIndex = 11;
            // 
            // LabelPanel
            // 
            this.LabelPanel.BackColor = System.Drawing.Color.Transparent;
            this.LabelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelPanel.Location = new System.Drawing.Point(12, 157);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(196, 190);
            this.LabelPanel.TabIndex = 2;
            this.LabelPanel.Visible = false;
            // 
            // ResumeMusicButton
            // 
            this.ResumeMusicButton.Enabled = false;
            this.ResumeMusicButton.Location = new System.Drawing.Point(214, 61);
            this.ResumeMusicButton.Name = "ResumeMusicButton";
            this.ResumeMusicButton.Size = new System.Drawing.Size(95, 23);
            this.ResumeMusicButton.TabIndex = 12;
            this.ResumeMusicButton.Text = "Resume";
            this.ResumeMusicButton.UseVisualStyleBackColor = true;
            this.ResumeMusicButton.Click += new System.EventHandler(this.ResumeMusicButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "LabelThread";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "RectangleThread";
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResumeMusicButton);
            this.Controls.Add(this.IconPanel);
            this.Controls.Add(this.LabelPanel);
            this.Controls.Add(this.CurrentSongLabel);
            this.Controls.Add(this.FixedSongText);
            this.Controls.Add(this.StopSongButton);
            this.Controls.Add(this.PlaySongButton);
            this.Controls.Add(this.OpenSongButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.StopDrawingIconButton);
            this.Controls.Add(this.StartDrawingIconButton);
            this.Controls.Add(this.StopDrawingLabelButton);
            this.Controls.Add(this.StartDrawingLabelButton);
            this.Name = "DefaultForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DefaultForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel IconPanel;
        private Button StartDrawingLabelButton;
        private Button StopDrawingLabelButton;
        private Button StartDrawingIconButton;
        private Button StopDrawingIconButton;
        public Label label;
        private Button OpenSongButton;
        private Button PlaySongButton;
        private Button StopSongButton;
        private OpenFileDialog FileDialog;
        private Label FixedSongText;
        private Label CurrentSongLabel;
        private Panel LabelPanel;
        private Button ResumeMusicButton;
        private Label label1;
        private Label label2;
    }
}

