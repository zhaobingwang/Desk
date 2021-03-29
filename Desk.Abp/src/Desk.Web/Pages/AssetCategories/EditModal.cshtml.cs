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
    public class EditModalModel : DeskPageModel
    {
        private readonly IAssetCategoryAppService _assetCategoryAppService;

        [BindProperty]
        public EditAssetCategotyViewModel AssetCategory { get; set; }
        public List<SelectListItem> RootCategoryItem { get; set; }

        public EditModalModel(IAssetCategoryAppService assetCategoryAppService)
        {
            _assetCategoryAppService = assetCategoryAppService;
        }

        public async Task OnGetAsync(Guid id)
        {
            var ac = await _assetCategoryAppService.GetAsync(id);
            var pid = ac.ParentId;

            AssetCategory = ObjectMapper.Map<AssetCategoryDto, EditAssetCategotyViewModel>(ac);
            RootCategoryItem = new List<SelectListItem> {
                new SelectListItem{ Value=Guid.Empty.ToString(),Text="Root"}
            };

            // TODO: fill data to level one category
            var acsRoot = await _assetCategoryAppService.GetRootListAsync();
            foreach (var item in acsRoot)
            {
                if (item.Id == id)
                {
                    continue;
                }

                RootCategoryItem.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.Name,
                    Selected = item.Id == pid ? true : false
                });
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _assetCategoryAppService.UpdateAsync(AssetCategory.Id, ObjectMapper.Map<EditAssetCategotyViewModel, UpdateAssetCategoryDto>(AssetCategory));
            return NoContent();
        }

        public class EditAssetCategotyViewModel
        {
            [HiddenInput]
            public Guid Id { get; set; }

            [Required]
            [StringLength(AssetConsts.MaxCategoryNameLength)]
            public string Name { get; set; }

            public string ParentId { get; set; }
        }
    }
}
