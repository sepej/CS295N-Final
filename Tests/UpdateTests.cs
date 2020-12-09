using System.Linq;
using Xunit;
using MADWORDS.Controllers;
using MADWORDS.Models;
using MADWORDS.Repos;

namespace Tests
{
    public class UpdatesTests
    {
        [Fact]
        public void AddUpdateTest()
        {
            // Arrange
            var fakeRepo = new FakeUpdateRepository();
            var controller = new UpdatesController(fakeRepo);
            var update = new Update()
            {
                UpdateTitle = "Update Title",
                UpdateText = "UPDATE TEXT"
            };
            // Act
            controller.NewUpdate(update);

            // Assert
            // Ensure that the review was added to the repository
            var retrievedUpdate = fakeRepo.Updates.ToList()[0];
            Assert.Equal(0,System.DateTime.Now.Date.CompareTo(retrievedUpdate.UpdateDate.Date));
        }
    }
}
