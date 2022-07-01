using System;
using System.Collections.Generic;
using System.Globalization;
using Project02.Entities;

namespace Project02 {
   internal class Program {
      static void Main( string[ ] args ) {

         // Input datas
         Console.Write( "Enter the number of employees: " );
         // number of employees
         int _numEmply = int.Parse(Console.ReadLine());
         Console.WriteLine();

         // employees
         List<Employee> employees = new List<Employee>();
         for ( int i = 1; i <= _numEmply; i++ ) {

            Console.WriteLine( $"Employee #{i} data:" );
            // is Outsourced??
            Console.Write( "Outsourced (y/n)? " );
            bool outSourced = Console.ReadLine() == "y";
            // name
            Console.Write( "Name: " );
            string name = Console.ReadLine();
            // hours
            Console.Write( "Hours: " );
            int hours = int.Parse(Console.ReadLine());
            // value per hour
            Console.Write( "Value per hour: $" );
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ( outSourced ) {

               // additional charge
               Console.Write( "Additional Charge: $" );
               double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               // Instantiation
               employees.Add( new OutsourcedEmployee( name , hours , valuePerHour , additionalCharge ) );
            } else {
               employees.Add( new Employee( name , hours , valuePerHour ) );
            }

            Console.WriteLine();
         }

         // Outputs
         Console.WriteLine( "PAYMENTS:" );
         foreach ( Employee e in employees ) {
            Console.WriteLine( e );
         }
      }
   }
}
