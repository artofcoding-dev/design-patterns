using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Classes
{
    public class ExcelDocument : IDocument
    {
        public void OpenFile(string filePath)
        {
            // File read logic specific to Excel
        }

        public void ProcessData()
        {
            // Data processing logic specific to Excel
        }
    }
}