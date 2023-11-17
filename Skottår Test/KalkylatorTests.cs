using Skottår_Kalkylator;

namespace Skottår_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //This test checks if true 
        // [Test]
        // public void ÄrDetSkottÅr_ShouldReturnTrue()
        // {
        //     //arrange
        //     int årAttKontrollera = 2020;
        //     // act
        //     bool result = År.ÄrSkottår(årAttKontrollera);

        //     // Assert 
        //     Assert.IsTrue(result); 
        // }

        //     // This Test checks century years. 
        // [Test]
        // public void ÄrDetSkottDecenium_ShouldReturnfalse()
        // {
        //     //arrange
        //     int årAttKontrollera = 1900;
        //     // act
        //     bool result = År.ÄrSkottår(årAttKontrollera);

        //     // Assert 
        //     Assert.IsFalse(result); 
        // }
        // // This checks for a century year wich is a leap year
        // [Test]
        // public void ÄrDetSkottÅrMillenium_ShouldReturnTrue()
        // {
        //     //arrange
        //     int årAttKontrollera = 2000;
        //     // act
        //     bool result = År.ÄrSkottår(årAttKontrollera);

        //     // Assert 
        //     Assert.IsTrue(result); 
        // }

        // [Test]
        // public void KollarEttIckeSkottÅr_ShouldReturnFalse()
        // {
        //     //arrange
        //     int årAttKontrollera = 2019;
        //     // act
        //     bool result = År.ÄrSkottår(årAttKontrollera);

        //     // Assert 
        //     Assert.IsFalse(result); 
        // }

        // [Test]
        // public void TestFörstaDagenPåÅret()
        // {
        //     // Arrange
        //     DateTime DagAttKontrollera = new DateTime(2023, 01, 01);
        //     // Act 
        //     int result = År.FåDagsNummer(DagAttKontrollera);

        //     Assert.AreEqual(1,result);

        // }

        // [Test]
        // public void TestSistaDagenPåÅret()
        // {
        //     // Arrange
        //     DateTime DagAttKontrollera = new DateTime(2023, 12, 31);
        //     // Act 
        //     int result = År.FåDagsNummer(DagAttKontrollera);

        //     Assert.AreEqual(365,result);

        // }

        // [Test]
        // public void Test60eDagenPåÅret()
        // {
        //     // Arrange
        //     DateTime DagAttKontrollera = new DateTime(2023, 03, 01);
        //     // Act 
        //     int result = År.FåDagsNummer(DagAttKontrollera);

        //     Assert.AreEqual(60,result);

        // }

        // [Test]
        //  public void TestFödelsedagen()
        // {
        //     // Arrange
        //     DateTime DagAttKontrollera = new DateTime(2023, 06, 10);
        //     // Act 
        //     int result = År.FåDagsNummer(DagAttKontrollera);
        //     // Assert
        //     Assert.AreEqual(161,result);
        // }   




        [Test]
         public void TestSistaVeckan()
        {
            // Arrange
            DateTime VeckaAttKontrollera = new DateTime (2023, 12, 30);
            // Act 
            int result = År.FåVeckoNummer(VeckaAttKontrollera);
            // Assert
            Assert.AreEqual(52,result);
        }   

         [Test]
         public void TestFörstaVeckan()
        {
            // Arrange
            DateTime VeckaAttKontrollera = new DateTime (2023, 01, 01);
            // Act 
            int result = År.FåVeckoNummer(VeckaAttKontrollera);
            // Assert
            Assert.AreEqual(1,result);
        }   
         [Test]
         public void TestMidYear()
        {
            // Arrange
            DateTime VeckaAttKontrollera = new DateTime (2023, 06, 24);
            // Act 
            int result = År.FåVeckoNummer(VeckaAttKontrollera);
            // Assert
            Assert.AreEqual(25,result);
        }   


    }
}