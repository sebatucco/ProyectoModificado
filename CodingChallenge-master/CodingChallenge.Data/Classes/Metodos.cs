using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public static class Metodos
    {
        public static List<Formas> cuerpo = new List<Formas>();
        public static List<Formas> CargarLista()
        {
            cuerpo.Add(new Formas { cuerpo = "Cuadrado", ValorCuerpo = 1, idioma = "Castellano", Valoridioma = 1, forma = "Cuadrado", formas = "Cuadrados", area = "Area", perimetro = " Perimetro", header = "Reporte de Formas" });
            cuerpo.Add(new Formas { cuerpo = "Cuadrado", ValorCuerpo = 1, idioma = "Ingles", Valoridioma = 2, forma = "Square", formas = "Squares", area = "Area", perimetro = "Perimeter", header = "Shapes report" });
            cuerpo.Add(new Formas { cuerpo = "Cuadrado", ValorCuerpo = 1, idioma = "Frances", Valoridioma = 3, forma = "Carré", formas = "Des carrés", area = "Zone", perimetro = "Périmètre", header = "Rapport de formulaires" });

            cuerpo.Add(new Formas { cuerpo = "TrianguloEquilatero", ValorCuerpo = 2, idioma = "Castellano", Valoridioma = 1, forma = "Triángulo", formas = "Triángulos", area = "Area", perimetro = " Perimetro", header = "Reporte de Formas" });
            cuerpo.Add(new Formas { cuerpo = "TrianguloEquilatero", ValorCuerpo = 2, idioma = "Ingles", Valoridioma = 2, forma = "Triangle", formas = "Triangles", area = "Area", perimetro = "Perimeter", header = "Shapes report" });
            cuerpo.Add(new Formas { cuerpo = "TrianguloEquilatero", ValorCuerpo = 2, idioma = "Frances", Valoridioma = 3, forma = "Triangle", formas = "Triangles", area = "Zone", perimetro = "Périmètre", header = "Rapport de formulaires" });

            cuerpo.Add(new Formas { cuerpo = "Circulo", ValorCuerpo = 3, idioma = "Castellano", Valoridioma = 1, forma = "Circulo", formas = "Circulos", area = "Area", perimetro = " Perimetro", header = "Reporte de Formas" });
            cuerpo.Add(new Formas { cuerpo = "Circulo", ValorCuerpo = 3, idioma = "Ingles", Valoridioma = 2, forma = "Circle", formas = "Circles", area = "Area", perimetro = "Perimeter", header = "Shapes report" });
            cuerpo.Add(new Formas { cuerpo = "Circulo", ValorCuerpo = 3, idioma = "Frances", Valoridioma = 3, forma = "Cercle", formas = "Cercles", area = "Zone", perimetro = "Périmètre", header = "Rapport de formulaires" });

            cuerpo.Add(new Formas { cuerpo = "Trapecio", ValorCuerpo = 4, idioma = "Castellano", Valoridioma = 1, forma = "Trapecio", formas = "Trapecios", area = "Area", perimetro = " Perimetro", header = "Reporte de Formas" });
            cuerpo.Add(new Formas { cuerpo = "Trapecio", ValorCuerpo = 4, idioma = "Ingles", Valoridioma = 2, forma = "Trapeze", formas = "Trapezes", area = "Area", perimetro = "Perimeter", header = "Shapes report" });
            cuerpo.Add(new Formas { cuerpo = "Trapecio", ValorCuerpo = 4, idioma = "Frances", Valoridioma = 3, forma = "Trapèze", formas = "Trapèze", area = "Zone", perimetro = "Périmètre", header = "Rapport de formulaires" });

            cuerpo.Add(new Formas { cuerpo = "Rectangulo", ValorCuerpo = 5, idioma = "Castellano", Valoridioma = 1, forma = "Rectangulo", formas = "Rectangulos", area = "Area", perimetro = " Perimetro", header = "Reporte de Formas" });
            cuerpo.Add(new Formas { cuerpo = "Rectangulo", ValorCuerpo = 5, idioma = "Ingles", Valoridioma = 2, forma = "Rectangle", formas = "Rectangles", area = "Area", perimetro = "Perimeter", header = "Shapes report" });
            cuerpo.Add(new Formas { cuerpo = "Rectangulo", ValorCuerpo = 5, idioma = "Frances", Valoridioma = 3, forma = "Rectangle", formas = "Rectangles", area = "Zone", perimetro = "Périmètre", header = "Rapport de formulaires" });
            return cuerpo;

        }
    }
}
