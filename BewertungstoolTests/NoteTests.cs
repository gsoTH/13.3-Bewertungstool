using Bewertungstool;

namespace BewertungstoolTests
{
    [TestClass]
    public class NoteTests
    {
        [TestMethod]
        public void Note_Erstellbar()
        {
            // Arrange
            int moeglichePunkte = 100;
            int erreichtePunkte = 25;

            // Act
            Note n = new Note(moeglichePunkte, erreichtePunkte);

            // Assert
            Assert.AreEqual(moeglichePunkte, n.MoeglichePunkte);
            Assert.AreEqual(erreichtePunkte, n.ErreichtePunkte);
            Assert.AreEqual(0.25, n.Prozent);
            Assert.AreEqual(5.3, n.Dezimal);
            Assert.AreEqual("5-", n.Kurz);
            Assert.AreEqual("mangelhaft", n.Lang);
        }
    }
}