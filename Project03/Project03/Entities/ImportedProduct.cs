using System.Globalization;

namespace Project03.Entities {
   internal class ImportedProduct : Product {

      public double CustomsFee {
         get; private set;
      }


      public ImportedProduct( ) {
      }
      public ImportedProduct( string _name , double _price , double _customsFee ) :
         base( _name , _price ) {

         CustomsFee = _customsFee;
      }


      public override string PriceTag( ) {
         
         return base.PriceTag() +
            $" (Customs fee: ${CustomsFee.ToString( "F2" , CultureInfo.InstalledUICulture )})";
      }
      public override double TotalPrice( ) {
         
         return base.TotalPrice() + CustomsFee;
      }
   }
}
