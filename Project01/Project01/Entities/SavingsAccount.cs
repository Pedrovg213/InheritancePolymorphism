
namespace Project01.Entities {
   internal class SavingsAccount : Account {
      public double InterestRate {
         get; set;
      }


      public SavingsAccount( ) {
      }
      public SavingsAccount( int _number , string _holder , double _balance , double _interestRate ) :
         base( _number , _holder , _balance ) {

         InterestRate = _interestRate;
      }


      public void UpdateBalance( ) {

         Balance += Balance * InterestRate;
      }
   }
}
