
namespace _23_variant_CSharp_1_4_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInputEl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelInputEl = new System.Windows.Forms.Label();
            this.textBoxInputEl = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInputEl
            // 
            this.buttonInputEl.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInputEl.Location = new System.Drawing.Point(628, 22);
            this.buttonInputEl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInputEl.Name = "buttonInputEl";
            this.buttonInputEl.Size = new System.Drawing.Size(196, 26);
            this.buttonInputEl.TabIndex = 17;
            this.buttonInputEl.Text = "Рассчитать";
            this.buttonInputEl.UseVisualStyleBackColor = true;
            this.buttonInputEl.Click += new System.EventHandler(this.buttonInputEl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(826, 384);
            this.dataGridView1.TabIndex = 15;
            // 
            // labelInputEl
            // 
            this.labelInputEl.AutoSize = true;
            this.labelInputEl.Font = new System.Drawing.Font("Segoe UI", 9.163636F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelInputEl.Location = new System.Drawing.Point(-2, 25);
            this.labelInputEl.Name = "labelInputEl";
            this.labelInputEl.Size = new System.Drawing.Size(236, 19);
            this.labelInputEl.TabIndex = 14;
            this.labelInputEl.Text = "Введите(через пробел) массив X:";
            this.labelInputEl.Click += new System.EventHandler(this.labelInputEl_Click);
            // 
            // textBoxInputEl
            // 
            this.textBoxInputEl.Location = new System.Drawing.Point(274, 22);
            this.textBoxInputEl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInputEl.Name = "textBoxInputEl";
            this.textBoxInputEl.Size = new System.Drawing.Size(348, 26);
            this.textBoxInputEl.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Александр\\source\\repos\\23_variant_CSharp_1_4_1\\images\\Formula.png";
            this.pictureBox1.Location = new System.Drawing.Point(525, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonInputEl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelInputEl);
            this.Controls.Add(this.textBoxInputEl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInputEl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelInputEl;
        private System.Windows.Forms.TextBox textBoxInputEl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

