namespace AniMaIndex.View
{
    partial class ControlAdStaff
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
            this.staffNameBox = new System.Windows.Forms.TextBox();
            this.staffWebBox = new System.Windows.Forms.TextBox();
            this.addStaffBut = new System.Windows.Forms.Button();
            this.staffOccupBox = new System.Windows.Forms.TextBox();
            this.aniBox = new System.Windows.Forms.ComboBox();
            this.mangaBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // staffNameBox
            // 
            this.staffNameBox.Location = new System.Drawing.Point(601, 411);
            this.staffNameBox.Name = "staffNameBox";
            this.staffNameBox.Size = new System.Drawing.Size(161, 20);
            this.staffNameBox.TabIndex = 20;
            this.staffNameBox.Text = "Name";
            this.staffNameBox.TextChanged += new System.EventHandler(this.staffNameBox_TextChanged);
            // 
            // staffWebBox
            // 
            this.staffWebBox.Location = new System.Drawing.Point(601, 483);
            this.staffWebBox.Name = "staffWebBox";
            this.staffWebBox.Size = new System.Drawing.Size(161, 20);
            this.staffWebBox.TabIndex = 19;
            this.staffWebBox.Text = "URL";
            this.staffWebBox.TextChanged += new System.EventHandler(this.staffWebBox_TextChanged);
            // 
            // addStaffBut
            // 
            this.addStaffBut.Location = new System.Drawing.Point(486, 520);
            this.addStaffBut.Name = "addStaffBut";
            this.addStaffBut.Size = new System.Drawing.Size(161, 54);
            this.addStaffBut.TabIndex = 18;
            this.addStaffBut.Text = "Add New Staff";
            this.addStaffBut.UseVisualStyleBackColor = true;
            this.addStaffBut.Click += new System.EventHandler(this.addStaffBut_Click);
            // 
            // staffOccupBox
            // 
            this.staffOccupBox.Location = new System.Drawing.Point(601, 447);
            this.staffOccupBox.Name = "staffOccupBox";
            this.staffOccupBox.Size = new System.Drawing.Size(161, 20);
            this.staffOccupBox.TabIndex = 21;
            this.staffOccupBox.Text = "Occupation";
            this.staffOccupBox.TextChanged += new System.EventHandler(this.staffOccupBox_TextChanged);
            // 
            // aniBox
            // 
            this.aniBox.FormattingEnabled = true;
            this.aniBox.Location = new System.Drawing.Point(394, 411);
            this.aniBox.Name = "aniBox";
            this.aniBox.Size = new System.Drawing.Size(170, 21);
            this.aniBox.TabIndex = 22;
            this.aniBox.Text = "Anime";
            this.aniBox.SelectedIndexChanged += new System.EventHandler(this.aniBox_SelectedIndexChanged);
            // 
            // mangaBox
            // 
            this.mangaBox.FormattingEnabled = true;
            this.mangaBox.Location = new System.Drawing.Point(394, 447);
            this.mangaBox.Name = "mangaBox";
            this.mangaBox.Size = new System.Drawing.Size(170, 21);
            this.mangaBox.TabIndex = 23;
            this.mangaBox.Text = "Manga";
            this.mangaBox.SelectedIndexChanged += new System.EventHandler(this.mangaBox_SelectedIndexChanged);
            // 
            // ControlAdStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mangaBox);
            this.Controls.Add(this.aniBox);
            this.Controls.Add(this.staffOccupBox);
            this.Controls.Add(this.staffNameBox);
            this.Controls.Add(this.staffWebBox);
            this.Controls.Add(this.addStaffBut);
            this.Name = "ControlAdStaff";
            this.Load += new System.EventHandler(this.ControlAdStaff_Load);
            this.Controls.SetChildIndex(this.addStaffBut, 0);
            this.Controls.SetChildIndex(this.staffWebBox, 0);
            this.Controls.SetChildIndex(this.staffNameBox, 0);
            this.Controls.SetChildIndex(this.staffOccupBox, 0);
            this.Controls.SetChildIndex(this.aniBox, 0);
            this.Controls.SetChildIndex(this.mangaBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox staffNameBox;
        private System.Windows.Forms.TextBox staffWebBox;
        private System.Windows.Forms.Button addStaffBut;
        private System.Windows.Forms.TextBox staffOccupBox;
        private System.Windows.Forms.ComboBox aniBox;
        private System.Windows.Forms.ComboBox mangaBox;
    }
}
