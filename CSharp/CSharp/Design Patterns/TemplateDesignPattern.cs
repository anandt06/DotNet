namespace CSharp
{
    internal class TemplateDesignPattern
    {
        static void Main()
        {
            ReportTemplate pdfReport = new PDFReport();
            pdfReport.CreateReport();

            Console.WriteLine();

            ReportTemplate htmlReport = new HTMLReport();
            htmlReport.CreateReport();
        }
    }


    abstract class ReportTemplate
    {
        // Template method
        public void CreateReport()
        {
            GatherData();
            FormatData();
            PrintReport();
        }

        // Steps that subclasses need to implement
        protected abstract void GatherData();
        protected abstract void FormatData();
        protected abstract void PrintReport();
    }



    class PDFReport : ReportTemplate
    {
        protected override void GatherData()
        {
            Console.WriteLine("Gathering data for PDF report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting data for PDF report...");
        }

        protected override void PrintReport()
        {
            Console.WriteLine("Printing PDF report...");
        }
    }

    class HTMLReport : ReportTemplate
    {
        protected override void GatherData()
        {
            Console.WriteLine("Gathering data for HTML report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting data for HTML report...");
        }

        protected override void PrintReport()
        {
            Console.WriteLine("Printing HTML report...");
        }
    }

}
