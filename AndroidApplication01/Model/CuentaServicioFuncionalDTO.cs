using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CGEDroid.Model
{
    [Serializable]
    [XmlRoot("Servicio", Namespace="")]
    public class CuentaServicioFuncionalDTO
    {
        public Int64? Id
        {
            get;
            set;
        }

        public Int64? IdUsuarioWeb
        {
            get;
            set;
        }

        public UsuarioWebFuncionalDTO UsuarioWeb
        {
            get;
            set;
        }

        public String UsuarioWebNombre
        {
            get;
            set;
        }

        public String NroInstalacion
        {
            get;
            set;
        }

        public String Direccion
        {
            get;
            set;
        }

        public Int32? DeudaVigente
        {
            get;
            set;
        }

        public DateTime? FchVencimiento
        {
            get;
            set;
        }

        public Int32? MtoPago
        {
            get;
            set;
        }

        public DateTime? FchUltimoPago
        {
            get;
            set;
        }

        public Int32? MtoUltimoPago
        {
            get;
            set;
        }

        public DateTime? FchCorteEnergia
        {
            get;
            set;
        }

        public String Tarifa
        {
            get;
            set;
        }

        public String Alias
        {
            get;
            set;
        }
    }
}
