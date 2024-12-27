using AuctionProject.Areas.Admin.ViewModelsAdmin.Brands;
using AuctionProject.Models.Entities;
using AuctionProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuctionProject.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class BrandsController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var brands = await _brandService.GetAllAsync();
                return View(brands);
            }
            catch (Exception ex)
            {
                // Log the error (implement logging as needed)
                ViewBag.ErrorMessage = "An error occurred while fetching the brands.";
                return View("Error");
            }
        }
        public async Task<IActionResult> Detail(int id)
        {
            try
            {
                var brand = await _brandService.GetByIdAsync(id);
                if (brand == null)
                {
                    return NotFound();
                }
                return View(brand);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while fetching the brand details.";
                return View("Error");
            }
        }
        public IActionResult Create()
        {
            return View(new BrandCreateVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BrandCreateVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            try
            {
                var brandNames = await _brandService.GetAllNamesAsync();

                var brand = new Brand
                {
                    Id = viewModel.Id,
                    BrandName = viewModel.BrandName
                };
                int count = 0;
                foreach (var item in brandNames)
                {
                    if (item.ToLower() == brand.BrandName.ToLower())
                    {
                        count++;
                    }
                }
                if (count < 1)
                {

                    await _brandService.UpdateAsync(brand);
                    TempData["SuccessMessage"] = "Brand Created successfully.";
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "A brand with the same name already exists.");
                    return View(viewModel);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while creating the brand.";
                return View("Error");
            }
        }

        public async Task<IActionResult> Update(int id)
        {
            try
            {
                var brand = await _brandService.GetByIdAsync(id);
                if (brand == null)
                {
                    return NotFound();
                }

                var viewModel = new BrandUpdateVM
                {
                    Id = brand.Id,
                    BrandName = brand.BrandName
                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while fetching the brand for Updateing.";
                return View("Error");
            }
        }

        // POST: Brands/Update/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, BrandUpdateVM viewModel)
        {
            if (id != viewModel.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            try
            {
                var brandNames = await _brandService.GetAllNamesAsync();

                var brand = new Brand
                {
                    Id = viewModel.Id,
                    BrandName = viewModel.BrandName
                };
                int count = 0;
                foreach (var item in brandNames)
                {
                    if (item.ToLower() == brand.BrandName.ToLower())
                    {
                        count++;
                    }
                }
                if (count < 1)
                {

                    await _brandService.UpdateAsync(brand);
                    TempData["SuccessMessage"] = "Brand updated successfully.";
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "A brand with the same name already exists.");
                    return View(viewModel);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while updating the brand.";
                return View("Error");
            }
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (!id.HasValue)
                return BadRequest();

            try
            {
                var brand = await _brandService.GetByIdAsync(id.Value);
                if (brand == null)
                    return NotFound();

                await _brandService.DeleteAsync(id.Value);
                TempData["SuccessMessage"] = "Brand deleted successfully.";
                return RedirectToAction("Index");
            }
            catch (KeyNotFoundException)
            {
                TempData["ErrorMessage"] = "Brand not found.";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the brand.";
                return RedirectToAction("Index");
            }
        }


    }
}
