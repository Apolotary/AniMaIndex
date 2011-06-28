namespace AniMaIndex.View
{
    partial class ControlAdUser
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
            this.addUsrBut = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addUsrBut
            // 
            this.addUsrBut.Location = new System.Drawing.Point(497, 511);
            this.addUsrBut.Name = "addUsrBut";
            this.addUsrBut.Size = new System.Drawing.Size(166, 54);
            this.addUsrBut.TabIndex = 7;
            this.addUsrBut.Text = "Add New User";
            this.addUsrBut.UseVisualStyleBackColor = true;
            this.addUsrBut.Click += new System.EventHandler(this.addUsrBut_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(501, 408);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(161, 20);
            this.nameBox.TabIndex = 10;
            this.nameBox.Text = "Nickname";
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(501, 434);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(161, 20);
            this.yearBox.TabIndex = 11;
            this.yearBox.Text = "01-Jan-2005";
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderBox.Location = new System.Drawing.Point(501, 460);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(161, 21);
            this.genderBox.TabIndex = 28;
            this.genderBox.Text = "Gender";
            // 
            // ControlAdUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addUsrBut);
            this.Name = "ControlAdUser";
            this.Controls.SetChildIndex(this.addUsrBut, 0);
            this.Controls.SetChildIndex(this.nameBox, 0);
            this.Controls.SetChildIndex(this.yearBox, 0);
            this.Controls.SetChildIndex(this.genderBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUsrBut;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.ComboBox genderBox;
    }
}
