using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class ControlLoe
    {
        private String id_vendedor_loe;
        private int opcao_loe;
        private String id_produto;
        private String qtade_loe;
        private float preco_loe;
        private String comentario_loe;
        private String data_loe;

        public String Data_loe
        {
            get { return data_loe; }
            set { data_loe = value; }
        }

        public String Id_vendedor_loe
        {
            get { return id_vendedor_loe; }
            set { id_vendedor_loe = value; }
        }

        public int Opcao_loe
        {
            get { return opcao_loe; }
            set { opcao_loe = value; }
        }

        public String Id_produto
        {
            get { return id_produto; }
            set { id_produto = value; }
        }

        public String Qtade_loe
        {
            get { return qtade_loe; }
            set { qtade_loe = value; }
        }

        public float Preco_loe
        {
            get { return preco_loe; }
            set { preco_loe = value; }
        }

        public String Comentario_loe
        {
            get { return comentario_loe; }
            set { comentario_loe = value; }
        }
    }
}
