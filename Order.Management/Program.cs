using System;
using System.Collections.Generic;

namespace Order.Management
{
    class Program
    {
        // Main entry
        static void Main(string[] args)
        {
            var (customerName, address, dueDate) = CustomerInfoInput();

            var orderedShapes = CustomerOrderInput();

            // Use factory pattern for generating reports.
            GetReports(customerName, address, dueDate, orderedShapes);
            // InvoiceReport(customerName, address, dueDate, orderedShapes);

            // CuttingListReport(customerName, address, dueDate, orderedShapes);

            // PaintingReport(customerName, address, dueDate, orderedShapes);
        }
        private static (int red, int blue, int yellow) ShapeInput(string shape)
        {
            Console.Write($"\nPlease input the number of Red {shape}: ");
            int red = Convert.ToInt32(userInput());
            Console.Write($"Please input the number of Blue {shape}: ");
            int blue = Convert.ToInt32(userInput());
            Console.Write($"Please input the number of Yellow {shape}: ");
            int yellow = Convert.ToInt32(userInput());
            return (red, blue, yellow);
        }

        //  AM:
        //  Remove repetitive code
        //

        // Order Circle Input
        //public static Circle OrderCirclesInput()
        //{
        //    Console.Write("\nPlease input the number of Red Circle: ");
        //    int redCircle = Convert.ToInt32(userInput());
        //    Console.Write("Please input the number of Blue Circle: ");
        //    int blueCircle = Convert.ToInt32(userInput());
        //    Console.Write("Please input the number of Yellow Circle: ");
        //    int yellowCircle = Convert.ToInt32(userInput());

        //    Circle circle = new Circle(redCircle, blueCircle, yellowCircle);
        //    return circle;
        //}

        //// Order Squares Input
        //public static Square OrderSquaresInput()
        //{
        //    Console.Write("\nPlease input the number of Red Squares: ");
        //    int redSquare = Convert.ToInt32(userInput());
        //    Console.Write("Please input the number of Blue Squares: ");
        //    int blueSquare = Convert.ToInt32(userInput());
        //    Console.Write("Please input the number of Yellow Squares: ");
        //    int yellowSquare = Convert.ToInt32(userInput());

        //    Square square = new Square(redSquare, blueSquare, yellowSquare);
        //    return square;
        //}

        //// Order Triangles Input
        //public static Triangle OrderTrianglesInput()
        //{
        //    Console.Write("\nPlease input the number of Red Triangles: ");
        //    int redTriangle = Convert.ToInt32(userInput());
        //    Console.Write("Please input the number of Blue Triangles: ");
        //    int blueTriangle = Convert.ToInt32(userInput());
        //    Console.Write("Please input the number of Yellow Triangles: ");
        //    int yellowTriangle = Convert.ToInt32(userInput());

        //    Triangle triangle = new Triangle(redTriangle, blueTriangle, yellowTriangle);
        //    return triangle;
        //}

        // User Console Input
        private static string userInput()
        {
            string input = Console.ReadLine();
            // Only is null or empty is checked, program accepts space as an input. Use IsNullOrWhiteSpace
            while (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("please enter valid details");
                input = Console.ReadLine();

            }
            return input;
        }

        // Generate Report
        private static void GetReports(string customerName, string address, string dueDate, List<Shape> orderedShapes)
        {
            Order InvoiceReport = ReportFactory.GetReport("Invoice", customerName, address, dueDate, orderedShapes);
            InvoiceReport.GenerateReport();
            Order CuttingListReport = ReportFactory.GetReport("CuttingList", customerName, address, dueDate, orderedShapes);
            CuttingListReport.GenerateReport();
            Order PaintingReport = ReportFactory.GetReport("Painting", customerName, address, dueDate, orderedShapes);
            PaintingReport.GenerateReport();
        }

        // Generate Painting Report 
        // private static void PaintingReport(string customerName, string address, string dueDate, List<Shape> orderedShapes)
        // {
        //     PaintingReport paintingReport = new PaintingReport(customerName, address, dueDate, orderedShapes);
        //     paintingReport.GenerateReport();
        // }

        // // Generate Painting Report 
        // private static void CuttingListReport(string customerName, string address, string dueDate, List<Shape> orderedShapes)
        // {
        //     CuttingListReport cuttingListReport = new CuttingListReport(customerName, address, dueDate, orderedShapes);
        //     cuttingListReport.GenerateReport();
        // }

        // // Generate Invoice Report 
        // private static void InvoiceReport(string customerName, string address, string dueDate, List<Shape> orderedShapes)
        // {
        //     InvoiceReport invoiceReport = new InvoiceReport(customerName, address, dueDate, orderedShapes);
        //     invoiceReport.GenerateReport();
        // }

        // Get customer Info
        private static (string customerName, string address, string dueDate) CustomerInfoInput()
        {
            Console.Write("Please input your Name: ");
            string customerName = userInput();
            Console.Write("Please input your Address: ");
            string address = userInput();
            Console.Write("Please input your Due Date: ");
            string dueDate = userInput();
            return (customerName, address, dueDate);
        }

        // Get order input
        private static List<Shape> CustomerOrderInput()
        {
            var (redCircle, yellowCircle, blueCircle) = ShapeInput("Circle");
            var (redSquare, yellowSquare, blueSquare) = ShapeInput("Square");
            var (redTriangle, yellowTriangle, blueTriangle) = ShapeInput("Triangle");

            Square square = new Square(redSquare, blueSquare, yellowSquare);
            Triangle triangle = new Triangle(redTriangle, blueTriangle, yellowTriangle);
            Circle circle = new Circle(redCircle, blueCircle, yellowCircle);

            var orderedShapes = new List<Shape>();
            orderedShapes.Add(square);
            orderedShapes.Add(triangle);
            orderedShapes.Add(circle);
            return orderedShapes;
        }
    }
}
