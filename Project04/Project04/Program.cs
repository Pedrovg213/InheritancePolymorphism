using System;
using System.Collections.Generic;
using System.Globalization;
using Project04.Entities;
using Project04.Entities.Enums;

namespace Project04 {
   internal class Program {
      static void Main( string[ ] args ) {

         // Inputs
         // shapes quantity
         Console.WriteLine( "Enter the number of shapes: " );
         int shapesNum = int.Parse(Console.ReadLine());

         // Shapes data
         List<Shape> list = new List<Shape>();
         for ( int i = 1; i <= shapesNum; i++ ) {

            // Rectangle or Circle
            Console.WriteLine( $"Shape #{i} data:" );
            Console.WriteLine( "Rectangle or Circle (r/c)? " );
            bool isRec = char.Parse(Console.ReadLine()) == 'r';
            // Color
            Console.WriteLine( "Colar (Black / Blue / Red / Green / Gray / Yellow): " );
            Color color = (Color)Enum.Parse(typeof (Color), Console.ReadLine());

            if ( isRec ) {
               // width
               Console.Write( "Width: " );
               double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               // height
               Console.Write( "Height: " );
               double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               // Instantiation
               list.Add( new Rectangle( width , height , color ) );
            } else {
               // Radius
               Console.Write( "Radius: " );
               double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               // Instantiation
               list.Add( new Circle( radius , color ) );
            }

            Console.WriteLine();
         }

         // Output
         // Areas
         Console.WriteLine( "SHAPE AREAS:" );
         foreach ( Shape sh in list ) {
            Console.WriteLine( sh.Area().ToString( "F2" , CultureInfo.InvariantCulture ) );
         }
      }
   }
}
