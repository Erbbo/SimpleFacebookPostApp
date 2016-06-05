namespace FacebookApp
{
    partial class Form1
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
            this.authorizeBtn = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.postBtn = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorizeBtn
            // 
            this.authorizeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.authorizeBtn.Location = new System.Drawing.Point(12, 590);
            this.authorizeBtn.Name = "authorizeBtn";
            this.authorizeBtn.Size = new System.Drawing.Size(107, 56);
            this.authorizeBtn.TabIndex = 0;
            this.authorizeBtn.Text = "AUTHORIZE";
            this.authorizeBtn.UseVisualStyleBackColor = false;
            this.authorizeBtn.Click += new System.EventHandler(this.authorizeBtn_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 29);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(978, 555);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // postBtn
            // 
            this.postBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.postBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.postBtn.Location = new System.Drawing.Point(601, 590);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(91, 56);
            this.postBtn.TabIndex = 2;
            this.postBtn.Text = "POST";
            this.postBtn.UseVisualStyleBackColor = false;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(63, 3);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(927, 20);
            this.address.TabIndex = 3;
            // 
            // richTxtBox
            // 
            this.richTxtBox.Location = new System.Drawing.Point(698, 590);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.Size = new System.Drawing.Size(292, 56);
            this.richTxtBox.TabIndex = 4;
            this.richTxtBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.BackColor = System.Drawing.Color.White;
            this.errorMessage.Location = new System.Drawing.Point(138, 612);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 658);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTxtBox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.postBtn);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.authorizeBtn);
            this.Name = "Form1";
            this.Text = "OAuth Facebook Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorizeBtn;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button postBtn;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.RichTextBox richTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorMessage;
    }
}

