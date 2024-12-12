using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pendik.ProductManagment.Models.ViewModels;

public class CategorySelectListViewModel
{
    public int? CategoryId { get; set; }
    public IEnumerable<SelectListItem> Categories { get; set; }
}