using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoNegocio.Models
{
    public class DDJJ1932
    {

        public int FOLIO { get; set; }
        public string FECHA { get; set; }
        public string RUT { get; set; }
        public int CTA { get; set; }
        public string CODIGO { get; set; }
        public string TIPO_MOVTO { get; set; }
        public string NEMO { get; set; }
        public string RAZON_SOCIAL { get; set; }
        public string MONEDA { get; set; }
        public decimal MONTO { get; set; }
        public string CONCEPTO_MVTO { get; set; }


    }


    public class Paginated_DDJJ1932
    {
        public int actualPage { get; set; }
        public int firstPage { get; set; }
        public int lastPage { get; set; }
        public int totalElements { get; set; }

        public List<DDJJ1932> data { get; set; }

        public Paginated_DDJJ1932()
        {
            data = new List<DDJJ1932>();
            actualPage = 0;
            firstPage = 0;
            lastPage = 0;
            totalElements = 0;
        }
    }

}
