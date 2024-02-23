namespace Async
{
    partial class Form1
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
            SyncButton = new Button();
            asycButton = new Button();
            SuspendLayout();
            // 
            // SyncButton
            // 
            SyncButton.Location = new Point(145, 93);
            SyncButton.Name = "SyncButton";
            SyncButton.Size = new Size(199, 50);
            SyncButton.TabIndex = 0;
            SyncButton.Text = "სინრონულად";
            SyncButton.UseVisualStyleBackColor = true;
            SyncButton.Click += SyncButton_Click;
            // 
            // asycButton
            // 
            asycButton.Location = new Point(467, 93);
            asycButton.Name = "asycButton";
            asycButton.Size = new Size(199, 50);
            asycButton.TabIndex = 0;
            asycButton.Text = "ასინრონულად";
            asycButton.UseVisualStyleBackColor = true;
            asycButton.Click += asycButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 336);
            Controls.Add(asycButton);
            Controls.Add(SyncButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button SyncButton;
        private Button asycButton;
    }
}
