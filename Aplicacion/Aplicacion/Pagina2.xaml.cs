using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Aplicacion.DTOs;

using Xamarin.Forms;

namespace Aplicacion
{	
	public partial class Pagina2 : ContentPage
	{	
		public Pagina2 ()
		{
			InitializeComponent ();
		}

        private async void btnGuardar_Clicked(System.Object sender, System.EventArgs e)
        {
			var user = new UserDTO
			{
				Nombre = txtNombre.Text,
				ApPaterno = txtApPaterno.Text
			};

			txtNombre.Text = "Rodrigo";
        }
    }
}

