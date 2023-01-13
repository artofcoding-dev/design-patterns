using FactoryMethodPattern.Classes;
using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // This should ideally come from the UI.
            // Hard coded to simulate
            string filePath = "c:/document_to_open.pdf";

            var documentFactory = new ExcelDocumentFactory();

            IDocument document = documentFactory.LoadDocument();
            document.OpenFile(filePath);
            document.ProcessData();
        }
    }
}