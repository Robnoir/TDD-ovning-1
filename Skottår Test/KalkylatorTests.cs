using Skottår_Kalkylator;

namespace Skottår_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

   
        [Test]
        public void När_ÅrÄrDelbartMed400_ShouldReturnTrue()
        {
            //arrange
            int årAttKontrollera = 2000;
            // act
            bool result = År.ÄrSkottår(årAttKontrollera);

            // Assert 
            Assert.IsTrue(result); 
        }

        [Test]
        public void När_ÅrÄrDelBartMed100_ShouldReturnTrue()
        {
            // Arrange
            int årAttKontrollera = 1700;

            // Act
            bool result = År.ÄrInteSkottår(årAttKontrollera);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void NärÅrÄrDelbartMed4MenInteMed100_ShouldReturnTrue()
        {   
            // Arrange
            int årAttKontrollera = 2008;
            // Act
            bool result = År.ÄrSkottårMenDelatPå4(årAttKontrollera);

            // Assert
            Assert.IsTrue(result);
        }


    }
}