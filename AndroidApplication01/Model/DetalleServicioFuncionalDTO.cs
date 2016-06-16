using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGEDroid.Model
{
    [Serializable]
    public class DetalleServicioFuncionalDTO
    {
        public Int64? Id
        {
            get;
            set;
        }

        public Int64? IdCuentaServicio
        {
            get;
            set;
        }

        public CuentaServicioFuncionalDTO CuentaServicio
        {
            get;
            set;
        }

        public Int32? Pago
        {
            get;
            set;
        }

        public Double? ConsumoKwh
        {
            get;
            set;
        }

        public DateTime? Fecha
        {
            get;
            set;
        }
    }
}
