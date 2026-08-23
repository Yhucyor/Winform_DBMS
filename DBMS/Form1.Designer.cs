namespace DBMS
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
            btnOpeConnect = new Button();
            btnCloseConnect = new Button();
            SuspendLayout();
            // 
            // btnOpeConnect
            // 
            btnOpeConnect.Location = new Point(21, 31);
            btnOpeConnect.Name = "btnOpeConnect";
            btnOpeConnect.Size = new Size(124, 37);
            btnOpeConnect.TabIndex = 0;
            btnOpeConnect.Text = "Mở Kết Nối";
            btnOpeConnect.UseVisualStyleBackColor = true;
            btnOpeConnect.Click += btnOpeConnect_Click;
            // 
            // btnCloseConnect
            // 
            btnCloseConnect.Location = new Point(21, 109);
            btnCloseConnect.Name = "btnCloseConnect";
            btnCloseConnect.Size = new Size(124, 37);
            btnCloseConnect.TabIndex = 1;
            btnCloseConnect.Text = "Đóng Kết Nối";
            btnCloseConnect.UseVisualStyleBackColor = true;
            btnCloseConnect.Click += btnCloseConnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCloseConnect);
            Controls.Add(btnOpeConnect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpeConnect;
        private Button btnCloseConnect;
    }
}
