using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor5dotnet.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace blazor5dotnet.Pages
{
    public partial class Counter : ComponentBase
    {
        [Inject]
        ILogger<Counter> logger {get;set;}

        [Inject]
        CounterViewModel vm {get;set;}

        protected  override void OnInitialized()
        {
            logger.LogInformation("Iniciando compoenente");
            Console.WriteLine("Iniciando Componente");
        }

        
        private void IncrementCount()
        {
            logger.LogInformation($"Incrementando count en 1 {vm.currentCount}");
            vm.currentCount++;
            logger.LogInformation($"Valor de count incrementado {vm.currentCount}");
        }
    }
}