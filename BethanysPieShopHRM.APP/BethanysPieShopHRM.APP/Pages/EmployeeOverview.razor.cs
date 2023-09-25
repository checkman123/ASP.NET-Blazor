using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BethanysPieShopHRM.APP.Pages
{
    public partial class EmployeeOverview
    {
        [Inject]
        public HttpClient HttpClient { get; set; }
        public List<Employee>? Employees { get; set; } = default!;
        private Employee? _selectedEmployee;
        public string Title = "Employee Overview";

        //life cycle method
        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }
        protected override async Task OnInitializedAsync()
        {
            var data = await HttpClient.GetFromJsonAsync<List<Employee>>("https://localhost:7039/api/Employee");
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
