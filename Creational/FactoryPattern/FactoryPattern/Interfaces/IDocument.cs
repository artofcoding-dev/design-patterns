using System.Data;

namespace FactoryPattern.Interfaces
{
    public interface IDocument
    {
        public void OpenFile(string filePath);

        public void ProcessData();
    }
}