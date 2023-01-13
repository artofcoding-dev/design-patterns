namespace FactoryMethodPattern.Interfaces
{
    public interface IDocument
    {
        public void OpenFile(string filePath);

        public void ProcessData();
    }
}