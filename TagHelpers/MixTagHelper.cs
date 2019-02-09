using Microsoft.AspNetCore.Razor.TagHelpers;
using QuickInvoice.Config;

namespace QuickInvoice.TagHelpers
{
    [HtmlTargetElement(Attributes = "mix")]
    public class MixTagHelper : TagHelper
    {
        private readonly MixManifest mixManifest;
        public MixTagHelper(MixManifest mixManifest)
        {
            this.mixManifest = mixManifest;

        }

        public string Mix { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var tag = context.TagName.ToLower();
            output.Attributes.RemoveAll("mix");

            if (tag == "link")
            {
                output.Attributes.Add("href", mixManifest.config[Mix]);
            }
            else if (tag == "script")
            {
                output.Attributes.Add("src", mixManifest.config[Mix]);
            }
        }

    }
}