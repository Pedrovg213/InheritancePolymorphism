using System;
using System.Collections.Generic;
using System.Globalization;
using Project01.Entities;

namespace Project01 {
   internal class Program {
      static void Main( string[ ] args ) {

         List<Account> list = new List<Account>();

         list.Add( new BusinessAccount( 1001 , "João" , 500.00 , 300.00 ) );
         list.Add( new SavingsAccount( 1010 , "Marcos" , 1000 , .03 ) );
         list.Add( new BusinessAccount( 1002 , "Arthur" , 700 , 400 ) );
         list.Add( new SavingsAccount( 1020 , "Pedro" , 2500 , .05 ) );

         double sum = 0;
         foreach ( Account a in list )
            sum += a.Balance;
         Console.WriteLine( "TOTAL:" );
         Console.WriteLine( sum.ToString( "F2" , CultureInfo.InvariantCulture ) );

         sum = 0;
         foreach ( Account a in list ) {
            a.WithDraw( 50 );
            sum += a.Balance;
         }
         Console.WriteLine( "Withdraw:" );
         Console.WriteLine( sum.ToString( "F2" , CultureInfo.InvariantCulture ) );
      }
   }
}
