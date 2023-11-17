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
        [Test]
        public void ÄrDetSkottÅr_ShouldReturnTrue()
        {
            //arrange
            int årAttKontrollera = 2020;
            // act
            bool result = År.ÄrSkottår(årAttKontrollera);

            // Assert 
            Assert.IsTrue(result); 
        }

            // This Test checks century years. 
        [Test]
        public void ÄrDetSkottDecenium_ShouldReturnfalse()
        {
            //arrange
            int årAttKontrollera = 1900;
            // act
            bool result = År.ÄrSkottår(årAttKontrollera);

            // Assert 
            Assert.IsFalse(result); 
        }
        // This checks for a century year wich is a leap year
        [Test]
        public void ÄrDetSkottÅrMillenium_ShouldReturnTrue()
        {
            //arrange
            int årAttKontrollera = 2000;
            // act
            bool result = År.ÄrSkottår(årAttKontrollera);

            // Assert 
            Assert.IsTrue(result); 
        }

        [Test]
        public void KollarEttIckeSkottÅr_ShouldReturnFalse()
        {
            //arrange
            int årAttKontrollera = 2019;
            // act
            bool result = År.ÄrSkottår(årAttKontrollera);

            // Assert 
            Assert.IsFalse(result); 
        }

    }
}