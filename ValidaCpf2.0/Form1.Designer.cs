namespace ValidaCpf2._0
{
    partial class frmCpf
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
            this.btnValidaCpf = new System.Windows.Forms.Button();
            this.txValidaCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidaCpf
            // 
            this.btnValidaCpf.Location = new System.Drawing.Point(219, 44);
            this.btnValidaCpf.Name = "btnValidaCpf";
            this.btnValidaCpf.Size = new System.Drawing.Size(75, 23);
            this.btnValidaCpf.TabIndex = 0;
            this.btnValidaCpf.Text = "VALIDAR";
            this.btnValidaCpf.UseVisualStyleBackColor = true;
            this.btnValidaCpf.Click += new System.EventHandler(this.btnValidaCpf_Click);
            // 
            // txValidaCpf
            // 
            this.txValidaCpf.Location = new System.Drawing.Point(90, 44);
            this.txValidaCpf.Mask = "000.000.000-00";
            this.txValidaCpf.Name = "txValidaCpf";
            this.txValidaCpf.Size = new System.Drawing.Size(101, 20);
            this.txValidaCpf.TabIndex = 1;
            this.txValidaCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txValidaCpf_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmCpf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 96);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txValidaCpf);
            this.Controls.Add(this.btnValidaCpf);
            this.MaximizeBox = false;
            this.Name = "frmCpf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar Cpf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidaCpf;
        private System.Windows.Forms.MaskedTextBox txValidaCpf;
        private System.Windows.Forms.Label label1;
    }
}

