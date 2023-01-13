using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Classes
{
    public class PdfDocument : IDocument
    {
        public void OpenFile(string filePath)
        {
            // File read logic specific to Pdf
        }

        public void ProcessData()
        {
            // Data processing logic specific to Pdf
        }
    }
}