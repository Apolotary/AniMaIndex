namespace AniMaIndex.View
{
    partial class ControlAdAnime
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aniEpsBox = new System.Windows.Forms.TextBox();
            this.aniNameBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.addAniBut = new System.Windows.Forms.Button();
            this.aniGenreBox = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.airedBox = new System.Windows.Forms.ComboBox();
            this.mangaBox = new System.Windows.Forms.ComboBox();
            this.studBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aniEpsBox
            // 
            this.aniEpsBox.Location = new System.Drawing.Point(438, 381);
            this.aniEpsBox.Name = "aniEpsBox";
            this.aniEpsBox.Size = new System.Drawing.Size(161, 20);
            this.aniEpsBox.TabIndex = 25;
            this.aniEpsBox.Text = "# of episodes";
            // 
            // aniNameBox
            // 
            this.aniNameBox.Location = new System.Drawing.Point(438, 328);
            this.aniNameBox.Name = "aniNameBox";
            this.aniNameBox.Size = new System.Drawing.Size(161, 20);
            this.aniNameBox.TabIndex = 24;
            this.aniNameBox.Text = "Name";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(438, 484);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(422, 20);
            this.descriptionBox.TabIndex = 23;
            this.descriptionBox.Text = "Short description";
            // 
            // addAniBut
            // 
            this.addAniBut.Location = new System.Drawing.Point(565, 510);
            this.addAniBut.Name = "addAniBut";
            this.addAniBut.Size = new System.Drawing.Size(161, 54);
            this.addAniBut.TabIndex = 22;
            this.addAniBut.Text = "Add New Anime";
            this.addAniBut.UseVisualStyleBackColor = true;
            this.addAniBut.Click += new System.EventHandler(this.addAniBut_Click);
            // 
            // aniGenreBox
            // 
            this.aniGenreBox.FormattingEnabled = true;
            this.aniGenreBox.Location = new System.Drawing.Point(438, 354);
            this.aniGenreBox.Name = "aniGenreBox";
            this.aniGenreBox.Size = new System.Drawing.Size(161, 21);
            this.aniGenreBox.TabIndex = 26;
            this.aniGenreBox.Text = "Genre";
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(699, 430);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(161, 21);
            this.typeBox.TabIndex = 29;
            this.typeBox.Text = "Type";
            // 
            // airedBox
            // 
            this.airedBox.FormattingEnabled = true;
            this.airedBox.Location = new System.Drawing.Point(699, 457);
            this.airedBox.Name = "airedBox";
            this.airedBox.Size = new System.Drawing.Size(161, 21);
            this.airedBox.TabIndex = 30;
            this.airedBox.Text = "Aired yet?";
            // 
            // mangaBox
            // 
            this.mangaBox.FormattingEnabled = true;
            this.mangaBox.Location = new System.Drawing.Point(438, 430);
            this.mangaBox.Name = "mangaBox";
            this.mangaBox.Size = new System.Drawing.Size(161, 21);
            this.mangaBox.TabIndex = 27;
            this.mangaBox.Text = "Manga";
            // 
            // studBox
            // 
            this.studBox.FormattingEnabled = true;
            this.studBox.Location = new System.Drawing.Point(438, 457);
            this.studBox.Name = "studBox";
            this.studBox.Size = new System.Drawing.Size(161, 21);
            this.studBox.TabIndex = 28;
            this.studBox.Text = "Studio";
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(699, 381);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(161, 20);
            this.yearBox.TabIndex = 31;
            this.yearBox.Text = "Year";
            // 
            // ControlAdAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.airedBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.studBox);
            this.Controls.Add(this.mangaBox);
            this.Controls.Add(this.aniGenreBox);
            this.Controls.Add(this.aniEpsBox);
            this.Controls.Add(this.aniNameBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.addAniBut);
            this.Name = "ControlAdAnime";
            this.Controls.SetChildIndex(this.addAniBut, 0);
            this.Controls.SetChildIndex(this.descriptionBox, 0);
            this.Controls.SetChildIndex(this.aniNameBox, 0);
            this.Controls.SetChildIndex(this.aniEpsBox, 0);
            this.Controls.SetChildIndex(this.aniGenreBox, 0);
            this.Controls.SetChildIndex(this.mangaBox, 0);
            this.Controls.SetChildIndex(this.studBox, 0);
            this.Controls.SetChildIndex(this.typeBox, 0);
            this.Controls.SetChildIndex(this.airedBox, 0);
            this.Controls.SetChildIndex(this.yearBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aniEpsBox;
        private System.Windows.Forms.TextBox aniNameBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button addAniBut;
        private System.Windows.Forms.ComboBox aniGenreBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ComboBox airedBox;
        private System.Windows.Forms.ComboBox mangaBox;
        private System.Windows.Forms.ComboBox studBox;
        private System.Windows.Forms.TextBox yearBox;
    }
}
