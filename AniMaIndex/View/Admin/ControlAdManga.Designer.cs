namespace AniMaIndex.View
{
    partial class ControlAdManga
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
            this.publishedStatBox = new System.Windows.Forms.ComboBox();
            this.publisherBox = new System.Windows.Forms.ComboBox();
            this.manGenreBox = new System.Windows.Forms.ComboBox();
            this.thomesBox = new System.Windows.Forms.TextBox();
            this.manNameBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.addManBut = new System.Windows.Forms.Button();
            this.chapsBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // publishedStatBox
            // 
            this.publishedStatBox.FormattingEnabled = true;
            this.publishedStatBox.Location = new System.Drawing.Point(647, 434);
            this.publishedStatBox.Name = "publishedStatBox";
            this.publishedStatBox.Size = new System.Drawing.Size(161, 21);
            this.publishedStatBox.TabIndex = 39;
            this.publishedStatBox.Text = "Published yet?";
            // 
            // publisherBox
            // 
            this.publisherBox.FormattingEnabled = true;
            this.publisherBox.Location = new System.Drawing.Point(647, 407);
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.Size = new System.Drawing.Size(161, 21);
            this.publisherBox.TabIndex = 37;
            this.publisherBox.Text = "Publisher";
            // 
            // manGenreBox
            // 
            this.manGenreBox.FormattingEnabled = true;
            this.manGenreBox.Location = new System.Drawing.Point(386, 331);
            this.manGenreBox.Name = "manGenreBox";
            this.manGenreBox.Size = new System.Drawing.Size(161, 21);
            this.manGenreBox.TabIndex = 35;
            this.manGenreBox.Text = "Genre";
            // 
            // thomesBox
            // 
            this.thomesBox.Location = new System.Drawing.Point(386, 434);
            this.thomesBox.Name = "thomesBox";
            this.thomesBox.Size = new System.Drawing.Size(161, 20);
            this.thomesBox.TabIndex = 34;
            this.thomesBox.Text = "# of thomes";
            // 
            // manNameBox
            // 
            this.manNameBox.Location = new System.Drawing.Point(386, 305);
            this.manNameBox.Name = "manNameBox";
            this.manNameBox.Size = new System.Drawing.Size(161, 20);
            this.manNameBox.TabIndex = 33;
            this.manNameBox.Text = "Name";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(386, 461);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(422, 20);
            this.descriptionBox.TabIndex = 32;
            this.descriptionBox.Text = "Short description";
            // 
            // addManBut
            // 
            this.addManBut.Location = new System.Drawing.Point(514, 487);
            this.addManBut.Name = "addManBut";
            this.addManBut.Size = new System.Drawing.Size(161, 54);
            this.addManBut.TabIndex = 31;
            this.addManBut.Text = "Add New Manga";
            this.addManBut.UseVisualStyleBackColor = true;
            this.addManBut.Click += new System.EventHandler(this.addManBut_Click);
            // 
            // chapsBox
            // 
            this.chapsBox.Location = new System.Drawing.Point(386, 407);
            this.chapsBox.Name = "chapsBox";
            this.chapsBox.Size = new System.Drawing.Size(161, 20);
            this.chapsBox.TabIndex = 40;
            this.chapsBox.Text = "# of chapters";
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(386, 358);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(161, 21);
            this.yearBox.TabIndex = 41;
            this.yearBox.Text = "Year";
            // 
            // ControlAdManga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.chapsBox);
            this.Controls.Add(this.publishedStatBox);
            this.Controls.Add(this.publisherBox);
            this.Controls.Add(this.manGenreBox);
            this.Controls.Add(this.thomesBox);
            this.Controls.Add(this.manNameBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.addManBut);
            this.Name = "ControlAdManga";
            this.Controls.SetChildIndex(this.addManBut, 0);
            this.Controls.SetChildIndex(this.descriptionBox, 0);
            this.Controls.SetChildIndex(this.manNameBox, 0);
            this.Controls.SetChildIndex(this.thomesBox, 0);
            this.Controls.SetChildIndex(this.manGenreBox, 0);
            this.Controls.SetChildIndex(this.publisherBox, 0);
            this.Controls.SetChildIndex(this.publishedStatBox, 0);
            this.Controls.SetChildIndex(this.chapsBox, 0);
            this.Controls.SetChildIndex(this.yearBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox publishedStatBox;
        private System.Windows.Forms.ComboBox publisherBox;
        private System.Windows.Forms.ComboBox manGenreBox;
        private System.Windows.Forms.TextBox thomesBox;
        private System.Windows.Forms.TextBox manNameBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button addManBut;
        private System.Windows.Forms.TextBox chapsBox;
        private System.Windows.Forms.ComboBox yearBox;
    }
}
