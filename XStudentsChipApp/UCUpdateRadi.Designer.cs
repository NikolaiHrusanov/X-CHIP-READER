namespace XStudentsChipApp
{
    partial class UCUpdateRadi
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_SecondName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_ID.Location = new System.Drawing.Point(192, 45);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(416, 36);
            this.txt_ID.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Name.Location = new System.Drawing.Point(192, 107);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(416, 36);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_SecondName
            // 
            this.txt_SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_SecondName.Location = new System.Drawing.Point(192, 165);
            this.txt_SecondName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SecondName.Name = "txt_SecondName";
            this.txt_SecondName.Size = new System.Drawing.Size(416, 36);
            this.txt_SecondName.TabIndex = 5;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_LastName.Location = new System.Drawing.Point(192, 222);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(416, 36);
            this.txt_LastName.TabIndex = 6;
            // 
            // UCUpdateRadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_SecondName);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_ID);
            this.Name = "UCUpdateRadi";
            this.Size = new System.Drawing.Size(632, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_SecondName;
        private System.Windows.Forms.TextBox txt_LastName;
    }
}
