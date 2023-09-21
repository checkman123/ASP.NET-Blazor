using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.APP.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;

        //life cycle method
        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }
    }
}
