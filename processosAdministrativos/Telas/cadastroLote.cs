using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using processosAdministrativos.Model;
using processosAdministrativos.Bll;

namespace processosAdministrativos.Telas
{
    public partial class cadastroLote : Form
    {
        variaveis vat = new variaveis();

        public cadastroLote()
        {
            InitializeComponent();
        }

        public bool CampoVazio()
        {
            bool ok = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (string.IsNullOrEmpty(ctrl.Text))
                    {
                        ok = true;
                        break;
                    }
                }
            }
            return ok;
        }
        public void limparCampo()
        {
            numLoteTxt.Text = string.Empty;
            codBarrasTxt.Text = string.Empty;
            produtoTxt.Text = string.Empty;
            qtdeTxt.Text = string.Empty;
            validadeMtxt.Text = string.Empty;
            vat.CodProdLote = string.Empty;
            vat.NomeProdLote = string.Empty;
            vat.AuxLote = 0;
            vat.CodLote = string.Empty;
        }

        private void Salvar(LoteM lotem)
        {
            LoteBLL lotebll = new LoteBLL();

            lotem.Ltv_numLote = numLoteTxt.Text;
            lotem.Ltv_codBarras = codBarrasTxt.Text;
            lotem.Ltv_produto = vat.CodProdLote;
            lotem.Ltv_qtde = int.Parse(qtdeTxt.Text);
            lotem.Ltv_validade = DateTime.Parse(validadeMtxt.Text).ToString("yyyy-MM-dd 23:59:59");

            if(vat.CodLote == string.Empty)
            {
                if (lotebll.SelecionarUm("SELECT ltv_produto FROM lote_validade WHERE ltv_numLote = '" + numLoteTxt.Text + "'").ToString() != vat.CodProdLote)
                {
                    lotem.Ltv_dataCriacao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    lotem.Ltv_dataAlteracao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    lotebll.Salvar(lotem);

                    MessageBox.Show("Lote salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampo();
                }
                else
                {
                    MessageBox.Show("Número de lote ja cadastrado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numLoteTxt.Text = string.Empty;
                    numLoteTxt.Focus();
                }
            }
            else
            {
                lotem.Ltv_codigo = vat.CodLote;
                lotem.Ltv_dataAlteracao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                lotebll.Alterar(lotem);

                MessageBox.Show("Lote alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampo();
            }
        }

        public void preencheCampos()
        {
            if (vat.AuxLote2 == 1)
            {
                produtoTxt.Text = vat.NomeProdLote;
                vat.AuxLote2 = 0;
            }
            else if (vat.AuxLote == 1)
            {
                LoteBLL lotebll = new LoteBLL();

                MySqlDataReader lote = lotebll.SelecionarVarios("SELECT ltv_numLote, ltv_codBarras, itm_descricao, ltv_produto, ltv_qtde, ltv_validade FROM lote_validade  INNER JOIN itens ON lote_validade.ltv_produto = itens.itm_codigo WHERE ltv_codigo = " + vat.CodLote + "");
                lote.Read();

                DateTime data = Convert.ToDateTime(lote["ltv_validade"]);
                numLoteTxt.Text = lote["ltv_numLote"].ToString();
                codBarrasTxt.Text = lote["ltv_codBarras"].ToString();
                produtoTxt.Text = lote["itm_descricao"].ToString();
                qtdeTxt.Text = lote["ltv_qtde"].ToString();
                validadeMtxt.Text = data.ToString("dd-MM-yyyy");
                vat.CodProdLote = lote["ltv_produto"].ToString();
                vat.AuxLote = 0;

                lote.Close();
            }
        }

        private void cadastroLote_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaCadLote = 0;
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            if(CampoVazio() == false)
            {
                LoteM lotem = new LoteM();
                Salvar(lotem);
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void alterarBt_Click(object sender, EventArgs e)
        {
            limparCampo();
            procuraLote pl = new procuraLote();
            pl.ShowDialog();
        }

        private void cadastroLote_Activated(object sender, EventArgs e)
        {
            preencheCampos();
        }

        private void lmpatBt_Click(object sender, EventArgs e)
        {
            limparCampo();
        }

        private void produtoTxt_Enter(object sender, EventArgs e)
        {
            vat.AuxLote2 = 1;
            procuraProd pp = new procuraProd();
            pp.ShowDialog();
        }
    }
}
