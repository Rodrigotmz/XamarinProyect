using System;
using System.Collections.Generic;
using Aplicacion.DTOs;
using Xamarin.Forms;

namespace Aplicacion
{
    public partial class Pagina3 : ContentPage
    {
        public Pagina3()
        {
            InitializeComponent();
        }


        async void btnGuardar_Clicked(System.Object sender, System.EventArgs e)
        {
            var user = new FisicDTO
            {
                Ritmo = txtRitmo.Text,
                Regate = txtRegate.Text,
                Tiro = txtTiro.Text,
                Defensa = txtDefnsa.Text,
                Pase = txtPase.Text,
                Fisico = txtFisico.Text
            };
            await Navigation.PushAsync(new Pagina4());
        }
    }
}

