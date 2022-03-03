using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

public class ProductData
{
    [BsonElement("_id")]
    [JsonProperty("_id")]
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    [BsonElement("name")]
    public string Name { get; set; }
    [BsonElement("price")]
    public int Price { get; set; }
    [BsonElement("base_price")]
    public int BasePrice { get; set; }
    [BsonElement("sum_specs")]
    public string[] SummarySpecs { get; set; }
    [BsonElement("detail_specs")]
    public DetailSpecsModel[] DetailSpecs { get; set; }
    [BsonElement("video_link")]
    public string VideoLink { get; set; }
    [BsonElement("product_details")]
    public string ProducteDetailsLink { get; set; }
    [BsonElement("related_products")]
    public ObjectId[] RelatedProducts { get; set; }
    [BsonElement("images")]
    public string[] Images { get; set; }
    [BsonElement("type")]
    public string Type{get;set;}
    public string Manufacturer{get;set;}
    public string Serie{get;set;}
    public ProductData(string _name, int _price, int _basePrice)
    {
        Name = _name;
        Price = _price;
        BasePrice = _basePrice;
    }
    private string GetPriceString(int price){
        var str = price.ToString();
        var res = "";
        for(int i = 1; i <= str.Length; i++){
            res = res.Insert(0, str[str.Length - i].ToString());
            if(i % 3 == 0) res = res.Insert(0, ".");
        }
        return res;
    }
    public string GetPriceString(){
        return GetPriceString(Price);
    }
    public string GetBasePriceString(){
        return GetPriceString(BasePrice);
    }
}
public class DetailSpecsModel
{
    public string key { get; set; }
    public string[] value { get; set; }
}
