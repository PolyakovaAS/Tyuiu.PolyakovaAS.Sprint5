namespace Tyuiu.PolyakovaAS.Sprint5.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(s);
            bool file = fileInfo.Exists;
            Assert.AreEqual(true, file);
        }
    }
}
