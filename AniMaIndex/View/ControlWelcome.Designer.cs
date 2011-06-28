namespace AniMaIndex
{
    partial class ControlWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlWelcome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.adminBut = new System.Windows.Forms.Button();
            this.userBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(555, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 471);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 679);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // adminBut
            // 
            this.adminBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBut.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(167)))), ((int)(((byte)(199)))));
            this.adminBut.Location = new System.Drawing.Point(235, 431);
            this.adminBut.Name = "adminBut";
            this.adminBut.Size = new System.Drawing.Size(213, 89);
            this.adminBut.TabIndex = 3;
            this.adminBut.Text = "Admin";
            this.adminBut.UseVisualStyleBackColor = true;
            this.adminBut.Click += new System.EventHandler(this.adminBut_Click);
            // 
            // userBut
            // 
            this.userBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBut.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(167)))), ((int)(((byte)(199)))));
            this.userBut.Location = new System.Drawing.Point(235, 256);
            this.userBut.Name = "userBut";
            this.userBut.Size = new System.Drawing.Size(213, 89);
            this.userBut.TabIndex = 4;
            this.userBut.Text = "User";
            this.userBut.UseVisualStyleBackColor = true;
            this.userBut.Click += new System.EventHandler(this.userBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(167)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(157, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose your destiny:";
            // 
            // aboutBut
            // 
            this.aboutBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBut.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(167)))), ((int)(((byte)(199)))));
            this.aboutBut.Location = new System.Drawing.Point(629, 56);
            this.aboutBut.Name = "aboutBut";
            this.aboutBut.Size = new System.Drawing.Size(161, 55);
            this.aboutBut.TabIndex = 6;
            this.aboutBut.Text = "About";
            this.aboutBut.UseVisualStyleBackColor = true;
            this.aboutBut.Click += new System.EventHandler(this.aboutBut_Click);
            // 
            // ControlWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.aboutBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userBut);
            this.Controls.Add(this.adminBut);
            this.Name = "ControlWelcome";
            this.Controls.SetChildIndex(this.adminBut, 0);
            this.Controls.SetChildIndex(this.userBut, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.aboutBut, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button adminBut;
        private System.Windows.Forms.Button userBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aboutBut;
    }
}
