using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Project.Pages
{
    public partial class SidebarChat : ComponentBase
    {
        Random _random = new Random();

        int x = 0;

        protected override async Task OnInitializedAsync()
        {
            x = _random.Next(1000, 9999);
        }
    }
}