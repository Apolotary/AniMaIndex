namespace AniMaIndex
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.controlWelcome1 = new AniMaIndex.ControlWelcome();
            this.SuspendLayout();
            // 
            // controlWelcome1
            // 
            this.controlWelcome1.BackColor = System.Drawing.Color.White;
            this.controlWelcome1.Location = new System.Drawing.Point(1, 1);
            this.controlWelcome1.Name = "controlWelcome1";
            this.controlWelcome1.Size = new System.Drawing.Size(893, 642);
            this.controlWelcome1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 662);
            this.Controls.Add(this.controlWelcome1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "AniMaIndex v 0.5";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlWelcome controlWelcome1;
    }
}

