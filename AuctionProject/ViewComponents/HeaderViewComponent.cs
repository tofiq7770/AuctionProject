using Microsoft.AspNetCore.Mvc;

namespace AuctionProject.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());

        }
    }
}
