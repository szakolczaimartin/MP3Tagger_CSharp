namespace MondayDriver
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
            this.Drive = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pathText = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mp3TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.artistBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.albumBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Drive
            // 
            this.Drive.AutoSize = true;
            this.Drive.Location = new System.Drawing.Point(13, 30);
            this.Drive.Name = "Drive";
            this.Drive.Size = new System.Drawing.Size(32, 13);
            this.Drive.TabIndex = 0;
            this.Drive.Text = "Drive";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(61, 67);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(235, 20);
            this.pathText.TabIndex = 2;
            // 
            // Path
            // 
            this.Path.AutoSize = true;
            this.Path.Location = new System.Drawing.Point(13, 70);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(29, 13);
            this.Path.TabIndex = 3;
            this.Path.Text = "Path";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 212);
            this.listBox1.TabIndex = 4;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mp3";
            // 
            // mp3TextBox
            // 
            this.mp3TextBox.Location = new System.Drawing.Point(371, 27);
            this.mp3TextBox.Name = "mp3TextBox";
            this.mp3TextBox.Size = new System.Drawing.Size(232, 20);
            this.mp3TextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Artist";
            // 
            // tagBox
            // 
            this.tagBox.Location = new System.Drawing.Point(410, 100);
            this.tagBox.MaxLength = 3;
            this.tagBox.Name = "tagBox";
            this.tagBox.ReadOnly = true;
            this.tagBox.Size = new System.Drawing.Size(193, 20);
            this.tagBox.TabIndex = 11;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(410, 129);
            this.titleBox.MaxLength = 30;
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(193, 20);
            this.titleBox.TabIndex = 12;
            // 
            // artistBox
            // 
            this.artistBox.Location = new System.Drawing.Point(410, 155);
            this.artistBox.MaxLength = 30;
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(193, 20);
            this.artistBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Album";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Comment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Genre";
            // 
            // albumBox
            // 
            this.albumBox.Location = new System.Drawing.Point(410, 187);
            this.albumBox.MaxLength = 30;
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(193, 20);
            this.albumBox.TabIndex = 18;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(410, 215);
            this.yearBox.MaxLength = 4;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(193, 20);
            this.yearBox.TabIndex = 19;
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(410, 247);
            this.commentBox.MaxLength = 30;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(193, 20);
            this.commentBox.TabIndex = 20;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(410, 284);
            this.genreBox.MaxLength = 1;
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(193, 20);
            this.genreBox.TabIndex = 21;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(504, 321);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 24);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 374);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.artistBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mp3TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Drive);
            this.Name = "Form1";
            this.Text = "Mp3Tagger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Drive;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mp3TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox artistBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox albumBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.Button saveButton;
    }
}

