using AG.BankApp.Web.Data.Context;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AG.BankApp.Web.TagHelpers
{
    [HtmlTargetElement("getAccountCount")]
    public class GetBankAccountCount : TagHelper
    {
        public int ApplicationUserId { get; set; }
        private readonly BankContext _context;
        public GetBankAccountCount(BankContext context)
        {
            _context = context;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var accountCount = _context.Accounts.Count(x => x.ApplicationUserId == ApplicationUserId);
            string html = $"<span>{accountCount}</span>";
            
            output.Content.SetHtmlContent(html);
        }
    }
}
