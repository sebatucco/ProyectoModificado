/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        #region Formas

        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;
        public const int Rectangulo = 5;

        #endregion

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Frances = 3;

        #endregion

        private readonly decimal _lado;
        private readonly decimal _lado1;
        private readonly decimal _alto;

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }

        public FormaGeometrica(int tipo, decimal ancho, decimal ancho1)
        {
            Tipo = tipo;
            _lado = ancho;
            _lado1 = ancho1;

        }

        public FormaGeometrica(int tipo, decimal ancho, decimal ancho1, decimal alto)
        {
            Tipo = tipo;
            _lado = ancho;
            _lado1 = ancho1;
            _alto = alto;
        }


        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();
            var cuerpo = Metodos.CargarLista();
            Formas _forma = new Formas();
            String _header = null;


            for (var j = 0; j < cuerpo.Count; j++)
            {
                if (idioma == cuerpo[j].Valoridioma)
                {
                    _header = cuerpo[j].header;
                    break;
                }
            }


            if (!formas.Any())
            {
                sb.Append("<h1>" + _header + "!</h1>");

                /* if (idioma == Castellano)
                     sb.Append("<h1>Lista vacía de formas!</h1>");
                 else
                     sb.Append("<h1>Empty list of shapes!</h1>");*/
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append("<h1>" + _header + "!</h1>");
                /*if (idioma == Castellano)
                      sb.Append("<h1>Reporte de Formas</h1>");
                  else
                      // default es inglés
                      sb.Append("<h1>Shapes report</h1>");*/

                var areaGenerico = 0m;
                var perimetroGenerico = 0m;

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;
                var numeroRectangulos = 0;
                var numeroTrapecios = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;
                var areaRectangulos = 0m;
                var areaTrapecios = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;
                var perimetroRectangulos = 0m;
                var perimetroTrapecios = 0m;

                for (var i = 0; i < formas.Count; i++)
                {
                    for (var j = 0; j < cuerpo.Count; j++)
                    {
                        if (formas[i].Tipo == cuerpo[j].ValorCuerpo && idioma == cuerpo[j].Valoridioma)
                        {
                            areaGenerico = formas[i].CalcularArea();
                            perimetroGenerico = formas[i].CalcularPerimetro();
                        }
                    }

                    if (formas[i].Tipo == Cuadrado)
                    {
                        numeroCuadrados++;
                        areaCuadrados += formas[i].CalcularArea();
                        perimetroCuadrados += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == Circulo)
                    {
                        numeroCirculos++;
                        areaCirculos += formas[i].CalcularArea();
                        perimetroCirculos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == TrianguloEquilatero)
                    {
                        numeroTriangulos++;
                        areaTriangulos += formas[i].CalcularArea();
                        perimetroTriangulos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == Rectangulo)
                    {
                        numeroRectangulos++;
                        areaRectangulos += areaGenerico;
                        perimetroRectangulos += perimetroGenerico;
                    }
                    if (formas[i].Tipo == Trapecio)
                    {
                        numeroTrapecios++;
                        areaTrapecios += areaGenerico;
                        perimetroTrapecios += perimetroGenerico;
                    }
                }

                /*sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, Cuadrado, idioma));
                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, Circulo, idioma));
                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TrianguloEquilatero, idioma));*/

                sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, Cuadrado, idioma, cuerpo));
                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, Circulo, idioma, cuerpo));
                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TrianguloEquilatero, idioma, cuerpo));
                sb.Append(ObtenerLinea(numeroRectangulos, areaRectangulos, perimetroRectangulos, Rectangulo, idioma, cuerpo));
                sb.Append(ObtenerLinea(numeroTrapecios, areaTrapecios, perimetroTrapecios, Trapecio, idioma, cuerpo));

               

                // FOOTER
                sb.Append("TOTAL:<br/>");
                /*sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + (idioma == Castellano ? "formas" : "shapes") + " ");
                sb.Append((idioma == Castellano ? "Perimetro " : "Perimeter ") + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));*/
                for (var i = 0; i < formas.Count; i++)
                {
                    for (var j = 0; j < cuerpo.Count; j++)
                    {
                        if (idioma == cuerpo[j].Valoridioma && formas[i].Tipo == cuerpo[j].ValorCuerpo)
                        {
                            sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroRectangulos + numeroTrapecios + " " + _forma.formas + " ");
                            sb.Append(_forma.perimetro + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroRectangulos + perimetroTrapecios).ToString("#.##") + " ");
                            sb.Append(_forma.area + (areaCuadrados + areaCirculos + areaTriangulos + areaRectangulos + areaTrapecios).ToString("#.##"));
                        }
                    }
                }
            }

            return sb.ToString();
        }

        /*private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma)
        {
            if (cantidad > 0)
            {
                if (idioma == Castellano)
                    return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

                return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }*/

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma, List<Formas> p_cuerpo)
        {
            if (cantidad > 0)
            {
                for (var j = 0; j < p_cuerpo.Count; j++)
                {
                    if (idioma == p_cuerpo[j].Valoridioma && tipo == p_cuerpo[j].ValorCuerpo)
                    {
                        return $"{cantidad} {TraducirForma(cantidad, p_cuerpo[j])} | {p_cuerpo[j].area} {area:#.##} | {p_cuerpo[j].perimetro} {perimetro:#.##} <br/>";
                    }

                }

            }

            return string.Empty;
        }

        /*private static string TraducirForma(int tipo, int cantidad, int idioma)
        {
            switch (tipo)
            {
                case Cuadrado:
                    if (idioma == Castellano) return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    else return cantidad == 1 ? "Square" : "Squares";
                case Circulo:
                    if (idioma == Castellano) return cantidad == 1 ? "Círculo" : "Círculos";
                    else return cantidad == 1 ? "Circle" : "Circles";
                case TrianguloEquilatero:
                    if (idioma == Castellano) return cantidad == 1 ? "Triángulo" : "Triángulos";
                    else return cantidad == 1 ? "Triangle" : "Triangles";
            }

            return string.Empty;
        }*/

        private static string TraducirForma(int cantidad, Formas p_forma)
        {
            return cantidad == 1 ? p_forma.forma : p_forma.formas;
        }


        public decimal CalcularArea()
        {
            switch (Tipo)
            {
                case Cuadrado: return _lado * _lado;
                case Circulo: return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
                case TrianguloEquilatero: return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
                case Trapecio: return ((decimal)Math.Sqrt(3) / 4) * (_alto * (_lado + _lado1) / 2);
                case Rectangulo: return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado1;

                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }

        public decimal CalcularPerimetro()
        {
            switch (Tipo)
            {
                case Cuadrado: return _lado * 4;
                case Circulo: return (decimal)Math.PI * _lado;
                case TrianguloEquilatero: return _lado * 3;
                case Trapecio: return perimetroTrapecio(_lado, _lado1, _alto);
                case Rectangulo: return (_lado * 2) + (_lado1 * 2);
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }

        public decimal perimetroTrapecio(decimal p_lado, decimal p_lado1, decimal p_altura)
        {
            decimal aux;
            decimal n;
            decimal i;

            if (p_lado < p_lado1)
            {
                aux = p_lado1;
                p_lado1 = p_lado;
                p_lado = aux;
            }
            n = (p_lado - p_lado1) / 2;
            i = (decimal)Math.Pow((Math.Pow((double)n, 2) + Math.Pow((double)p_altura, 2)), 1 / 2);
            return p_lado + p_lado1 + (2 * i);

        }
    }
}
