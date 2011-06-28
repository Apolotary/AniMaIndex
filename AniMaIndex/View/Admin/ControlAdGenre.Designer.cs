namespace AniMaIndex.View
{
    partial class ControlAdGenre
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
            this.genreNameBox = new System.Windows.Forms.TextBox();
            this.addGenBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genreNameBox
            // 
            this.genreNameBox.Location = new System.Drawing.Point(592, 401);
            this.genreNameBox.Name = "genreNameBox";
            this.genreNameBox.Size = new System.Drawing.Size(161, 20);
            this.genreNameBox.TabIndex = 11;
            // 
            // addGenBut
            // 
            this.addGenBut.Location = new System.Drawing.Point(592, 450);
            this.addGenBut.Name = "addGenBut";
            this.addGenBut.Size = new System.Drawing.Size(161, 54);
            this.addGenBut.TabIndex = 10;
            this.addGenBut.Text = "Add New Genre";
            this.addGenBut.UseVisualStyleBackColor = true;
            this.addGenBut.Click += new System.EventHandler(this.addGenBut_Click);
            // 
            // ControlAdGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.genreNameBox);
            this.Controls.Add(this.addGenBut);
            this.Name = "ControlAdGenre";
            this.Controls.SetChildIndex(this.addGenBut, 0);
            this.Controls.SetChildIndex(this.genreNameBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox genreNameBox;
        private System.Windows.Forms.Button addGenBut;
    }
}
