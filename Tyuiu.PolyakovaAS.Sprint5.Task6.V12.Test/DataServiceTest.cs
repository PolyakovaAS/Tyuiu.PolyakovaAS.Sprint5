namespace Tyuiu.PolyakovaAS.Sprint5.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.KupriyanovEA.Sprint5\Tyuiu.KupriyanovEA.Sprint5.Task6.V12\bin\Debug\InPutDataFileTask6V12.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
