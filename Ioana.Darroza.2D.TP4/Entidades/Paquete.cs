using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{

    public class Paquete : IMostrar<Paquete>
    {

        #region Delegados y eventos

        public delegate void MiDelegadoEstado(object sender, EventArgs e);
        public event MiDelegadoEstado InformarEstado;

        #endregion

        #region Enumerados

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado,
        }

        #endregion

        #region Atributos

        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        #endregion

        #region Propiedades


        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }


        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }


        #endregion

        #region Constructor


        public Paquete(string direccionEntrega, string trakingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trakingID;
        }

        #endregion

        #region Metodo To String

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        #endregion

        #region Metodo Mostrar

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(string.Format("{0} para {1}", ((Paquete)elemento).trackingID, ((Paquete)elemento).direccionEntrega));
            return datos.ToString();
        }

        #endregion

        #region Sobrecarga de Operdores

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool retorno = false;
            if (p1.trackingID == p2.trackingID)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }


        #endregion

        #region Metodo Mock Ciclo de vida

        public void MockCicloDeVida()
        {
            for (this.estado = EEstado.Ingresado; this.estado <= EEstado.Entregado; this.estado++)
            {
                this.InformarEstado.Invoke(this, new EventArgs());
                Thread.Sleep(1000);
                if (this.estado == EEstado.Entregado)
                {
                    break;
                }
            }
            PaqueteDAO.Insertar(this);
        }

        #endregion
    }
}