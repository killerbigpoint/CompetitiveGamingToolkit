namespace CompetitiveGamingToolkit.UI
{
    partial class MainUI
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
            this.inputDataQueueSize = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // inputDataQueueSize
            // 
            this.inputDataQueueSize.Location = new System.Drawing.Point(24, 64);
            this.inputDataQueueSize.Name = "inputDataQueueSize";
            this.inputDataQueueSize.Size = new System.Drawing.Size(128, 23);
            this.inputDataQueueSize.TabIndex = 0;
            this.inputDataQueueSize.Text = "Input Data Queue Size";
            this.inputDataQueueSize.UseSelectable = true;
            this.inputDataQueueSize.Click += new System.EventHandler(this.inputDataQueueSize_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputDataQueueSize);
            this.Name = "MainUI";
            this.Text = "Competitive Gaming Toolkit";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton inputDataQueueSize;
    }
}

