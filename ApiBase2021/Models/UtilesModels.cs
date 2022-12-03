using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccesoNegocio.Models;

namespace ApiBase2021.Models
{
    public class UtilesModels
    {
        /// <summary>
        /// Negocio to model para cada DDJJ
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static List<DDJJ1874Models> ConvertListActivoNegocioToModel(IList<DDJJ1874> IlistDDJJ1874)
        {
            List<DDJJ1874Models> listDDJJ1874 = new List<DDJJ1874Models>();

            foreach (DDJJ1874 objNeg in IlistDDJJ1874)
            {
                DDJJ1874Models objMod = new DDJJ1874Models();


                objMod.FEC_OPE = objNeg.FEC_OPE;
                objMod.SEC_MOVTO = objNeg.SEC_MOVTO;
                objMod.RUT_CLI = objNeg.RUT_CLI;
                objMod.RUT_EMI = objNeg.RUT_EMI;
                objMod.CODIGO = objNeg.CODIGO;
                objMod.DESCRIPCION = objNeg.DESCRIPCION;
                objMod.NEMO = objNeg.NEMO;
                objMod.MON_REAJUSTE = objNeg.MON_REAJUSTE;
                objMod.INT_DEV_CLP = objNeg.INT_DEV_CLP;
                objMod.RETENC_DEV_CLP = objNeg.RETENC_DEV_CLP;
                objMod.RUT_ADM = objNeg.RUT_ADM;

                listDDJJ1874.Add(objMod);
            }
            return listDDJJ1874;
        }

        ///PAGINADO AQUI
        public static List<DDJJ1922Models> ConvertListActivoNegocioToModel(IList<DDJJ1922> IlistDDJJ1922)
        {
            List<DDJJ1922Models> listDDJJ1922 = new List<DDJJ1922Models>();

            foreach (DDJJ1922 objNeg in IlistDDJJ1922)
            {
                DDJJ1922Models objMod = new DDJJ1922Models();


                objMod.FEC_MVTO = objNeg.FEC_MVTO;
                objMod.SEC_MOVTO = objNeg.SEC_MOVTO;
                objMod.FOLIO_COMP_ADJ = objNeg.FOLIO_COMP_ADJ;
                objMod.RUT_CLI = objNeg.RUT_CLI;
                objMod.SEC_RUT_CLI = objNeg.SEC_RUT_CLI;
                objMod.CODIGO = objNeg.CODIGO;
                objMod.DESCRIPCION = objNeg.DESCRIPCION;
                objMod.NEMO = objNeg.NEMO;
                objMod.CANTIDAD = objNeg.CANTIDAD;
                objMod.PRECIO = objNeg.PRECIO;
                objMod.MONTO = objNeg.MONTO;
                objMod.SEC_EVE = objNeg.SEC_EVE;
                
             
                listDDJJ1922.Add(objMod);
            }
            return listDDJJ1922;
        }
        public static List<DDJJ1932Models> ConvertListActivoNegocioToModel(IList<DDJJ1932> IlistDDJJ1932)
        {
            List<DDJJ1932Models> listDDJJ1932 = new List<DDJJ1932Models>();

            foreach (DDJJ1932 objNeg in IlistDDJJ1932)
            {
                DDJJ1932Models objMod = new DDJJ1932Models();


                objMod.FOLIO = (int)objNeg.FOLIO;
                objMod.FECHA = objNeg.FECHA;
                objMod.RUT = objNeg.RUT;
                objMod.CTA = objNeg.CTA;
                objMod.CODIGO = objNeg.CODIGO;
                objMod.TIPO_MOVTO = objNeg.TIPO_MOVTO;
                objMod.NEMO = objNeg.NEMO;
                objMod.RAZON_SOCIAL = objNeg.RAZON_SOCIAL;
                objMod.MONEDA = objNeg.MONEDA;
                objMod.MONTO = objNeg.MONTO;
                objMod.CONCEPTO_MVTO = objNeg.CONCEPTO_MVTO;

      
                 listDDJJ1932.Add(objMod);
            }
            return listDDJJ1932;
        }

        public static List<DDJJ1949Models> ConvertListActivoNegocioToModel(IList<DDJJ1949> IlistDDJJ1949)
        {
            List<DDJJ1949Models> listDDJJ1949 = new List<DDJJ1949Models>();

            foreach (DDJJ1949 objNeg in IlistDDJJ1949)
            {
                DDJJ1949Models objMod = new DDJJ1949Models();


                objMod.FECHA_PAG = objNeg.FECHA_PAG;
                objMod.SEC_MOVTO = objNeg.SEC_MOVTO;
                objMod.RUT_CLI = objNeg.RUT_CLI;
                objMod.SEC_RUT_CLI = objNeg.SEC_RUT_CLI;
                objMod.COD_MOVTO = objNeg.COD_MOVTO;
                objMod.DESCRIPCION = objNeg.DESCRIPCION;
                objMod.RUT_EMI = objNeg.RUT_EMI;
                objMod.NEMO = objNeg.NEMO;
                objMod.MTO_PAG = objNeg.MTO_PAG;
                objMod.FOL_EVE = objNeg.FOL_EVE;
                objMod.SEC_VC = objNeg.SEC_VC;
                objMod.TIP_SOC = objNeg.TIP_SOC;
                objMod.RUT_ADM = objNeg.RUT_ADM;


        listDDJJ1949.Add(objMod);
            }
            return listDDJJ1949;
        }

        public static List<DDJJListarModels> ConvertListDDJJNegocioToModel(IList<DDJJListar> IlistDDJJ)
        {
            List<DDJJListarModels> listDDJJ = new List<DDJJListarModels>();

            foreach (DDJJListar objNeg in IlistDDJJ)
            {
                DDJJListarModels objMod = new DDJJListarModels();

                objMod.ID = objNeg.ID;
                objMod.DDJJ = objNeg.DDJJ;


                listDDJJ.Add(objMod);
            }
            return listDDJJ;
        }

        //listar tipo evento
        public static List<DDJJListarEventoModels> ConvertListDDJJEventoNegocioToModel(IList<DDJJListarEvento> IlistDDJJ)
        {
            List<DDJJListarEventoModels> listDDJJ = new List<DDJJListarEventoModels>();

            foreach (DDJJListarEvento objNeg in IlistDDJJ)
            {
                DDJJListarEventoModels objMod = new DDJJListarEventoModels();

                objMod.ID = objNeg.ID;

                objMod.TipoEvento = objNeg.TipoEvento;


                listDDJJ.Add(objMod);
            }
            return listDDJJ;
        }

        public static List<DDJJListarMonedaModels> ConvertListDDJJMonedaNegocioToModel(IList<DDJJListarMoneda> IlistDDJJ)
        {
            List<DDJJListarMonedaModels> listDDJJ = new List<DDJJListarMonedaModels>();

            foreach (DDJJListarMoneda objNeg in IlistDDJJ)
            {
                DDJJListarMonedaModels objMod = new DDJJListarMonedaModels();

                objMod.ID = objNeg.ID;

                objMod.Moneda = objNeg.Moneda;


                listDDJJ.Add(objMod);
            }
            return listDDJJ;
        }

        public static List<DDJJListarTipoMovtoModels> ConvertListDDJJMovtoNegocioToModel(IList<DDJJListarTipoMovto> IlistDDJJ)
        {
            List<DDJJListarTipoMovtoModels> listDDJJ = new List<DDJJListarTipoMovtoModels>();

            foreach (DDJJListarTipoMovto objNeg in IlistDDJJ)
            {
                DDJJListarTipoMovtoModels objMod = new DDJJListarTipoMovtoModels();

                objMod.ID = objNeg.ID;

                objMod.CodigoMovto = objNeg.CodigoMovto;


                listDDJJ.Add(objMod);
            }
            return listDDJJ;
        }

        public static List<DDJJListarMovtoModels> ConvertListDDJJListarMovtoNegocioToModel(IList<DDJJListarMovto> IlistDDJJ)
        {
            List<DDJJListarMovtoModels> listDDJJ = new List<DDJJListarMovtoModels>();

            foreach (DDJJListarMovto objNeg in IlistDDJJ)
            {
                DDJJListarMovtoModels objMod = new DDJJListarMovtoModels();

                objMod.ID_DDJJ = objNeg.ID_DDJJ;
                objMod.DDJJ = objNeg.DDJJ;
                objMod.ID_TipoEvento = objNeg.ID_TipoEvento;
                objMod.TipoEvento = objNeg.TipoEvento;
                objMod.ID_CodigoMovto = objNeg.ID_CodigoMovto;
                objMod.CodigoMovto = objNeg.CodigoMovto;
                objMod.ID_Moneda = objNeg.ID_Moneda;
                objMod.Moneda = objNeg.Moneda;


                listDDJJ.Add(objMod);
            }
            return listDDJJ;
        }


        public static List<ListaTipoEventoModels> ConvertListTipoEventoNegocioToModel(IList<ListaTipoEvento> IlistDDJJ)
        {
            List<ListaTipoEventoModels> listDDJJ = new List<ListaTipoEventoModels>();

            foreach (ListaTipoEvento objNeg in IlistDDJJ)
            {
                ListaTipoEventoModels objMod = new ListaTipoEventoModels();

                objMod.ID = objNeg.ID;
                objMod.ID_DDJJ = objNeg.ID_DDJJ;
                objMod.ID_TipoEvento = objNeg.ID_TipoEvento;
                objMod.ID_CodigoMovto = objNeg.ID_CodigoMovto;
                objMod.ID_Moneda = objNeg.ID_Moneda;


                listDDJJ.Add(objMod);
            }
            return listDDJJ;
        }



    }
}