using processosAdministrativos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using processosAdministrativos.Classes;

namespace processosAdministrativos.Telas
{
    public partial class CadastroEstoquista : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        List<string> classes = new List<string>();
        Variaveis vat = new Variaveis();

        public CadastroEstoquista()
        {
            InitializeComponent();
        }

        public int codEstoq()
        {
            Sql = "SELECT MAX(est_codigo) FROM estoquista";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            object pedido = dao.Query.ExecuteScalar();
            dao.Desconecta();

            return Convert.ToInt32(pedido);
        }
        public void limpaCampo()
        {
            nomeTxt.Text = String.Empty;
            abrasivosCb.Checked = false;
            correiasCb.Checked = false;
            eletricaCb.Checked = false;
            epiCb.Checked = false;
            ferragensCb.Checked = false;
            ferramentasCb.Checked = false;
            fixadoresCb.Checked = false;
            hidraulicaCb.Checked = false;
            quimicosCb.Checked = false;
            rodiziosCb.Checked = false;
            soldasCb.Checked = false;
            nomeTxt.Focus();
            vat.CodEstoquista = String.Empty;
            classes.Clear();
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            if (nomeLb.Text != "" && (abrasivosCb.Checked == true || correiasCb.Checked == true || eletricaCb.Checked == true || epiCb.Checked == true || ferragensCb.Checked == true || ferramentasCb.Checked == true || fixadoresCb.Checked == true || hidraulicaCb.Checked == true || quimicosCb.Checked == true || rodiziosCb.Checked == true || soldasCb.Checked == true))
            {
                ControlEstoquista ce = new ControlEstoquista();
                ce.Estoquista = nomeTxt.Text;
                String data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ce.Data = Convert.ToDateTime(data);
                ce.CodEstoquista = codEstoq() +1;

                for (int i = 0; i < 11; i++)
                {
                    if (abrasivosCb.Checked)
                    {
                        ce.CodClasse.Add(1);
                        abrasivosCb.Checked = false;
                    }
                    else
                    {
                        if (correiasCb.Checked)
                        {
                            ce.CodClasse.Add(2);
                            correiasCb.Checked = false;
                        }
                        else
                        {
                            if (eletricaCb.Checked)
                            {
                                ce.CodClasse.Add(3);
                                eletricaCb.Checked = false;
                            }
                            else
                            {
                                if (epiCb.Checked)
                                {
                                    ce.CodClasse.Add(4);
                                    epiCb.Checked = false;
                                }
                                else
                                {
                                    if (ferragensCb.Checked)
                                    {
                                        ce.CodClasse.Add(5);
                                        ferragensCb.Checked = false;
                                    }
                                    else
                                    {
                                        if (ferramentasCb.Checked)
                                        {
                                            ce.CodClasse.Add(6);
                                            ferramentasCb.Checked = false;
                                        }
                                        else
                                        {
                                            if (fixadoresCb.Checked)
                                            {
                                                ce.CodClasse.Add(13);
                                                fixadoresCb.Checked = false;
                                            }
                                            else
                                            {
                                                if (hidraulicaCb.Checked)
                                                {
                                                    ce.CodClasse.Add(7);
                                                    hidraulicaCb.Checked = false;
                                                }
                                                else
                                                {
                                                    if (quimicosCb.Checked)
                                                    {
                                                        ce.CodClasse.Add(8);
                                                        ce.CodClasse.Add(9);
                                                        quimicosCb.Checked = false;
                                                    }
                                                    else
                                                    {
                                                        if (rodiziosCb.Checked)
                                                        {
                                                            ce.CodClasse.Add(10);
                                                            rodiziosCb.Checked = false;
                                                        }
                                                        else
                                                        {
                                                            if (soldasCb.Checked)
                                                            {
                                                                ce.CodClasse.Add(11);
                                                                soldasCb.Checked = false;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }                   
                }
                if (vat.CodEstoquista == "")
                {
                    dao.CadastraEstoquista(ce);
                    dao.CadastraClasseEstoq(ce);
                    MessageBox.Show("Estoquista salvo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampo();
                }
                else
                {
                    dao.AlteraEstoquista(ce, Convert.ToInt32(vat.CodEstoquista));
                    dao.AlteraClasseEstoq(ce, Convert.ToInt32(vat.CodEstoquista));
                    MessageBox.Show("Estoquista Alterado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampo();
                }
                
            }
            else
            {
                MessageBox.Show("Campo Nome e Categorias obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void alterarBt_Click(object sender, EventArgs e)
        {
            limpaCampo();
            ProcuraEstoquista ae = new ProcuraEstoquista();
            ae.ShowDialog();          
        }

        private void CadastroEstoquista_Activated(object sender, EventArgs e)
        {
            ControlEstoquista ce = new ControlEstoquista();
            if (vat.CodEstoquista.Length > 0)
            {
                Sql = "SELECT cles_classe, est_nome FROM classes_estoque INNER JOIN estoquista ON classes_estoque.cles_estoquista = estoquista.est_codigo WHERE est_codigo = " + vat.CodEstoquista + "";
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.Conecta();
                MySqlDataReader clas = dao.Query.ExecuteReader();
                while (clas.Read())
                {
                    classes.Add(clas["cles_classe"].ToString());
                }
                nomeTxt.Text = clas["est_nome"].ToString();
                clas.Close();
                dao.Desconecta();
                for (int i = 0; i < classes.Count; i++)
                {
                    if (classes[i] == "1")
                    {
                        abrasivosCb.Checked = true;
                    }
                    else
                    {
                        if (classes[i] == "2")
                        {
                            correiasCb.Checked = true;
                        }
                        else
                        {
                            if (classes[i] == "3")
                            {
                                eletricaCb.Checked = true;
                            }
                            else
                            {
                                if (classes[i] == "4")
                                {
                                    epiCb.Checked = true;
                                }
                                else
                                {
                                    if (classes[i] == "5")
                                    {
                                        ferragensCb.Checked = true;
                                    }
                                    else
                                    {
                                        if (classes[i] == "6")
                                        {
                                            ferramentasCb.Checked = true;
                                        }
                                        else
                                        {
                                            if (classes[i] == "13")
                                            {
                                                fixadoresCb.Checked = true;
                                            }
                                            else
                                            {
                                                if (classes[i] == "7")
                                                {
                                                    hidraulicaCb.Checked = true;
                                                }
                                                else
                                                {
                                                    if (classes[i] == "9")
                                                    {
                                                        quimicosCb.Checked = true;
                                                    }
                                                    else
                                                    {
                                                        if (classes[i] == "10")
                                                        {
                                                            rodiziosCb.Checked = true;
                                                        }
                                                        else
                                                        {
                                                            if (classes[i] == "11")
                                                            {
                                                                soldasCb.Checked = true;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }                   
                }
            }
        }

        private void CadastroEstoquista_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaCadEstoquista = 0;
            limpaCampo();
        }
    }
}
