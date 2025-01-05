namespace RenameFileToCorresponding
{
    partial class ItensAlteradosForms
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
            this.Dgv_Files = new System.Windows.Forms.DataGridView();
            this.Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Files)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Files
            // 
            this.Dgv_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Files.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Video,
            this.Legenda});
            this.Dgv_Files.Location = new System.Drawing.Point(12, 81);
            this.Dgv_Files.Name = "Dgv_Files";
            this.Dgv_Files.RowHeadersWidth = 45;
            this.Dgv_Files.Size = new System.Drawing.Size(948, 509);
            this.Dgv_Files.TabIndex = 8;
            // 
            // Video
            // 
            this.Video.HeaderText = "Video";
            this.Video.MinimumWidth = 6;
            this.Video.Name = "Video";
            this.Video.ReadOnly = true;
            this.Video.Width = 450;
            // 
            // Legenda
            // 
            this.Legenda.HeaderText = "Legenda";
            this.Legenda.MinimumWidth = 6;
            this.Legenda.Name = "Legenda";
            this.Legenda.ReadOnly = true;
            this.Legenda.Width = 450;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(449, 37);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(120, 29);
            this.Lbl_Titulo.TabIndex = 9;
            this.Lbl_Titulo.Text = "Lbl_Titulo";
            // 
            // ItensAlteradosForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 603);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Dgv_Files);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ItensAlteradosForms";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itens Alterados";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Files)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Files;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legenda;
    }
}