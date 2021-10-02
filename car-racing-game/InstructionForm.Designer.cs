
namespace car_racing_game
{
    partial class InstructionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            this.lbNguoiChoi1 = new System.Windows.Forms.Label();
            this.lbCachChoi = new System.Windows.Forms.Label();
            this.lbNoiDung1 = new System.Windows.Forms.Label();
            this.lbNoiDung2 = new System.Windows.Forms.Label();
            this.lbNguoiChoi2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNguoiChoi1
            // 
            this.lbNguoiChoi1.AutoSize = true;
            this.lbNguoiChoi1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbNguoiChoi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiChoi1.ForeColor = System.Drawing.Color.DarkRed;
            this.lbNguoiChoi1.Location = new System.Drawing.Point(98, 93);
            this.lbNguoiChoi1.Name = "lbNguoiChoi1";
            this.lbNguoiChoi1.Size = new System.Drawing.Size(173, 32);
            this.lbNguoiChoi1.TabIndex = 0;
            this.lbNguoiChoi1.Text = "Người chơi 1";
            // 
            // lbCachChoi
            // 
            this.lbCachChoi.AutoSize = true;
            this.lbCachChoi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbCachChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCachChoi.ForeColor = System.Drawing.Color.DarkRed;
            this.lbCachChoi.Location = new System.Drawing.Point(305, 29);
            this.lbCachChoi.Name = "lbCachChoi";
            this.lbCachChoi.Size = new System.Drawing.Size(163, 38);
            this.lbCachChoi.TabIndex = 0;
            this.lbCachChoi.Text = "Cách chơi";
            // 
            // lbNoiDung1
            // 
            this.lbNoiDung1.AutoSize = true;
            this.lbNoiDung1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbNoiDung1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDung1.ForeColor = System.Drawing.Color.DarkRed;
            this.lbNoiDung1.Location = new System.Drawing.Point(12, 144);
            this.lbNoiDung1.Name = "lbNoiDung1";
            this.lbNoiDung1.Size = new System.Drawing.Size(358, 125);
            this.lbNoiDung1.TabIndex = 0;
            this.lbNoiDung1.Text = "Dùng các phím mũi tên để di chuyển xe:\r\n - Mũi tên lên (Di chuyển lên)\r\n - Mũi tê" +
    "n xuống (Di chuyển sang trái)\r\n - Mũi tên phải (Di chuyển sang phải)\r\n - Mũi tên" +
    " xuống (Di chuyển xuống)";
            // 
            // lbNoiDung2
            // 
            this.lbNoiDung2.AutoSize = true;
            this.lbNoiDung2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbNoiDung2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDung2.ForeColor = System.Drawing.Color.DarkRed;
            this.lbNoiDung2.Location = new System.Drawing.Point(411, 144);
            this.lbNoiDung2.Name = "lbNoiDung2";
            this.lbNoiDung2.Size = new System.Drawing.Size(357, 125);
            this.lbNoiDung2.TabIndex = 0;
            this.lbNoiDung2.Text = "Dùng các phím WSAD để di chuyển xe:\r\n - Phím W (Di chuyển lên)\r\n - Phím A (Di chu" +
    "yển sang trái)\r\n - Phím D (Di chuyển sang phải)\r\n - Phím S (Di chuyển xuống)";
            // 
            // lbNguoiChoi2
            // 
            this.lbNguoiChoi2.AutoSize = true;
            this.lbNguoiChoi2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbNguoiChoi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiChoi2.ForeColor = System.Drawing.Color.DarkRed;
            this.lbNguoiChoi2.Location = new System.Drawing.Point(503, 93);
            this.lbNguoiChoi2.Name = "lbNguoiChoi2";
            this.lbNguoiChoi2.Size = new System.Drawing.Size(173, 32);
            this.lbNguoiChoi2.TabIndex = 0;
            this.lbNguoiChoi2.Text = "Người chơi 2";
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCachChoi);
            this.Controls.Add(this.lbNoiDung2);
            this.Controls.Add(this.lbNoiDung1);
            this.Controls.Add(this.lbNguoiChoi2);
            this.Controls.Add(this.lbNguoiChoi1);
            this.Name = "InstructionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstructionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNguoiChoi1;
        private System.Windows.Forms.Label lbCachChoi;
        private System.Windows.Forms.Label lbNoiDung1;
        private System.Windows.Forms.Label lbNoiDung2;
        private System.Windows.Forms.Label lbNguoiChoi2;
    }
}