using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class AssistenciaTecnica : Form
    {
        DAO dao = new DAO();
        GMarkerGoogle marker;
        GMapOverlay makerOverlay; 
        private string Sql = String.Empty;
        List<string> fornecedor = new List<string>();
        List<string> nome = new List<string>();
        List<string> telefone = new List<string>();
        List<string> endereco = new List<string>();
        List<string> latitude = new List<string>();
        List<string> longitude = new List<string>();
        List<string> produto = new List<string>();
        int aux2 = 0;
        Variaveis vat = new Variaveis();

        public AssistenciaTecnica()
        {
            InitializeComponent();
        }
        public void limparVar()
        {
            fornecedor.Clear();
            nome.Clear();
            telefone.Clear();
            latitude.Clear();
            longitude.Clear();
            produto.Clear();
            aux2 = 0;
            if (makerOverlay != null)
            {
                makerOverlay.Clear();
            }
            marker = null;
            assistEnd1Txt.Text = string.Empty;
            assistEnd2Txt.Text = string.Empty;
            assistEnd3Txt.Text = string.Empty;
            assistNome1Txt.Text = string.Empty;
            assistNome2Txt.Text = string.Empty;
            assistNome3Txt.Text = string.Empty;
            assistTel1Txt.Text = string.Empty;
            assistTel2Txt.Text = string.Empty;
            assistTel3Txt.Text = string.Empty;
            produtoTxt.Text = string.Empty;
            vat.CodProdAssistTec = 0;
            vat.Aux1AssistTec = 0;
        }
        public void mapaPadrao()
        {
            double x = -25.5318354;
            double y = -49.2035722;
            mapa.DragButton = MouseButtons.Left;
            mapa.CanDragMap = true;
            mapa.MapProvider = GMapProviders.GoogleMap;
            mapa.Position = new PointLatLng(x, y);
            mapa.MinZoom = 0;
            mapa.MaxZoom = 20;
            mapa.Zoom = 12;
            mapa.AutoScroll = true;
        }
        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            limparVar();
            mapaPadrao();
            vat.Aux1AssistTec = 1;
            ProcuraProd pp = new ProcuraProd();
            pp.ShowDialog();
        }

        private void assistenciaTecnica_Activated(object sender, EventArgs e)
        {
            if (vat.CodProdAssistTec > 0)
            {
                Sql = "SELECT nome_assistTec, telefone_assistTec, endereco_assistTec, fnc_nome, itm_descricao, lat_assistTec, long_assistTec FROM (itens INNER JOIN assistencias_tecnicas ON itens.itm_fornecedor = assistencias_tecnicas.fornecedor_assistTec) INNER JOIN fornecedores ON assistencias_tecnicas.fornecedor_assistTec = fornecedores.fnc_codigo WHERE itm_codigo = " + vat.CodProdAssistTec + "";
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.Conecta();
                MySqlDataReader assistTec = dao.Query.ExecuteReader();

                while (assistTec.Read())
                {
                    nome.Add(assistTec["nome_assistTec"].ToString());
                    telefone.Add(assistTec["telefone_assistTec"].ToString());
                    endereco.Add(assistTec["endereco_assistTec"].ToString());
                    latitude.Add(assistTec["lat_assistTec"].ToString());
                    longitude.Add(assistTec["long_assistTec"].ToString());
                    fornecedor.Add(assistTec["fnc_nome"].ToString());
                    produto.Add(assistTec["itm_descricao"].ToString());
                    aux2++;
                }
                assistTec.Close();
                dao.Desconecta();
                produtoTxt.Text = produto[0];
                if (aux2 == 1)
                {
                    assistNome1Txt.Text = nome[0];
                    assistTel1Txt.Text = telefone[0];
                    assistEnd1Txt.Text = endereco[0];
                    assistForn1Txt.Text = fornecedor[0];
                }
                else
                {
                    if (aux2 == 2)
                    {
                        assistNome1Txt.Text = nome[0];
                        assistTel1Txt.Text = telefone[0];
                        assistEnd1Txt.Text = endereco[0];
                        assistForn1Txt.Text = fornecedor[0];
                        assistNome2Txt.Text = nome[1];
                        assistTel2Txt.Text = telefone[1];
                        assistEnd2Txt.Text = endereco[1];
                        assistForn2Txt.Text = fornecedor[1];
                    }
                    else
                    {
                        if (aux2 == 3)
                        {
                            assistNome1Txt.Text = nome[0];
                            assistTel1Txt.Text = telefone[0];
                            assistEnd1Txt.Text = endereco[0];
                            assistForn1Txt.Text = fornecedor[0];
                            assistNome2Txt.Text = nome[1];
                            assistTel2Txt.Text = telefone[1];
                            assistEnd2Txt.Text = endereco[1];
                            assistForn2Txt.Text = fornecedor[1];
                            assistNome3Txt.Text = nome[2];
                            assistTel3Txt.Text = telefone[2];
                            assistEnd3Txt.Text = endereco[2];
                            assistForn3Txt.Text = fornecedor[2];
                        }
                    }
                }
                if (aux2 > 0)
                {
                    double x = double.Parse(latitude[0], CultureInfo.InvariantCulture);
                    double y = double.Parse(longitude[0], CultureInfo.InvariantCulture);
                    mapa.DragButton = MouseButtons.Left;
                    mapa.CanDragMap = true;
                    mapa.MapProvider = GMapProviders.GoogleMap;
                    mapa.Position = new PointLatLng(x, y);
                    mapa.MinZoom = 0;
                    mapa.MaxZoom = 20;
                    mapa.Zoom = 15;
                    mapa.AutoScroll = true;

                    makerOverlay = new GMapOverlay("marcador");
                    marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.red_dot);
                    makerOverlay.Markers.Add(marker);
                    mapa.Overlays.Add(makerOverlay);
                }
                vat.CodProdAssistTec = 0;
            }          
        }
        private void assistencia1_Enter(object sender, EventArgs e)
        {
            if (aux2 > 0)
            {
                makerOverlay.Clear();
                marker = null;
                double x = double.Parse(latitude[0], CultureInfo.InvariantCulture);
                double y = double.Parse(longitude[0], CultureInfo.InvariantCulture);
                mapa.DragButton = MouseButtons.Left;
                mapa.CanDragMap = true;
                mapa.MapProvider = GMapProviders.GoogleMap;
                mapa.Position = new PointLatLng(x, y);
                mapa.MinZoom = 0;
                mapa.MaxZoom = 20;
                mapa.Zoom = 15;
                mapa.AutoScroll = true;

                makerOverlay = new GMapOverlay("marcador");
                marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.red_dot);
                makerOverlay.Markers.Add(marker);
                mapa.Overlays.Add(makerOverlay);
            }
        }

        private void assistencia2_Enter(object sender, EventArgs e)
        {
            if (aux2 > 1 && aux2 < 3)
            {
                makerOverlay.Clear();
                marker = null;
                double x = double.Parse(latitude[1], CultureInfo.InvariantCulture);
                double y = double.Parse(longitude[1], CultureInfo.InvariantCulture);
                mapa.DragButton = MouseButtons.Left;
                mapa.CanDragMap = true;
                mapa.MapProvider = GMapProviders.GoogleMap;
                mapa.Position = new PointLatLng(x, y);
                mapa.MinZoom = 0;
                mapa.MaxZoom = 20;
                mapa.Zoom = 15;
                mapa.AutoScroll = true;

                makerOverlay = new GMapOverlay("marcador");
                marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.red_dot);
                makerOverlay.Markers.Add(marker);
                mapa.Overlays.Add(makerOverlay);
            }
        }

        private void assisntecia3_Enter(object sender, EventArgs e)
        {
            if (aux2 == 3)
            {
                makerOverlay.Clear();
                marker = null;
                double x = double.Parse(latitude[2], CultureInfo.InvariantCulture);
                double y = double.Parse(longitude[2], CultureInfo.InvariantCulture);
                mapa.DragButton = MouseButtons.Left;
                mapa.CanDragMap = true;
                mapa.MapProvider = GMapProviders.GoogleMap;
                mapa.Position = new PointLatLng(x, y);
                mapa.MinZoom = 0;
                mapa.MaxZoom = 20;
                mapa.Zoom = 15;
                mapa.AutoScroll = true;

                makerOverlay = new GMapOverlay("marcador");
                marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.red_dot);
                makerOverlay.Markers.Add(marker);
                mapa.Overlays.Add(makerOverlay);
            }
        }

        private void assistenciaTecnica_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaAssistTec = 0;
            limparVar();
        }

        private void assistenciaTecnica_Load(object sender, EventArgs e)
        {
            mapaPadrao();
        }
    }
}
