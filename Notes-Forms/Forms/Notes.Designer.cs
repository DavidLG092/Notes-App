namespace Notes_Forms
{
    partial class Notes
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblDirectories = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateDir = new System.Windows.Forms.Button();
            this.btnDeleteDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(312, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Notes App";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(312, 186);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(517, 237);
            this.txtContent.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(313, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 26);
            this.textBox1.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(308, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Arquivo";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(308, 158);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(105, 25);
            this.lblContent.TabIndex = 4;
            this.lblContent.Text = "Conteúdo";
            // 
            // lblDirectories
            // 
            this.lblDirectories.AutoSize = true;
            this.lblDirectories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectories.Location = new System.Drawing.Point(12, 42);
            this.lblDirectories.Name = "lblDirectories";
            this.lblDirectories.Size = new System.Drawing.Size(104, 25);
            this.lblDirectories.TabIndex = 5;
            this.lblDirectories.Text = "Diretórios";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(313, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(248, 38);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar arquivo";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(581, 444);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(248, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Apagar arquivo";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCreateDir
            // 
            this.btnCreateDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDir.Location = new System.Drawing.Point(3, 444);
            this.btnCreateDir.Name = "btnCreateDir";
            this.btnCreateDir.Size = new System.Drawing.Size(113, 38);
            this.btnCreateDir.TabIndex = 8;
            this.btnCreateDir.Text = "Criar diretório";
            this.btnCreateDir.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDir
            // 
            this.btnDeleteDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDir.Location = new System.Drawing.Point(141, 444);
            this.btnDeleteDir.Name = "btnDeleteDir";
            this.btnDeleteDir.Size = new System.Drawing.Size(113, 38);
            this.btnDeleteDir.TabIndex = 9;
            this.btnDeleteDir.Text = "Apagar diretório";
            this.btnDeleteDir.UseVisualStyleBackColor = true;
            // 
            // Notes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(841, 494);
            this.Controls.Add(this.btnDeleteDir);
            this.Controls.Add(this.btnCreateDir);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDirectories);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblTitle);
            this.Name = "Notes";
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblDirectories;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreateDir;
        private System.Windows.Forms.Button btnDeleteDir;
    }
}

