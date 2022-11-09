namespace Strategy
{
    public class Strategy
    {
        static void Perform()
        {
            Console.Title = "Strategy";

            var order = new Order("Radek Sen", 10, "VS License");
            order.ExportService = new CsvExportService();
            order.Export();

            order.ExportService = new JsonExportService();
            order.Export();
        }

    }
    public class JsonExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting {order.Name} to JSON");
        }
    }

    public class XmlExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting {order.Name} to XML");
        }
    }

    public class CsvExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting {order.Name} to CSV");
        }
    }

    /// <summary>
    /// Strategy
    /// </summary>
    public interface IExportService
    {
        void Export(Order order);
    }


    /// <summary>
    /// Context
    /// </summary>
    public class Order
    {
        public string Customer { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public IExportService? ExportService { get; set; }

        public Order(string customer, int amount, string name)
        {
            Customer = customer;
            Amount = amount;
            Name = name;
            // What if is not any value? ExportService = exportService
        }

        public void Export(/*IExportService exportService*/)
        {
            //if (exportService is null)
            //{
            //    throw new ArgumentNullException(nameof(exportService));
            //}

            //exportService.Export(this);


            ExportService?.Export(this);
        }
    }


    // TODO: 1. The boss comes to us with a new requirement: We want to see products in JSON and XML. How can we deal with it?

    //public void Export(T objectToExport)
    //{
    //    Console.WriteLine($"Exporting {typeof(T).Name} to CSV");
    //}



}