using System;
using System.Drawing;

namespace EjercicioAbstracción
{
    internal class PlantaFlor : Planta
    {
        public bool TieneFragancia { get; set; }
        public int NumeroPetalos { get; set; }
        public bool EsAnual { get; set; }
        public bool EsPerenne { get; set; }

        public PlantaFlor(string nombreComun, string nombreCientifico, string color, int altura, bool tieneFragancia, int numeroPetalos, bool esAnual, bool esPerenne)
        {
            this.nombreComun = nombreComun;
            this.nombreCientifico = nombreCientifico;
            this.color = color;
            this.altura = altura;
            TieneFragancia = tieneFragancia;
            NumeroPetalos = numeroPetalos;
            EsAnual = esAnual;
            EsPerenne = esPerenne;
        }

        public override void Crecer()
        {
            Console.WriteLine("La planta con flor está creciendo.");
        }

        public override void Fotosintesis()
        {
            Console.WriteLine("La planta con flor realiza la fotosíntesis.");
        }

        public override void Reproducirse()
        {
            Console.WriteLine("La planta con flor se reproduce por polinización.");
        }
    }
}
