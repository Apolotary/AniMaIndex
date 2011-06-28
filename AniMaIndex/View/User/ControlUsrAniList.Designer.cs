namespace AniMaIndex.View
{
    partial class ControlUsrAniList
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
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.epsWBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.aniBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(526, 476);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(161, 20);
            this.scoreBox.TabIndex = 45;
            this.scoreBox.Text = "Score";
            // 
            // epsWBox
            // 
            this.epsWBox.Location = new System.Drawing.Point(526, 529);
            this.epsWBox.Name = "epsWBox";
            this.epsWBox.Size = new System.Drawing.Size(161, 20);
            this.epsWBox.TabIndex = 44;
            this.epsWBox.Text = "# of eps watched";
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(526, 502);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(161, 21);
            this.statusBox.TabIndex = 46;
            this.statusBox.Text = "Status";
            // 
            // aniBut
            // 
            this.aniBut.Location = new System.Drawing.Point(772, 441);
            this.aniBut.Name = "aniBut";
            this.aniBut.Size = new System.Drawing.Size(95, 47);
            this.aniBut.TabIndex = 47;
            this.aniBut.Text = "Add!";
            this.aniBut.UseVisualStyleBackColor = true;
            this.aniBut.Click += new System.EventHandler(this.aniBut_Click);
            // 
            // ControlUsrAniList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aniBut);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.epsWBox);
            this.Name = "ControlUsrAniList";
            this.Controls.SetChildIndex(this.epsWBox, 0);
            this.Controls.SetChildIndex(this.scoreBox, 0);
            this.Controls.SetChildIndex(this.statusBox, 0);
            this.Controls.SetChildIndex(this.aniBut, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.TextBox epsWBox;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Button aniBut;
    }
}
