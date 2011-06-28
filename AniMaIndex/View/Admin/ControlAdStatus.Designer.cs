namespace AniMaIndex.View.Admin
{
    partial class ControlAdStatus
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
            this.addStatBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(541, 429);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(161, 20);
            this.nameBox.TabIndex = 12;
            this.nameBox.Text = "Name";
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // addStatBut
            // 
            this.addStatBut.Location = new System.Drawing.Point(541, 464);
            this.addStatBut.Name = "addStatBut";
            this.addStatBut.Size = new System.Drawing.Size(166, 54);
            this.addStatBut.TabIndex = 11;
            this.addStatBut.Text = "Add New Status";
            this.addStatBut.UseVisualStyleBackColor = true;
            this.addStatBut.Click += new System.EventHandler(this.addStatBut_Click);
            // 
            // ControlAdStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addStatBut);
            this.Name = "ControlAdStatus";
            this.Controls.SetChildIndex(this.addStatBut, 0);
            this.Controls.SetChildIndex(this.nameBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addStatBut;
    }
}
