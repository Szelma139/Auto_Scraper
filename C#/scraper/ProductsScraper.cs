using IronWebScraper;
using System;
public class ProductsScraper : WebScraper
{
    string Url;
    public ProductsScraper(string url) => this.Url = url;
    public override void Init()
    {

        this.LoggingLevel = WebScraper.LogLevel.All;
        this.Request(this.Url, Parse);
    
    }

 public override void Parse(Response response)
        {
            foreach (var title_link in response.Css("div.list__title a"))
            {
                string strTitle = title_link.TextContentClean;
                Console.WriteLine("Line"+ strTitle);
                Scrape(new ScrapedData() { { "Title", strTitle } }, "HelloScraper2.Jsonl");
            }
          //  if (response.CssExists("div.prev-post > a[href]"))
           // {
            //    var next_page = response.Css("div.prev-post > a[href]")[0].Attributes["href"];
              //  this.Request(next_page, Parse);
            //}
        }
}
