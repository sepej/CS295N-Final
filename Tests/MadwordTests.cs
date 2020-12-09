using System.Linq;
using Xunit;
using MADWORDS.Controllers;
using MADWORDS.Models;
using MADWORDS.Repos;

namespace Tests
{
    public class MadwordsTests
    {
        [Fact]
        public void AddMadwordTest()
        {
            // Arrange
            var fakeRepo = new FakeMadwordRepository();
            var controller = new MadwordController(fakeRepo);
            var madword = new Madword()
            {
                MadwordTitle = "New Madword Title",
                MadwordTopic = "New Topic",
                AuthorName = "Author",
                MadwordRating = 5,
                MadwordText = "MADWORD TEXT"
            };

            // Act
            controller.Create(madword);

            // Assert
            // Ensure that the review was added to the repository
            var retrievedMadword = fakeRepo.Madwords.ToList()[0];
            Assert.Equal(0,System.DateTime.Now.Date.CompareTo(retrievedMadword.MadwordDate.Date));
        }
    }
}
