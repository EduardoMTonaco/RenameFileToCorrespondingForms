using LibRegex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RenameFileToCorresponding
{
    public partial class MainFormRename : Form
    {
        private string _diretory;
        private string _standartPattern = "(s\\d{2}e\\d{2})";
        private string _pattern = "";
        private string _standartMainExpression = "mkv";
        private string _mainExpression = "";
        private string _standartSlaveExpression = "srt";
        private string _slaveExpression = "";
        public MainFormRename()
        {
            InitializeComponent();

            Lbl_Titulo.Text = "Renomear arquivos em massa";
            Lbl_RegularExpression.Text = "Expressão Regular";
            Lbl_Path.Text = "Caminho";
            Lbl_MainExtension.Text = "Extensão Principal";
            Lbl_SlaveExtension.Text = "Extensão Secundario";
            Lbl_Standart.Text = "Voltar ao padrão";

            Txt_Path.Text = "";
            Txt_RegularExpression.Text = "";
            Txt_MainExtension.Text = _standartMainExpression;
            Txt_SlaveExpression.Text = _standartSlaveExpression;
            Txt_Path.Enabled = false;
            Txt_RegularExpression.Enabled = false;
            Txt_MainExtension.Enabled = false;
            Txt_SlaveExpression.Enabled = false;


            Btn_Rename.Text = "Renomear";
            Btn_SelecPath.Text = "Selecionar Pasta";
            Btn_ChangeRegularExpression.Text = "Alterar Expressão";
            Btn_Standart.Text = "Retornar ao padrão";
            Btn_AlterExtension.Text = "Alterar Extensão";
        }

        private void Btn_Rename_Click(object sender, EventArgs e)
        {
            if (Txt_RegularExpression.Enabled == true)
            {
                MessageBox.Show("Confirme a expressão regular, deixe vazio para o padrão!", "Falha ao renomear", MessageBoxButtons.OK);
                return;
            }
            if (Txt_MainExtension.Enabled == true || Txt_SlaveExpression.Enabled == true)
            {
                MessageBox.Show("Confirme a expressão regular, deixe vazio para o padrão!", "Falha ao renomear", MessageBoxButtons.OK);
                return;
            }
            //Btn_AlterExpression
            if (!string.IsNullOrEmpty(_diretory))
            {
                try
                {
                    RenameFileToCorrespondingClass rename = new RenameFileToCorrespondingClass(_diretory, _pattern == "" ? _standartPattern : _pattern, Txt_MainExtension.Text, Txt_SlaveExpression.Text);
                    List<string[]> listFile = rename.RenameFileName();
                    ItensAlteradosForms alteradosForms = new ItensAlteradosForms(listFile);
                    alteradosForms.ShowDialog();
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro na expressão regular, deixe vazio caso para deixar o padrão!", "Erro na expressão regular!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o diretorio", "Falha ao renomear", MessageBoxButtons.OK);
            }
        }

        private void Btn_ChangeRegularExpression_Click(object sender, EventArgs e)
        {
            if (Txt_RegularExpression.Enabled == true)
            {
                Txt_RegularExpression.Enabled = false;
                Btn_ChangeRegularExpression.Text = "Alterar Expressão";
            }
            else
            {
                Txt_RegularExpression.Enabled = true;
                Btn_ChangeRegularExpression.Text = "Confirmar";
            }
            _pattern = Txt_RegularExpression.Text;
        }

        private void Btn_SelecPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dirDialog = new FolderBrowserDialog())
            {
                // Mostra a janela de escolha do directorio
                DialogResult res = dirDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // Como o utilizador carregou no OK, o directorio escolhido pode ser acedido da seguinte forma:
                    _diretory = dirDialog.SelectedPath;
                    Txt_Path.Text = _diretory;
                }
                else
                {
                    _diretory = "";
                    Txt_Path.Text = "";
                }
            }
        }

        private void Btn_AlterExpression_Click(object sender, EventArgs e)
        {

            if (Txt_MainExtension.Enabled == true)
            {
                Txt_MainExtension.Enabled = false;
                Txt_SlaveExpression.Enabled = false;
                Btn_AlterExtension.Text = "Alterar Extensão";
            }
            else
            {
                Txt_MainExtension.Enabled = true;
                Txt_SlaveExpression.Enabled = true;
                Btn_AlterExtension.Text = "Confirmar";
            }
            _mainExpression = Txt_MainExtension.Text;
            _slaveExpression = Txt_SlaveExpression.Text;
        }

        private void Btn_Standart_Click(object sender, EventArgs e)
        {
            Txt_MainExtension.Text = _standartMainExpression;
            Txt_SlaveExpression.Text = _standartSlaveExpression;
            Txt_RegularExpression.Text = "";
            Txt_Path.Text = "";
        }
    }


}
