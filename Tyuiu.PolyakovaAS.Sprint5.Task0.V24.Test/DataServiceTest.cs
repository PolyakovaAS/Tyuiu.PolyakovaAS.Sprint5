using Tyuiu.PolyakovaAS.Sprint5.Task0.V24.Lib;

namespace Tyuiu.PolyakovaAS.Sprint5.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            string result = File.ReadAllText(path);

            Assert.AreEqual("9,037", result);
        }
    }
}
