﻿
namespace car_racing_game
{
    partial class BeginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeginForm));
            this.btMotNguoiChoi = new System.Windows.Forms.Button();
            this.btHaiNguoiChoi = new System.Windows.Forms.Button();
            this.btDiemSo = new System.Windows.Forms.Button();
            this.btHuongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMotNguoiChoi
            // 
            this.btMotNguoiChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMotNguoiChoi.ForeColor = System.Drawing.Color.Maroon;
            this.btMotNguoiChoi.Location = new System.Drawing.Point(254, 115);
            this.btMotNguoiChoi.Name = "btMotNguoiChoi";
            this.btMotNguoiChoi.Size = new System.Drawing.Size(312, 49);
            this.btMotNguoiChoi.TabIndex = 0;
            this.btMotNguoiChoi.Text = "Một người chơi";
            this.btMotNguoiChoi.UseVisualStyleBackColor = true;
            this.btMotNguoiChoi.Click += new System.EventHandler(this.btMotNguoiChoi_Click);
            this.btMotNguoiChoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btMotNguoiChoi_KeyDown);
            this.btMotNguoiChoi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btMotNguoiChoi_MouseMove);
            // 
            // btHaiNguoiChoi
            // 
            this.btHaiNguoiChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHaiNguoiChoi.ForeColor = System.Drawing.Color.Maroon;
            this.btHaiNguoiChoi.Location = new System.Drawing.Point(254, 186);
            this.btHaiNguoiChoi.Name = "btHaiNguoiChoi";
            this.btHaiNguoiChoi.Size = new System.Drawing.Size(312, 49);
            this.btHaiNguoiChoi.TabIndex = 1;
            this.btHaiNguoiChoi.Text = "Hai người chơi";
            this.btHaiNguoiChoi.UseVisualStyleBackColor = true;
            this.btHaiNguoiChoi.Click += new System.EventHandler(this.btHaiNguoiChoi_Click);
            this.btHaiNguoiChoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btHaiNguoiChoi_KeyDown);
            this.btHaiNguoiChoi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btHaiNguoiChoi_MouseMove);
            // 
            // btDiemSo
            // 
            this.btDiemSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiemSo.ForeColor = System.Drawing.Color.Maroon;
            this.btDiemSo.Location = new System.Drawing.Point(254, 255);
            this.btDiemSo.Name = "btDiemSo";
            this.btDiemSo.Size = new System.Drawing.Size(312, 49);
            this.btDiemSo.TabIndex = 2;
            this.btDiemSo.Text = "Điểm số ";
            this.btDiemSo.UseVisualStyleBackColor = true;
            this.btDiemSo.Click += new System.EventHandler(this.btDiemSo_Click);
            this.btDiemSo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btDiemSo_KeyDown);
            this.btDiemSo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btDiemSo_MouseMove);
            // 
            // btHuongDan
            // 
            this.btHuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuongDan.ForeColor = System.Drawing.Color.Maroon;
            this.btHuongDan.Location = new System.Drawing.Point(254, 320);
            this.btHuongDan.Name = "btHuongDan";
            this.btHuongDan.Size = new System.Drawing.Size(312, 49);
            this.btHuongDan.TabIndex = 3;
            this.btHuongDan.Text = "Hướng dẫn";
            this.btHuongDan.UseVisualStyleBackColor = true;
            this.btHuongDan.Click += new System.EventHandler(this.btHuongDan_Click);
            this.btHuongDan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btHuongDan_KeyDown);
            this.btHuongDan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btHuongDan_MouseMove);
            // 
            // BeginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btHuongDan);
            this.Controls.Add(this.btDiemSo);
            this.Controls.Add(this.btHaiNguoiChoi);
            this.Controls.Add(this.btMotNguoiChoi);
            this.Name = "BeginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeginForm";
            this.Load += new System.EventHandler(this.BeginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btMotNguoiChoi;
        private System.Windows.Forms.Button btHaiNguoiChoi;
        private System.Windows.Forms.Button btDiemSo;
        private System.Windows.Forms.Button btHuongDan;
    }
}