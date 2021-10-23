
namespace car_racing_game
{
    partial class FormChonMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChonMap));
            this.btMap1 = new System.Windows.Forms.Button();
            this.btMap2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMap1
            // 
            this.btMap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMap1.Location = new System.Drawing.Point(109, 43);
            this.btMap1.Name = "btMap1";
            this.btMap1.Size = new System.Drawing.Size(234, 49);
            this.btMap1.TabIndex = 0;
            this.btMap1.Text = "Bản đồ một";
            this.btMap1.UseVisualStyleBackColor = true;
            this.btMap1.Click += new System.EventHandler(this.btMap1_Click);
            // 
            // btMap2
            // 
            this.btMap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMap2.Location = new System.Drawing.Point(109, 112);
            this.btMap2.Name = "btMap2";
            this.btMap2.Size = new System.Drawing.Size(234, 49);
            this.btMap2.TabIndex = 0;
            this.btMap2.Text = "Bản đồ hai";
            this.btMap2.UseVisualStyleBackColor = true;
            this.btMap2.Click += new System.EventHandler(this.btMap2_Click);
            // 
            // FormChonMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 216);
            this.Controls.Add(this.btMap2);
            this.Controls.Add(this.btMap1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChonMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hãy chọn bản đồ bạn thích!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMap1;
        private System.Windows.Forms.Button btMap2;
    }
}