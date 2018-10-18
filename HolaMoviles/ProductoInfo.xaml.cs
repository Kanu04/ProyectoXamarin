using System;
using System.Collections.Generic;
using Plugin.Media;
using Xamarin.Forms;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using HolaMoviles.Modelos;

namespace HolaMoviles
{
	public partial class ProductoInfo : ContentPage
	{
		public ProductoInfo(String Nombre)
        {
            InitializeComponent();

            BotonCamara.Command = new Command(CapturarImagen);

            Texto.Text = Nombre;

            if (Nombre == "bed")
            {
                Imagen.Source = ImageSource.FromFile("bed.jpg");
            }
            if (Nombre == "bench")
            {
                Imagen.Source = ImageSource.FromFile("Bench.jpg");
            }
            if (Nombre == "chair")
            {
                Imagen.Source = ImageSource.FromFile("chair.jpg");
            }
            if (Nombre == "couch")
            {
                Imagen.Source = ImageSource.FromFile("Couch.jpg");
            }
            if (Nombre == "pillow")
            {
                Imagen.Source = ImageSource.FromFile("Pillow.jpg");
            }

        }

        private void CapturarImagen()
		{
            DetalleT.Text = "Detalle";

            if (Texto.Text == "bed")
            {
                PrecioT.Text = "Precio: $225";
                CantidadT.Text = "Cantidad: 1";
            }
            if (Texto.Text == "bench")
            {
                PrecioT.Text = "Precio: $29.99";
                CantidadT.Text = "Cantidad: 3";
            }
            if (Texto.Text == "chair")
            {
                PrecioT.Text = "Precio: $9.99";
                CantidadT.Text = "Cantidad: 7";
            }
            if (Texto.Text == "couch")
            {
                PrecioT.Text = "Precio: $50";
                CantidadT.Text = "Cantidad: 2";
            }
            if (Texto.Text == "pillow")
            {
                PrecioT.Text = "Precio: $5";
                CantidadT.Text = "Cantidad: 1";
            }
        }
        
	}
}
