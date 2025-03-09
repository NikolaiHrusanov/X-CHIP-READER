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
            this.BTN_Download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(291, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Инсталиране";
            // 
            // BTN_Download
            // 
            this.BTN_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.BTN_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Download.ForeColor = System.Drawing.Color.White;
            this.BTN_Download.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Download.Image")));
            this.BTN_Download.Location = new System.Drawing.Point(288, 392);
            this.BTN_Download.Name = "BTN_Download";
            this.BTN_Download.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_Download.Size = new System.Drawing.Size(230, 52);
            this.BTN_Download.TabIndex = 11;
            this.BTN_Download.Text = " Инсталиране";
            this.BTN_Download.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Download.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Download.UseVisualStyleBackColor = false;
            // 
            // UCDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Download);
            this.Controls.Add(this.label1);
            this.Name = "UCDownload";
            this.Size = new System.Drawing.Size(843, 553);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Download;
    }
}
