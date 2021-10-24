
namespace car_racing_game
{
    partial class FormChonMap2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChonMap2));
            this.btMap2 = new System.Windows.Forms.Button();
            this.btMap1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMap2
            // 
            this.btMap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMap2.Location = new System.Drawing.Point(117, 118);
            this.btMap2.Name = "btMap2";
            this.btMap2.Size = new System.Drawing.Size(234, 49);
            this.btMap2.TabIndex = 1;
            this.btMap2.Text = "Bản đồ hai";
            this.btMap2.UseVisualStyleBackColor = true;
            this.btMap2.Click += new System.EventHandler(this.btMap2_Click);
            this.btMap2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btMap2_KeyDown);
            this.btMap2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btMap2_MouseMove);
            // 
            // btMap1
            // 
            this.btMap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMap1.Location = new System.Drawing.Point(117, 49);
            this.btMap1.Name = "btMap1";
            this.btMap1.Size = new System.Drawing.Size(234, 49);
            this.btMap1.TabIndex = 0;
            this.btMap1.Text = "Bản đồ một";
            this.btMap1.UseVisualStyleBackColor = true;
            this.btMap1.Click += new System.EventHandler(this.btMap1_Click);
            this.btMap1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btMap1_KeyDown);
            this.btMap1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btMap1_MouseMove);
            // 
            // FormChonMap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 216);
            this.Controls.Add(this.btMap2);
            this.Controls.Add(this.btMap1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChonMap2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChonMap2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChonMap2_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMap2;
        private System.Windows.Forms.Button btMap1;
    }
}