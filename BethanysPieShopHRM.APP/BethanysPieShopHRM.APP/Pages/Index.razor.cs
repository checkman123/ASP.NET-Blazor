using BethanysPieShopHRM.APP.Components.Widgets;

namespace BethanysPieShopHRM.APP.Pages
{
    public partial class Index
    {
        public List<Type> Widgets { get; set; } = new List<Type>() { 
            typeof(EmployeeCountWidget), typeof(InboxWidget) };
    }
}
