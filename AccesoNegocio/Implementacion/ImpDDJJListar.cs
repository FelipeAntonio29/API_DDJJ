using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoNegocio.Models;

namespace AccesoNegocio.Implementacion
{
    public class ImpDDJJListar
    {
        //private BD35Entities _accesData = new BD35Entities();
        private ProyOperacionesEntities _accesData = new ProyOperacionesEntities();

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IList<DDJJListar> ObtenerDDJJ()
        {
            List<DDJJListar> listDDJJ = new List<DDJJListar>();
            try
            {

                List<SS_DDJJ_ObtenerDJ_Result> resultList = _accesData.SS_DDJJ_ObtenerDJ().ToList();

                foreach (SS_DDJJ_ObtenerDJ_Result _obj in resultList)
                {
                    DDJJListar _objDDJJ = new DDJJListar();

                    _objDDJJ.ID = _obj.ID;
                    _objDDJJ.DDJJ = _obj.DDJJ;
                    listDDJJ.Add(_objDDJJ);
                }

            }
            catch (Exception ex)
            {
                string mensajeError = "Error ejecutando el método ObtenerDDJJ. Error: " + ex.Message + " // " + ex.InnerException + " // " + ex.StackTrace;
                log.Error(mensajeError);
                ImplUtiles.SendEmail(mensajeError, true);
               
            }

            return listDDJJ;
        }


        public IList<DDJJListarEvento> ObtenerTipoEvento()
        {
            List<DDJJListarEvento> listDDJJ = new List<DDJJListarEvento>();
            try
            {
                List<SS_DDJJ_ObtenerTipoEvento_Result> resultList = _accesData.SS_DDJJ_ObtenerTipoEvento().ToList();

                foreach (SS_DDJJ_ObtenerTipoEvento_Result _obj in resultList)
                {
                    DDJJListarEvento _objDDJJ = new DDJJListarEvento();

                    _objDDJJ.ID = _obj.ID;
                    _objDDJJ.TipoEvento = _obj.TipoEvento;

                
                    listDDJJ.Add(_objDDJJ);
                }

            }
            catch (Exception ex)
            {
                string mensajeError = "Error ejecutando el método ObtenerEvento. Error: " + ex.InnerException + " // " + ex.StackTrace;
                log.Error(mensajeError);
                ImplUtiles.SendEmail(mensajeError, true);

            }

            return listDDJJ;
        }

        public IList<DDJJListarMoneda> ObtenerMoneda()
        {
            List<DDJJListarMoneda> listDDJJ = new List<DDJJListarMoneda>();
            try
            {
                List<SS_DDJJ_ObtenerMoneda_Result> resultList = _accesData.SS_DDJJ_ObtenerMoneda().ToList();

                foreach (SS_DDJJ_ObtenerMoneda_Result _obj in resultList)
                {
                    DDJJListarMoneda _objDDJJ = new DDJJListarMoneda();

                    _objDDJJ.ID = _obj.ID;
                    _objDDJJ.Moneda = _obj.Moneda;


                    listDDJJ.Add(_objDDJJ);
                }

            }
            catch (Exception ex)
            {
                string mensajeError = "Error ejecutando el método ObtenerMoneda. Error: " + ex.InnerException + " // " + ex.StackTrace;
                log.Error(mensajeError);
                ImplUtiles.SendEmail(mensajeError, true);

            }

            return listDDJJ;
        }

        public IList<DDJJListarTipoMovto> ObtenerMovto()
        {
            List<DDJJListarTipoMovto> listDDJJ = new List<DDJJListarTipoMovto>();
            try
            {
                List<SS_DDJJ_ObtenerCodigoMovto_Result> resultList = _accesData.SS_DDJJ_ObtenerCodigoMovto().ToList();

                foreach (SS_DDJJ_ObtenerCodigoMovto_Result _obj in resultList)
                {
                    DDJJListarTipoMovto _objDDJJ = new DDJJListarTipoMovto();

                    _objDDJJ.ID = _obj.ID;
                    _objDDJJ.CodigoMovto = _obj.CodigoMovto;


                    listDDJJ.Add(_objDDJJ);
                }

            }
            catch (Exception ex)
            {
                string mensajeError = "Error ejecutando el método ObtenerMovto. Error: " + ex.InnerException + " // " + ex.StackTrace;
                log.Error(mensajeError);
                ImplUtiles.SendEmail(mensajeError, true);

            }

            return listDDJJ;
        }
        public IList<DDJJListarMovto> ListarMovto(int ID_DDJJ)
        {
            List<DDJJListarMovto> listDDJJ = new List<DDJJListarMovto>();
            try
            {
                List<SS_DDJJ_ObtenerMovto_Result> resultList = _accesData.SS_DDJJ_ObtenerMovto(ID_DDJJ).ToList();

                foreach (SS_DDJJ_ObtenerMovto_Result _obj in resultList)
                {
                    DDJJListarMovto _objDDJJ = new DDJJListarMovto();


                    _objDDJJ.ID_DDJJ = _obj.ID_DDJJ;
                    _objDDJJ.DDJJ = _obj.DDJJ;
                    _objDDJJ.ID_TipoEvento = _obj.ID_TipoEvento;
                    _objDDJJ.TipoEvento = _obj.TipoEvento;
                    _objDDJJ.ID_CodigoMovto = _obj.ID_CodigoMovto;
                    _objDDJJ.CodigoMovto = _obj.CodigoMovto;
                    _objDDJJ.ID_Moneda = _obj.ID_Moneda;
                    _objDDJJ.Moneda = _obj.Moneda;




                    listDDJJ.Add(_objDDJJ);
                }

            }
            catch (Exception ex)
            {
                string mensajeError = "Error ejecutando el método ObtenerMovto. Error: " + ex.InnerException + " // " + ex.StackTrace;
                log.Error(mensajeError);
                ImplUtiles.SendEmail(mensajeError, true);

            }

            return listDDJJ;
        }



        public IList<ListaTipoEvento> LISTARTIPOEVENTO(int iD_TipoEvento)

        {

            List<ListaTipoEvento> list = new List<ListaTipoEvento>();
            try
            {
                List<SS_DDJJ_ListaTipoEvento_Result> resultList = _accesData.SS_DDJJ_ListaTipoEvento(iD_TipoEvento).ToList();

                foreach (SS_DDJJ_ListaTipoEvento_Result items in resultList)
                {
                    ListaTipoEvento _obj = new ListaTipoEvento();
                    _obj.ID = items.ID;
                    _obj.ID_DDJJ = items.ID_DDJJ;
                    _obj.ID_TipoEvento = items.ID_TipoEvento;
                    _obj.ID_CodigoMovto = items.ID_CodigoMovto;
                    _obj.ID_Moneda = items.ID_Moneda;
                    list.Add(_obj);
                    //llamar a sp sp retorna lista y esa lista agrgar a u lista de retorno
                }
            }
            catch (Exception ex)
            {
                string mensajeError = "Error ejecutando el método. Error: " + ex.InnerException + " // " + ex.StackTrace;
                log.Error(mensajeError);
                ImplUtiles.SendEmail(mensajeError, true);

            }

            return list;
        }



    }

}


