using Project04.Entities.Enums;

namespace Project04.Entities {
   abstract class Shape {

      public Color Color {
         get; set;
      }

      
      public Shape( Color _color ) {
         
         Color = _color;
      }


      public abstract double Area( );
   }
}
