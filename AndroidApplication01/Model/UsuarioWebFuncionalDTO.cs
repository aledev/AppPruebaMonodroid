using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CGEDroid.Model
{
    [Serializable]
    [XmlRoot("UsuarioWeb", Namespace="")]
    public class UsuarioWebFuncionalDTO
    {
        public Int64? Id
        {
            get;
            set;
        }

        public String Rut
        {
            get;
            set;
        }

        public String Nombre
        {
            get;
            set;
        }

        public String Apellido
        {
            get;
            set;
        }

        public String Clave
        {
            get;
            set;
        }
    }
}
