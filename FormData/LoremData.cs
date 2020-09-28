using System;
using System.Collections.Generic;
using UnitTestProject.Pages.Lorem_Pages;

namespace UnitTestProject.FormData
{
    public class LoremData : IData
    {
        private static readonly Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();

        public static void GenerateData()
        {
            new LoremHomePage().UncheckStartText().ClickGenerate();
            int i = 1;
            foreach (var paragraph in new ResultPage().Paragraphs)
            {
                var testData = new Dictionary<string, string>
                {
                    ["Tell us your story"] = paragraph.Length > 500 ? paragraph.Substring(0, 500) : paragraph,
                    ["Name"] = paragraph.Substring(0, paragraph.IndexOf(' ')),
                    ["I am over 16 years old"] = (paragraph.Length % 2 == 0) ? true.ToString() : false.ToString(),
                    ["Terms of Service"] = false.ToString()
                };
                data["TestCase" + i++] = testData;
            }
        }

        public Dictionary<string, string> GetTestData(string key)
        {
            return data[key];
        }

        public Dictionary<string, Dictionary<string, string>> CopyData() // a not completely correct version of prototype pattern
                                                                         // but I've got nothing else to make copy of
        {
            var dataCopy = new Dictionary<string, Dictionary<string, string>>();
            foreach (var key in data.Keys)
            {
                var _data = new Dictionary<string, string>();
                foreach (var values in data.Values)
                {
                    foreach (var pair in values)
                    {
                        _data[pair.Key] = pair.Value;
                    }
                }
                dataCopy[key] = _data;
            }
            return dataCopy;
        }
    }
}