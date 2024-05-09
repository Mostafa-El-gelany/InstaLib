namespace Library
{
    partial class frmBorrow
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.siticoneComboBox2 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(84, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Book Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReturn.Image = global::Library.Properties.Resources.icons8_borrow_book_52;
            this.btnReturn.Location = new System.Drawing.Point(430, 336);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(186, 70);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Borrow";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.siticoneComboBox2);
            this.panel3.Controls.Add(this.siticoneComboBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(709, 119);
            this.panel3.TabIndex = 46;
            // 
            // siticoneComboBox2
            // 
            this.siticoneComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.siticoneComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.siticoneComboBox2.ItemHeight = 30;
            this.siticoneComboBox2.Location = new System.Drawing.Point(471, 54);
            this.siticoneComboBox2.Name = "siticoneComboBox2";
            this.siticoneComboBox2.Size = new System.Drawing.Size(193, 36);
            this.siticoneComboBox2.TabIndex = 25;
            // 
            // siticoneComboBox1
            // 
            this.siticoneComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.siticoneComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.siticoneComboBox1.ItemHeight = 30;
            this.siticoneComboBox1.Location = new System.Drawing.Point(87, 54);
            this.siticoneComboBox1.Name = "siticoneComboBox1";
            this.siticoneComboBox1.Size = new System.Drawing.Size(193, 36);
            this.siticoneComboBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(468, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "UserName";
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBorrow";
            this.Text = "frmBorrow";
            this.Load += new System.EventHandler(this.frmBorrow_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel3;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox2;
        private System.Windows.Forms.Label label1;
    }
}