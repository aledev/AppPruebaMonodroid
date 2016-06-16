using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Mono.Data.Sqlite;

namespace AndroidApplication01
{
    [Activity(Label = "My Activity", MainLauncher = true, Icon = "@drawable/icon")]
    public class FormExample : Activity
    {
        #region Propiedades Privadas

        Button btnIngresar;
        TextView tvEstadoSolicitud;
        EditText txtUsuario;
        EditText txtPassword;
        ProgressDialog progDialog;

        #endregion

        #region Eventos

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FormExample);

            // Create your application here

            progDialog = new ProgressDialog(this);
            progDialog.SetTitle("Cargando...");
            progDialog.SetMessage("Por favor, espere un momento...");
            progDialog.SetCancelable(false);

            btnIngresar = FindViewById<Button>(Resource.Id.btnIngresar);
            tvEstadoSolicitud = FindViewById<TextView>(Resource.Id.tvEstado);
            txtUsuario = FindViewById<EditText>(Resource.Id.txtUsuario);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPass);

            btnIngresar.Click += new EventHandler(btnIngresar_Click);
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarTextoSolicitud("Cargando...");
                progDialog.Show();

                String _user = txtUsuario.Text;
                String _pass = txtPassword.Text;

                AndroidServices.Services1 servicios = new AndroidServices.Services1();
                servicios.Timeout = 30000;
                servicios.Url = "http://localhost:8080/AppMobile.Web.Services/Services.asmx";

                servicios.GetUserValidationXMLCompleted += new AndroidServices.GetUserValidationXMLCompletedEventHandler(servicios_GetUserValidationXMLCompleted);
                servicios.GetUserValidationXMLAsync(_user, _pass);
            }
            catch (Exception ex)
            {
                progDialog.Hide();
                ModificarTextoSolicitud(ex.Message);
            }
        }

        protected void servicios_GetUserValidationXMLCompleted(object sender, AndroidServices.GetUserValidationXMLCompletedEventArgs e)
        {
            progDialog.Hide();
            
            String result = e.Result;

            if (string.IsNullOrEmpty(result))
            {
                ModificarTextoSolicitud("Usuario y/o Password Incorrectos");
            }
            else
            {
                ModificarTextoSolicitud("Usuario Válido!");
            }
        }

        #endregion

        #region Metodos Privados

        private void ModificarTextoSolicitud(String texto)
        {
            tvEstadoSolicitud.Text = string.Format("Estado Solicitud: {0}", texto);
        }

        #endregion
    }
}