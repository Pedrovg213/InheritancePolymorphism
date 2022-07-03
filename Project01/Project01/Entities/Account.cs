
namespace Project01.Entities {
   abstract internal class Account {
      public int Number {
         get; set;
      }
      public string Holder {
         get; set;
      }
      public double Balance {
         get; protected set;
      }


      public Account( ) {
      }
      public Account( int _number , string _holder , double _balance ) {

         Number = _number;
         Holder = _holder;
         Balance = _balance;
      }


      public virtual void WithDraw( double _amount ) {

         Balance -= ( _amount + 5 );
      }
      public void Deposit( double _amount ) {

         Balance += _amount;
      }
   }
}
