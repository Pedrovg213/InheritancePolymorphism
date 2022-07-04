using System;
using System.Collections.Generic;
using System.Globalization;
using Project05.Entities;

namespace Project05 {
   internal class Program {
      static void Main( string[ ] args ) {

         // Inputs
         // num of tax payers
         Console.Write( "Enter the number of tax payers: " );
         int numTaxPayer = int.Parse(Console.ReadLine());
         Console.WriteLine();

         // Tax payers data
         List<TaxPayer> taxPayers = new List<TaxPayer>();
         for ( int i = 1; i <= numTaxPayer; i++ ) {

            Console.WriteLine( $"Tax payer #{i} data:" );
            // is individual?
            Console.Write( "Individual or company (i/c)? " );
            bool isIndividual = char.Parse(Console.ReadLine()) == 'i';
            // name
            Console.Write( "Name: " );
            string name = Console.ReadLine();
            // anual incomes
            Console.Write( "Anual income: " );
            double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Individual
            if ( isIndividual ) {

               // health expenditures:
               Console.Write( "Health expenditures: " );
               double healthExpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               // Instantiation
               taxPayers.Add( new Individual( name , anualIncome , healthExpend ) );
            } else { // Company

               // Number of Employees
               Console.Write( "Number of employees: " );
               int numEmployees = int.Parse(Console.ReadLine());

               // Instantiation
               taxPayers.Add( new Company( name , anualIncome , numEmployees ) );
            }

            Console.WriteLine();
         }

         // Outputs
         double sum = 0;
         Console.WriteLine( "TAXES PAID:" );
         foreach ( TaxPayer tp in taxPayers ) {
            Console.WriteLine( tp );
            sum += tp.Tax();
         }
         Console.WriteLine();
         // Total taxes
         Console.WriteLine( "TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture) );
      }
   }
}
