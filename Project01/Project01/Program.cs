using System;
using Project01.Entities;

namespace Project01 {
   internal class Program {
      static void Main( string[ ] args ) {

         Account account01 = new Account(1001, "Jon", 500);
         Account account02 = new SavingsAccount(1010, "Anna", 500, .01);
         Account account03 = new BusinessAccount(1100, "Algusto", 500, 300);

         account01.WithDraw( 20 );
         account02.WithDraw( 20 );
         account03.WithDraw( 20 );

         Console.WriteLine( account01.Balance );
         Console.WriteLine( account02.Balance );
         Console.WriteLine( account03.Balance );
      }
   }
}
