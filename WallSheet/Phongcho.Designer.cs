﻿namespace WallSheet
{
    partial class Phongcho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phongcho));
            this.btn_Option = new System.Windows.Forms.Button();
            this.btnRandom_click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Option
            // 
            this.btn_Option.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Option.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Option.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Option.Location = new System.Drawing.Point(312, 250);
            this.btn_Option.Name = "btn_Option";
            this.btn_Option.Size = new System.Drawing.Size(122, 46);
            this.btn_Option.TabIndex = 1;
            this.btn_Option.Text = "Option";
            this.btn_Option.UseVisualStyleBackColor = false;
            // 
            // btnRandom_click
            // 
            this.btnRandom_click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRandom_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom_click.Location = new System.Drawing.Point(312, 331);
            this.btnRandom_click.Name = "btnRandom_click";
            this.btnRandom_click.Size = new System.Drawing.Size(127, 46);
            this.btnRandom_click.TabIndex = 2;
            this.btnRandom_click.Text = "Random";
            this.btnRandom_click.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 135);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Phongcho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandom_click);
            this.Controls.Add(this.btn_Option);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Phongcho";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Phongcho_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Option;
        private System.Windows.Forms.Button btnRandom_click;
        private System.Windows.Forms.Label label1;
    }
}