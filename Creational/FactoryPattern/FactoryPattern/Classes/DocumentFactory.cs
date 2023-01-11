using FactoryPattern.Interfaces;

namespace FactoryPattern.Classes
{
    public class DocumentFactory
    {
        public IDocument ReadDocument(string filePath)
        {
            IDocument document = null;

            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentNullException(nameof(filePath));

            // Other validations to check if the path exists.

            switch (Path.GetExtension(filePath).ToLower())
            {
                case ".pdf":
                    document = new PdfDocument();
                    break;

                case ".doc":
                case ".docx":
                    document = new WordDocument();
                    break;

                case ".xls":
                case ".xlsx":
                    document = new ExcelDocument();
                    break;

                default:
                    document = new WordDocument();
                    break;
            }

            document.OpenFile(filePath);
            return document;
        }
    }
}