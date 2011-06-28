namespace AniMaIndex.View
{
    partial class ControlAdminEditBase
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
            this.outGrid = new System.Windows.Forms.DataGridView();
            this.remButt = new System.Windows.Forms.Button();
            this.homeBut = new System.Windows.Forms.Button();
            this.loadBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // outGrid
            // 
            this.outGrid.BackgroundColor = System.Drawing.Color.White;
            this.outGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outGrid.Location = new System.Drawing.Point(21, 28);
            this.outGrid.Name = "outGrid";
            this.outGrid.Size = new System.Drawing.Size(787, 210);
            this.outGrid.TabIndex = 0;
            // 
            // remButt
            // 
            this.remButt.Location = new System.Drawing.Point(713, 244);
            this.remButt.Name = "remButt";
            this.remButt.Size = new System.Drawing.Size(95, 47);
            this.remButt.TabIndex = 1;
            this.remButt.Text = "Remove!";
            this.remButt.UseVisualStyleBackColor = true;
            this.remButt.Click += new System.EventHandler(this.remButt_Click);
            // 
            // homeBut
            // 
            this.homeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBut.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(167)))), ((int)(((byte)(199)))));
            this.homeBut.Location = new System.Drawing.Point(21, 584);
            this.homeBut.Name = "homeBut";
            this.homeBut.Size = new System.Drawing.Size(131, 47);
            this.homeBut.TabIndex = 6;
            this.homeBut.Text = ">Admin";
            this.homeBut.UseVisualStyleBackColor = true;
            this.homeBut.Click += new System.EventHandler(this.homeBut_Click);
            // 
            // loadBut
            // 
            this.loadBut.Location = new System.Drawing.Point(612, 244);
            this.loadBut.Name = "loadBut";
            this.loadBut.Size = new System.Drawing.Size(95, 47);
            this.loadBut.TabIndex = 7;
            this.loadBut.Text = "Load!";
            this.loadBut.UseVisualStyleBackColor = true;
            this.loadBut.Click += new System.EventHandler(this.loadBut_Click);
            // 
            // ControlAdminEditBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.loadBut);
            this.Controls.Add(this.homeBut);
            this.Controls.Add(this.remButt);
            this.Controls.Add(this.outGrid);
            this.Name = "ControlAdminEditBase";
            this.Size = new System.Drawing.Size(909, 680);
            ((System.ComponentModel.ISupportInitialize)(this.outGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView outGrid;
        private System.Windows.Forms.Button remButt;
        private System.Windows.Forms.Button homeBut;
        private System.Windows.Forms.Button loadBut;
    }
}
