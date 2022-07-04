using System.Globalization;

namespace Project05.Entities {
   internal class Company : TaxPayer {

      public int NumEmployees {
         get; private set;
      }


      public Company( string _name , double _anualIncome , int _numEmployeers ) :
         base( _name , _anualIncome ) {

         NumEmployees = _numEmployeers;
      }


      public override double Tax( ) {

         double tax = NumEmployees > 10 ? .14 : .16;

         return AnualIncome * tax;
      }
   }
}
