namespace AniMaIndex.View.Admin
{
    partial class ControlAdAired
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addUsrBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(590, 398);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(161, 20);
            this.nameBox.TabIndex = 12;
            this.nameBox.Text = "Name";
            // 
            // addUsrBut
            // 
            this.addUsrBut.Location = new System.Drawing.Point(590, 440);
            this.addUsrBut.Name = "addUsrBut";
            this.addUsrBut.Size = new System.Drawing.Size(166, 54);
            this.addUsrBut.TabIndex = 11;
            this.addUsrBut.Text = "Add New Aired Status";
            this.addUsrBut.UseVisualStyleBackColor = true;
            this.addUsrBut.Click += new System.EventHandler(this.addUsrBut_Click);
            // 
            // ControlAdAired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addUsrBut);
            this.Name = "ControlAdAired";
            this.Controls.SetChildIndex(this.addUsrBut, 0);
            this.Controls.SetChildIndex(this.nameBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addUsrBut;
    }
}
