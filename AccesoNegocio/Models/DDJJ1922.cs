using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoNegocio.Models
{
    public class DDJJ1922
    {

        public string FEC_MVTO { get; set; }
        public int SEC_MOVTO { get; set; }
        public int FOLIO_COMP_ADJ { get; set; }
        public string RUT_CLI { get; set; }
        public int SEC_RUT_CLI { get; set; }
        public string CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public string NEMO { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal PRECIO { get; set; }
        public decimal MONTO { get; set; }
        public int SEC_EVE { get; set; }
        public string MONEDA { get; set; }

    }




    public class Paginated_DDJJ1922
    {
        public int actualPage { get; set; }
        public int firstPage { get; set; }
        public int lastPage { get; set; }
        public int totalElements { get; set; }

        public List<DDJJ1922> data { get; set; }

        public Paginated_DDJJ1922()
        {
            data = new List<DDJJ1922>();
            actualPage = 0;
            firstPage = 0;
            lastPage = 0;
            totalElements = 0;
        }
    }

}
