using System;
using System.Globalization;

namespace Project03.Entities {
   internal class UsedProduct : Product {

      public DateTime ManufactureDate {
         get; private set;
      }


      public UsedProduct( ) {
      }
      public UsedProduct( string _name , double _price , DateTime _manufactureDate ) :
         base( _name , _price ) {

         ManufactureDate = _manufactureDate;
      }


      public override string PriceTag( ) {
         return $"{Name} (used): ${Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
            $"(Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
      }
   }
}
