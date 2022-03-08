namespace Plantjes.Models.Db; 

public class FenoLevensvorm {
    public int Id { get; set; }
    public string Levensvorm { get; set; }
    public byte[] Figuur { get; set; }
    public string UrlLocatie { get; set; }
}