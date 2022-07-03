using Project04.Entities.Enums;

namespace Project04.Entities {
   internal class Rectangle : Shape {

      public double Width {
         get; set;
      }
      public double Height {
         get; set;
      }


      public Rectangle(double _width, double _height, Color _color) : 
         base( _color ) {

         Width = _width;
         Height = _height;
      }


      public override double Area( ) {

         return Width * Height;
      }
   }
}
