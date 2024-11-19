using System;

namespace ClassesApp
{
    internal class Rectangle
    {
        // declaration of field
        public const int NumberOfCorners = 4;

        // declaration of field
        public readonly string Color = "Blue";

        // Read-only field: A unique identifier for each rectangle instance
        private readonly string _id;

        public Rectangle(string color)
        {
            Color = color;
        }

        // Method to display the details of the rectangle

        public void DisplayDetails()
        {
            Console.WriteLine($"Color; {Color}, Width: {Width}, " +
                $"Height: {Height}, Area: {Area}, " +
                $"Number of Corners: {NumberOfCorners}");
        }

        public double Width { get; set; }
        public double Height { get; set; }


        // Computed property
        // Read Only Prop
        public double Area
        {
            get
            {
                return Width * Height;
            }
        }

    }
}
