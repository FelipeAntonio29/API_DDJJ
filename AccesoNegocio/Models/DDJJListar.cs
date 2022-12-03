using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoNegocio.Models
{
    public class DDJJListar
    {
        public int ID { get; set; }
        public string DDJJ { get; set; }
    }


    public  class DDJJListarEvento
    {
        public int ID { get; set; }
        public string TipoEvento { get; set; }
    }

    public class DDJJListarMoneda
    {
        public int ID { get; set; }
        public string Moneda { get; set; }
    }

    public class DDJJListarTipoMovto
    {
        public int ID { get; set; }
        public string CodigoMovto { get; set; }
    }



    public  class DDJJListarMovto
    {
        public Nullable<int> ID_DDJJ { get; set; }
        public string DDJJ { get; set; }
        public Nullable<int> ID_TipoEvento { get; set; }
        public string TipoEvento { get; set; }
        public Nullable<int> ID_CodigoMovto { get; set; }
        public string CodigoMovto { get; set; }
        public Nullable<int> ID_Moneda { get; set; }
        public string Moneda { get; set; }
    }


}
