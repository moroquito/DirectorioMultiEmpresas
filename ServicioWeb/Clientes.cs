using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWeb
{
    public class Clientes
    {
        public String IdCliente { get; set; }

        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public String Direccion { get; set; }

        public String Telefono { get; set; }

        public String CorreoElectronico { get; set; }

        public String TipoCliente { get; set; }

        public decimal Credito { get; set; }

        public decimal Saldo { get; set; }

        public String Empresa { get; set; }

        public Clientes()
        {
            this.IdCliente = "";
            this.Nombre = "";
            this.Apellido = "";
            this.Direccion = "";
            this.Telefono = "";
            this.CorreoElectronico = "";
            this.TipoCliente = "";
            this.Credito = 0;
            this.Saldo = 0;
            this.Empresa = "";
        }

        public Clientes(String IdCL, String Nom, String Apell, String Dir, String Tel, String Mail, String Tipo, decimal Cred, decimal Sald, String Empre)
        {
            this.IdCliente = IdCL;
            this.Nombre = Nom;
            this.Apellido = Apell;
            this.Direccion = Dir;
            this.Telefono = Tel;
            this.CorreoElectronico = Mail;
            this.TipoCliente = Tipo;
            this.Credito = Cred;
            this.Saldo = Sald;
            this.Empresa = Empre;
        }
    }
}