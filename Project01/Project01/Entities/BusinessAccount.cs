
namespace Project01.Entities {
   internal class BusinessAccount : Account {
      public double LoanLimit {
         get; set;
      }


      public BusinessAccount( ) {
      }
      public BusinessAccount( int _number , string _holder , double _balance , double _loanLimit ) :
         base( _number , _holder , _balance ) {

         LoanLimit = _loanLimit;
      }


      public void Loan( double _amount ) {

         if ( _amount <= LoanLimit )
            Balance += _amount;
      }


      public override void WithDraw( double _amount ) {

         base.WithDraw( _amount );
         Balance -= 2;
      }
   }
}
