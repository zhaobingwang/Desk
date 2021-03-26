using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Desk.Assets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Desk.Web.Pages.AssetCategories
{
    public class CreateModalModel : DeskPageModel
    {
        private readonly IAssetCategoryAppService _assetCategoryAppService;

        [BindProperty]
        public CreateAssetCategoryViewModel AssetCategory { get; set; }

        public List<SelectListItem> RootCategoryItem { get; set; }

        public CreateModalModel(IAssetCategoryAppService assetCategoryAppService)
        {
            _assetCategoryAppService = assetCategoryAppService;
        }

        public async Task OnGet()
        {
            AssetCategory = new CreateAssetCategoryViewModel();
            RootCategoryItem = new List<SelectListItem> {
                new SelectListItem{ Value=Guid.Empty.ToString(),Text="Root",Selected=true}
            };

            // TODO: fill data to level one category
            var ac = await _assetCategoryAppService.GetRootListAsync();
            ac.ForEach(x =>
            {
                RootCategoryItem.Add(new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                });
            });
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateAssetCategoryViewModel, CreateAssetCategoryDto>(AssetCategory);
            await _assetCategoryAppService.CreateAsync(dto);
            return NoContent();
        }

        public class CreateAssetCategoryViewModel
        {
            [Required]
            [StringLength(AssetConsts.MaxCategoryNameLength)]
            public string Name { get; set; }
            public string ParentId { get; set; }
        }
    }
}
