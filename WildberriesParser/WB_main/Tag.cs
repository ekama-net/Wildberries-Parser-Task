namespace WildberriesParser
{
    public class Tag
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Title { get; set; }
        [Newtonsoft.Json.JsonProperty("brand")]
        public string Brand { get; set; }
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }
        [Newtonsoft.Json.JsonProperty("feedbacks")]
        public int Feedbacks { get; set; }
        [Newtonsoft.Json.JsonProperty("priceU")]
        public int Price { get; set; }
    }
}
