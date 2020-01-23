using MySql.Data.MySqlClient;
using System;


namespace processosAdministrativos.Classes
{
    class DAO
    {
        ConexaoRede cr = new ConexaoRede();

        private static MySqlConnection conexaoInterna = new MySqlConnection("server=" + ConexaoRede.RecuperaConexao()[0] + ";port="+ConexaoRede.RecuperaConexao()[1]+ ";database="+ ConexaoRede.RecuperaConexao()[2] + ";userid="+ ConexaoRede.RecuperaConexao()[3] + ";password="+ ConexaoRede.RecuperaConexao()[4] + ";");
        private static MySqlConnection conexaoInterna2 = new MySqlConnection("server=" + ConexaoRede.RecuperaConexao()[0] + ";port=" + ConexaoRede.RecuperaConexao()[1] + ";database=" + ConexaoRede.RecuperaConexao()[2] + ";userid=" + ConexaoRede.RecuperaConexao()[3] + ";password=" + ConexaoRede.RecuperaConexao()[4] + ";");

        private static MySqlCommand query;

        public MySqlConnection Conexao { get => conexaoInterna; set => conexaoInterna = value; }
        public MySqlConnection Conexao2 { get => conexaoInterna2; set => conexaoInterna2 = value; }

        public MySqlCommand Query { get => query; set => query = value; }

        public void conecta()
        {
            if(Conexao.State == System.Data.ConnectionState.Closed)
                Conexao.Open();
        }

        public void desconecta()
        {
            if (Conexao.State == System.Data.ConnectionState.Open)
                Conexao.Close();
        }

        public void conecta2()
        {
            if (Conexao2.State == System.Data.ConnectionState.Closed)
                Conexao2.Open();
        }

        public void desconecta2()
        {
            if (Conexao2.State == System.Data.ConnectionState.Open)
                Conexao2.Close();
        }

        public int TesteConexao(string servidor, string porta, string baseDados, string usuario, string senha)
        {
            MySqlConnection teste = new MySqlConnection("server="+ servidor + ";port=" + porta + ";database=" + baseDados + ";userid=" + usuario + ";password=" + senha + ";");
            try
            {
                teste.Open();
                teste.Close();
                return 1;
            }
            catch(Exception error)
            {
                return 0;
            }
        }

        public void cadastraAssistTec(controlAssistTec ca)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@nome_assistTec", ca.Nome_assistTec);
            Query.Parameters.AddWithValue("@telefone_assistTec", ca.Telefone_assistTec);
            Query.Parameters.AddWithValue("@endereco_assistTec", ca.Endereco_assistTec);
            Query.Parameters.AddWithValue("@lat_assistTec", ca.Lat_assistTec);
            Query.Parameters.AddWithValue("@long_assistTec", ca.Long_assistTec);
            Query.Parameters.AddWithValue("@fornecedor_assistTec", ca.Fornecedor_assistTec);
            Query.CommandText = "INSERT INTO assistencias_tecnicas (nome_assistTec, telefone_assistTec, endereco_assistTec, lat_assistTec, long_assistTec, fornecedor_assistTec) VALUES (@nome_assistTec, @telefone_assistTec, @endereco_assistTec, @lat_assistTec, @long_assistTec, @fornecedor_assistTec)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void alteraAssistTec(controlAssistTec ca, int codigoAssist)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@nome_assistTec", ca.Nome_assistTec);
            Query.Parameters.AddWithValue("@telefone_assistTec", ca.Telefone_assistTec);
            Query.Parameters.AddWithValue("@endereco_assistTec", ca.Endereco_assistTec);
            Query.Parameters.AddWithValue("@lat_assistTec", ca.Lat_assistTec);
            Query.Parameters.AddWithValue("@long_assistTec", ca.Long_assistTec);
            Query.Parameters.AddWithValue("@fornecedor_assistTec", ca.Fornecedor_assistTec);
            Query.CommandText = "UPDATE assistencias_tecnicas SET nome_assistTec = @nome_assistTec, telefone_assistTec = @telefone_assistTec, endereco_assistTec = @endereco_assistTec, lat_assistTec = @lat_assistTec, long_assistTec = @long_assistTec, fornecedor_assistTec = @fornecedor_assistTec WHERE codigo_assistTec = " + codigoAssist + "";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void cadastraEntrega(controlEntreg cl)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@pedido_contEntre", cl.Pedido_contEntre);
            Query.Parameters.AddWithValue("@cliente_contEntre", cl.Cliente_contEntre);
            Query.Parameters.AddWithValue("@vendedor_contEntre", cl.Vendedor_contEntre);
            Query.Parameters.AddWithValue("@motoboy_contEntre", cl.Motoboy_contEntre);
            Query.Parameters.AddWithValue("@situacao_contEntre", cl.Situacao_contEntre);
            Query.Parameters.AddWithValue("@dt_aCaminho", cl.Dt_aCaminho);
            Query.Parameters.AddWithValue("@dt_entregue", cl.Dt_entregue);
            Query.Parameters.AddWithValue("@obs_contEntre", cl.Obs_contEntre);
            Query.CommandText = "INSERT INTO controle_entrega (pedido_contEntre, cliente_contEntre, vendedor_contEntre, motoboy_contEntre, situacao_contEntre, dt_aCaminho, dt_entregue, obs_contEntre) VALUES (@pedido_contEntre, @cliente_contEntre, @vendedor_contEntre, @motoboy_contEntre, @situacao_contEntre, @dt_aCaminho, @dt_entregue, @obs_contEntre)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void alteraEntrega(controlEntreg cl, int codigo)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@situacao_contEntre", cl.Situacao_contEntre);
            Query.Parameters.AddWithValue("@dt_entregue", cl.Dt_entregue);
            Query.CommandText = "UPDATE controle_entrega SET situacao_contEntre = @situacao_contEntre, dt_entregue = @dt_entregue WHERE pedido_contEntre =" +codigo;
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraObsEntrega(controlEntreg cl, int codigo)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@obs_contEntre", cl.Obs_contEntre);
            Query.CommandText = "UPDATE controle_entrega SET obs_contEntre = @obs_contEntre WHERE cod_contEntre =" + codigo;
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraSituEntrega(controlEntreg cl, int codigo)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@situacao_contEntre", cl.Situacao_contEntre);
            Query.Parameters.AddWithValue("@dt_entregue", cl.Dt_entregue);
            Query.CommandText = "UPDATE controle_entrega SET situacao_contEntre = @situacao_contEntre, dt_entregue = @dt_entregue WHERE cod_contEntre =" + codigo;
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void alteraEntregador(controlEntreg cl, int codigo)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@motoboy_contEntre", cl.Motoboy_contEntre);
            Query.CommandText = "UPDATE controle_entrega SET motoboy_contEntre = @motoboy_contEntre WHERE cod_contEntre =" + codigo;
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void deletaEntrega(int codigo)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.CommandText = "delete from controle_entrega where cod_contEntre = " + codigo;
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void cadastraEstoquista(ControlEstoquista ce)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@est_nome", ce.Estoquista);
            Query.Parameters.AddWithValue("@est_dataCriacao", ce.Data);
            Query.CommandText = "INSERT INTO estoquista (est_nome, est_dataCriacao) VALUES (@est_nome, @est_dataCriacao)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void cadastraClasseEstoq(ControlEstoquista ce)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@cles_estoquista", ce.CodEstoquista);
            for (int i = 0; i < ce.CodClasse.Count; i++)
            {
                Query.CommandText = "INSERT INTO classes_estoque (cles_estoquista, cles_classe) VALUES (@cles_estoquista, " + ce.CodClasse[i] + ")";
                conecta();
                Query.ExecuteNonQuery();
                desconecta();
            }
        }
        public void alteraEstoquista(ControlEstoquista ce, int codEsto)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@est_nome", ce.Estoquista);
            Query.Parameters.AddWithValue("@est_dataCriacao", ce.Data);
            Query.CommandText = "UPDATE estoquista SET est_nome = @est_nome, est_dataCriacao = @est_dataCriacao WHERE est_codigo = " + codEsto + "";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraClasseEstoq(ControlEstoquista ce, int codEsto)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@cles_estoquista", codEsto);
            for (int i = 0; i < ce.CodClasse.Count; i++)
            {
                Query.CommandText = "UPDATE classes_estoque SET cles_estoquista = @cles_estoquista WHERE cles_classe = " + ce.CodClasse[i] + " AND cles_classe";
                conecta();
                Query.ExecuteNonQuery();
                desconecta();
            }
        }

        public void cadastraBanner(controlBanner cb)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@banrot_campanha", cb.Banrot_campanha);
            Query.Parameters.AddWithValue("@banrot_img", cb.Banrot_img);
            Query.Parameters.AddWithValue("@banrot_validade", cb.Banrot_validade);
            Query.CommandText = "INSERT INTO banner_rotativo (banrot_campanha, banrot_img, banrot_validade) VALUES (@banrot_campanha, @banrot_img, @banrot_validade)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraBanner(controlBanner cb, int codBanner)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@banrot_campanha", cb.Banrot_campanha);
            Query.Parameters.AddWithValue("@banrot_img", cb.Banrot_img);
            Query.Parameters.AddWithValue("@banrot_validade", cb.Banrot_validade);
            Query.CommandText = "UPDATE banner_rotativo SET banrot_campanha = @banrot_campanha, banrot_img = @banrot_img, banrot_validade = @banrot_validade WHERE banrot_codigo = " + codBanner + "";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void cadastraLote(controlLote cl)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@ltv_numLote", cl.Ltv_numLote);
            Query.Parameters.AddWithValue("@ltv_codBarras", cl.Ltv_codBarras);
            Query.Parameters.AddWithValue("@ltv_produto", cl.Ltv_produto);
            Query.Parameters.AddWithValue("@ltv_qtde", cl.Ltv_qtde);
            Query.Parameters.AddWithValue("@ltv_validade", cl.Ltv_validade);
            Query.Parameters.AddWithValue("@ltv_dataCriacao", cl.Ltv_dataCriacao);
            Query.Parameters.AddWithValue("@ltv_dataAlteracao", cl.Ltv_dataAlteracao);
            Query.CommandText = "INSERT INTO lote_validade (ltv_numLote, ltv_codBarras, ltv_produto, ltv_qtde, ltv_validade, ltv_dataCriacao, ltv_dataAlteracao) VALUES (@ltv_numLote, @ltv_codBarras, @ltv_produto, @ltv_qtde, @ltv_validade, @ltv_dataCriacao, @ltv_dataAlteracao)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraLote(controlLote cl, string codLote)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@ltv_numLote", cl.Ltv_numLote);
            Query.Parameters.AddWithValue("@ltv_codBarras", cl.Ltv_codBarras);
            Query.Parameters.AddWithValue("@ltv_produto", cl.Ltv_produto);
            Query.Parameters.AddWithValue("@ltv_qtde", cl.Ltv_qtde);
            Query.Parameters.AddWithValue("@ltv_validade", cl.Ltv_validade);
            Query.Parameters.AddWithValue("@ltv_dataAlteracao", cl.Ltv_dataAlteracao);
            Query.CommandText = "UPDATE lote_validade SET ltv_numLote = @ltv_numLote, ltv_codBarras = @ltv_codBarras, ltv_produto = @ltv_produto, ltv_qtde = @ltv_qtde, ltv_validade = @ltv_validade, ltv_dataAlteracao = @ltv_dataAlteracao WHERE ltv_codigo = " + codLote + "";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraQtdeLote(controlLote cl, string numLote)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@ltv_qtde", cl.Ltv_qtde);
            Query.Parameters.AddWithValue("@ltv_dataAlteracao", cl.Ltv_dataAlteracao);
            Query.CommandText = "UPDATE lote_validade SET ltv_qtde = @ltv_qtde, ltv_dataAlteracao = @ltv_dataAlteracao WHERE ltv_numLote = " + numLote + "";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void cadastraLoe(controlLoe cl)
        {

            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@loe_id_vendedor", cl.Id_vendedor_loe);
            Query.Parameters.AddWithValue("@loe_opcao", cl.Opcao_loe);
            Query.Parameters.AddWithValue("@loe_id_produto", cl.Id_produto);
            Query.Parameters.AddWithValue("@loe_qtde", cl.Qtade_loe);
            Query.Parameters.AddWithValue("@loe_preco", cl.Preco_loe);
            Query.Parameters.AddWithValue("@loe_comentario", cl.Comentario_loe);
            Query.Parameters.AddWithValue("@loe_data", cl.Data_loe);
            Query.CommandText = "INSERT INTO loe(loe_id_vendedor, loe_opcao, loe_id_produto, loe_qtde,loe_preco,loe_comentario,loe_data) VALUES (@loe_id_vendedor, @loe_opcao, @loe_id_produto, @loe_qtde,@loe_preco,@loe_comentario,@loe_data)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void cadastraFallowUpSit(controlFallowUp cf)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@fups_nome", cf.Fup_situacao);
            Query.CommandText = "INSERT INTO fallowupsit(fups_nome) VALUES (@fups_nome)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraFallowUpSit(controlFallowUp cf, int cod)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@fups_nome", cf.Fup_situacao);
            Query.CommandText = "UPDATE fallowupsit SET fups_nome = @fups_nome WHERE fups_codigo = " + cod + "";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void cadastraFallowUp(controlFallowUp cf)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@fup_ordCompra", cf.Fup_ordCompra);
            Query.Parameters.AddWithValue("@fup_dataPed", cf.Fup_dataPed);
            Query.Parameters.AddWithValue("@fup_fornecedor", cf.Fup_fornecedor);
            Query.Parameters.AddWithValue("@fup_comprador", cf.Fup_comprador);
            Query.Parameters.AddWithValue("@fup_dataEntrega", cf.Fup_dataEntrega);
            Query.Parameters.AddWithValue("@fup_situacao", cf.Fup_situacao);
            Query.Parameters.AddWithValue("@fup_dataAlteracao", cf.Fup_dataAlteracao);
            Query.CommandText = "INSERT INTO fallowup(fup_ordCompra, fup_dataPed, fup_fornecedor, fup_comprador, fup_dataEntrega, fup_situacao, fup_dataAlteracao) VALUES (@fup_ordCompra, @fup_dataPed, @fup_fornecedor, @fup_comprador, @fup_dataEntrega, @fup_situacao, @fup_dataAlteracao)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void AlteraFallowUp(controlFallowUp cf, string cod)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@fup_ordCompra", cf.Fup_ordCompra);
            Query.Parameters.AddWithValue("@fup_dataPed", cf.Fup_dataPed);
            Query.Parameters.AddWithValue("@fup_fornecedor", cf.Fup_fornecedor);
            Query.Parameters.AddWithValue("@fup_comprador", cf.Fup_comprador);
            Query.Parameters.AddWithValue("@fup_dataEntrega", cf.Fup_dataEntrega);
            Query.Parameters.AddWithValue("@fup_situacao", cf.Fup_situacao);
            Query.Parameters.AddWithValue("@fup_dataAlteracao", cf.Fup_dataAlteracao);
            Query.CommandText = "UPDATE fallowup SET fup_situacao = @fup_situacao, fup_dataAlteracao = @fup_dataAlteracao WHERE fup_ordCompra = " + cod + "";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void cadastraCodifica(controlCodifica cc)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@codf_nota", cc.Codf_nota);
            Query.Parameters.AddWithValue("@codf_codForn", cc.Codf_codForn);
            Query.Parameters.AddWithValue("@codf_codEstoquista1", cc.Codf_codEstoquista1);
            Query.Parameters.AddWithValue("@codf_codEstoquista2", cc.Codf_codEstoquista2);
            Query.Parameters.AddWithValue("@codf_situacao", cc.Codf_situacao);
            Query.Parameters.AddWithValue("@codf_data", cc.Codf_data);
            Query.CommandText = "INSERT INTO codificacao(codf_nota, codf_codForn, codf_codEstoquista1, codf_codEstoquista2, codf_situacao, codf_data) VALUES (@codf_nota, @codf_codForn, @codf_codEstoquista1, @codf_codEstoquista2, @codf_situacao, @codf_data)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void cadastraNSerie(controlNSerie cn)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@ns_nSerie", cn.Ns_nSerie);
            Query.Parameters.AddWithValue("@ns_pedido", cn.Ns_pedido);
            Query.Parameters.AddWithValue("@ns_produto", cn.Ns_produto);
            Query.Parameters.AddWithValue("@ns_data", cn.Ns_data);
            Query.CommandText = "INSERT INTO n_serie(ns_nSerie, ns_pedido, ns_produto, ns_data) VALUES (@ns_nSerie, @ns_pedido, @ns_produto, @ns_data)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void cadastraContagem(controlContagem cc)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@cont_produto", cc.Cont_produto);
            Query.Parameters.AddWithValue("@cont_data", cc.Cont_data);
            Query.CommandText = "INSERT INTO contagem (cont_produto, cont_data) VALUES (@cont_produto, @cont_data)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void cadastraGrupoEmail(controlGruposEmail cg)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@grpe_dono", cg.Grpe_dono);
            Query.Parameters.AddWithValue("@grpe_grupo", cg.Grpe_grupo);
            Query.Parameters.AddWithValue("@grpe_email", cg.Grpe_email);
            Query.CommandText = "INSERT INTO grupo_emails(grpe_dono, grpe_grupo, grpe_email) VALUES (@grpe_dono, @grpe_grupo, @grpe_email)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraGrupoEmail(controlGruposEmail cg, int cod)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@grpe_dono", cg.Grpe_dono);
            Query.Parameters.AddWithValue("@grpe_grupo", cg.Grpe_grupo);
            Query.Parameters.AddWithValue("@grpe_email", cg.Grpe_email);
            Query.Parameters.AddWithValue("@cod", cod);
            Query.CommandText = "UPDATE grupo_emails SET grpe_dono = @grpe_dono, grpe_grupo = @grpe_grupo, grpe_email = @grpe_email WHERE grpe_codigo = @cod";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void deletaGrupoEmail(int cod)
        {
            Query = new MySqlCommand();
            Query.Parameters.AddWithValue("@cod", cod);
            Query.Connection = Conexao;
            Query.CommandText = "DELETE FROM grupo_emails WHERE grpe_codigo = @cod";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void cadastraOrdemCompra(controlOrdemCompra co)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@oci_empresa", co.Oci_empresa);
            Query.Parameters.AddWithValue("@oci_numero", co.Oci_numero);
            Query.Parameters.AddWithValue("@oci_sequencia", co.Oci_sequencia);
            Query.Parameters.AddWithValue("@oci_item", co.Oci_item);
            Query.Parameters.AddWithValue("@oci_fornecedor", co.Oci_fornecedor);
            Query.Parameters.AddWithValue("@oci_descricao", co.Oci_descricao);
            Query.Parameters.AddWithValue("@oci_unidade", co.Oci_unidade);
            Query.Parameters.AddWithValue("@oci_unestoque", co.Oci_unestoque);
            Query.Parameters.AddWithValue("@oci_quantidade", co.Oci_quantidade);
            Query.Parameters.AddWithValue("@oci_estoque", co.Oci_estoque);
            Query.Parameters.AddWithValue("@oci_precokg", co.Oci_precokg);
            Query.Parameters.AddWithValue("@oci_preco", co.Oci_preco);
            Query.Parameters.AddWithValue("@oci_total", co.Oci_total);
            Query.Parameters.AddWithValue("@oci_aliqipi", co.Oci_aliqipi);
            Query.Parameters.AddWithValue("@oci_valoripi", co.Oci_valoripi);
            Query.Parameters.AddWithValue("@oci_comprimento", co.Oci_comprimento);
            Query.Parameters.AddWithValue("@oci_largura", co.Oci_largura);
            Query.Parameters.AddWithValue("@oci_bitola", co.Oci_bitola);
            Query.Parameters.AddWithValue("@oci_aliqsubtrib", co.Oci_aliqsubtrib);
            Query.Parameters.AddWithValue("@oci_valorsubtrib", co.Oci_valorsubtrib);
            Query.Parameters.AddWithValue("@oci_qtdfaturada", co.Oci_qtdfaturada);
            Query.Parameters.AddWithValue("@oci_observacao", co.Oci_Observacao);
            Query.Parameters.AddWithValue("@oci_sitentrega", co.Oci_sitentrega);
            Query.Parameters.AddWithValue("@oci_aliqicms", co.Oci_aliqicms);
            Query.CommandText = "INSERT INTO ordcitem (oci_empresa, oci_numero, oci_sequencia, oci_item, oci_fornecedor, oci_descricao, oci_unidade, oci_unestoque, oci_quantidade, oci_estoque, oci_precokg, oci_preco, oci_total, oci_aliqipi, oci_valoripi, oci_comprimento, oci_largura, oci_bitola, oci_aliqsubtrib, oci_valorsubtrib, oci_qtdfaturada, oci_observacao, oci_sitentrega, oci_aliqicms) VALUES (@oci_empresa, @oci_numero, @oci_sequencia, @oci_item, @oci_fornecedor, @oci_descricao, @oci_unidade, @oci_unestoque, @oci_quantidade, @oci_estoque, @oci_precokg, @oci_preco, @oci_total, @oci_aliqipi, @oci_valoripi, @oci_comprimento, @oci_largura, @oci_bitola, @oci_aliqsubtrib, @oci_valorsubtrib, @oci_qtdfaturada, @oci_observacao, @oci_sitentrega, @oci_aliqicms)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void deletaLote(string cod)
        {
            Query = new MySqlCommand();
            Query.Parameters.AddWithValue("@cod", cod);
            Query.Connection = Conexao;
            Query.CommandText = "DELETE FROM lote_validade WHERE ltv_codigo = @cod";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void cadastraCompra(controlCompNComp cn)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@cnc_item", cn.Cnc_item);
            Query.Parameters.AddWithValue("@cnc_comprar", cn.Cnc_comprar);
            Query.Parameters.AddWithValue("@cnc_grupo", cn.Cnc_grupo);
            Query.Parameters.AddWithValue("@cnc_fornecedor", cn.Cnc_fornecedor);
            Query.CommandText = "INSERT INTO compra_naocompra(cnc_item, cnc_grupo, cnc_comprar, cnc_fornecedor) VALUES (@cnc_item, @cnc_grupo, @cnc_comprar, @cnc_fornecedor)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraCompra(controlCompNComp cn, string cod)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@cnc_item", cn.Cnc_item);
            Query.Parameters.AddWithValue("@cnc_comprar", cn.Cnc_comprar);
            Query.CommandText = "UPDATE compra_naocompra SET cnc_comprar = @cnc_comprar WHERE cnc_item = '"+cod+"'";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void cadastraCompra2(controlCompNComp cn)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@cnc_item", cn.Cnc_item);
            Query.Parameters.AddWithValue("@cnc_qtde", cn.Cnc_qtde);
            Query.Parameters.AddWithValue("@cnc_grupo", cn.Cnc_grupo);
            Query.Parameters.AddWithValue("@cnc_fornecedor", cn.Cnc_fornecedor);
            Query.CommandText = "INSERT INTO compra_naocompra(cnc_item, cnc_grupo, cnc_qtde, cnc_fornecedor) VALUES (@cnc_item, @cnc_grupo, @cnc_qtde, @cnc_fornecedor)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraCompra2(controlCompNComp cn, string cod)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@cnc_item", cn.Cnc_item);
            Query.Parameters.AddWithValue("@cnc_qtde", cn.Cnc_qtde);
            Query.CommandText = "UPDATE compra_naocompra SET cnc_qtde = @cnc_qtde WHERE cnc_item = '" + cod + "'";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraCompra3()
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.CommandText = "UPDATE compra_naocompra SET cnc_qtde = ''";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void cadastraCampanha(controlCampanha cc)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@cmak_campanha", cc.Cmak_campanha);
            Query.Parameters.AddWithValue("@cmak_item", cc.Cmak_codigo);
            Query.Parameters.AddWithValue("@cmak_produto", cc.Cmak_produto);
            Query.Parameters.AddWithValue("@cmak_data", cc.Cmak_data);
            Query.Parameters.AddWithValue("@cmak_alcance", cc.Cmak_alcance);
            Query.Parameters.AddWithValue("@cmak_curtidas", cc.Cmak_curtidas);
            Query.Parameters.AddWithValue("@cmak_compart", cc.Cmak_compart);
            Query.CommandText = "INSERT INTO campanha_marketing(cmak_campanha, cmak_item, cmak_produto, cmak_alcance, cmak_curtidas, cmak_compart, cmak_data) VALUES (@cmak_campanha, @cmak_item, @cmak_produto, @cmak_alcance, @cmak_curtidas, @cmak_compart, @cmak_data)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraCampanha(controlCampanha cc, int cod)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@cmak_alcance", cc.Cmak_alcance);
            Query.Parameters.AddWithValue("@cmak_curtidas", cc.Cmak_curtidas);
            Query.Parameters.AddWithValue("@cmak_compart", cc.Cmak_compart);
            Query.CommandText = "UPDATE campanha_marketing SET cmak_alcance = @cmak_alcance, cmak_curtidas = @cmak_curtidas, cmak_compart = @cmak_compart WHERE cmak_codigo = "+cod+"";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void cadastraUsuario(controlUsuarios cu)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@res_usuario", cu.Res_usuario);
            Query.Parameters.AddWithValue("@res_senha", cu.Res_senha);
            Query.Parameters.AddWithValue("@res_compras", cu.Res_compras);
            Query.Parameters.AddWithValue("@res_expedicao", cu.Res_expedicao);
            Query.Parameters.AddWithValue("@res_estoque", cu.Res_estoque);
            Query.Parameters.AddWithValue("@res_financeiro", cu.Res_financeiro);
            Query.Parameters.AddWithValue("@res_vendas", cu.Res_vendas);
            Query.Parameters.AddWithValue("@res_marketing", cu.Res_marketing);
            Query.Parameters.AddWithValue("@res_utilitarios", cu.Res_utilitarios);
            Query.CommandText = "INSERT INTO restricoes(res_usuario, res_senha, res_compras, res_expedicao, res_estoque, res_financeiro, res_vendas, res_marketing, res_utilitarios) VALUES (@res_usuario, @res_senha, @res_compras, @res_expedicao, @res_estoque, @res_financeiro, @res_vendas, @res_marketing, @res_utilitarios)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraUsuario(controlUsuarios cu, string cod)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@res_senha", cu.Res_senha);
            Query.Parameters.AddWithValue("@res_compras", cu.Res_compras);
            Query.Parameters.AddWithValue("@res_expedicao", cu.Res_expedicao);
            Query.Parameters.AddWithValue("@res_estoque", cu.Res_estoque);
            Query.Parameters.AddWithValue("@res_financeiro", cu.Res_financeiro);
            Query.Parameters.AddWithValue("@res_vendas", cu.Res_vendas);
            Query.Parameters.AddWithValue("@res_marketing", cu.Res_marketing);
            Query.Parameters.AddWithValue("@res_utilitarios", cu.Res_utilitarios);
            Query.CommandText = "UPDATE restricoes SET res_senha = @res_senha, res_compras = @res_compras, res_expedicao = @res_expedicao, res_estoque = @res_estoque, res_financeiro = @res_financeiro, res_vendas = @res_vendas, res_marketing = @res_marketing, res_utilitarios = @res_utilitarios WHERE res_usuario = " + cod+"";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void cadastraMeta(controlMeta cm)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@vmet_vendedor", cm.Vmet_vendedor);
            Query.Parameters.AddWithValue("@vmet_meta", cm.Vmet_meta);
            Query.Parameters.AddWithValue("@vmet_situacao", cm.Vmet_situacao);
            Query.Parameters.AddWithValue("@vmet_tipo", cm.Vmet_tipo);
            Query.Parameters.AddWithValue("@vmet_periodo", cm.Vmet_periodo);
            Query.CommandText = "INSERT INTO valor_meta(vmet_vendedor, vmet_meta, vmet_situacao, vmet_tipo, vmet_periodo) VALUES (@vmet_vendedor, @vmet_meta, @vmet_situacao, @vmet_tipo, @vmet_periodo)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraMeta(controlMeta cm, string cod)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@vmet_vendedor", cm.Vmet_vendedor);
            Query.Parameters.AddWithValue("@vmet_meta", cm.Vmet_meta);
            Query.Parameters.AddWithValue("@vmet_situacao", cm.Vmet_situacao);
            Query.Parameters.AddWithValue("@vmet_tipo", cm.Vmet_tipo);
            Query.Parameters.AddWithValue("@vmet_periodo", cm.Vmet_periodo);
            Query.CommandText = "UPDATE valor_meta SET vmet_meta = @vmet_meta, vmet_situacao = @vmet_situacao, vmet_tipo = @vmet_tipo, vmet_periodo = @vmet_periodo WHERE vmet_vendedor = '" + cod+"'";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void cadastraTmpMeta(controlTmpMeta ctm)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@tmet_dia", ctm.Tmet_dia);
            Query.Parameters.AddWithValue("@tmet_semana", ctm.Tmet_semana);
            Query.Parameters.AddWithValue("@tmet_meta", ctm.Tmet_meta);
            Query.Parameters.AddWithValue("@tmet_feriado", ctm.Tmet_feriado);
            Query.CommandText = "INSERT INTO tmp_meta(tmet_dia, tmet_semana, tmet_meta, tmet_feriado) VALUES (@tmet_dia, @tmet_semana, @tmet_meta, @tmet_feriado)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void deletaTmpMeta()
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.CommandText = "delete from tmp_meta";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
            Query.CommandText = "ALTER TABLE tmp_meta AUTO_INCREMENT = 1";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void alteraTmpMeta(controlTmpMeta ctm, string dia)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@tmet_meta", ctm.Tmet_meta);
            Query.Parameters.AddWithValue("@tmet_feriado", ctm.Tmet_feriado);
            Query.CommandText = "UPDATE tmp_meta SET tmet_meta = @tmet_meta, tmet_feriado = @tmet_feriado WHERE tmet_dia = '" + dia + "'";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void CadastraLigacoes(ControlLigacoes cl)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@liga_data", cl.Liga_data);
            Query.Parameters.AddWithValue("@liga_hora", cl.Liga_hora);
            Query.Parameters.AddWithValue("@liga_cliente", cl.Liga_cliente);
            Query.Parameters.AddWithValue("@liga_para", cl.Liga_para);
            Query.Parameters.AddWithValue("@liga_situacao", cl.Liga_situacao);
            Query.Parameters.AddWithValue("@liga_obs", cl.Liga_obs);
            Query.CommandText = "INSERT INTO ligacoes(liga_data, liga_hora, liga_cliente, liga_para, liga_situacao, liga_obs) VALUES (@liga_data, @liga_hora, @liga_cliente, @liga_para, @liga_situacao, @liga_obs)";
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void AlteraLigacoes(ControlLigacoes cl, int cod)
        {
            Query = new MySqlCommand();
            Query.Connection = Conexao;
            Query.Parameters.AddWithValue("@liga_hora", cl.Liga_hora);
            Query.Parameters.AddWithValue("@liga_cliente", cl.Liga_cliente);
            Query.Parameters.AddWithValue("@liga_para", cl.Liga_para);
            Query.Parameters.AddWithValue("@liga_situacao", cl.Liga_situacao);
            Query.Parameters.AddWithValue("@liga_obs", cl.Liga_obs);
            Query.CommandText = "UPDATE ligacoes SET liga_hora = @liga_hora, liga_cliente = @liga_cliente, liga_para = @liga_para, liga_situacao = @liga_situacao, liga_obs = @liga_obs WHERE liga_id ="+cod;
            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
    }
}
