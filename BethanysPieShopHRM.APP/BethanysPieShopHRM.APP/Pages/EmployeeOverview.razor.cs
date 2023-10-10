using BethanysPieShopHRM.APP.Models;
using BethanysPieShopHRM.APP.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BethanysPieShopHRM.APP.Pages
{
    public partial class EmployeeOverview
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        public List<Employee>? Employees { get; set; } = default!;
        private Employee? _selectedEmployee;
        public string Title = "Employee Overview";

        //life cycle method
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }
        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
