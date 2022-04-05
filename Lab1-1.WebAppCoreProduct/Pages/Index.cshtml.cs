using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1_1.WebAppCoreProduct.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Lab1_1.WebAppCoreProduct.Pages
{
    //Требуется, чтобы страница принимала название продукта и его цену, а также была реализована проверка вводимой цены.
    public class IndexModel : PageModel
    {
        
        public void OnGet(string name, decimal? price)
        {
            
        }            

    }
}
