using FactoryPattern.Interfaces;

namespace FactoryPattern.Classes
{
    public class ExcelDocument : IDocument
    {
        public void OpenFile(string filePath)
        {
            // Data read logic specific to Excel
        }

        public void ProcessData()
        {
            // Data processing logic specific to Excel
        }
    }
}