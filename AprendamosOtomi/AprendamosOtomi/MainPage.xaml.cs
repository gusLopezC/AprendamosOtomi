﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AprendamosOtomi.Views;
using AprendamosOtomi.WebApiFiles;


namespace AprendamosOtomi
{
	public partial class MainPage : ContentPage
	{
        /*
         * Crean lista de las imagenes para mandarlas como parametros
         * */
        public List<string> ListaVestimenta = new List<string>(){"https://preview.ibb.co/koHxMT/Vcamisa.png","https://preview.ibb.co/eoZcMT/Vfalda.png","https://preview.ibb.co/fb5TT8/Vsapare.png","https://preview.ibb.co/djH8T8/Vsueter.png"};
        public List<string> ListaFamilia = new List<string>() { "https://preview.ibb.co/eJkcBT/vcabuela.png", "https://preview.ibb.co/i0T7o8/Vabuelo.png","https://preview.ibb.co/iH4xo8/Vbebe.png","https://preview.ibb.co/dOEK1T/Vgemalas.png","https://preview.ibb.co/jz2Tvo/Vmadre.png","https://preview.ibb.co/ft3CMT/Vnieto.png","https://preview.ibb.co/jGiwgT/Vnina.png","https://preview.ibb.co/gWW5ao/Vnino.png","https://preview.ibb.co/cgndvo/Vpadre.png"};
        public List<string> ListaAnimales = new List<string>() { "https://preview.ibb.co/ej9SMT/Vardilla.png", "https://preview.ibb.co/fEuivo/Vconejo.png", "https://preview.ibb.co/hkDHd8/vcpollo.png", "https://preview.ibb.co/c106Fo/Vgato.png", "https://preview.ibb.co/mp6k88/Vmariposa.png", "https://preview.ibb.co/hzmJT8/Vobeja.png", "https://preview.ibb.co/jS4SMT/Vpajaro.png", "https://preview.ibb.co/g0fTT8/Vpato.png", "https://preview.ibb.co/fWR2o8/Vperro.png", "https://preview.ibb.co/gKtF88/Vpuerco.png", "https://preview.ibb.co/hM29ko/Vrana.png", "https://preview.ibb.co/hdeZQo/vcrata.png", "https://preview.ibb.co/gehXBT/vcvibora.png", "https://preview.ibb.co/eRGVrT/Vvaca.png" };
        public List<string> ListaComida = new List<string>() { "https://preview.ibb.co/cONyd8/Vaguacate.png", "https://preview.ibb.co/mBAAWT/vcarbol.png", "https://preview.ibb.co/j5v1y8/Vchile.png", "https://preview.ibb.co/kBaqrT/Vjitomate.png", "https://preview.ibb.co/kmGVrT/Vlimon.png", "https://preview.ibb.co/gGsyd8/Vmaiz.png", "https://preview.ibb.co/dJjjQo/vcnopal.png" };
        public List<string> ListaColores = new List<string>() { "https://preview.ibb.co/j9dh88/amarillo.png", "https://preview.ibb.co/jns9o8/azul.png", "https://preview.ibb.co/iCh7BT/vcblanco.png", "https://preview.ibb.co/n9QOFo/gris.png", "https://preview.ibb.co/miFiko/vcmorado.png", "https://preview.ibb.co/ffoX88/naranja.png", "https://preview.ibb.co/eYwVvo/negro.png", "https://preview.ibb.co/i26pQo/vcrosa.jpg", "https://preview.ibb.co/j9UYFo/verde.png", "https://preview.ibb.co/kiHLvo/vrojo.png" };
        public List<string> ListaSaludos = new List<string>() { "https://preview.ibb.co/mpLSBT/vcdias.png", "https://preview.ibb.co/cPkC88/viewhola.png","https://preview.ibb.co/kumfvo/viewtarde.png","https://preview.ibb.co/kiQJgT/viewnoche.png" };
        public List<string> ListaTradicciones = new List<string>() { "https://preview.ibb.co/nb48Fo/carnaval.png", "https://preview.ibb.co/cT43gT/muertos.png"};
        public List<string> ListaCuerpo = new List<string>() { "https://preview.ibb.co/jhhZo8/viewbrazo.png", "https://preview.ibb.co/doT788/viewmano.png", "https://preview.ibb.co/iDBaWT/vcnariz.png", "https://preview.ibb.co/cVxTFo/viewoido.png", "https://preview.ibb.co/fTeVT8/viewvista.png" };
        public MainPage()
		{
           //inicializan los componentes
            InitializeComponent();
            btnComida.Clicked += clic_Comida;
            btnFamilia.Clicked += clic_Familia;
            btnCuerpo.Clicked += clic_Cuerpo;
            btnVestimenta.Clicked += clic_Vestimenta;
            btnAnimales.Clicked += clic_Animales;
            btnColores.Clicked += clic_Colores;
            btnSaludos.Clicked += clic_Saludos;
            btnTradicciones.Clicked += clic_Tradicciones;
            btnTraductor.Clicked += clic_Traductor;
        
        }
        //Declaran los metodos para redireccionar a cada vista con sus lista a usar como practica
        public void clic_Traductor(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Traductor());
        }

        public void clic_Tradicciones(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaTradicciones));
        }

        public void clic_Saludos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaSaludos));
        }

        private void clic_Colores(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaColores));
        }

        public void clic_Vestimenta(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaVestimenta));
        }

        public void clic_Animales(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaAnimales));
        }

        public void clic_Familia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaFamilia));
        }

        public void clic_Comida(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaComida));
        }
        public void clic_Cuerpo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewCarousel(ListaCuerpo));
        }
    }
}
