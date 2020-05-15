namespace Delegates
{
    class Program
    {
        //public delegate double PerformCalculation(double x, double y);

        //public static double Addition(double a, double b)
        //{
        //    Console.WriteLine("a+b is :   " + (a+b));
        //    return a + b;
        //}
        //public static double Division(double a, double b)
        //{
        //    Console.WriteLine("a/b is :   " + (a / b));
        //    return a / b;
        //}
        //public static double Subtraction(double a, double b)
        //{
        //    Console.WriteLine("a-b is :   " + (a - b));
        //    return a - b;
        //}
        //public delegate string GetTextDelegate(string name);

        //public delegate double GetResultDelegate(double a, double b);

        

        static void Main(string[] args)
        {
            // Creating an anonymous method or inline delegate
            //GetTextDelegate getTextDelegate = delegate (string name)
            //{
            //    return "Hello, " + name;
            //};

            //Lambda expression
            //GetTextDelegate getHelloText = (string name) => { return "Hello, " + name; };

            //Statement lambda
            //GetTextDelegate getGoodbyeText = (string name) =>
            //{
            //    Console.WriteLine("I'm inside of a statement lambda");
            //    return "Goodbye, " + name;
            //};

            //GetTextDelegate getWelcomeText = name => "Welcome, " + name;

            //GetResultDelegate getSum = (a, b) => a + b;

            //GetResultDelegate getProductDelegate = (a, b) => a * b;

            //DisplayNum(getSum);

            //DisplayNum1(getProductDelegate);

            //Console.WriteLine(getWelcomeText("Sophie"));
            //Display(getTextDelegate);

            //PerformCalculation getSum = Addition;
            ////getSum(5.0, 5.0);
            //PerformCalculation getQuotient = Division;
            ////getQuotient(5.0, 5.0);

            //PerformCalculation multiCalc = getSum + getQuotient;
            //multiCalc += Subtraction;
            //multiCalc -= getSum;
            //multiCalc(3.2, 3.2);
            var file = new File() { Title = "File 1" };
            var downloadHelper = new DownloadHelper(); //publisher
            var unpackService = new UnpackService(); //reciever
            var notificationService = new NotificationService();
            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;
            downloadHelper.FileDownloaded += notificationService.OnFileDownloaded;


            downloadHelper.Download(file);
        }

        //static void DisplayNum1(GetResultDelegate getProductDelegate)
        //{
        //    Console.WriteLine(getProductDelegate(3.0,2.0));
        //}

        //static void DisplayNum(GetResultDelegate getResultDelegate)
        //{
        //    Console.WriteLine(getResultDelegate(3.5,2.5));
        //}

        //static void Display(GetTextDelegate getTextDelegate)
        //{
        //    Console.WriteLine(getTextDelegate("World"));
        //}
        //public static void SayHello()
        //{
        //    Console.WriteLine("Hello");
        //}
    }
    
}
