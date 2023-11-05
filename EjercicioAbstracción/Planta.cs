using System;
namespace EjercicioAbstracción
{
    public abstract class Planta
    {
        public string? nombreComun { get; set; }
        public string? nombreCientifico { get; set; }
        public string? color { get; set; }
        public int altura { get; set; }

        public abstract void Crecer();
        public abstract void Fotosintesis();
        public abstract void Reproducirse();
    }
}

