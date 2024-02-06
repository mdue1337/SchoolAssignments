using TestOfAlgoritms;

namespace TestCode
{
    public class Tests
    {
        Sorting _sorting;

        [SetUp]
        public void Setup()
        {
            _sorting = new Sorting();
        }

        [TestCase(new[] {8, 5, 288, 144, 99}, new[] {5, 8, 99, 144, 288})]
        public void Test1(int[] array, int[] result)
        {
            // Act
            int[] arr = _sorting.SortArray(array, 0, array.Length - 1);

            // Assert
            Assert.AreEqual(result, array);
        }
    }
}