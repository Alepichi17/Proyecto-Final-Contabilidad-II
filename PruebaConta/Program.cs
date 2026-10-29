using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Claims;

namespace PruebaConta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Opcion;
            decimal CostoVariableProduccion = 1;
            decimal CostoVariableVentaAdmon = 1;
            decimal PrecioVenta = 1;
            decimal CostosFijosProduccion = 1;
            decimal CostosFijosVentaAdmon = 1;
            decimal GananciaDeseada = 1;
            do
            {
                Opcion = Menu();

                switch (Opcion)
                {
                    case "1":
                        IngresarDatos(ref CostoVariableProduccion, ref CostoVariableVentaAdmon,
                            ref PrecioVenta, ref CostosFijosProduccion, ref CostosFijosVentaAdmon, ref GananciaDeseada);
                        break;
                    case "2":
                        ActualizarDatos(ref CostoVariableProduccion, ref CostoVariableVentaAdmon,
                            ref PrecioVenta, ref CostosFijosProduccion, ref CostosFijosVentaAdmon, ref GananciaDeseada);
                        break;
                    case "3":
                        EstadoDeResultados(CostoVariableProduccion, CostoVariableVentaAdmon,
                            PrecioVenta, CostosFijosProduccion, CostosFijosVentaAdmon, GananciaDeseada);
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del Programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;
                }
            }
            while (Opcion != "4");
        }
        public static string Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Punto De Equilibrio");
            Console.WriteLine("Opcion 1: Ingresar Datos");
            Console.WriteLine("Opcion 2: Actualizar Datos");
            Console.WriteLine("Opcion 3: Estado de Resultados");
            Console.WriteLine("Opcion 4: Salir");
            Console.Write("Escoje Una Opcion: ");
            return Console.ReadLine();
        }
        public static void IngresarDatos(ref decimal CostoVariableProduccion,
            ref decimal CostoVariableVentaAdmon, ref decimal PrecioVenta,
            ref decimal CostosFijosProduccion, ref decimal CostosFijosVentaAdmon, ref decimal GananciaDeseada)
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese Los Datos");
            Console.Write("Costos Variable de Produccion: Q");
            decimal.TryParse(Console.ReadLine(), out CostoVariableProduccion);
            Console.Write("Costos Variable de Venta y Administracion: Q");
            decimal.TryParse(Console.ReadLine(), out CostoVariableVentaAdmon);
            Console.Write("Precio Venta: Q");
            decimal.TryParse(Console.ReadLine(), out PrecioVenta);
            Console.Write("Costos Fijos Produccion: Q");
            decimal.TryParse(Console.ReadLine(), out CostosFijosProduccion);
            Console.Write("Costos Fijos Venta y Administracion: Q");
            decimal.TryParse(Console.ReadLine(), out CostosFijosVentaAdmon);
            Console.Write("Ingrese la ganancia deseada: [Ingrese 0 para punto de equilibrio puro]: ");
            decimal.TryParse(Console.ReadLine(), out GananciaDeseada);

            

        }
        public static void ActualizarDatos(ref decimal CostoVariableProduccion,
            ref decimal CostoVariableVentaAdmon, ref decimal PrecioVenta,
            ref decimal CostosFijosProduccion, ref decimal CostosFijosVentaAdmon, ref decimal GananciaDeseada)
        {
            Console.WriteLine();
            Console.WriteLine("Que Dato necesitas Cambiar?");
            Console.WriteLine("//Costos Variables//");
            Console.WriteLine("Opcion 1: Costo Variable de Produccion");
            Console.WriteLine("Opcion 2: Costo Variable de Ventas y Administracion");
            Console.WriteLine("*********************");
            Console.WriteLine("Opcion 3: Precio de Venta");
            Console.WriteLine("*********************");
            Console.WriteLine("//Costos Fijos//");
            Console.WriteLine("Opcion 4: Costos Fijos de Produccion");
            Console.WriteLine("Opcion 5: Costos Fijos de Ventas y Administracion");
            Console.WriteLine("Opcion 6: Ganancia Deseada");
            Console.Write("Escoja Una Opcion: ");
            string Opcion = Console.ReadLine();

            switch (Opcion)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine($"Valor Actual: {CostoVariableProduccion:N2}");
                    Console.WriteLine();
                    Console.Write("Nuevo Costos Variable de Produccion: ");
                    decimal.TryParse(Console.ReadLine(), out CostoVariableProduccion);
                    Console.WriteLine(CostoVariableProduccion > 0 ? "Actualizado" : "Dato no Validos");
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine($"Valor Actual: {CostoVariableVentaAdmon:N2}");
                    Console.WriteLine();
                    Console.Write("Nuevo Costos Variable de Ventas y Administracion: ");
                    decimal.TryParse(Console.ReadLine(), out CostoVariableVentaAdmon);
                    Console.WriteLine(CostoVariableVentaAdmon > 0 ? "Actualizado" : "Dato no Validos");
                    break;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine($"Valor Actual: {PrecioVenta:N2}");
                    Console.WriteLine();
                    Console.Write("Nuevo Precio Venta: ");
                    decimal.TryParse(Console.ReadLine(), out PrecioVenta);
                    Console.WriteLine(PrecioVenta > 0 ? "Actualizado" : "Dato no Validos");
                    break;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine($"Valor Actual: {CostosFijosProduccion:N2}");
                    Console.WriteLine();
                    Console.Write("Nuevo Costos Fijos de Produccion: ");
                    decimal.TryParse(Console.ReadLine(), out CostosFijosProduccion);
                    Console.WriteLine(CostosFijosProduccion > 0 ? "Actualizado" : "Dato no Validos");
                    break;
                case "5":
                    Console.WriteLine();
                    Console.WriteLine($"Valor Actual: {CostosFijosVentaAdmon:N2}");
                    Console.WriteLine();
                    Console.Write("Nuevo Costos Fijos de Venta y Administracion: ");
                    decimal.TryParse(Console.ReadLine(), out CostosFijosVentaAdmon);
                    Console.WriteLine(CostosFijosVentaAdmon > 0 ? "Actualizado" : "Dato no Validos");
                    break;
                case "6":
                    Console.WriteLine();
                    Console.WriteLine($"Valor Actual: {GananciaDeseada:N2}");
                    Console.WriteLine();
                    Console.Write("Ganancia Deseada: ");
                    decimal.TryParse(Console.ReadLine(), out GananciaDeseada);
                    Console.WriteLine(GananciaDeseada > 0 ? "Actualizado" : "Dato no Validos");
                    break;
            }
        }
        public static void EstadoDeResultados(decimal CostoVariableProduccion, decimal CostoVariableVentaAdmon,
                            decimal PrecioVenta, decimal CostosFijosProduccion, decimal CostosFijosVentaAdmon, decimal GananciaDeseada)
        {
            decimal TotalFijos = CostosFijosProduccion + CostosFijosVentaAdmon;
            decimal TotalVariables = CostoVariableProduccion + CostoVariableVentaAdmon;
            decimal VentaVariable = PrecioVenta - TotalVariables;
            decimal PuntoDeEquilibrioUnidades = (TotalFijos + GananciaDeseada) / VentaVariable;
            decimal Ventas = PrecioVenta * PuntoDeEquilibrioUnidades;
            decimal Produccion = CostoVariableProduccion * PuntoDeEquilibrioUnidades;
            decimal VentaAdmon = CostoVariableVentaAdmon * PuntoDeEquilibrioUnidades;
            decimal SumaVariables = Produccion + VentaAdmon;
            decimal MargenContribucion = Ventas - SumaVariables;
            decimal GananciaPerdida = MargenContribucion - TotalFijos;
            Console.WriteLine("======Estado De Resultados======");
            Console.WriteLine($"PuntoDeEquilibrio Unidades: {PuntoDeEquilibrioUnidades,25:N2}");
            Console.WriteLine("Ingresos");
            Console.WriteLine($"Ingreso de Ventas:          {Ventas,25:N2}");
            Console.WriteLine($"(-)Costo de Ventas");
            Console.WriteLine($"Costos Variables");
            Console.WriteLine($"Produccion:                 {Produccion,25:N2}");
            Console.WriteLine($"Venta y Administracion:     {VentaAdmon,25:N2}");
            Console.WriteLine("=====================================================");
            Console.WriteLine($"Margen de constribucion:    {MargenContribucion,25:N2}");
            Console.WriteLine($"(-)Costos Fijos");
            Console.WriteLine($"Produccion:                 {CostosFijosProduccion,25:N2}");
            Console.WriteLine($"Venta y Administracion:     {CostosFijosVentaAdmon,25:N2}");
            Console.WriteLine("=====================================================");
            Console.WriteLine($"Ganancia/Perdida:           {GananciaPerdida,25:N2}");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"Para Tener Una Ganancia de Q{GananciaPerdida:N2} Debes Vender: {PuntoDeEquilibrioUnidades:N0} Unidades a Un Precio de Q{PrecioVenta} Tomando Los Costos Variables y Fijos Actuales");

        }
    }
}