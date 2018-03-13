namespace Speech_to_Text
{
    partial class SpeechToText
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
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.speechButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(13, 13);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(259, 204);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "";
            // 
            // speechButton
            // 
            this.speechButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speechButton.Location = new System.Drawing.Point(105, 223);
            this.speechButton.Name = "speechButton";
            this.speechButton.Size = new System.Drawing.Size(75, 23);
            this.speechButton.TabIndex = 1;
            this.speechButton.Text = "Speech";
            this.speechButton.UseVisualStyleBackColor = true;
            this.speechButton.Click += new System.EventHandler(this.speechButton_Click);
            // 
            // SpeechToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 254);
            this.Controls.Add(this.speechButton);
            this.Controls.Add(this.outputTextBox);
            this.Name = "SpeechToText";
            this.Text = "Speech to Text";
            this.Load += new System.EventHandler(this.SpeechToText_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button speechButton;
    }
}

