using Microsoft.AspNetCore.Mvc;

namespace AuctionProject.ViewComponents
{
    public class FooterViewComponent:ViewComponent

    {
        public async Task<IViewComponentResult> InvokeAsync()
        {   
            return await Task.FromResult(View());
        }
    }
}
