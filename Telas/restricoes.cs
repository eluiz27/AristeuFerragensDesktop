using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class restricoes : Form
    {
        variaveis var = new variaveis();
        DAO dao = new DAO();
        controlUsuarios cu = new controlUsuarios();
        private string Sql = String.Empty;

        List<string> restri = new List<string>();
        string recuTab1 = string.Empty;
        string recuTab2 = string.Empty;
        string recuTab3 = string.Empty;
        string recuTab4 = string.Empty;
        string recuTab5 = string.Empty;
        string recuTab6 = string.Empty;
        string recuTab7 = string.Empty;

        string tab1 = string.Empty;
        string tab2 = string.Empty;
        string tab3 = string.Empty;
        string tab4 = string.Empty;
        string tab5 = string.Empty;
        string tab6 = string.Empty;
        string tab7 = string.Empty;

        public void salvaMarcados()
        {
            restri.Add("1:" + (compCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("2:" + (compAssistTecCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("3:" + (compAssistTecCadCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("4:" + (compAssistTecConsCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("5:" + (compLoteValCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("6:" + (compLoeCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("7:" + (compLoeCadCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("8:" + (compLoeConsCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("9:" + (compFollowCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("10:" + (compFollowCadCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("11:" + (compFollowConsCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("12:" + (compFollowCadSitCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("13:" + (compNSerieCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("14:" + (compCodifcCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("15:" + (compOrdCompCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("16:" + (compMediaVendCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("17:" + (compCotCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("18:" + (compCotFixCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("19:" + (compCotProdCb.Checked ? 1 : 0).ToString());         
            for(int i = 0; i < restri.Count; i++)
            {
                tab1 = tab1+restri[i];
            }
            restri.Clear();

            restri.Add("1:" + (expedCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("2:" + (expedControEntreCb.Checked ? 1 : 0).ToString());
            for (int i = 0; i < restri.Count; i++)
            {
                tab2 = tab2 + restri[i];
            }
            restri.Clear();

            restri.Add("1:" + (estCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("2:" + (estCadEstoqCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("3:" + (estControEstCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("4:" + (estLoteValCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("5:" + (estLoeCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("6:" + (estCodifCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("7:" + (estEtiqPrecCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("8:" + (EstContCb.Checked ? 1 : 0).ToString());
            for (int i = 0; i < restri.Count; i++)
            {
                tab3 = tab3 + restri[i];
            }
            restri.Clear();

            restri.Add("1:" + (finanCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("2:" + (finanMapaVendCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("3:" + (finanIndicVendCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("4:" + (finanCompFuncCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("5:" + (finanControlaCb.Checked ? 1 : 0).ToString());
            for (int i = 0; i < restri.Count; i++)
            {
                tab4 = tab4 + restri[i];
            }
            restri.Clear();

            restri.Add("1:" + (vendCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("2:" + (vendLoeCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("3:" + (vendConsultLoe.Checked ? 1 : 0).ToString() + "-");
            restri.Add("4:" + (vendEntregCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("5:" + (vendAssistTecCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("6:" + (vendNSeriCb.Checked ? 1 : 0).ToString() + "-");
            for (int i = 0; i < restri.Count; i++)
            {
                tab5 = tab5 + restri[i];
            }
            restri.Clear();

            restri.Add("1:" + (markCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("2:" + (markCampCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("3:" + (markCadCampCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("4:" + (markCadBanCb.Checked ? 1 : 0).ToString());
            for (int i = 0; i < restri.Count; i++)
            {
                tab6 = tab6 + restri[i];
            }
            restri.Clear();

            restri.Add("1:" + (utiCb.Checked ? 1 : 0).ToString() + "-");
            restri.Add("2:" + (utiRestCb.Checked ? 1 : 0).ToString());
            for (int i = 0; i < restri.Count; i++)
            {
                tab7 = tab7 + restri[i];
            }
            restri.Clear();
        }

        public void abilitaCheck()
        {
            compCb.Enabled = true;
            expedCb.Enabled = true;
            estCb.Enabled = true;
            finanCb.Enabled = true;
            vendCb.Enabled = true;
            markCb.Enabled = true;
            utiCb.Enabled = true;
        }
        public void desabilitaCheck()
        {
            compCb.Enabled = false;
            compAssistTecCb.Enabled = false;
            compAssistTecCadCb.Enabled = false;
            compAssistTecConsCb.Enabled = false;
            compLoteValCb.Enabled = false;
            compLoeCb.Enabled = false;
            compLoeCadCb.Enabled = false;
            compLoeConsCb.Enabled = false;
            compFollowCb.Enabled = false;
            compFollowCadCb.Enabled = false;
            compFollowConsCb.Enabled = false;
            compFollowCadSitCb.Enabled = false;
            compNSerieCb.Enabled = false;
            compCodifcCb.Enabled = false;
            compOrdCompCb.Enabled = false;
            compMediaVendCb.Enabled = false;
            compCotCb.Enabled = false;
            compCotFixCb.Enabled = false;
            compCotProdCb.Enabled = false;
            expedCb.Enabled = false;
            expedControEntreCb.Enabled = false;
            estCb.Enabled = false;
            estCadEstoqCb.Enabled = false;
            estControEstCb.Enabled = false;
            estLoteValCb.Enabled = false;
            estLoeCb.Enabled = false;
            estCodifCb.Enabled = false;
            estEtiqPrecCb.Enabled = false;
            EstContCb.Enabled = false;
            finanCb.Enabled = false;
            finanMapaVendCb.Enabled = false;
            finanIndicVendCb.Enabled = false;
            finanCompFuncCb.Enabled = false;
            finanControlaCb.Enabled = false;
            vendCb.Enabled = false;
            vendLoeCb.Enabled = false;
            vendConsultLoe.Enabled = false;
            vendEntregCb.Enabled = false;
            vendAssistTecCb.Enabled = false;
            vendNSeriCb.Enabled = false;
            markCb.Enabled = false;
            markCampCb.Enabled = false;
            markCadCampCb.Enabled = false;
            markCadBanCb.Enabled = false;
            utiCb.Enabled = false;
            utiRestCb.Enabled = false;
        }

        public void desmarca()
        {
            compCb.Checked = false;
            compAssistTecCb.Checked = false;
            compAssistTecCadCb.Checked = false;
            compAssistTecConsCb.Checked = false;
            compLoteValCb.Checked = false;
            compLoeCb.Checked = false;
            compLoeCadCb.Checked = false;
            compLoeConsCb.Checked = false;
            compFollowCb.Checked = false;
            compFollowCadCb.Checked = false;
            compFollowConsCb.Checked = false;
            compFollowCadSitCb.Checked = false;
            compNSerieCb.Checked = false;
            compCodifcCb.Checked = false;
            compOrdCompCb.Checked = false;
            compMediaVendCb.Checked = false;
            compCotCb.Checked = false;
            compCotFixCb.Checked = false;
            compCotProdCb.Checked = false;
            expedCb.Checked = false;
            expedControEntreCb.Checked = false;
            estCb.Checked = false;
            estCadEstoqCb.Checked = false;
            estControEstCb.Checked = false;
            estLoteValCb.Checked = false;
            estLoeCb.Checked = false;
            estCodifCb.Checked = false;
            estEtiqPrecCb.Checked = false;
            EstContCb.Checked = false;
            finanCb.Enabled = false;
            finanMapaVendCb.Checked = false;
            finanIndicVendCb.Checked = false;
            finanCompFuncCb.Checked = false;
            finanControlaCb.Checked = false;
            vendCb.Checked = false;
            vendLoeCb.Checked = false;
            vendConsultLoe.Checked = false;
            vendEntregCb.Checked = false;
            vendAssistTecCb.Checked = false;
            vendNSeriCb.Checked = false;
            markCb.Checked = false;
            markCampCb.Checked = false;
            markCadCampCb.Checked = false;
            markCadBanCb.Checked = false;
            utiCb.Checked = false;
            utiRestCb.Checked = false;
        }

        public void limpaVar()
        {
            tab1 = string.Empty;
            tab2 = string.Empty;
            tab3 = string.Empty;
            tab4 = string.Empty;
            tab5 = string.Empty;
            tab6 = string.Empty;
            tab7 = string.Empty;
            restri.Clear();
            recuTab1 = string.Empty;
            recuTab2 = string.Empty;
            recuTab3 = string.Empty;
            recuTab4 = string.Empty;
            recuTab5 = string.Empty;
            recuTab6 = string.Empty;
            recuTab7 = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox3.Enabled = false;
        }

        public restricoes()
        {
            InitializeComponent();
        }

        private void restricoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaRestricoes = 0;
        }

        private void restricoes_Activated(object sender, EventArgs e)
        {
            if(var.AuxUsuario == 1)
            {
                textBox1.Text = var.CodUsuario;
                textBox3.Text = var.AuxSenha;
                textBox3.Enabled = true;
                var.AuxUsuario = 0;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                string nome = string.Empty;
                string senha = string.Empty;
                if (textBox1.TextLength == 1)
                    textBox1.Text = "000" + textBox1.Text;
                else if (textBox1.TextLength == 2)
                    textBox1.Text = "00" + textBox1.Text;
                else if (textBox1.TextLength == 3)
                    textBox1.Text = "0" + textBox1.Text;

                Sql = "SELECT sen_usuario, res_senha, if(res_compras is null, '', res_compras) as 'res_compras', if(res_expedicao is null, '', res_expedicao) as 'res_expedicao', "+
                        "if (res_estoque is null, '', res_estoque) as 'res_estoque', if (res_financeiro is null, '', res_financeiro) as 'res_financeiro', "+
                        "if (res_vendas is null, '', res_vendas) as 'res_vendas', if (res_marketing is null, '', res_marketing) as 'res_marketing', "+
                        "if (res_utilitarios is null, '', res_utilitarios) as 'res_utilitarios' FROM senhas a LEFT OUTER JOIN restricoes b ON a.sen_acesso = b.res_usuario where sen_acesso = '" + textBox1.Text + "'";
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.conecta();
                MySqlDataReader usu = dao.Query.ExecuteReader();
                while (usu.Read())
                {
                    nome = usu["sen_usuario"].ToString();
                    senha = usu["res_senha"].ToString();
                    recuTab1 = usu["res_compras"].ToString();
                    recuTab2 = usu["res_expedicao"].ToString();
                    recuTab3 = usu["res_estoque"].ToString();
                    recuTab4 = usu["res_financeiro"].ToString();
                    recuTab5 = usu["res_vendas"].ToString();
                    recuTab6 = usu["res_marketing"].ToString();
                    recuTab7 = usu["res_utilitarios"].ToString();
                }
                if (nome != string.Empty)
                {
                    desmarca();
                    abilitaCheck();
                    textBox2.Text = nome;
                    textBox3.Text = senha;
                    textBox3.Enabled = true;
                    if (recuTab1.Length > 0)
                    {
                        string[] x1 = recuTab1.Split('-');
                        if (x1[0] == "1:1")
                            compCb.Checked = true;
                        if (x1[1] == "2:1")
                            compAssistTecCb.Checked = true;
                        if (x1[2] == "3:1")
                            compAssistTecCadCb.Checked = true;
                        if (x1[3] == "4:1")
                            compAssistTecConsCb.Checked = true;
                        if (x1[4] == "5:1")
                            compLoteValCb.Checked = true;
                        if (x1[5] == "6:1")
                            compLoeCb.Checked = true;
                        if (x1[6] == "7:1")
                            compLoeCadCb.Checked = true;
                        if (x1[7] == "8:1")
                            compLoeConsCb.Checked = true;
                        if (x1[8] == "9:1")
                            compFollowCb.Checked = true;
                        if (x1[9] == "10:1")
                            compFollowCadCb.Checked = true;
                        if (x1[10] == "12:1")
                            compFollowConsCb.Checked = true;
                        if (x1[11] == "12:1")
                            compFollowCadSitCb.Checked = true;
                        if (x1[12] == "13:1")
                            compNSerieCb.Checked = true;
                        if (x1[13] == "14:1")
                            compCodifcCb.Checked = true;
                        if (x1[14] == "15:1")
                            compOrdCompCb.Checked = true;
                        if (x1[15] == "16:1")
                            compMediaVendCb.Checked = true;
                        if (x1[16] == "17:1")
                            compCotCb.Checked = true;
                        if (x1[17] == "18:1")
                            compCotFixCb.Checked = true;
                        if (x1[18] == "19:1")
                            compCotProdCb.Checked = true;
                        for (int i = 0; i < x1.Length; i++)
                        {
                            x1[i] = null;
                        }

                        string[] x2 = recuTab2.Split('-');
                        if (x2[0] == "1:1")
                            expedCb.Checked = true;
                        if (x2[1] == "2:1")
                            expedControEntreCb.Checked = true;
                        for (int i = 0; i < x2.Length; i++)
                        {
                            x2[i] = null;
                        }

                        string[] x3 = recuTab3.Split('-');
                        if (x3[0] == "1:1")
                            estCb.Checked = true;
                        if (x3[1] == "2:1")
                            estCadEstoqCb.Checked = true;
                        if (x3[2] == "3:1")
                            estControEstCb.Checked = true;
                        if (x3[3] == "4:1")
                            estLoteValCb.Checked = true;
                        if (x3[4] == "5:1")
                            estLoeCb.Checked = true;
                        if (x3[5] == "6:1")
                            estCodifCb.Checked = true;
                        if (x3[6] == "7:1")
                            estEtiqPrecCb.Checked = true;
                        if (x3[7] == "8:1")
                            EstContCb.Checked = true;
                        for (int i = 0; i < x3.Length; i++)
                        {
                            x3[i] = null;
                        }

                        string[] x4 = recuTab4.Split('-');
                        if (x4[0] == "1:1")
                            finanCb.Checked = true;
                        if (x4[1] == "2:1")
                            finanMapaVendCb.Checked = true;
                        if (x4[2] == "3:1")
                            finanIndicVendCb.Checked = true;
                        if (x4[3] == "4:1")
                            finanCompFuncCb.Checked = true;
                        if (x4[4] == "5:1")
                            finanControlaCb.Checked = true;
                        for (int i = 0; i < x4.Length; i++)
                        {
                            x4[i] = null;
                        }

                        string[] x5 = recuTab5.Split('-');
                        if (x5[0] == "1:1")
                            vendCb.Checked = true;
                        if (x5[1] == "2:1")
                            vendLoeCb.Checked = true;
                        if (x5[2] == "3:1")
                            vendConsultLoe.Checked = true;
                        if (x5[3] == "4:1")
                            vendEntregCb.Checked = true;
                        if (x5[4] == "5:1")
                            vendAssistTecCb.Checked = true;
                        if (x5[5] == "6:1")
                            vendNSeriCb.Checked = true;
                        for (int i = 0; i < x5.Length; i++)
                        {
                            x5[i] = null;
                        }

                        string[] x6 = recuTab6.Split('-');
                        if (x6[0] == "1:1")
                            markCb.Checked = true;
                        if (x6[1] == "2:1")
                            markCampCb.Checked = true;
                        if (x6[2] == "3:1")
                            markCadCampCb.Checked = true;
                        if (x6[3] == "4:1")
                            markCadBanCb.Checked = true;
                        for (int i = 0; i < x6.Length; i++)
                        {
                            x6[i] = null;
                        }

                        string[] x7 = recuTab7.Split('-');
                        if (x7[0] == "1:1")
                            utiCb.Checked = true;
                        if (x7[1] == "2:1")
                            utiRestCb.Checked = true;
                        for (int i = 0; i < x7.Length; i++)
                        {
                            x7[i] = null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuário inexistente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    desmarca();
                    limpaVar();
                    desabilitaCheck();
                }
                usu.Close();
                dao.desconecta();
            }
            else
            {
                textBox1.Focus();
                desmarca();
                limpaVar();
                desabilitaCheck();
            }
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            procuraUsuarios pu = new procuraUsuarios();
            pu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                try
                {
                    salvaMarcados();

                    string x = string.Empty;
                    Sql = "SELECT count(res_codigo) FROM restricoes where res_usuario = '" + textBox1.Text + "'";
                    dao.Query = new MySqlCommand(Sql, dao.Conexao);
                    dao.conecta();
                    object usua = dao.Query.ExecuteScalar();
                    x = usua.ToString();
                    dao.desconecta();

                    if (Convert.ToInt32(usua) == 0)
                    {
                        cu.Res_usuario = textBox1.Text;
                        cu.Res_compras = tab1;
                        cu.Res_expedicao = tab2;
                        cu.Res_estoque = tab3;
                        cu.Res_financeiro = tab4;
                        cu.Res_vendas = tab5;
                        cu.Res_marketing = tab6;
                        cu.Res_utilitarios = tab7;
                        cu.Res_senha = textBox3.Text;

                        dao.cadastraUsuario(cu);
                        MessageBox.Show("Cadastrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cu.Res_compras = tab1;
                        cu.Res_expedicao = tab2;
                        cu.Res_estoque = tab3;
                        cu.Res_financeiro = tab4;
                        cu.Res_vendas = tab5;
                        cu.Res_marketing = tab6;
                        cu.Res_utilitarios = tab7;
                        cu.Res_senha = textBox3.Text;

                        dao.alteraUsuario(cu, textBox1.Text);
                        MessageBox.Show("Alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    limpaVar();
                    desabilitaCheck();
                    desmarca();
                    tabControl1.SelectTab(0);
                    textBox1.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro, contate o suporte!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Campos obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void compCb_CheckedChanged(object sender, EventArgs e)
        {
            if(compCb.Checked == false)
            {
                compAssistTecCb.Enabled = false;
                compAssistTecCadCb.Enabled = false;
                compAssistTecConsCb.Enabled = false;
                compLoteValCb.Enabled = false;
                compLoeCb.Enabled = false;
                compLoeCadCb.Enabled = false;
                compLoeConsCb.Enabled = false;
                compFollowCb.Enabled = false;
                compFollowCadCb.Enabled = false;
                compFollowConsCb.Enabled = false;
                compFollowCadSitCb.Enabled = false;
                compNSerieCb.Enabled = false;
                compCodifcCb.Enabled = false;
                compOrdCompCb.Enabled = false;
                compMediaVendCb.Enabled = false;
                compCotCb.Enabled = false;
                compCotFixCb.Enabled = false;
                compCotProdCb.Enabled = false;

                compAssistTecCb.Checked = false;
                compAssistTecCadCb.Checked = false;
                compAssistTecConsCb.Checked = false;
                compLoteValCb.Checked = false;
                compLoeCb.Checked = false;
                compLoeCadCb.Checked = false;
                compLoeConsCb.Checked = false;
                compFollowCb.Checked = false;
                compFollowCadCb.Checked = false;
                compFollowConsCb.Checked = false;
                compFollowCadSitCb.Checked = false;
                compNSerieCb.Checked = false;
                compCodifcCb.Checked = false;
                compOrdCompCb.Checked = false;
                compMediaVendCb.Checked = false;
                compCotCb.Checked = false;
                compCotFixCb.Checked = false;
                compCotProdCb.Checked = false;
            }
            else
            {
                compAssistTecCb.Enabled = true;
                if(compAssistTecCb.Checked == true)
                {
                    compAssistTecCadCb.Enabled = true;
                    compAssistTecConsCb.Enabled = true;
                }
                compLoteValCb.Enabled = true;
                compLoeCb.Enabled = true;
                if (compLoeCb.Checked == true)
                {
                    compLoeCadCb.Enabled = true;
                    compLoeConsCb.Enabled = true;
                }
                compFollowCb.Enabled = true;
                if (compFollowCb.Checked == true)
                {
                    compFollowCadCb.Enabled = true;
                    compFollowConsCb.Enabled = true;
                    compFollowCadSitCb.Enabled = true;
                }
                compNSerieCb.Enabled = true;
                compCodifcCb.Enabled = true;
                compOrdCompCb.Enabled = true;
                compMediaVendCb.Enabled = true;
                compCotCb.Enabled = true;
                if (compCotCb.Checked == true)
                {
                    compCotFixCb.Enabled = true;
                    compCotProdCb.Enabled = true;
                }
            }
        }

        private void compAssistTecCb_CheckedChanged(object sender, EventArgs e)
        {
            if(compAssistTecCb.Checked == false)
            {
                compAssistTecCadCb.Enabled = false;
                compAssistTecConsCb.Enabled = false;

                compAssistTecCadCb.Checked = false;
                compAssistTecConsCb.Checked = false;
            }
            else
            {
                compAssistTecCadCb.Enabled = true;
                compAssistTecConsCb.Enabled = true;
            }
        }

        private void compLoeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (compLoeCb.Checked == false)
            {
                compLoeCadCb.Enabled = false;
                compLoeConsCb.Enabled = false;

                compLoeCadCb.Checked = false;
                compLoeConsCb.Checked = false;
            }
            else
            {
                compLoeCadCb.Enabled = true;
                compLoeConsCb.Enabled = true;
            }
        }

        private void compFollowCb_CheckedChanged(object sender, EventArgs e)
        {
            if (compFollowCb.Checked == false)
            {
                compFollowCadCb.Enabled = false;
                compFollowConsCb.Enabled = false;
                compFollowCadSitCb.Enabled = false;

                compFollowCadCb.Checked = false;
                compFollowConsCb.Checked = false;
                compFollowCadSitCb.Checked = false;
            }
            else
            {
                compFollowCadCb.Enabled = true;
                compFollowConsCb.Enabled = true;
                compFollowCadSitCb.Enabled = true;
            }
        }

        private void compCotCb_CheckedChanged(object sender, EventArgs e)
        {
            if (compCotCb.Checked == false)
            {
                compCotFixCb.Enabled = false;
                compCotProdCb.Enabled = false;

                compCotFixCb.Checked = false;
                compCotProdCb.Checked = false;
            }
            else
            {
                compCotFixCb.Enabled = true;
                compCotProdCb.Enabled = true;
            }
        }

        private void expedCb_CheckedChanged(object sender, EventArgs e)
        {
            if(expedCb.Checked == false)
            {
                expedControEntreCb.Enabled = false;

                expedControEntreCb.Checked = false;
            }
            else
            {
                expedControEntreCb.Enabled = true;
            }
        }

        private void estCb_CheckedChanged(object sender, EventArgs e)
        {
            if(estCb.Checked == false)
            {
                estCadEstoqCb.Enabled = false;
                estControEstCb.Enabled = false;
                estLoteValCb.Enabled = false;
                estLoeCb.Enabled = false;
                estCodifCb.Enabled = false;
                estEtiqPrecCb.Enabled = false;
                EstContCb.Enabled = false;

                estCadEstoqCb.Checked = false;
                estControEstCb.Checked = false;
                estLoteValCb.Checked = false;
                estLoeCb.Checked = false;
                estCodifCb.Checked = false;
                estEtiqPrecCb.Checked = false;
                EstContCb.Checked = false;
            }
            else
            {
                estCadEstoqCb.Enabled = true;
                estControEstCb.Enabled = true;
                estLoteValCb.Enabled = true;
                estLoeCb.Enabled = true;
                estCodifCb.Enabled = true;
                estEtiqPrecCb.Enabled = true;
                EstContCb.Enabled = true;
            }
        }

        private void finanCb_CheckedChanged(object sender, EventArgs e)
        {
            if(finanCb.Checked == false)
            {
                finanMapaVendCb.Enabled = false;
                finanIndicVendCb.Enabled = false;
                finanCompFuncCb.Enabled = false;
                finanControlaCb.Enabled = false;

                finanMapaVendCb.Checked = false;
                finanIndicVendCb.Checked = false;
                finanCompFuncCb.Checked = false;
                finanControlaCb.Checked = false;
            }
            else
            {
                finanMapaVendCb.Enabled = true;
                finanIndicVendCb.Enabled = true;
                finanCompFuncCb.Enabled = true;
                finanControlaCb.Enabled = true;
            }
        }

        private void vendCb_CheckedChanged(object sender, EventArgs e)
        {
            if(vendCb.Checked == false)
            {
                vendLoeCb.Enabled = false;
                vendConsultLoe.Enabled = false;
                vendEntregCb.Enabled = false;
                vendAssistTecCb.Enabled = false;
                vendNSeriCb.Enabled = false;

                vendLoeCb.Checked = false;
                vendConsultLoe.Checked = false;
                vendEntregCb.Checked = false;
                vendAssistTecCb.Checked = false;
                vendNSeriCb.Checked = false;
            }
            else
            {
                vendLoeCb.Enabled = true;
                vendConsultLoe.Enabled = true;
                vendEntregCb.Enabled = true;
                vendAssistTecCb.Enabled = true;
                vendNSeriCb.Enabled = true;
            }
        }

        private void markCb_CheckedChanged(object sender, EventArgs e)
        {
            if(markCb.Checked == false)
            {
                markCampCb.Enabled = false;

                markCampCb.Checked = false;
            }
            else
            {
                markCampCb.Enabled = true;
                if(markCampCb.Checked == true)
                {
                    markCadCampCb.Enabled = true;
                    markCadBanCb.Enabled = true;
                }
            }
        }

        private void markCampCb_CheckedChanged(object sender, EventArgs e)
        {
            if(markCampCb.Checked == false)
            {
                markCadCampCb.Enabled = false;
                markCadBanCb.Enabled = false;

                markCadCampCb.Checked = false;
                markCadBanCb.Checked = false;
            }
            else
            {
                markCadCampCb.Enabled = true;
                markCadBanCb.Enabled = true;
            }
        }

        private void utiCb_CheckedChanged(object sender, EventArgs e)
        {
            if(utiCb.Checked == false)
            {
                utiRestCb.Enabled = false;

                utiRestCb.Checked = false;
            }
            else
            {
                utiRestCb.Enabled = true;
            }
        }
    }
}
