namespace RenameFileToCorresponding
{
    partial class MainFormRename
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Rename = new System.Windows.Forms.Button();
            this.Txt_Path = new System.Windows.Forms.TextBox();
            this.Txt_RegularExpression = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_SelecPath = new System.Windows.Forms.Button();
            this.Btn_ChangeRegularExpression = new System.Windows.Forms.Button();
            this.Btn_AlterExtension = new System.Windows.Forms.Button();
            this.Txt_SlaveExpression = new System.Windows.Forms.TextBox();
            this.Txt_MainExtension = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Standart = new System.Windows.Forms.Button();
            this.Lbl_Path = new System.Windows.Forms.Label();
            this.Lbl_MainExtension = new System.Windows.Forms.Label();
            this.Lbl_SlaveExtension = new System.Windows.Forms.Label();
            this.Lbl_Standart = new System.Windows.Forms.Label();
            this.Lbl_RegularExpression = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Rename
            // 
            this.Btn_Rename.Location = new System.Drawing.Point(12, 338);
            this.Btn_Rename.Name = "Btn_Rename";
            this.Btn_Rename.Size = new System.Drawing.Size(456, 71);
            this.Btn_Rename.TabIndex = 0;
            this.Btn_Rename.Text = "Btn_Rename";
            this.Btn_Rename.UseVisualStyleBackColor = true;
            this.Btn_Rename.Click += new System.EventHandler(this.Btn_Rename_Click);
            // 
            // Txt_Path
            // 
            this.Txt_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Path.Location = new System.Drawing.Point(12, 272);
            this.Txt_Path.Name = "Txt_Path";
            this.Txt_Path.Size = new System.Drawing.Size(459, 24);
            this.Txt_Path.TabIndex = 1;
            this.Txt_Path.Text = "Txt_Path";
            // 
            // Txt_RegularExpression
            // 
            this.Txt_RegularExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RegularExpression.Location = new System.Drawing.Point(12, 78);
            this.Txt_RegularExpression.Name = "Txt_RegularExpression";
            this.Txt_RegularExpression.Size = new System.Drawing.Size(224, 24);
            this.Txt_RegularExpression.TabIndex = 2;
            this.Txt_RegularExpression.Text = "Txt_RegularExpression";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(12, 10);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(106, 25);
            this.Lbl_Titulo.TabIndex = 4;
            this.Lbl_Titulo.Text = "Lbl_Titulo";
            // 
            // Btn_SelecPath
            // 
            this.Btn_SelecPath.Location = new System.Drawing.Point(12, 302);
            this.Btn_SelecPath.Name = "Btn_SelecPath";
            this.Btn_SelecPath.Size = new System.Drawing.Size(189, 30);
            this.Btn_SelecPath.TabIndex = 5;
            this.Btn_SelecPath.Text = "Btn_SelecPath";
            this.Btn_SelecPath.UseVisualStyleBackColor = true;
            this.Btn_SelecPath.Click += new System.EventHandler(this.Btn_SelecPath_Click);
            // 
            // Btn_ChangeRegularExpression
            // 
            this.Btn_ChangeRegularExpression.Location = new System.Drawing.Point(12, 113);
            this.Btn_ChangeRegularExpression.Name = "Btn_ChangeRegularExpression";
            this.Btn_ChangeRegularExpression.Size = new System.Drawing.Size(224, 30);
            this.Btn_ChangeRegularExpression.TabIndex = 6;
            this.Btn_ChangeRegularExpression.Text = "Btn_ChangeRegularExpression";
            this.Btn_ChangeRegularExpression.UseVisualStyleBackColor = true;
            this.Btn_ChangeRegularExpression.Click += new System.EventHandler(this.Btn_ChangeRegularExpression_Click);
            // 
            // Btn_AlterExtension
            // 
            this.Btn_AlterExtension.Location = new System.Drawing.Point(10, 134);
            this.Btn_AlterExtension.Name = "Btn_AlterExtension";
            this.Btn_AlterExtension.Size = new System.Drawing.Size(195, 30);
            this.Btn_AlterExtension.TabIndex = 7;
            this.Btn_AlterExtension.Text = "Btn_AlterExtension";
            this.Btn_AlterExtension.UseVisualStyleBackColor = true;
            this.Btn_AlterExtension.Click += new System.EventHandler(this.Btn_AlterExpression_Click);
            // 
            // Txt_SlaveExpression
            // 
            this.Txt_SlaveExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SlaveExpression.Location = new System.Drawing.Point(10, 94);
            this.Txt_SlaveExpression.MaxLength = 5;
            this.Txt_SlaveExpression.Name = "Txt_SlaveExpression";
            this.Txt_SlaveExpression.Size = new System.Drawing.Size(194, 24);
            this.Txt_SlaveExpression.TabIndex = 8;
            this.Txt_SlaveExpression.Text = "Txt_SlaveExpression";
            // 
            // Txt_MainExtension
            // 
            this.Txt_MainExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_MainExtension.Location = new System.Drawing.Point(10, 34);
            this.Txt_MainExtension.MaxLength = 5;
            this.Txt_MainExtension.Name = "Txt_MainExtension";
            this.Txt_MainExtension.Size = new System.Drawing.Size(195, 24);
            this.Txt_MainExtension.TabIndex = 9;
            this.Txt_MainExtension.Text = "Txt_MainExtension";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_SlaveExtension);
            this.panel1.Controls.Add(this.Lbl_MainExtension);
            this.panel1.Controls.Add(this.Txt_SlaveExpression);
            this.panel1.Controls.Add(this.Btn_AlterExtension);
            this.panel1.Controls.Add(this.Txt_MainExtension);
            this.panel1.Location = new System.Drawing.Point(247, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 183);
            this.panel1.TabIndex = 10;
            // 
            // Btn_Standart
            // 
            this.Btn_Standart.Location = new System.Drawing.Point(12, 197);
            this.Btn_Standart.Name = "Btn_Standart";
            this.Btn_Standart.Size = new System.Drawing.Size(224, 30);
            this.Btn_Standart.TabIndex = 11;
            this.Btn_Standart.Text = "Btn_Standart";
            this.Btn_Standart.UseVisualStyleBackColor = true;
            this.Btn_Standart.Click += new System.EventHandler(this.Btn_Standart_Click);
            // 
            // Lbl_Path
            // 
            this.Lbl_Path.AutoSize = true;
            this.Lbl_Path.Location = new System.Drawing.Point(12, 244);
            this.Lbl_Path.Name = "Lbl_Path";
            this.Lbl_Path.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Path.TabIndex = 12;
            this.Lbl_Path.Text = "Lbl_Path";
            // 
            // Lbl_MainExtension
            // 
            this.Lbl_MainExtension.AutoSize = true;
            this.Lbl_MainExtension.Location = new System.Drawing.Point(10, 14);
            this.Lbl_MainExtension.Name = "Lbl_MainExtension";
            this.Lbl_MainExtension.Size = new System.Drawing.Size(96, 13);
            this.Lbl_MainExtension.TabIndex = 13;
            this.Lbl_MainExtension.Text = "Lbl_MainExtension";
            // 
            // Lbl_SlaveExtension
            // 
            this.Lbl_SlaveExtension.AutoSize = true;
            this.Lbl_SlaveExtension.Location = new System.Drawing.Point(10, 69);
            this.Lbl_SlaveExtension.Name = "Lbl_SlaveExtension";
            this.Lbl_SlaveExtension.Size = new System.Drawing.Size(100, 13);
            this.Lbl_SlaveExtension.TabIndex = 14;
            this.Lbl_SlaveExtension.Text = "Lbl_SlaveExtension";
            // 
            // Lbl_Standart
            // 
            this.Lbl_Standart.AutoSize = true;
            this.Lbl_Standart.Location = new System.Drawing.Point(12, 178);
            this.Lbl_Standart.Name = "Lbl_Standart";
            this.Lbl_Standart.Size = new System.Drawing.Size(67, 13);
            this.Lbl_Standart.TabIndex = 13;
            this.Lbl_Standart.Text = "Lbl_Standart";
            // 
            // Lbl_RegularExpression
            // 
            this.Lbl_RegularExpression.AutoSize = true;
            this.Lbl_RegularExpression.Location = new System.Drawing.Point(12, 58);
            this.Lbl_RegularExpression.Name = "Lbl_RegularExpression";
            this.Lbl_RegularExpression.Size = new System.Drawing.Size(115, 13);
            this.Lbl_RegularExpression.TabIndex = 14;
            this.Lbl_RegularExpression.Text = "Lbl_RegularExpression";
            // 
            // MainFormRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(497, 433);
            this.Controls.Add(this.Lbl_RegularExpression);
            this.Controls.Add(this.Lbl_Standart);
            this.Controls.Add(this.Lbl_Path);
            this.Controls.Add(this.Btn_Standart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_ChangeRegularExpression);
            this.Controls.Add(this.Btn_SelecPath);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Txt_RegularExpression);
            this.Controls.Add(this.Txt_Path);
            this.Controls.Add(this.Btn_Rename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFormRename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renomear Arquivos em Massa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Rename;
        private System.Windows.Forms.TextBox Txt_Path;
        private System.Windows.Forms.TextBox Txt_RegularExpression;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_SelecPath;
        private System.Windows.Forms.Button Btn_ChangeRegularExpression;
        private System.Windows.Forms.Button Btn_AlterExtension;
        private System.Windows.Forms.TextBox Txt_SlaveExpression;
        private System.Windows.Forms.TextBox Txt_MainExtension;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Standart;
        private System.Windows.Forms.Label Lbl_Path;
        private System.Windows.Forms.Label Lbl_SlaveExtension;
        private System.Windows.Forms.Label Lbl_MainExtension;
        private System.Windows.Forms.Label Lbl_Standart;
        private System.Windows.Forms.Label Lbl_RegularExpression;
    }
}

