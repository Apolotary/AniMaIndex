namespace AniMaIndex
{
    partial class ControlUserOpts
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
            this.label1 = new System.Windows.Forms.Label();
            this.enterUNameBut = new System.Windows.Forms.Button();
            this.userTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(167)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(158, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter your username:";
            // 
            // enterUNameBut
            // 
            this.enterUNameBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterUNameBut.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterUNameBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(167)))), ((int)(((byte)(199)))));
            this.enterUNameBut.Location = new System.Drawing.Point(225, 309);
            this.enterUNameBut.Name = "enterUNameBut";
            this.enterUNameBut.Size = new System.Drawing.Size(213, 52);
            this.enterUNameBut.TabIndex = 8;
            this.enterUNameBut.Text = "Enter!";
            this.enterUNameBut.UseVisualStyleBackColor = true;
            this.enterUNameBut.Click += new System.EventHandler(this.enterUNameBut_Click);
            // 
            // userTBox
            // 
            this.userTBox.Location = new System.Drawing.Point(225, 242);
            this.userTBox.Name = "userTBox";
            this.userTBox.Size = new System.Drawing.Size(213, 20);
            this.userTBox.TabIndex = 10;
            // 
            // ControlUserOpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterUNameBut);
            this.Name = "ControlUserOpts";
            this.Controls.SetChildIndex(this.enterUNameBut, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.userTBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enterUNameBut;
        private System.Windows.Forms.TextBox userTBox;
    }
}
