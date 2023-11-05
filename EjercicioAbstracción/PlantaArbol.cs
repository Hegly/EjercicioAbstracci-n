using System;
using System.Drawing;

namespace EjercicioAbstracción
{
    internal class PlantaArbol : Planta
    {
        public string TipoHoja { get; set; }
        public bool EsFrutal { get; set; }
        public int Edad { get; set; }
        public bool EsCaducifolio { get; set; }

        public PlantaArbol(string nombreComun, string nombreCientifico, string color, int altura, string tipoHoja, bool esFrutal, int edad, bool esCaducifolio)
        {
            this.nombreComun = nombreComun;
            this.nombreCientifico = nombreCientifico;
            this.color = color;
            this.altura = altura;
            TipoHoja = tipoHoja;
            EsFrutal = esFrutal;
            Edad = edad;
            EsCaducifolio = esCaducifolio;
        }

        public override void Crecer()
        {
            Console.WriteLine("El árbol está creciendo.");
        }

        public override void Fotosintesis()
        {
            Console.WriteLine("El árbol realiza la fotosíntesis.");
        }

        public override void Reproducirse()
        {
            Console.WriteLine("El árbol se reproduce por semillas.");
        }
    }
}
