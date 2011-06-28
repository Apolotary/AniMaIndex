namespace AniMaIndex.View
{
    partial class ControlAdPublisher
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
            this.pubNameBox = new System.Windows.Forms.TextBox();
            this.pubWebBox = new System.Windows.Forms.TextBox();
            this.addPubBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pubNameBox
            // 
            this.pubNameBox.Location = new System.Drawing.Point(546, 390);
            this.pubNameBox.Name = "pubNameBox";
            this.pubNameBox.Size = new System.Drawing.Size(161, 20);
            this.pubNameBox.TabIndex = 17;
            this.pubNameBox.Text = "Name";
            // 
            // pubWebBox
            // 
            this.pubWebBox.Location = new System.Drawing.Point(546, 427);
            this.pubWebBox.Name = "pubWebBox";
            this.pubWebBox.Size = new System.Drawing.Size(161, 20);
            this.pubWebBox.TabIndex = 16;
            this.pubWebBox.Text = "URL";
            // 
            // addPubBut
            // 
            this.addPubBut.Location = new System.Drawing.Point(546, 471);
            this.addPubBut.Name = "addPubBut";
            this.addPubBut.Size = new System.Drawing.Size(161, 54);
            this.addPubBut.TabIndex = 15;
            this.addPubBut.Text = "Add New Publisher";
            this.addPubBut.UseVisualStyleBackColor = true;
            this.addPubBut.Click += new System.EventHandler(this.addPubBut_Click);
            // 
            // ControlAdPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pubNameBox);
            this.Controls.Add(this.pubWebBox);
            this.Controls.Add(this.addPubBut);
            this.Name = "ControlAdPublisher";
            this.Controls.SetChildIndex(this.addPubBut, 0);
            this.Controls.SetChildIndex(this.pubWebBox, 0);
            this.Controls.SetChildIndex(this.pubNameBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pubNameBox;
        private System.Windows.Forms.TextBox pubWebBox;
        private System.Windows.Forms.Button addPubBut;
    }
}
