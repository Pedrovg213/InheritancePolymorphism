using System.Globalization;

namespace Project02.Entities {
   internal class Employee {

      public string Name {
         get; set;
      }
      public int Hours {
         get; set;
      }
      public double ValuePerHour {
         get; set;
      }


      public Employee( ) {
      }
      public Employee( string _name , int _hours , double _valuePerHour ) {

         Name = _name;
         Hours = _hours;
         ValuePerHour = _valuePerHour;
      }


      public virtual double Payment( ) {

         return Hours * ValuePerHour;
      }


      public override string ToString( ) {
         return $"{Name} - ${Payment().ToString( "F2" , CultureInfo.InvariantCulture )}";
      }
   }
}
