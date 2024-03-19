[Test]
public void TestRepoItemsEmpty()
{
    // Arrange
    var repo = new Repository(); // create a new repository object
    // Act
    repo.Clear(); // clear the repository of any items
    // Assert
    Assert.IsTrue(!repo.Items.Any()); // check if the repository is empty
}
