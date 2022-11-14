using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace WildberriesParser
{
    class Wildberries
    {
        public static string GetPage(string keyword)
        {
            //our api
            var uri = "https://" +
                "search.wb.ru/exactmatch/ru/common/v4/search?appType=1&couponsGeo=12,3,18,15,21&curr=rub&dest=-1029256,-102269,-2162196,-1257786" +
                $"&emp=0&lang=ru&locale=ru&pricemarginCoeff=1.0&query={keyword}&reg=0&regions=80,64,83,4,38,33,70,82,69,68,86,75,30,40,48,1,22,66,31,71" +
                "&resultset=catalog&sort=popular&spp=0&suppressSpellcheck=false";

            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.Accept = "text / plain; charset = UTF - 8";
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static void ConfigureExel(string filePath)
        {
            string folderPath = $"{filePath}\\..";
            string[] lines = File.ReadAllLines(filePath);
            Tag[][] result = new Tag[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                //encrypt russian word for uri
                string keyword = Uri.EscapeDataString(lines[i]);
                var json = GetPage(keyword);
                
                //remove useless informations and deserialize it
                Match match = Regex.Match(json, @"\[{(.*?)}}");
                var correctJsonArray = match.Groups[0].Value[0..^2];
                result[i] = JsonConvert.DeserializeObject<Tag[]>(correctJsonArray);
            }
            var reportExcel = new ExcelGenerator().Generate(result, lines);
            File.WriteAllBytes($"{folderPath}\\Report.xlsx", reportExcel);
        }
    }
}
