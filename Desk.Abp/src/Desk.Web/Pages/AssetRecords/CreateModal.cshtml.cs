using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Desk.Assets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Desk.Web.Pages.AssetRecords
{
    public class CreateModalModel : DeskPageModel
    {
        private readonly IAssetRecordAppService _assetRecordAppService;
        private readonly IAssetCategoryAppService _assetCategoryAppService;

        [BindProperty]
        public CreateAssetRecordViewModel AssetRecord { get; set; }
        public List<SelectListItem> NotInRootCategoryItem { get; set; }

        public CreateModalModel(IAssetRecordAppService assetRecordAppService, IAssetCategoryAppService assetCategoryAppService)
        {
            _assetRecordAppService = assetRecordAppService;
            _assetCategoryAppService = assetCategoryAppService;
        }

        public async Task OnGetAsync()
        {
            AssetRecord = new CreateAssetRecordViewModel();
            NotInRootCategoryItem = new List<SelectListItem>();

            var ac = await _assetCategoryAppService.GetNotInRootListAsync();
            ac.ForEach(x =>
            {
                NotInRootCategoryItem.Add(new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                });
            });
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateAssetRecordViewModel, CreateAssetRecordDto>(AssetRecord);
            await _assetRecordAppService.CreateAsync(dto);
            return NoContent();
        }

        public class CreateAssetRecordViewModel
        {
            public float Price { get; set; }
            public Guid CategoryId { get; set; }
        }
    }
}
