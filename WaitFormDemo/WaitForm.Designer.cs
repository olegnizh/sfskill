namespace WaitFormDemo
{
    partial class WaitForm
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
            this.LblWait = new System.Windows.Forms.Label();
            this.LblMessages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblWait
            // 
            this.LblWait.AutoSize = true;
            this.LblWait.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblWait.Location = new System.Drawing.Point(75, 18);
            this.LblWait.Name = "LblWait";
            this.LblWait.Size = new System.Drawing.Size(213, 25);
            this.LblWait.TabIndex = 0;
            this.LblWait.Text = "Please Wait Processing";
            // 
            // LblMessages
            // 
            this.LblMessages.Location = new System.Drawing.Point(0, 0);
            this.LblMessages.Name = "LblMessages";
            this.LblMessages.Size = new System.Drawing.Size(100, 23);
            this.LblMessages.TabIndex = 0;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 222);
            this.Controls.Add(this.LblMessages);
            this.Controls.Add(this.LblWait);
            this.Name = "WaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wait Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblWait;
        
    }
}