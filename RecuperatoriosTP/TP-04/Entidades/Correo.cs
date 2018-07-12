using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using Entidades;


namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {

        #region Atributos

        private List<Paquete> paquetes;
        private List<Thread> mockPaquetes;

        #endregion


        #region Propiedades


        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }


        #endregion


        #region Constructor


        public Correo()
        {
            paquetes = new List<Paquete>();
            mockPaquetes = new List<Thread>();
        }


        #endregion


        #region Métodos

        public static Correo operator +(Correo c, Paquete p)
        {
            for (int i = 0; i < c.Paquetes.Count; i++)
            {
                if (c.Paquetes[i] == p)
                {
                    throw new TrackingIdRepetidoException("El paquete con ID " + c.paquetes[i].TrackingID +  " ya esta en la lista!");
                }
            }

            if (!(c.paquetes.Contains(p)))
            {
                c.paquetes.Add(p);
                Thread hilo = new Thread(p.MockCicloDeVida);
                hilo.Start();
                c.mockPaquetes.Add(hilo);
            }

            return c;
        }


        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Paquete p in (List<Paquete>)((Correo)elementos).paquetes)
            {
                sb.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }
            return sb.ToString();
        }

        public void FinEntregas()
        {
            foreach (Thread hilo in this.mockPaquetes)
            {
                hilo.Abort();
            }
        }

        #endregion
    }
}