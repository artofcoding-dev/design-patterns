using FactoryPattern.Interfaces;

namespace FactoryPattern.Classes
{
    public class WordDocument : IDocument
    {
        public void OpenFile(string filePath)
        {
            // Data read logic specific to Word
        }

        public void ProcessData()
        {
            // Data processing logic specific to Word
        }
    }
}