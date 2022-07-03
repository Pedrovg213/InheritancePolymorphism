using System.Globalization;

namespace Project03.Entities {
   internal class Product {

      public string Name {
         get; protected set;
      }
      public double Price {
         get; protected set;
      }


      public Product( ) {
      }
      public Product( string _name , double _price ) {

         Name = _name;
         Price = _price;
      }


      public virtual string PriceTag( ) {

         return $"{Name}: ${Price.ToString( "F2" , CultureInfo.InvariantCulture )}";
      }
      public virtual double TotalPrice( ) {
         
         return Price;
      }


      public override string ToString( ) {
        
         return PriceTag();
      }
   }
}
