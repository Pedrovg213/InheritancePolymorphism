using System.Globalization;

namespace Project05.Entities {
   abstract internal class TaxPayer {

      public string Name {
         get; protected set;
      }
      public double AnualIncome {
         get; protected set;
      }


      public TaxPayer( string _name, double _anualIncome ) {

         Name = _name;
         AnualIncome = _anualIncome;
      }


      public abstract double Tax( );


      public override string ToString( ) {

         return $"{Name}: ${Tax().ToString( "F2" , CultureInfo.InvariantCulture )}";
      }
   }
}
