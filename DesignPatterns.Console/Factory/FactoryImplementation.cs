namespace DesignPatterns.Console.Factory
{
    public static class FactoryImplementation
    {
        public static void Perform()
        {
            var point = Point.NewPolarPoint(2, 3);
        }
    }

}
