namespace NN_Family_Creater
{
    partial class PropertyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.directoryPathTB = new System.Windows.Forms.TextBox();
            this.browseDirPathBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Директория ";
            // 
            // directoryPathTB
            // 
            this.directoryPathTB.Location = new System.Drawing.Point(267, 42);
            this.directoryPathTB.Name = "directoryPathTB";
            this.directoryPathTB.Size = new System.Drawing.Size(299, 22);
            this.directoryPathTB.TabIndex = 1;
            // 
            // browseDirPathBtn
            // 
            this.browseDirPathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseDirPathBtn.Location = new System.Drawing.Point(572, 42);
            this.browseDirPathBtn.Name = "browseDirPathBtn";
            this.browseDirPathBtn.Size = new System.Drawing.Size(67, 23);
            this.browseDirPathBtn.TabIndex = 2;
            this.browseDirPathBtn.Text = "Обзор";
            this.browseDirPathBtn.UseVisualStyleBackColor = true;
            this.browseDirPathBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(471, 347);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(95, 32);
            this.ApplyBtn.TabIndex = 3;
            this.ApplyBtn.Text = "Применить";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(572, 347);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(88, 32);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // PropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 382);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.browseDirPathBtn);
            this.Controls.Add(this.directoryPathTB);
            this.Controls.Add(this.label1);
            this.Name = "PropertyForm";
            this.Text = "PropertyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directoryPathTB;
        private System.Windows.Forms.Button browseDirPathBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}