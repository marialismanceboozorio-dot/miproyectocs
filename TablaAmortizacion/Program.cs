
using Spectre.Console;

decimal montoPrestamo = AnsiConsole.Ask<decimal>(
    "ingrese el monto del prestamo:");

decimal interesesAnual = AnsiConsole.Ask<decimal>(
    "ingrese la tasa de interes anual (%):");

int plazoMeses = AnsiConsole.Ask<int>(
    "ingrese el plazo del prestamo en meses:");

decimal tasaMensual = interesesAnual / 12 / 100;

double potencia = Math.Pow(
    (double)(1 + tasaMensual),
    plazoMeses);

decimal cuota = 
   montoPrestamo * 
   (tasaMensual * (decimal)potencia)
   /

   ((decimal)potencia - 1);

   var tabla = new Table();

   tabla.Border(TableBorder.Rounded);

   tabla.AddColumn("Mes");
   tabla.AddColumn("Pago");
   tabla.AddColumn("Interes");
   tabla.AddColumn("Abono Capital");
   tabla.AddColumn("Saldo");

   decimal Saldo = montoPrestamo;

   for (int mes = 1; mes <= plazoMeses; mes++)
   {
       decimal interes = Saldo * tasaMensual;
       
       decimal abonoCapital = cuota - interes;

       Saldo -= abonoCapital;

       if (Saldo < 0 )
       {

           Saldo = 0;

       }

       tabla.AddRow( 
           mes.ToString(),
           cuota.ToString("N2"),
           interes.ToString("N2"),
           abonoCapital.ToString("N2"),
           Saldo.ToString("N2")

       );

}

AnsiConsole.Write(tabla);