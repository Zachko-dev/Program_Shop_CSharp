namespace Progrm_Easy_Shopping
{
    partial class AddThingPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureAddThing = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NameThing = new System.Windows.Forms.Label();
            this.SizeThing = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddThing)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Thing ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureAddThing
            // 
            this.pictureAddThing.Image = global::Progrm_Easy_Shopping.Properties.Resources.iconfinder_sale_lineal_color_cnvrt_17_3827705;
            this.pictureAddThing.Location = new System.Drawing.Point(236, 164);
            this.pictureAddThing.Name = "pictureAddThing";
            this.pictureAddThing.Size = new System.Drawing.Size(114, 113);
            this.pictureAddThing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAddThing.TabIndex = 1;
            this.pictureAddThing.TabStop = false;
            this.pictureAddThing.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(69, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(402, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 3;
            // 
            // NameThing
            // 
            this.NameThing.AutoSize = true;
            this.NameThing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameThing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(232)))));
            this.NameThing.Location = new System.Drawing.Point(12, 217);
            this.NameThing.Name = "NameThing";
            this.NameThing.Size = new System.Drawing.Size(51, 20);
            this.NameThing.TabIndex = 4;
            this.NameThing.Text = "Name";
            // 
            // SizeThing
            // 
            this.SizeThing.AutoSize = true;
            this.SizeThing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeThing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(247)))), ((int)(((byte)(232)))));
            this.SizeThing.Location = new System.Drawing.Point(356, 217);
            this.SizeThing.Name = "SizeThing";
            this.SizeThing.Size = new System.Drawing.Size(40, 20);
            this.SizeThing.TabIndex = 5;
            this.SizeThing.Text = "Size";
            this.SizeThing.Click += new System.EventHandler(this.Label3_Click);
            // 
            // AddThingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.SizeThing);
            this.Controls.Add(this.NameThing);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureAddThing);
            this.Controls.Add(this.panel1);
            this.Name = "AddThingPanel";
            this.Text = "AddThingPanel";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddThing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureAddThing;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label NameThing;
        private System.Windows.Forms.Label SizeThing;
    }
}