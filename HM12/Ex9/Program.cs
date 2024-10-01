namespace l6t9
{
    public struct CustomLine
    {
        private int length;
        private char symbol;
        public CustomLine(int length, char symbol)
        {
            this.length = length;
            this.symbol = symbol;
        }
        public static void PrintLine(CustomLine line)
        {

            Console.WriteLine(new string(line.symbol, line.length));
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomLine line1 = new CustomLine(10, '$');
            CustomLine line2 = new CustomLine(10, '$');
            CustomLine line3 = new CustomLine(10, '$');
            CustomLine.PrintLine(line1);
            CustomLine.PrintLine(line2);
            CustomLine.PrintLine(line3);
        }
    }
}