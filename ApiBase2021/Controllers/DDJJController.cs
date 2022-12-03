using ApiBase2021.Models;
using AccesoNegocio.Implementacion;
using System.Collections.Generic;
using System.Web.Http;
using AccesoNegocio.Models;
using System.Web.Http.Description;

namespace ApiBase2021.Controllers
{
    public class DDJJ1874Controller : ApiController
    {

        private string LV_USER = System.Web.HttpContext.Current.User.Identity.Name;

        private ImplDDJJ1874 _implDDJJ1874 = new ImplDDJJ1874();

        private ImplDDJJ1922 _implDDJJ1922 = new ImplDDJJ1922();

        private ImplDDJJ1932 _implDDJJ1932 = new ImplDDJJ1932();

        private ImplDDJJ1949 _implDDJJ1949 = new ImplDDJJ1949();

        private ImpDDJJListar _implDDJJListar = new ImpDDJJListar();


        [HttpGet]
        [Route("api/DDJJ1874/ListaTipoEvento")]
        public List<ListaTipoEventoModels> LISTARTIPOEVENTO(int iD_TipoEvento)
        {
            return UtilesModels.ConvertListTipoEventoNegocioToModel(_implDDJJListar.LISTARTIPOEVENTO(iD_TipoEvento));
        }




        //1874 paginado

        [HttpGet]
        [Route("api/DDJJ1874/Listar")]
        public Paginated_DDJJ1874 ObtenerDDJJ1874(string Codigo_movto, string Moneda, string fechaInicio, string fechaFin, string tipoEvento, int page, int limit, string sortby = default(string), string order = default(string))
        {
            return _implDDJJ1874.ObtenerDDJJ1874(Codigo_movto, Moneda, fechaInicio, fechaFin, tipoEvento, page, limit, sortby, order);
        }

        [HttpGet] //T: Filtra por fecha trade   S:Filtra por fecha S
        [Route("api/DDJJ1874/Excel64_DDJJ1874")]
        [ResponseType(typeof(string))]
        public string Excel64_DDJJ1874(string Codigo_movto, string Moneda,string fechaInicio, string fechaFin, string tipoEvento)
        {
            return _implDDJJ1874.ObtenerDDJJ1874Excel64(Codigo_movto, Moneda, fechaInicio, fechaFin, tipoEvento);
        }
        //fin 1874 paginado


        //1922 paginado
        [HttpGet]
        [Route("api/DDJJ1922/Listar")]
        public Paginated_DDJJ1922 ObtenerDDJJ1922(string Codigo_movto,string Moneda, string fechaInicio, string fechaFin, string tipoEvento, int page, int limit, string sortby = default(string), string order = default(string))
        {
            return _implDDJJ1922.ObtenerDDJJ1922(Codigo_movto, Moneda, fechaInicio, fechaFin, tipoEvento, page, limit, sortby, order);
        }

        [HttpGet] //T: Filtra por fecha trade   S:Filtra por fecha S
        [Route("api/DDJJ1922/Excel64_DDJJ1922")]
        [ResponseType(typeof(string))]
        public string Excel64_DDJJ1922(string Codigo_movto, string Moneda, string fechaInicio, string fechaFin, string tipoEvento)
        {
            return _implDDJJ1922.ObtenerDDJJ1922Excel64(Codigo_movto, Moneda, fechaInicio, fechaFin, tipoEvento);
        }
        //fin 1922 paginado



        ///1932 paginado 
        [HttpGet]
        [Route("api/DDJJ1932/Listar")]
        public Paginated_DDJJ1932 ObtenerDDJJ1932(string Codigo_movto, string Moneda, string fechaInicio, string fechaFin, string tipoEvento, int page, int limit, string sortby = default(string), string order = default(string))
        {
            return _implDDJJ1932.ObtenerDDJJ1932(Codigo_movto, Moneda, fechaInicio, fechaFin, tipoEvento, page, limit, sortby, order);
        }

        [HttpGet] //T: Filtra por fecha trade   S:Filtra por fecha S
        [Route("api/DDJJ1932/Excel64_DDJJ1932")]
        [ResponseType(typeof(string))]
        public string Excel64_DDJJ1932(string Codigo_movto, string Moneda, string fechaInicio, string fechaFin, string tipoEvento)
        {
            return _implDDJJ1932.ObtenerDDJJ1932Excel64(Codigo_movto, Moneda, fechaInicio, fechaFin, tipoEvento);
        }
        ///fin 1932 paginado
        ///

        //1949 paginado
        [HttpGet]
        [Route("api/DDJJ1949/Listar")]
        public Paginated_DDJJ1949 ObtenerDDJJ1949(string Codigo_movto, string Moneda, string fechaInicio, string fechaFin, string tipoEvento, int page, int limit, string sortby = default(string), string order = default(string))
        {
            return _implDDJJ1949.ObtenerDDJJ1949(Codigo_movto,Moneda, fechaInicio, fechaFin, tipoEvento, page,limit,sortby,order);
        }

        [HttpGet] //T: Filtra por fecha trade   S:Filtra por fecha S
        [Route("api/DDJJ1949/Excel64_DDJJ1949")]
        [ResponseType(typeof(string))]
        public string Excel64_DDJJ1949(string Codigo_movto, string Moneda,string fechaInicio, string fechaFin, string tipoEvento)
        {
            return _implDDJJ1949.ObtenerDDJJ1949Excel64(Codigo_movto, Moneda, fechaInicio, fechaFin, tipoEvento);
        }
        //fin 1949 paginado

        [HttpGet]
        [Route("api/DDJJ/Listar")]
        public List<DDJJListarModels> ObtenerDDJJ()
        {

            return UtilesModels.ConvertListDDJJNegocioToModel(_implDDJJListar.ObtenerDDJJ());

        }

        [HttpGet]
        [Route("api/DDJJ/ListarEvento")]
        public List<DDJJListarEventoModels> ObtenerTipoEvento()
        {

            return UtilesModels.ConvertListDDJJEventoNegocioToModel(_implDDJJListar.ObtenerTipoEvento());

        }

        [HttpGet]
        [Route("api/DDJJ/ListarMoneda")]
        public List<DDJJListarMonedaModels> ObtenerMoneda()
        {

            return UtilesModels.ConvertListDDJJMonedaNegocioToModel(_implDDJJListar.ObtenerMoneda());

        }

        [HttpGet]
        [Route("api/DDJJ/ListarMovto")]
        public List<DDJJListarTipoMovtoModels> ObtenerMovto()
        {

            return UtilesModels.ConvertListDDJJMovtoNegocioToModel(_implDDJJListar.ObtenerMovto());

        }


        [HttpGet]
        [Route("api/DDJJ/ListarMovimientos")]
        public List<DDJJListarMovtoModels> ListarMovto(int ID_DDJJ)
        {

            return UtilesModels.ConvertListDDJJListarMovtoNegocioToModel(_implDDJJListar.ListarMovto(ID_DDJJ));

        }
    }


}

