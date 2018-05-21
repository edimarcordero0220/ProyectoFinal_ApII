using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace GestionVentas
{
    public static  class Utilidades
    {
        public static int TOINT(string nombre)
        {
            int.TryParse(nombre, out int numero);
            return numero;
        }


        public static void ShowToastr(this Page page, string message, string title, string type = "info")
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "toastr_message",
                  String.Format("toastr.{0}('{1}', '{2}');", type.ToLower(), message, title), addScriptTags: true);
        }

        public static void Mensage(this Page page, string Letrero, string scripts)
        {

            page.ClientScript.RegisterStartupScript(page.GetType(), Letrero, scripts);
        }
        public static int ValidarIdEntero(string IdTextBox)//todo: llevar a utilitarios
        {
            int Id = 0;

            if (IdTextBox.Length > 0)
            {
                bool result = Int32.TryParse(IdTextBox, out Id);
            }

            return Id;
        }
    }
}