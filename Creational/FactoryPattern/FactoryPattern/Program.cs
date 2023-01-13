using FactoryPattern.Classes;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // This should ideally come from the UI.
            // Hard coded to simulate
            string filePath = "c:/document_to_open.pdf";

            var documentFactory = new DocumentFactory();

            IDocument document = documentFactory.ReadDocument(filePath);
            document.ProcessData();

        }
    }
}
