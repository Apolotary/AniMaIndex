namespace AniMaIndex.View
{
    partial class ControlUsrMangaList
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
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.thomesRBox = new System.Windows.Forms.TextBox();
            this.chapsRBox = new System.Windows.Forms.TextBox();
            this.addMangaBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(592, 490);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(161, 21);
            this.statusBox.TabIndex = 49;
            this.statusBox.Text = "Status";
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(592, 464);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(161, 20);
            this.scoreBox.TabIndex = 48;
            this.scoreBox.Text = "Score";
            // 
            // thomesRBox
            // 
            this.thomesRBox.Location = new System.Drawing.Point(592, 517);
            this.thomesRBox.Name = "thomesRBox";
            this.thomesRBox.Size = new System.Drawing.Size(161, 20);
            this.thomesRBox.TabIndex = 47;
            this.thomesRBox.Text = "# of thomes read";
            // 
            // chapsRBox
            // 
            this.chapsRBox.Location = new System.Drawing.Point(592, 543);
            this.chapsRBox.Name = "chapsRBox";
            this.chapsRBox.Size = new System.Drawing.Size(161, 20);
            this.chapsRBox.TabIndex = 50;
            this.chapsRBox.Text = "# of chapters read";
            // 
            // addMangaBut
            // 
            this.addMangaBut.Location = new System.Drawing.Point(772, 441);
            this.addMangaBut.Name = "addMangaBut";
            this.addMangaBut.Size = new System.Drawing.Size(95, 47);
            this.addMangaBut.TabIndex = 51;
            this.addMangaBut.Text = "Add!";
            this.addMangaBut.UseVisualStyleBackColor = true;
            this.addMangaBut.Click += new System.EventHandler(this.addMangaBut_Click);
            // 
            // ControlUsrMangaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addMangaBut);
            this.Controls.Add(this.chapsRBox);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.thomesRBox);
            this.Name = "ControlUsrMangaList";
            this.Controls.SetChildIndex(this.thomesRBox, 0);
            this.Controls.SetChildIndex(this.scoreBox, 0);
            this.Controls.SetChildIndex(this.statusBox, 0);
            this.Controls.SetChildIndex(this.chapsRBox, 0);
            this.Controls.SetChildIndex(this.addMangaBut, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.TextBox thomesRBox;
        private System.Windows.Forms.TextBox chapsRBox;
        private System.Windows.Forms.Button addMangaBut;
    }
}
