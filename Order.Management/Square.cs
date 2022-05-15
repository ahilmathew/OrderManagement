using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Square : Shape
    {
        // Unnecessary Variable
        public int SquarePrice = 1;

        public Square(int numberOfRedSquares, int numberOfBlueSquares, int numberOfYellowSquares)
        {
            Name = "Square";
            //base.Price = SquarePrice;
            base.Price = 1;
            AdditionalCharge = 1;
            base.NumberOfRedShape = numberOfRedSquares;
            base.NumberOfBlueShape = numberOfBlueSquares;
            base.NumberOfYellowShape = numberOfYellowSquares;
        }

        public override int Total()
        {
            return ShapeTotal(base.NumberOfRedShape) + ShapeTotal(base.NumberOfBlueShape)
                    + ShapeTotal(base.NumberOfYellowShape);
        }
        // AM:
        // All the below methods should have been private since these are only used in this class.
        // All methods do the same operation. Can be done in a single method with parameter.
        // Same for other shapes.
        private int ShapeTotal(int quantity)
        {
            return (quantity * base.Price);
        }
        //public int RedSquaresTotal()
        //{
        //    return (base.NumberOfRedShape * Price);
        //}
        //public int BlueSquaresTotal()
        //{
        //    return (base.NumberOfBlueShape * Price);
        //}
        //public int YellowSquaresTotal()
        //{
        //    return (base.NumberOfYellowShape * Price);
        //}
    }
}
