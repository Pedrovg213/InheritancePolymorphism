
namespace Project02.Entities {
   internal class OutsourcedEmployee : Employee {

      public double AdditionalCharge {
         get; set;
      }


      public OutsourcedEmployee( ) {
      }
      public OutsourcedEmployee( string _name , int _hours , double _valuePerHour , double additionalCharge ) :
         base( _name , _hours , _valuePerHour ) {

         AdditionalCharge = additionalCharge;
      }


      public override double Payment( ) {

         return base.Payment() + ( 1.1 * AdditionalCharge );
      }
   }
}
