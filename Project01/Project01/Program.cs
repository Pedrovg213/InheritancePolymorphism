using System;
using Project01.Entities;

namespace Project01 {
   internal class Program {
      static void Main( string[ ] args ) {

         Account account = new Account(1001, "José", 700.00);
         BusinessAccount bAccount = new BusinessAccount(1010, "João", 5000.00, 1000.0);
         SavingsAccount sAccount = new SavingsAccount(1101, "Ana", 400, .2);

         // UPCASTING

         Account account01 = bAccount;
         Account account02 = sAccount;

         Console.WriteLine( account01.Holder );
         Console.WriteLine( account02.Holder );

         // DOWNCASTING

         if ( account01 is BusinessAccount ) {

            //BusinessAccount business01 = (BusinessAccount)account01;
            BusinessAccount bAccount01 = account01 as BusinessAccount;

            bAccount01.Loan( 100 );

            Console.WriteLine( bAccount01.Balance );
         }
         if ( account02 is BusinessAccount ) {

            BusinessAccount bAccount01 = account02 as BusinessAccount;

            bAccount01.Loan( 200 );

            Console.WriteLine( bAccount01.Balance );
         }
      }
   }
}
