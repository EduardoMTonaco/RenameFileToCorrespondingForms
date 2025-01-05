using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFileToCorresponding
{
    public partial class ItensAlteradosForms : Form
    {
        public ItensAlteradosForms(List<string[]> filesList)
        {
            InitializeComponent();
            FillGridView(filesList);
            Dgv_Files.Enabled = true;
            Lbl_Titulo.Text = "Itens alterados";
        }

        private void FillGridView(List<string[]> filesList)
        {
            Dgv_Files.Rows.Clear();

            foreach (string[] fileList in filesList)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(Dgv_Files);
                for (int i = 0; i < fileList.Length; i++)
                {
                    dataGridViewRow.Cells[i].Value = fileList[i];

                }
                Dgv_Files.Rows.Add(dataGridViewRow);
            }
        }
    }
}
