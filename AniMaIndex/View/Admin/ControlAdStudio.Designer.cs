namespace AniMaIndex.View
{
    partial class ControlAdStudio
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
            this.studWebBox = new System.Windows.Forms.TextBox();
            this.addStudBut = new System.Windows.Forms.Button();
            this.studNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // studWebBox
            // 
            this.studWebBox.Location = new System.Drawing.Point(529, 440);
            this.studWebBox.Name = "studWebBox";
            this.studWebBox.Size = new System.Drawing.Size(161, 20);
            this.studWebBox.TabIndex = 13;
            this.studWebBox.Text = "URL";
            // 
            // addStudBut
            // 
            this.addStudBut.Location = new System.Drawing.Point(529, 490);
            this.addStudBut.Name = "addStudBut";
            this.addStudBut.Size = new System.Drawing.Size(161, 54);
            this.addStudBut.TabIndex = 12;
            this.addStudBut.Text = "Add New Studio";
            this.addStudBut.UseVisualStyleBackColor = true;
            this.addStudBut.Click += new System.EventHandler(this.addStudBut_Click);
            // 
            // studNameBox
            // 
            this.studNameBox.Location = new System.Drawing.Point(529, 403);
            this.studNameBox.Name = "studNameBox";
            this.studNameBox.Size = new System.Drawing.Size(161, 20);
            this.studNameBox.TabIndex = 14;
            this.studNameBox.Text = "Name";
            // 
            // ControlAdStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.studNameBox);
            this.Controls.Add(this.studWebBox);
            this.Controls.Add(this.addStudBut);
            this.Name = "ControlAdStudio";
            this.Controls.SetChildIndex(this.addStudBut, 0);
            this.Controls.SetChildIndex(this.studWebBox, 0);
            this.Controls.SetChildIndex(this.studNameBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studWebBox;
        private System.Windows.Forms.Button addStudBut;
        private System.Windows.Forms.TextBox studNameBox;
    }
}
