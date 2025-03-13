namespace XStudentsChipApp
{
    partial class UCDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDownload));
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_downloadLocal = new System.Windows.Forms.Button();
            this.BTN_downloadOnline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(291, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Инсталиране";
            // 
            // BTN_downloadLocal
            // 
            this.BTN_downloadLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.BTN_downloadLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_downloadLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_downloadLocal.ForeColor = System.Drawing.Color.White;
            this.BTN_downloadLocal.Image = ((System.Drawing.Image)(resources.GetObject("BTN_downloadLocal.Image")));
            this.BTN_downloadLocal.Location = new System.Drawing.Point(105, 392);
            this.BTN_downloadLocal.Name = "BTN_downloadLocal";
            this.BTN_downloadLocal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_downloadLocal.Size = new System.Drawing.Size(303, 52);
            this.BTN_downloadLocal.TabIndex = 11;
            this.BTN_downloadLocal.Text = " Локално инсталиране";
            this.BTN_downloadLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_downloadLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_downloadLocal.UseVisualStyleBackColor = false;
            // 
            // BTN_downloadOnline
            // 
            this.BTN_downloadOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.BTN_downloadOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_downloadOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_downloadOnline.ForeColor = System.Drawing.Color.White;
            this.BTN_downloadOnline.Image = ((System.Drawing.Image)(resources.GetObject("BTN_downloadOnline.Image")));
            this.BTN_downloadOnline.Location = new System.Drawing.Point(459, 392);
            this.BTN_downloadOnline.Name = "BTN_downloadOnline";
            this.BTN_downloadOnline.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_downloadOnline.Size = new System.Drawing.Size(310, 52);
            this.BTN_downloadOnline.TabIndex = 12;
            this.BTN_downloadOnline.Text = " Онлайн Инсталиране";
            this.BTN_downloadOnline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_downloadOnline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_downloadOnline.UseVisualStyleBackColor = false;
            // 
            // UCDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_downloadOnline);
            this.Controls.Add(this.BTN_downloadLocal);
            this.Controls.Add(this.label1);
            this.Name = "UCDownload";
            this.Size = new System.Drawing.Size(843, 553);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_downloadLocal;
        private System.Windows.Forms.Button BTN_downloadOnline;
    }
}
