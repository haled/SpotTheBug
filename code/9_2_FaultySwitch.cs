namespace SpotTheBug
{
    public enum Colors
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black
    }

    public class ColorPicker
    {
        public Colors PickColor(string shape)
        {
            Colors returnColor = Colors.Black;

	    switch(shape)
            {
                case "Circle":
                    returnColor = Colors.Red;
                    break;
                case "Square":
                    returnColor = Colors.Blue;
                    break;
                case "Triangle":
                    returnColor = Colors.Yellow;
                    break;
                default:
                    returnColor = Colors.Black;
                    break;
            }

            return returnColor;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var picker = new ColorPicker();
            var colorForShape = picker.PickColor("Square");
            Console.WriteLine("The color for a Square is %s", colorForShape);
            var colorForShape = picker.PickColor("Rectangle");
            Console.WriteLine("The color for a Rectangle is %s", colorForShape);
        }
    }
}
