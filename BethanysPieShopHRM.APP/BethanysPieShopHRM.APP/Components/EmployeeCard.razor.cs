using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.APP.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;
        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Employee.LastName))
            {
                throw new Exception("Last name cant be empty");
            }
        }

        public void NavigateToDetails(Employee selectedEmployee)
        {
            // can add more code like auth check
            NavigationManager.NavigateTo($"employeedetail/{selectedEmployee.EmployeeId}");
        }
        public void NavigateToEdit(Employee selectedEmployee)
        {
            // can add more code like auth check
            NavigationManager.NavigateTo($"employeeedit/{selectedEmployee.EmployeeId}");
        }
    }
}
