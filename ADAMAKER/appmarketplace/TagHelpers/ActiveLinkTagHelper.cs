using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Http;

namespace appmarketplace.TagHelpers
{
    [HtmlTargetElement("a", Attributes = "href")]
    public class ActiveLinkTagHelper : TagHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ActiveLinkTagHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HtmlAttributeName("asp-active-prefix")]
        public string ActivePrefix { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var currentPath = _httpContextAccessor.HttpContext.Request.Path.Value?.ToLowerInvariant() ?? "";

            bool isActive = false;

            if (!string.IsNullOrEmpty(ActivePrefix))
            {
                if (ActivePrefix == "/")
                {
                    // Para a home, só é ativo se a rota atual for exatamente "/"
                    isActive = (currentPath == "/");
                }
                else
                {
                    // Para rotas diferentes de "/", use StartsWith
                    isActive = currentPath.StartsWith(ActivePrefix.ToLower());
                }
            }

            if (isActive)
            {
                var existingClasses = output.Attributes["class"]?.Value.ToString() ?? "";
                if (!existingClasses.Contains("v-list-item--active"))
                {
                    output.Attributes.SetAttribute("class", existingClasses + " v-list-item--active");
                }
            }
        }
    }
}
