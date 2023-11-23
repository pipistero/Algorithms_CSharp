using Algorithms.ArraySort;

namespace AlgorithmsTests.Sort.Selection;

[TestClass]
public class SortTests
{
    [TestMethod]
    public void SelectionSort_Test()
    {
        var array = new[] { 34, 15, 78, 3, 55, 9, 83 };
        var expectedOutput = new[] { 3, 9, 15, 34, 55, 78, 83 };

        array.SelectionSort();
        
        Assert.IsNotNull(array);
        CollectionAssert.AreEqual(array, expectedOutput);
    }
}