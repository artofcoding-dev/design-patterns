namespace FactoryPatternTests
{
    [TestFixture]
    public class DocumentFactoryTests
    {
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ReadDocument_EmptyPath_ThrowsArgumentNullException(string path)
        {
            // Arrange
            var documentFactory = new DocumentFactory();

            // Act + Assert
            Assert.Throws<ArgumentNullException>(() => documentFactory.ReadDocument(path));
        }

        [TestCase("c:/document.pdf", typeof(PdfDocument))]
        [TestCase("c:/document.doc", typeof(WordDocument))]
        [TestCase("c:/document.docx", typeof(WordDocument))]
        [TestCase("c:/document.xls", typeof(ExcelDocument))]
        [TestCase("c:/document.xlsx", typeof(ExcelDocument))]
        [TestCase("c:/document.default", typeof(WordDocument))]
        public void ReadDocument_ValidPath_ReturnsExpectedDocument(string path, Type expectedDocumentType)
        {
            // Arrange
            var documentFactory = new DocumentFactory();

            // Act
            var document = documentFactory.ReadDocument(path);

            // Assert
            Assert.IsNotNull(document);
            Assert.IsInstanceOf(expectedDocumentType, document);
        }
    }
}