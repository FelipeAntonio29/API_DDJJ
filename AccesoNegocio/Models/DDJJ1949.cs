using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoNegocio.Models
{
    public class DDJJ1949
    {

        public string FECHA_PAG { get; set; }
        public int SEC_MOVTO { get; set; }
        public string RUT_CLI { get; set; }
        public int SEC_RUT_CLI { get; set; }
        public string COD_MOVTO { get; set; }
        public string DESCRIPCION { get; set; }
        public string RUT_EMI { get; set; }
        public string NEMO { get; set; }
        public decimal MTO_PAG { get; set; }
        public int FOL_EVE { get; set; }
        public int SEC_VC { get; set; }
        public string TIP_SOC { get; set; }
        public string RUT_ADM { get; set; }
        public string MONEDA { get; set; }



    }

    public class Paginated_DDJJ1949
    {
        public int actualPage { get; set; }
        public int firstPage { get; set; }
        public int lastPage { get; set; }
        public int totalElements { get; set; }

        public List<DDJJ1949> data { get; set; }

        public Paginated_DDJJ1949()
        {
            data = new List<DDJJ1949>();
            actualPage = 0;
            firstPage = 0;
            lastPage = 0;
            totalElements = 0;
        }
    }
}
