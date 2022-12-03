using AccesoDatos;
using AccesoNegocio.Models;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccesoNegocio.Implementacion
{
    public class ImplDDJJ1932
    {
        private ProyOperacionesEntities _accesData = new ProyOperacionesEntities();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /////////////////////////////////////////////////////////////////
        /////paginado
        ///

        public Paginated_DDJJ1932 ObtenerDDJJ1932(

             string Codigo_movto,
             string Moneda,
             string fechaInicio,
             string fechaFin,
             string tipoEvento,
             int page,
             int limit,
             string sortby = default(string),
             string order = default(string)

            )
        {

            Paginated_DDJJ1932 respuesta = new Paginated_DDJJ1932();

            try
            {
                List<DDJJ1932> listDDJJ1932 = new List<DDJJ1932>();

                #region Session
                int diferent = 0;
                var session = System.Web.HttpContext.Current.Session;
                if (session != null)
                {
                    #region Si hay valores en session
                    #region Codigo_movto
                    if (session["Codigo_movto"] == null)
                    {
                        diferent = 1;
                        session["Codigo_movto"] = Codigo_movto;
                    }
                    else
                    {
                        if (session["Codigo_movto"].ToString() != Codigo_movto)
                        {
                            diferent = 1;
                            session["Codigo_movto"] = Codigo_movto;
                        }
                    }
                    #endregion
                    #region fechaInicio
                    if (session["fechaInicio"] == null)
                    {
                        diferent = 1;
                        session["fechaInicio"] = fechaInicio;
                    }
                    else
                    {
                        if (session["fechaInicio"].ToString() != fechaInicio)
                        {
                            diferent = 1;
                            session["fechaInicio"] = fechaInicio;
                        }
                    }
                    #endregion
                    #region fechaFin
                    if (session["fechaFin"] == null)
                    {
                        diferent = 1;
                        session["fechaFin"] = fechaFin;
                    }
                    else
                    {
                        if (session["fechaFin"].ToString() != fechaFin)
                        {
                            diferent = 1;
                            session["fechaFin"] = fechaFin;
                        }
                    }
                    #endregion
                    #region tipoEvento
                    if (session["tipoEvento"] == null)
                    {
                        diferent = 1;
                        session["tipoEvento"] = tipoEvento;
                    }
                    else
                    {
                        if (session["tipoEvento"].ToString() != tipoEvento)
                        {
                            diferent = 1;
                            session["tipoEvento"] = tipoEvento;
                        }
                    }
                    #endregion
                    #region Moneda
                    if (session["Moneda"] == null)
                    {
                        diferent = 1;
                        session["Moneda"] = Moneda;
                    }
                    else
                    {
                        if (session["Moneda"].ToString() != Moneda)
                        {
                            diferent = 1;
                            session["Moneda"] = Moneda;
                        }
                    }
                    #endregion

                    if (diferent == 1)
                    {
                        #region Si cambiaron valores de busqueda
                        List<SS_DDJJ_1932_Result> resultList = new List<SS_DDJJ_1932_Result>();
                        resultList = _accesData.SS_DDJJ_1932(Codigo_movto, Moneda, tipoEvento, fechaInicio, fechaFin ).ToList();

                        foreach (SS_DDJJ_1932_Result _obj in resultList)
                        {
                            DDJJ1932 _objDDJJ1932 = new DDJJ1932();
                            _objDDJJ1932.FOLIO = _obj.FOLIO;
                            _objDDJJ1932.FECHA = _obj.FECHA;
                            _objDDJJ1932.RUT = _obj.RUT;
                            _objDDJJ1932.CTA = _obj.CTA;
                            _objDDJJ1932.CODIGO = _obj.CODIGO;
                            _objDDJJ1932.TIPO_MOVTO = _obj.TIPO_MOVTO;
                            _objDDJJ1932.NEMO = _obj.NEMO;
                            _objDDJJ1932.RAZON_SOCIAL = _obj.RAZON_SOCIAL;
                            _objDDJJ1932.MONEDA = _obj.MONEDA;
                            _objDDJJ1932.MONTO = _obj.MONTO;
                            _objDDJJ1932.CONCEPTO_MVTO = _obj.CONCEPTO_MVTO;
                            listDDJJ1932.Add(_objDDJJ1932);

                        }

                        session["listDDJJ1932"] = listDDJJ1932;
                        #endregion
                    }
                    else
                    {
                        #region Si la busqueda es la misma
                        if (session["listDDJJ1932"] != null)
                        {
                            #region si esta en session
                            listDDJJ1932 = (List<DDJJ1932>)session["listDDJJ1932"];
                            #endregion
                        }
                        else
                        {
                            #region Si no esta en session
                            List<SS_DDJJ_1932_Result> resultList = new List<SS_DDJJ_1932_Result>();
                            resultList = _accesData.SS_DDJJ_1932(Codigo_movto, tipoEvento, Moneda, fechaInicio, fechaFin).ToList();

                            foreach (SS_DDJJ_1932_Result _obj in resultList)
                            {
                                DDJJ1932 _objDDJJ1932 = new DDJJ1932();
                                _objDDJJ1932.FOLIO = _obj.FOLIO;
                                _objDDJJ1932.FECHA = _obj.FECHA;
                                _objDDJJ1932.RUT = _obj.RUT;
                                _objDDJJ1932.CTA = _obj.CTA;
                                _objDDJJ1932.CODIGO = _obj.CODIGO;
                                _objDDJJ1932.TIPO_MOVTO = _obj.TIPO_MOVTO;
                                _objDDJJ1932.NEMO = _obj.NEMO;
                                _objDDJJ1932.RAZON_SOCIAL = _obj.RAZON_SOCIAL;
                                _objDDJJ1932.MONEDA = _obj.MONEDA;
                                _objDDJJ1932.MONTO = _obj.MONTO;
                                _objDDJJ1932.CONCEPTO_MVTO = _obj.CONCEPTO_MVTO;
                                listDDJJ1932.Add(_objDDJJ1932);
                            }

                            session["listDDJJ1932"] = listDDJJ1932;
                            #endregion
                        }
                        #endregion
                    }
                    #endregion
                }
                else
                {
                    #region Si la session esta vacia
                    List<SS_DDJJ_1932_Result> resultList = new List<SS_DDJJ_1932_Result>();
                    resultList = _accesData.SS_DDJJ_1932(Codigo_movto, tipoEvento, Moneda, fechaInicio, fechaFin).ToList();

                    foreach (SS_DDJJ_1932_Result _obj in resultList)
                    {
                        DDJJ1932 _objDDJJ1932 = new DDJJ1932();
                        _objDDJJ1932.FOLIO = _obj.FOLIO;
                        _objDDJJ1932.FECHA = _obj.FECHA;
                        _objDDJJ1932.RUT = _obj.RUT;
                        _objDDJJ1932.CTA = _obj.CTA;
                        _objDDJJ1932.CODIGO = _obj.CODIGO;
                        _objDDJJ1932.TIPO_MOVTO = _obj.TIPO_MOVTO;
                        _objDDJJ1932.NEMO = _obj.NEMO;
                        _objDDJJ1932.RAZON_SOCIAL = _obj.RAZON_SOCIAL;
                        _objDDJJ1932.MONEDA = _obj.MONEDA;
                        _objDDJJ1932.MONTO = _obj.MONTO;
                        _objDDJJ1932.CONCEPTO_MVTO = _obj.CONCEPTO_MVTO;
                        listDDJJ1932.Add(_objDDJJ1932);
                    }

                    session["Codigo_movto"] = Codigo_movto;
                    session["Moneda"] = Moneda;
                    session["fechaInicio"] = fechaInicio;
                    session["fechaFin"] = fechaFin;
                    session["tipoEvento"] = tipoEvento;
                    session["listDDJJ1932"] = listDDJJ1932;
                    #endregion
                }
                #endregion

                respuesta = PaginateListDDJJ1932(listDDJJ1932, page, limit, sortby, order);

            }
            catch (Exception ex)
            {
                string mensajeError = "Error ejecutando el método ObtenerDDJJ. Error: " + ex.InnerException + " // " + ex.StackTrace;
                log.Error(mensajeError);
                ImplUtiles.SendEmail(mensajeError, true);

            }

            return respuesta;
        }

        public string ObtenerDDJJ1932Excel64(string Codigo_movto, string  Moneda, string fechaInicio, string fechaFin, string tipoEvento)
        {

            string Excel64File = "";

            try
            {
                List<DDJJ1932> listDDJJ1932 = new List<DDJJ1932>();

                #region Session
                int diferent = 0;
                var session = System.Web.HttpContext.Current.Session;

                if (session != null)
                {
                    #region Si hay valores en session
                    #region Codigo_movto
                    if (session["Codigo_movto"] == null)
                    {
                        diferent = 1;
                        session["Codigo_movto"] = Codigo_movto;
                    }
                    else
                    {
                        if (session["Codigo_movto"].ToString() != Codigo_movto)
                        {
                            diferent = 1;
                            session["Codigo_movto"] = Codigo_movto;
                        }
                    }
                    #endregion
                    #region fechaInicio
                    if (session["fechaInicio"] == null)
                    {
                        diferent = 1;
                        session["fechaInicio"] = fechaInicio;
                    }
                    else
                    {
                        if (session["fechaInicio"].ToString() != fechaInicio)
                        {
                            diferent = 1;
                            session["fechaInicio"] = fechaInicio;
                        }
                    }
                    #endregion
                    #region fechaFin
                    if (session["fechaFin"] == null)
                    {
                        diferent = 1;
                        session["fechaFin"] = fechaFin;
                    }
                    else
                    {
                        if (session["fechaFin"].ToString() != fechaFin)
                        {
                            diferent = 1;
                            session["fechaFin"] = fechaFin;
                        }
                    }
                    #endregion
                    #region tipoEvento
                    if (session["tipoEvento"] == null)
                    {
                        diferent = 1;
                        session["tipoEvento"] = tipoEvento;
                    }
                    else
                    {
                        if (session["tipoEvento"].ToString() != tipoEvento)
                        {
                            diferent = 1;
                            session["tipoEvento"] = tipoEvento;
                        }
                    }
                    #endregion
                    #region Moneda
                    if (session["Moneda"] == null)
                    {
                        diferent = 1;
                        session["Moneda"] = Moneda;
                    }
                    else
                    {
                        if (session["Moneda"].ToString() != Moneda)
                        {
                            diferent = 1;
                            session["Moneda"] = Moneda;
                        }
                    }
                    #endregion

                    if (diferent == 1)
                    {
                        #region Si cambiaron valores de busqueda
                        List<SS_DDJJ_1932_Result> resultList = new List<SS_DDJJ_1932_Result>();
                        resultList = _accesData.SS_DDJJ_1932(Codigo_movto, Moneda, tipoEvento, fechaInicio, fechaFin).ToList();

                        foreach (SS_DDJJ_1932_Result _obj in resultList)
                        {
                            DDJJ1932 _objDDJJ1932 = new DDJJ1932();
                            _objDDJJ1932.FOLIO = _obj.FOLIO;
                            _objDDJJ1932.FECHA = _obj.FECHA;
                            _objDDJJ1932.RUT = _obj.RUT;
                            _objDDJJ1932.CTA = _obj.CTA;
                            _objDDJJ1932.CODIGO = _obj.CODIGO;
                            _objDDJJ1932.TIPO_MOVTO = _obj.TIPO_MOVTO;
                            _objDDJJ1932.NEMO = _obj.NEMO;
                            _objDDJJ1932.RAZON_SOCIAL = _obj.RAZON_SOCIAL;
                            _objDDJJ1932.MONEDA = _obj.MONEDA;
                            _objDDJJ1932.MONTO = _obj.MONTO;
                            _objDDJJ1932.CONCEPTO_MVTO = _obj.CONCEPTO_MVTO;
                            listDDJJ1932.Add(_objDDJJ1932);
                        }

                        session["listDDJJ1932"] = listDDJJ1932;
                        #endregion
                    }
                    else
                    {
                        #region Si la busqueda es la misma
                        if (session["listDDJJ1932"] != null)
                        {
                            #region si esta en session
                            listDDJJ1932 = (List<DDJJ1932>)session["listDDJJ1932"];
                            #endregion
                        }
                        else
                        {
                            #region Si no esta en session
                            List<SS_DDJJ_1932_Result> resultList = new List<SS_DDJJ_1932_Result>();
                            resultList = _accesData.SS_DDJJ_1932(Codigo_movto, Moneda, tipoEvento, fechaInicio, fechaFin).ToList();

                            foreach (SS_DDJJ_1932_Result _obj in resultList)
                            {
                                DDJJ1932 _objDDJJ1932 = new DDJJ1932();
                                _objDDJJ1932.FOLIO = _obj.FOLIO;
                                _objDDJJ1932.FECHA = _obj.FECHA;
                                _objDDJJ1932.RUT = _obj.RUT;
                                _objDDJJ1932.CTA = _obj.CTA;
                                _objDDJJ1932.CODIGO = _obj.CODIGO;
                                _objDDJJ1932.TIPO_MOVTO = _obj.TIPO_MOVTO;
                                _objDDJJ1932.NEMO = _obj.NEMO;
                                _objDDJJ1932.RAZON_SOCIAL = _obj.RAZON_SOCIAL;
                                _objDDJJ1932.MONEDA = _obj.MONEDA;
                                _objDDJJ1932.MONTO = _obj.MONTO;
                                _objDDJJ1932.CONCEPTO_MVTO = _obj.CONCEPTO_MVTO;
                                listDDJJ1932.Add(_objDDJJ1932);
                            }

                            session["listDDJJ1932"] = listDDJJ1932;
                            #endregion
                        }
                        #endregion
                    }
                    #endregion
                }
                else
                {
                    #region Si la session esta vacia
                    List<SS_DDJJ_1932_Result> resultList = new List<SS_DDJJ_1932_Result>();
                    resultList = _accesData.SS_DDJJ_1932(Codigo_movto, Moneda, tipoEvento, fechaInicio, fechaFin).ToList();

                    foreach (SS_DDJJ_1932_Result _obj in resultList)
                    {
                        DDJJ1932 _objDDJJ1932 = new DDJJ1932();
                        _objDDJJ1932.FOLIO = _obj.FOLIO;
                        _objDDJJ1932.FECHA = _obj.FECHA;
                        _objDDJJ1932.RUT = _obj.RUT;
                        _objDDJJ1932.CTA = _obj.CTA;
                        _objDDJJ1932.CODIGO = _obj.CODIGO;
                        _objDDJJ1932.TIPO_MOVTO = _obj.TIPO_MOVTO;
                        _objDDJJ1932.NEMO = _obj.NEMO;
                        _objDDJJ1932.RAZON_SOCIAL = _obj.RAZON_SOCIAL;
                        _objDDJJ1932.MONEDA = _obj.MONEDA;
                        _objDDJJ1932.MONTO = _obj.MONTO;
                        _objDDJJ1932.CONCEPTO_MVTO = _obj.CONCEPTO_MVTO;
                        listDDJJ1932.Add(_objDDJJ1932);
                    }

                    session["Codigo_movto"] = Codigo_movto;
                    session["fechaInicio"] = fechaInicio;
                    session["fechaFin"] = fechaFin;
                    session["tipoEvento"] = tipoEvento;
                    session["listDDJJ1932"] = listDDJJ1932;
                    #endregion
                }
                #endregion

                Excel64File = GenerarExcel_DDJJ1932(listDDJJ1932);

            }
            catch (Exception ex)
            {
                string mensajeError = "Error ejecutando el método ObtenerDDJJ. Error: " + ex.InnerException + " // " + ex.StackTrace;
                log.Error(mensajeError);
                ImplUtiles.SendEmail(mensajeError, true);

            }

            return Excel64File;
        }

        #region PaginateDDJJ1949
        public static Paginated_DDJJ1932 PaginateListDDJJ1932(List<DDJJ1932> ListaDDJJ1932, int page, int limit, string sortby, string order)
        {
            Paginated_DDJJ1932 respuesta = new Paginated_DDJJ1932();
            try
            {
                List<DDJJ1932> li = new List<DDJJ1932>();
                int pageActual = page - 1;

                #region Order By
                Func<DDJJ1932, Object> orderByFunc = null;
                #region DEFAULT
                if (sortby == null)
                {
                    sortby = "CODIGO";
                }
                if (order == null)
                {
                    order = "asc";
                }
                #endregion

                sortby = sortby.ToUpper();
                #region Order BY
                switch (sortby)
                {
                    case "FOLIO":
                        orderByFunc = item => item.FOLIO;
                        break;
                    case "FECHA":
                        orderByFunc = item => item.FECHA;
                        break;
                    case "RUT":
                        orderByFunc = item => item.RUT;
                        break;
                    case "CTA":
                        orderByFunc = item => item.CTA;
                        break;
                    case "CODIGO":
                        orderByFunc = item => item.CODIGO;
                        break;
                    case "TIPO_MOVTO":
                        orderByFunc = item => item.TIPO_MOVTO;
                        break;
                    case "NEMO":
                        orderByFunc = item => item.NEMO;
                        break;
                    case "RAZON_SOCIAL":
                        orderByFunc = item => item.RAZON_SOCIAL;
                        break;
                    case "MONEDA":
                        orderByFunc = item => item.MONEDA;
                        break;
                    case "MONTO":
                        orderByFunc = item => item.MONTO;
                        break;
                    case "CONCEPTO_MVTO":
                        orderByFunc = item => item.CONCEPTO_MVTO;
                        break;
                }
                #endregion

                if (order == "asc")
                {
                    ListaDDJJ1932 = (from p in ListaDDJJ1932
                                     select p).OrderBy(orderByFunc).ToList();
                }
                else
                {
                    ListaDDJJ1932 = (from p in ListaDDJJ1932
                                     select p).OrderByDescending(orderByFunc).ToList();
                }

                #endregion

                li = ListaDDJJ1932.Skip(limit * pageActual).Take(limit).ToList();

                //===============================================

                respuesta.actualPage = page;
                respuesta.data = li;
                respuesta.firstPage = 1;
                int nPages = (int)Math.Ceiling((double)ListaDDJJ1932.Count / (double)limit);
                respuesta.lastPage = nPages;
                respuesta.totalElements = ListaDDJJ1932.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return respuesta;
        }
        #endregion



        #region GenerarExcel_DDJJ1949
        public static string GenerarExcel_DDJJ1932(List<DDJJ1932> Get_Positions_L)
        {
            string respuesta = "";
            string worksheetName = "DDJJ1932";
            //variable que aloja valor en web config
            string url = ConfigurationManager.AppSettings["RutaExcel"];
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add(worksheetName);
                    worksheet.ShowGridLines = true;
                    List<string> Columnas = PropertiesFromType(new DDJJ1932());
                    #region Columnas
                    for (int a = 0; a < Columnas.Count; a++)
                    {
                        string position = Number2String(a + 1, true) + "1";
                        worksheet.Cell(position).Value = Columnas[a].ToUpper().Trim();
                        worksheet.Cell(position).Style.Font.Bold = true;
                    }
                    #endregion

                    #region Datos
                    for (int a = 0; a < Get_Positions_L.Count; a++)
                    {
                        int b = a + 2;
                        for (int c = 0; c < Columnas.Count; c++)
                        {
                            
                            string position = Number2String(c + 1, true) + b.ToString();

                            if (c == 1)
                            {
                                worksheet.Cell(position).SetDataType(XLDataType.Text);
                                worksheet.Cell(position).SetValue<string>(Get_Positions_L[a].GetType().GetProperty(Columnas[c]).GetValue(Get_Positions_L[a], null).ToString());
                            }
                            else
                            {                               
                                worksheet.Cell(position).Value = Get_Positions_L[a].GetType().GetProperty(Columnas[c]).GetValue(Get_Positions_L[a], null);
                            }
                        }
                    }
                    #endregion

                    #region Guardado
                    string fecha = DateTime.Now.ToString("dd/MM/yyyy");
                    string name = "Archivo_DJ1932_" + fecha + "_" + Guid.NewGuid().ToString() + ".xlsx";
                    //Guardar como archivo
                    workbook.SaveAs(url + name);
                    respuesta = url + name;
                    #endregion

                }
            }
            catch (Exception ex)
            {
                string mensajeError = "Error ejecutando el método de generación de archivo Excel. Error: " + ex.InnerException + " // " + ex.StackTrace;
                log.Error(mensajeError);
                ImplUtiles.SendEmail(mensajeError, true);

            }


            return respuesta;
        }
        #endregion

        #region PropertiesFromType
        public static List<string> PropertiesFromType(object atype)
        {
            if (atype == null) return new List<string>();
            Type t = atype.GetType();
            PropertyInfo[] props = t.GetProperties();
            List<string> propNames = new List<string>();
            foreach (PropertyInfo prp in props)
            {
                propNames.Add(prp.Name);
            }
            return propNames.ToList();
        }
        #endregion

        #region Number2String
        private static String Number2String(int number, bool isCaps)
        {
            Char c = (Char)((isCaps ? 65 : 97) + (number - 1));
            return c.ToString();
        }
        #endregion

    }
}
