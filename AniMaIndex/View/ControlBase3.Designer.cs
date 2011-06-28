namespace AniMaIndex.View
{
    partial class ControlBase3
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
            this.homeBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homeBut
            // 
            this.homeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBut.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(167)))), ((int)(((byte)(199)))));
            this.homeBut.Location = new System.Drawing.Point(604, 37);
            this.homeBut.Name = "homeBut";
            this.homeBut.Size = new System.Drawing.Size(213, 89);
            this.homeBut.TabIndex = 5;
            this.homeBut.Text = "Home";
            this.homeBut.UseVisualStyleBackColor = true;
            this.homeBut.Click += new System.EventHandler(this.homeBut_Click);
            // 
            // ControlBase3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homeBut);
            this.Name = "ControlBase3";
            this.Controls.SetChildIndex(this.homeBut, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeBut;
    }
}
