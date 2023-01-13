using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Classes
{
    public class WordDocumentFactory : DocumentFactory
    {
        protected override IDocument ReadDocument()
        {
            IDocument document = new PdfDocument();
            return document;
        }
    }
}