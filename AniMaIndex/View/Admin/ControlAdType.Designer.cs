namespace AniMaIndex.View.Admin
{
    partial class ControlAdType
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
            this.addTypeBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(564, 382);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(161, 20);
            this.nameBox.TabIndex = 12;
            this.nameBox.Text = "Name";
            // 
            // addTypeBut
            // 
            this.addTypeBut.Location = new System.Drawing.Point(564, 434);
            this.addTypeBut.Name = "addTypeBut";
            this.addTypeBut.Size = new System.Drawing.Size(166, 54);
            this.addTypeBut.TabIndex = 11;
            this.addTypeBut.Text = "Add New Type";
            this.addTypeBut.UseVisualStyleBackColor = true;
            this.addTypeBut.Click += new System.EventHandler(this.addUsrBut_Click);
            // 
            // ControlAdType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addTypeBut);
            this.Name = "ControlAdType";
            this.Controls.SetChildIndex(this.addTypeBut, 0);
            this.Controls.SetChildIndex(this.nameBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addTypeBut;
    }
}
