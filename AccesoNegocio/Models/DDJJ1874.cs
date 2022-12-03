using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoNegocio.Models
{
    public class DDJJ1874
    {
        public string FEC_OPE { get; set; }
        public Nullable<int> SEC_MOVTO { get; set; }
        public int SEC_RUT_CLI { get; set; }
        public string RUT_CLI { get; set; }
        public string RUT_EMI { get; set; }
        public string CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public string NEMO { get; set; }
        public string MON_REAJUSTE { get; set; }
        public Nullable<decimal> INT_DEV_CLP { get; set; }
        public Nullable<decimal> RETENC_DEV_CLP { get; set; }
        public string RUT_ADM { get; set; }
        public int ID_TipoEvento { get; set; }
        public int ID_CodigoMovto { get; set; }
        public int ID_Moneda { get; set; }

    }

    public class Paginated_DDJJ1874
    {
        public int actualPage { get; set; }
        public int firstPage { get; set; }
        public int lastPage { get; set; }
        public int totalElements { get; set; }

        public List<DDJJ1874> data { get; set; }

        public Paginated_DDJJ1874()
        {
            data = new List<DDJJ1874>();
            actualPage = 0;
            firstPage = 0;
            lastPage = 0;
            totalElements = 0;
        }
    }

    public class ListaTipoEvento {

        public int ID { get; set; }
        public Nullable<int> ID_DDJJ { get; set; }
        public Nullable<int> ID_TipoEvento { get; set; }
        public Nullable<int> ID_CodigoMovto { get; set; }
        public Nullable<int> ID_Moneda { get; set; }




    }





}
