
namespace Project05.Entities {
   internal class Individual : TaxPayer {

      public double HealthExpend {
         get; private set;
      }


      public Individual( string _name , double _anualIncome , double _helthExpend ) :
         base( _name , _anualIncome ) {
         
         HealthExpend = _helthExpend;
      }


      public override double Tax( ) {

         double tax = AnualIncome < 20000 ? .15 : .25;

         return ( AnualIncome * tax ) - ( HealthExpend * .5 );
      }
   }
}
