using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGEDroid.Model
{
    [Serializable]
    public class ContenidoFuncionalDTO
    {
        public Int64? Id
        {
            get;
            set;
        }

        public String Contenido
        {
            get;
            set;
        }

        public String UrlImagen
        {
            get;
            set;
        }
    }
}
