using System;
using System.Collections.Generic;
using System.Globalization;
using Project03.Entities;

namespace Project03 {
   internal class Program {
      static void Main( string[ ] args ) {

         // Inputs
         // number os products
         Console.Write( "Enter the number of products: " );
         int _numProducts = int.Parse(Console.ReadLine());
         Console.WriteLine();

         // Products data
         List<Product> products = new List<Product>();
         for ( int i = 1; i <= _numProducts; i++ ) {

            // type
            Console.WriteLine( $"Product #{i} data:" );
            Console.Write( "Commum, used or imported (c/u/i)? " );
            char productType = char.Parse(Console.ReadLine());
            // name
            Console.Write( "Name: " );
            string name = Console.ReadLine();
            // price
            Console.Write( "Price: $" );
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            switch ( productType ) {
               case 'u':
                  // manufacture date
                  Console.Write( "Manufacture date (dd/mm/yyyy): " );
                  DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                  // Instantiation
                  products.Add( new UsedProduct( name , price , manufactureDate ) );
                  break;

               case 'i':
                  // custom fee
                  Console.Write( "Custom fee: $" );
                  double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                  // Instantiation
                  products.Add( new ImportedProduct( name , price , customFee ) );
                  break;

               default:
                  // Instantiation
                  products.Add( new Product( name , price ) );
                  break;
            }

            Console.WriteLine();
         }

         // Output
         Console.WriteLine( "PRICE TAGS:" );
         foreach ( Product p in products )
            Console.WriteLine( p );
         double sum = 0;
         foreach ( Product p in products )
            sum += p.TotalPrice();

         Console.Write( "Total Price: $" + sum.ToString( "F2" , CultureInfo.InvariantCulture ) );
      }
   }
}
