using AccesoDatos;
using AccesoNegocio.Models;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccesoNegocio.Implementacion
{
    public class ImplDDJJ1949
    {

        private ProyOperacionesEntities _accesData = new ProyOperacionesEntities();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Paginated_DDJJ1949 ObtenerDDJJ1949(
            string Codigo_movto,
            string Moneda,
            string fechaInicio, 
            string fechaFin, 
            string tipoEvento,
            
            int page, 
            int limit, 
            string sortby = default(string), 
            string order = default(string))
        {

            Paginated_DDJJ1949 respuesta = new Paginated_DDJJ1949();

            try
            {
                List<DDJJ1949> listDDJJ1949 = new List<DDJJ1949>();

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
                    #region moneda
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
                        List<SS_DDJJ_1949_Result> resultList = new List<SS_DDJJ_1949_Result>();
                        resultList = _accesData.SS_DDJJ_1949(Codigo_movto, tipoEvento, fechaInicio, fechaFin , Moneda).ToList();

                        foreach (SS_DDJJ_1949_Result _obj in resultList)
                        {
                            DDJJ1949 _objDDJJ1949 = new DDJJ1949();
                            _objDDJJ1949.FECHA_PAG = _obj.FECHA_PAG;
                            _objDDJJ1949.SEC_MOVTO = _obj.SEC_MOVTO;
                            _objDDJJ1949.RUT_CLI = _obj.RUT_CLI;
                            _objDDJJ1949.SEC_RUT_CLI = _obj.SEC_RUT_CLI;
                            _objDDJJ1949.COD_MOVTO = _obj.COD_MOVTO;
                            _objDDJJ1949.DESCRIPCION = _obj.DESCRIPCION;
                            _objDDJJ1949.RUT_EMI = _obj.RUT_EMI;
                            _objDDJJ1949.NEMO = _obj.NEMO;
                            _objDDJJ1949.MTO_PAG = _obj.MTO_PAG;
                            _objDDJJ1949.FOL_EVE = _obj.FOL_EVE;
                            _objDDJJ1949.SEC_VC = _obj.SEC_VC;
                            _objDDJJ1949.TIP_SOC = _obj.TIP_SOC;
                            _objDDJJ1949.RUT_ADM = _obj.RUT_ADM;
                            _objDDJJ1949.MONEDA = _obj.MONEDA;

                            listDDJJ1949.Add(_objDDJJ1949);
                        }

                        session["listDDJJ1949"] = listDDJJ1949;
                        #endregion
                    }
                    else
                    {
                        #region Si la busqueda es la misma
                        if (session["listDDJJ1949"] != null)
                        {
                            #region si esta en session
                            listDDJJ1949 = (List<DDJJ1949>)session["listDDJJ1949"];
                            #endregion
                        }
                        else
                        {
                            #region Si no esta en session
                            List<SS_DDJJ_1949_Result> resultList = new List<SS_DDJJ_1949_Result>();
                            resultList = _accesData.SS_DDJJ_1949(Codigo_movto, tipoEvento, fechaInicio, fechaFin, Moneda).ToList();

                            foreach (SS_DDJJ_1949_Result _obj in resultList)
                            {
                                DDJJ1949 _objDDJJ1949 = new DDJJ1949();
                                _objDDJJ1949.FECHA_PAG = _obj.FECHA_PAG;
                                _objDDJJ1949.SEC_MOVTO = _obj.SEC_MOVTO;
                                _objDDJJ1949.RUT_CLI = _obj.RUT_CLI;
                                _objDDJJ1949.SEC_RUT_CLI = _obj.SEC_RUT_CLI;
                                _objDDJJ1949.COD_MOVTO = _obj.COD_MOVTO;
                                _objDDJJ1949.DESCRIPCION = _obj.DESCRIPCION;
                                _objDDJJ1949.RUT_EMI = _obj.RUT_EMI;
                                _objDDJJ1949.NEMO = _obj.NEMO;
                                _objDDJJ1949.MTO_PAG = _obj.MTO_PAG;
                                _objDDJJ1949.FOL_EVE = _obj.FOL_EVE;
                                _objDDJJ1949.SEC_VC = _obj.SEC_VC;
                                _objDDJJ1949.TIP_SOC = _obj.TIP_SOC;
                                _objDDJJ1949.RUT_ADM = _obj.RUT_ADM;
                                _objDDJJ1949.MONEDA = _obj.MONEDA;
                                listDDJJ1949.Add(_objDDJJ1949);
                            }

                            session["listDDJJ1949"] = listDDJJ1949;
                            #endregion
                        }
                        #endregion
                    } 
                    #endregion
                }
                else
                {
                    #region Si la session esta vacia
                    List<SS_DDJJ_1949_Result> resultList = new List<SS_DDJJ_1949_Result>();
                    resultList = _accesData.SS_DDJJ_1949(Codigo_movto, tipoEvento, fechaInicio, fechaFin, Moneda).ToList();

                    foreach (SS_DDJJ_1949_Result _obj in resultList)
                    {
                        DDJJ1949 _objDDJJ1949 = new DDJJ1949();
                        _objDDJJ1949.FECHA_PAG = _obj.FECHA_PAG;
                        _objDDJJ1949.SEC_MOVTO = _obj.SEC_MOVTO;
                        _objDDJJ1949.RUT_CLI = _obj.RUT_CLI;
                        _objDDJJ1949.SEC_RUT_CLI = _obj.SEC_RUT_CLI;
                        _objDDJJ1949.COD_MOVTO = _obj.COD_MOVTO;
                        _objDDJJ1949.DESCRIPCION = _obj.DESCRIPCION;
                        _objDDJJ1949.RUT_EMI = _obj.RUT_EMI;
                        _objDDJJ1949.NEMO = _obj.NEMO;
                        _objDDJJ1949.MTO_PAG = _obj.MTO_PAG;
                        _objDDJJ1949.FOL_EVE = _obj.FOL_EVE;
                        _objDDJJ1949.SEC_VC = _obj.SEC_VC;
                        _objDDJJ1949.TIP_SOC = _obj.TIP_SOC;
                        _objDDJJ1949.RUT_ADM = _obj.RUT_ADM;
                        _objDDJJ1949.MONEDA = _obj.MONEDA;
                        listDDJJ1949.Add(_objDDJJ1949);
                    }
                    
                    session["Codigo_movto"] = Codigo_movto;
                    session["fechaInicio"] = fechaInicio;
                    session["fechaFin"] = fechaFin;
                    session["tipoEvento"] = tipoEvento;
                    session["Moneda"] = Moneda;
                    session["listDDJJ1949"] = listDDJJ1949; 
                    #endregion
                }
                #endregion

                respuesta = PaginateListDDJJ1949(listDDJJ1949,page,limit,sortby,order);

            }
            catch (Exception ex)
            {
                string mensajeError = "Error ejecutando el método ObtenerDDJJ. Error: " + ex.InnerException + " // " + ex.StackTrace;
                log.Error(mensajeError);
                ImplUtiles.SendEmail(mensajeError, true);

            }

            return respuesta;
        }

        public string ObtenerDDJJ1949Excel64(string Codigo_movto, string Moneda, string fechaInicio, string fechaFin, string tipoEvento)
        {

            string Excel64File = "";

            try
            {
                List<DDJJ1949> listDDJJ1949 = new List<DDJJ1949>();

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
                    #region moneda
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
                        List<SS_DDJJ_1949_Result> resultList = new List<SS_DDJJ_1949_Result>();
                        resultList = _accesData.SS_DDJJ_1949(Codigo_movto, tipoEvento, fechaInicio, fechaFin, Moneda).ToList();

                        foreach (SS_DDJJ_1949_Result _obj in resultList)
                        {
                            DDJJ1949 _objDDJJ1949 = new DDJJ1949();
                            _objDDJJ1949.FECHA_PAG = _obj.FECHA_PAG;
                            _objDDJJ1949.SEC_MOVTO = _obj.SEC_MOVTO;
                            _objDDJJ1949.RUT_CLI = _obj.RUT_CLI;
                            _objDDJJ1949.SEC_RUT_CLI = _obj.SEC_RUT_CLI;
                            _objDDJJ1949.COD_MOVTO = _obj.COD_MOVTO;
                            _objDDJJ1949.DESCRIPCION = _obj.DESCRIPCION;
                            _objDDJJ1949.RUT_EMI = _obj.RUT_EMI;
                            _objDDJJ1949.NEMO = _obj.NEMO;
                            _objDDJJ1949.MTO_PAG = _obj.MTO_PAG;
                            _objDDJJ1949.FOL_EVE = _obj.FOL_EVE;
                            _objDDJJ1949.SEC_VC = _obj.SEC_VC;
                            _objDDJJ1949.TIP_SOC = _obj.TIP_SOC;
                            _objDDJJ1949.RUT_ADM = _obj.RUT_ADM;
                            _objDDJJ1949.MONEDA = _obj.MONEDA;
                            listDDJJ1949.Add(_objDDJJ1949);
                        }

                        session["listDDJJ1949"] = listDDJJ1949;
                        #endregion
                    }
                    else
                    {
                        #region Si la busqueda es la misma
                        if (session["listDDJJ1949"] != null)
                        {
                            #region si esta en session
                            listDDJJ1949 = (List<DDJJ1949>)session["listDDJJ1949"];
                            #endregion
                        }
                        else
                        {
                            #region Si no esta en session
                            List<SS_DDJJ_1949_Result> resultList = new List<SS_DDJJ_1949_Result>();
                            resultList = _accesData.SS_DDJJ_1949(Codigo_movto, tipoEvento, fechaInicio, fechaFin, Moneda).ToList();

                            foreach (SS_DDJJ_1949_Result _obj in resultList)
                            {
                                DDJJ1949 _objDDJJ1949 = new DDJJ1949();
                                _objDDJJ1949.FECHA_PAG = _obj.FECHA_PAG;
                                _objDDJJ1949.SEC_MOVTO = _obj.SEC_MOVTO;
                                _objDDJJ1949.RUT_CLI = _obj.RUT_CLI;
                                _objDDJJ1949.SEC_RUT_CLI = _obj.SEC_RUT_CLI;
                                _objDDJJ1949.COD_MOVTO = _obj.COD_MOVTO;
                                _objDDJJ1949.DESCRIPCION = _obj.DESCRIPCION;
                                _objDDJJ1949.RUT_EMI = _obj.RUT_EMI;
                                _objDDJJ1949.NEMO = _obj.NEMO;
                                _objDDJJ1949.MTO_PAG = _obj.MTO_PAG;
                                _objDDJJ1949.FOL_EVE = _obj.FOL_EVE;
                                _objDDJJ1949.SEC_VC = _obj.SEC_VC;
                                _objDDJJ1949.TIP_SOC = _obj.TIP_SOC;
                                _objDDJJ1949.RUT_ADM = _obj.RUT_ADM;
                                _objDDJJ1949.MONEDA = _obj.MONEDA;
                                listDDJJ1949.Add(_objDDJJ1949);
                            }

                            session["listDDJJ1949"] = listDDJJ1949;
                            #endregion
                        }
                        #endregion
                    }
                    #endregion
                }
                else
                {
                    #region Si la session esta vacia
                    List<SS_DDJJ_1949_Result> resultList = new List<SS_DDJJ_1949_Result>();
                    resultList = _accesData.SS_DDJJ_1949(Codigo_movto, tipoEvento, fechaInicio, fechaFin, Moneda).ToList();

                    foreach (SS_DDJJ_1949_Result _obj in resultList)
                    {
                        DDJJ1949 _objDDJJ1949 = new DDJJ1949();
                        _objDDJJ1949.FECHA_PAG = _obj.FECHA_PAG;
                        _objDDJJ1949.SEC_MOVTO = _obj.SEC_MOVTO;
                        _objDDJJ1949.RUT_CLI = _obj.RUT_CLI;
                        _objDDJJ1949.SEC_RUT_CLI = _obj.SEC_RUT_CLI;
                        _objDDJJ1949.COD_MOVTO = _obj.COD_MOVTO;
                        _objDDJJ1949.DESCRIPCION = _obj.DESCRIPCION;
                        _objDDJJ1949.RUT_EMI = _obj.RUT_EMI;
                        _objDDJJ1949.NEMO = _obj.NEMO;
                        _objDDJJ1949.MTO_PAG = _obj.MTO_PAG;
                        _objDDJJ1949.FOL_EVE = _obj.FOL_EVE;
                        _objDDJJ1949.SEC_VC = _obj.SEC_VC;
                        _objDDJJ1949.TIP_SOC = _obj.TIP_SOC;
                        _objDDJJ1949.RUT_ADM = _obj.RUT_ADM;
                        _objDDJJ1949.MONEDA = _obj.MONEDA;
                        listDDJJ1949.Add(_objDDJJ1949);
                    }

                    session["Codigo_movto"] = Codigo_movto;
                    session["fechaInicio"] = fechaInicio;
                    session["fechaFin"] = fechaFin;
                    session["tipoEvento"] = tipoEvento;
                    session["Moneda"] = Moneda;
                    session["listDDJJ1949"] = listDDJJ1949;
                    #endregion
                }
                #endregion

                Excel64File = GenerarExcel_DDJJ1949(listDDJJ1949);

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
        public static Paginated_DDJJ1949 PaginateListDDJJ1949(List<DDJJ1949> ListaDDJJ1949, int page, int limit, string sortby, string order)
        {
            Paginated_DDJJ1949 respuesta = new Paginated_DDJJ1949();
            try
            {
                List<DDJJ1949> li = new List<DDJJ1949>();
                int pageActual = page - 1;

                #region Order By
                Func<DDJJ1949, Object> orderByFunc = null;
                #region DEFAULT
                if (sortby == null)
                {
                    sortby = "COD_MOVTO";
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
                    case "COD_MOVTO":
                        orderByFunc = item => item.COD_MOVTO;
                        break;
                    case "DESCRIPCION":
                        orderByFunc = item => item.DESCRIPCION;
                        break;
                    case "FECHA_PAG":
                        orderByFunc = item => item.FECHA_PAG;
                        break;
                    case "FOL_EVE":
                        orderByFunc = item => item.FOL_EVE;
                        break;
                    case "MTO_PAG":
                        orderByFunc = item => item.MTO_PAG;
                        break;
                    case "NEMO":
                        orderByFunc = item => item.NEMO;
                        break;
                    case "RUT_ADM":
                        orderByFunc = item => item.RUT_ADM;
                        break;
                    case "RUT_CLI":
                        orderByFunc = item => item.RUT_CLI;
                        break;
                    case "RUT_EMI":
                        orderByFunc = item => item.RUT_EMI;
                        break;
                    case "SEC_MOVTO":
                        orderByFunc = item => item.SEC_MOVTO;
                        break;
                    case "SEC_RUT_CLI":
                        orderByFunc = item => item.SEC_RUT_CLI;
                        break;
                    case "SEC_VC":
                        orderByFunc = item => item.SEC_VC;
                        break;
                    case "TIP_SOC":
                        orderByFunc = item => item.TIP_SOC;
                        break;
                    case "MONEDA":
                        orderByFunc = item => item.MONEDA;
                        break;
                    default:
                        orderByFunc = item => item.COD_MOVTO;
                        break;
                } 
                #endregion

                if (order == "asc")
                {
                    ListaDDJJ1949 = (from p in ListaDDJJ1949
                                      select p).OrderBy(orderByFunc).ToList();
                }
                else
                {
                    ListaDDJJ1949 = (from p in ListaDDJJ1949
                                      select p).OrderByDescending(orderByFunc).ToList();
                }

                #endregion

                li = ListaDDJJ1949.Skip(limit * pageActual).Take(limit).ToList();

                //===============================================

                respuesta.actualPage = page;
                respuesta.data = li;
                respuesta.firstPage = 1;
                int nPages = (int)Math.Ceiling((double)ListaDDJJ1949.Count / (double)limit);
                respuesta.lastPage = nPages;
                respuesta.totalElements = ListaDDJJ1949.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return respuesta;
        }
        #endregion

        #region GenerarExcel_DDJJ1949
        public static string GenerarExcel_DDJJ1949(List<DDJJ1949> Get_Positions_L)
        {
            string respuesta = "";
            string worksheetName = "DDJJ1949";
            //variable que aloja valor en web config
            string url = ConfigurationManager.AppSettings["RutaExcel"];
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add(worksheetName);
                    worksheet.ShowGridLines = true;
                    List<string> Columnas = PropertiesFromType(new DDJJ1949());
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

                            if (c == 0)
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
                    string name = "Archivo_DJ1949_" + fecha +"_"+ Guid.NewGuid().ToString() + ".xlsx";
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
