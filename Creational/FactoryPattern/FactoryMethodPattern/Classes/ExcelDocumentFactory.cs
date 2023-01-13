using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Classes
{
    public class ExcelDocumentFactory : DocumentFactory
    {
        protected override IDocument ReadDocument()
        {
            IDocument document = new ExcelDocument();
            return document;
        }
    }
}