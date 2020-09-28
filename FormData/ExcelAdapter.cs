using System.Collections.Generic;

namespace UnitTestProject.FormData
{
    class ExcelAdapter : IData
    {
        ExcelData excel;
        public ExcelAdapter(ExcelData excel)
        {
            this.excel = excel;
        }
        public Dictionary<string, string> GetTestData(string key)
        {
            List<string> values = excel.GetTestData(key);
            var testData = new Dictionary<string, string>()
            {
                ["Tell us your story"] = values[0],
                ["Name"] = values[1],
                ["I am over 16 years old"] = values[2],
                ["Terms of Service"] = values[3]
            };
            return testData;
        }
    }
}