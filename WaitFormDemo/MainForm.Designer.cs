namespace WaitFormDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLongTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLongTask
            // 
            this.BtnLongTask.Location = new System.Drawing.Point(632, 324);
            this.BtnLongTask.Name = "BtnLongTask";
            this.BtnLongTask.Size = new System.Drawing.Size(130, 46);
            this.BtnLongTask.TabIndex = 0;
            this.BtnLongTask.Text = "Do Long task";
            this.BtnLongTask.UseVisualStyleBackColor = true;
            this.BtnLongTask.Click += new System.EventHandler(this.BtnLongTask_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLongTask);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnLongTask;
    }
}