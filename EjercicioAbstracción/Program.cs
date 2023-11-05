using EjercicioAbstracción;

PlantaFlor plantaFlor = new PlantaFlor("Rosa", "Rosa sp.", "Roja", 30, true, 5, true, false);
PlantaArbol plantaArbol = new PlantaArbol("Roble", "Quercus robur", "Verde", 500, "Caduca", true, 25, true);

Console.WriteLine("Datos de la Planta de Flor");
Console.WriteLine("Nombre Común: " + plantaFlor.nombreComun);
Console.WriteLine("Nombre Científico: " + plantaFlor.nombreCientifico);
Console.WriteLine("Color: " + plantaFlor.color);
Console.WriteLine("Altura: " + plantaFlor.altura + " cm");
Console.WriteLine("Tiene Fragancia: " + (plantaFlor.TieneFragancia ? "Sí" : "No"));
Console.WriteLine("Número de Pétalos: " + plantaFlor.NumeroPetalos);
Console.WriteLine("Es Anual: " + (plantaFlor.EsAnual ? "Sí" : "No"));
Console.WriteLine("Es Perenne: " + (plantaFlor.EsPerenne ? "Sí" : "No"));

plantaFlor.Crecer();
plantaFlor.Fotosintesis();
plantaFlor.Reproducirse();

Console.WriteLine();

Console.WriteLine("Datos del Árbol");
Console.WriteLine("Nombre Común: " + plantaArbol.nombreComun);
Console.WriteLine("Nombre Científico: " + plantaArbol.nombreCientifico);
Console.WriteLine("Color: " + plantaArbol.color);
Console.WriteLine("Altura: " + plantaArbol.altura + " cm");
Console.WriteLine("Tipo de Hoja: " + plantaArbol.TipoHoja);
Console.WriteLine("Es Frutal: " + (plantaArbol.EsFrutal ? "Sí" : "No"));
Console.WriteLine("Edad: " + plantaArbol.Edad + " años");
Console.WriteLine("Es Caducifolio: " + (plantaArbol.EsCaducifolio ? "Sí" : "No"));

plantaArbol.Crecer();
plantaArbol.Fotosintesis();
plantaArbol.Reproducirse();

