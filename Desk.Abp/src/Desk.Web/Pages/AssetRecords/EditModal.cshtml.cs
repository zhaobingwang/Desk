using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Desk.Assets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Desk.Web.Pages.AssetRecords
{
    public class EditModalModel : DeskPageModel
    {
        private readonly IAssetRecordAppService _assetRecordAppService;
        private readonly IAssetCategoryAppService _assetCategoryAppService;

        [BindProperty]
        public EditAssetRecordViewModel AssetRecord { get; set; }

        public List<SelectListItem> NotInRootCategoryItem { get; set; }

        public EditModalModel(IAssetRecordAppService assetRecordAppService, IAssetCategoryAppService assetCategoryAppService)
        {
            _assetRecordAppService = assetRecordAppService;
            _assetCategoryAppService = assetCategoryAppService;
        }

        public async Task OnGetAsync(Guid id)
        {
            var ar = await _assetRecordAppService.GetAsync(id);
            AssetRecord = ObjectMapper.Map<AssetRecordDto, EditAssetRecordViewModel>(ar);

            NotInRootCategoryItem = new List<SelectListItem>();

            var acs = await _assetCategoryAppService.GetNotInRootListAsync();
            foreach (var ac in acs)
            {
                NotInRootCategoryItem.Add(new SelectListItem
                {
                    Value = ac.Id.ToString(),
                    Text = ac.Name,
                    Selected = ac.Id == ar.CategoryId
                });
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _assetRecordAppService.UpdateAsync(AssetRecord.Id, ObjectMapper.Map<EditAssetRecordViewModel, UpdateAssetRecordDto>(AssetRecord));
            return NoContent();
        }

        public class EditAssetRecordViewModel
        {
            [HiddenInput]
            public Guid Id { get; set; }
            public float Price { get; set; }

            [DisabledInput]
            public Guid Category { get; set; }

            [HiddenInput]
            public Guid CategoryId { get; set; }
        }
    }
}
