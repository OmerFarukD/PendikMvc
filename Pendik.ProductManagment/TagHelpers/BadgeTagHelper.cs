using System.Net.Mime;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Pendik.ProductManagment.TagHelpers;

public class BadgeTagHelper : TagHelper
{
    public string Text { get; set; }
    public string Color { get; set; }


    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "span";
        if (Color.ToLower()=="yellow")
        {
            output.Attributes.SetAttribute("class",$"badge rounded-pill bg-warning text-dark");
        }

        if (Color.ToLower()=="green")
        {
            output.Attributes.SetAttribute("class",$"badge rounded-pill bg-success");
        }

        if (Color.ToLower()=="red")
        {
            output.Attributes.SetAttribute("class",$"badge rounded-pill bg-danger");
        }
        if (Color.ToLower()=="gray")
        {
            output.Attributes.SetAttribute("class",$"badge rounded-pill bg-secondary");
        }
        if (Color.ToLower()=="blue")
        {
            output.Attributes.SetAttribute("class",$"badge rounded-pill bg-primary");
        }
        
        if (Color.ToLower()=="white")
        {
            output.Attributes.SetAttribute("class",$"badge rounded-pill bg-light text-dark");
        }
        
        if (Color.ToLower()=="black")
        {
            output.Attributes.SetAttribute("class",$"badge rounded-pill bg-dark");
        }
        output.Content.SetContent((Convert.ToDouble(Text)*1.20).ToString());
    }
}