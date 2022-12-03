using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiBase2021.Models
{
    public class DDJJListarModels
    {
        public int ID { get; set; }
        public string DDJJ { get; set; }
    }

    public class DDJJListarEventoModels
    {
        public int ID { get; set; }
        public string TipoEvento { get; set; }
    }

    public  class DDJJListarMonedaModels
    {
        public int ID { get; set; }
        public string Moneda { get; set; }
    }

    public  class DDJJListarTipoMovtoModels
    {
        public int ID { get; set; }
        public string CodigoMovto { get; set; }
    }


    public class DDJJListarMovtoModels
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


    public class ListaTipoEventoModels
    {

        public int ID { get; set; }
        public Nullable<int> ID_DDJJ { get; set; }
        public Nullable<int> ID_TipoEvento { get; set; }
        public Nullable<int> ID_CodigoMovto { get; set; }
        public Nullable<int> ID_Moneda { get; set; }




    }

}




