using System;
using Project04.Entities.Enums;

namespace Project04.Entities {
   internal class Circle : Shape {

      public double Radius {
         get; set;
      }


      public Circle( double _radius , Color _color ) :
         base( _color ) {

         Radius = _radius;
      }


      public override double Area( ) {
         return Math.PI * Radius * Radius;
      }
   }
}
