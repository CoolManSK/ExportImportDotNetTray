namespace ExportImportDotNetTray.OtherForms
{
    partial class LoginForm
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
            this.PASSWORD = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ENTER = new System.Windows.Forms.Button();
            this.btn_CANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PASSWORD
            // 
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PASSWORD.Location = new System.Drawing.Point(12, 9);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(176, 23);
            this.PASSWORD.TabIndex = 0;
            this.PASSWORD.Text = "PASSWORD";
            this.PASSWORD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_ENTER
            // 
            this.btn_ENTER.Location = new System.Drawing.Point(12, 61);
            this.btn_ENTER.Name = "btn_ENTER";
            this.btn_ENTER.Size = new System.Drawing.Size(85, 23);
            this.btn_ENTER.TabIndex = 2;
            this.btn_ENTER.Text = "ENTER";
            this.btn_ENTER.UseVisualStyleBackColor = true;
            this.btn_ENTER.Click += new System.EventHandler(this.btn_ENTER_Click);
            // 
            // btn_CANCEL
            // 
            this.btn_CANCEL.Location = new System.Drawing.Point(103, 61);
            this.btn_CANCEL.Name = "btn_CANCEL";
            this.btn_CANCEL.Size = new System.Drawing.Size(85, 23);
            this.btn_CANCEL.TabIndex = 3;
            this.btn_CANCEL.Text = "CANCEL";
            this.btn_CANCEL.UseVisualStyleBackColor = true;
            this.btn_CANCEL.Click += new System.EventHandler(this.btn_CANCEL_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 93);
            this.ControlBox = false;
            this.Controls.Add(this.btn_CANCEL);
            this.Controls.Add(this.btn_ENTER);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PASSWORD);
            this.Name = "LoginForm";
            this.Text = "LOGIN to SETUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ENTER;
        private System.Windows.Forms.Button btn_CANCEL;
    }
}