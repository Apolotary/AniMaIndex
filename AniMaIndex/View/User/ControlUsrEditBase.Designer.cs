namespace AniMaIndex.View
{
    partial class ControlUsrEditBase
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
            this.loadBut = new System.Windows.Forms.Button();
            this.homeBut = new System.Windows.Forms.Button();
            this.remButt = new System.Windows.Forms.Button();
            this.outGrid = new System.Windows.Forms.DataGridView();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            this.addButt = new System.Windows.Forms.Button();
            this.srchGenre = new System.Windows.Forms.Button();
            this.srchGenreBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.unameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // loadBut
            // 
            this.loadBut.Location = new System.Drawing.Point(671, 172);
            this.loadBut.Name = "loadBut";
            this.loadBut.Size = new System.Drawing.Size(95, 47);
            this.loadBut.TabIndex = 11;
            this.loadBut.Text = "Load!";
            this.loadBut.UseVisualStyleBackColor = true;
            this.loadBut.Click += new System.EventHandler(this.loadBut_Click);
            // 
            // homeBut
            // 
            this.homeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBut.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(167)))), ((int)(((byte)(199)))));
            this.homeBut.Location = new System.Drawing.Point(34, 589);
            this.homeBut.Name = "homeBut";
            this.homeBut.Size = new System.Drawing.Size(131, 47);
            this.homeBut.TabIndex = 10;
            this.homeBut.Text = ">User";
            this.homeBut.UseVisualStyleBackColor = true;
            this.homeBut.Click += new System.EventHandler(this.homeBut_Click);
            // 
            // remButt
            // 
            this.remButt.Location = new System.Drawing.Point(772, 172);
            this.remButt.Name = "remButt";
            this.remButt.Size = new System.Drawing.Size(95, 47);
            this.remButt.TabIndex = 9;
            this.remButt.Text = "Remove!";
            this.remButt.UseVisualStyleBackColor = true;
            this.remButt.Click += new System.EventHandler(this.remButt_Click);
            // 
            // outGrid
            // 
            this.outGrid.BackgroundColor = System.Drawing.Color.White;
            this.outGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outGrid.Location = new System.Drawing.Point(34, 18);
            this.outGrid.Name = "outGrid";
            this.outGrid.Size = new System.Drawing.Size(833, 148);
            this.outGrid.TabIndex = 8;
            // 
            // searchGrid
            // 
            this.searchGrid.BackgroundColor = System.Drawing.Color.White;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Location = new System.Drawing.Point(34, 276);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.Size = new System.Drawing.Size(833, 159);
            this.searchGrid.TabIndex = 12;
            // 
            // addButt
            // 
            this.addButt.Location = new System.Drawing.Point(772, 441);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(95, 47);
            this.addButt.TabIndex = 15;
            this.addButt.Text = "Add!";
            this.addButt.UseVisualStyleBackColor = true;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // srchGenre
            // 
            this.srchGenre.Location = new System.Drawing.Point(793, 240);
            this.srchGenre.Name = "srchGenre";
            this.srchGenre.Size = new System.Drawing.Size(74, 30);
            this.srchGenre.TabIndex = 16;
            this.srchGenre.Text = "Search";
            this.srchGenre.UseVisualStyleBackColor = true;
            this.srchGenre.Click += new System.EventHandler(this.srchGenre_Click);
            // 
            // srchGenreBox
            // 
            this.srchGenreBox.FormattingEnabled = true;
            this.srchGenreBox.Location = new System.Drawing.Point(592, 246);
            this.srchGenreBox.Name = "srchGenreBox";
            this.srchGenreBox.Size = new System.Drawing.Size(161, 21);
            this.srchGenreBox.TabIndex = 42;
            this.srchGenreBox.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(167)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(490, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "You\'re logged as:";
            // 
            // unameLabel
            // 
            this.unameLabel.AutoSize = true;
            this.unameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(167)))), ((int)(((byte)(199)))));
            this.unameLabel.Location = new System.Drawing.Point(660, 606);
            this.unameLabel.Name = "unameLabel";
            this.unameLabel.Size = new System.Drawing.Size(0, 22);
            this.unameLabel.TabIndex = 46;
            // 
            // ControlUsrEditBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.unameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.srchGenreBox);
            this.Controls.Add(this.srchGenre);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.searchGrid);
            this.Controls.Add(this.loadBut);
            this.Controls.Add(this.homeBut);
            this.Controls.Add(this.remButt);
            this.Controls.Add(this.outGrid);
            this.Name = "ControlUsrEditBase";
            this.Size = new System.Drawing.Size(909, 680);
            ((System.ComponentModel.ISupportInitialize)(this.outGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadBut;
        private System.Windows.Forms.Button homeBut;
        private System.Windows.Forms.Button remButt;
        private System.Windows.Forms.DataGridView outGrid;
        private System.Windows.Forms.DataGridView searchGrid;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Button srchGenre;
        private System.Windows.Forms.ComboBox srchGenreBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label unameLabel;
    }
}
