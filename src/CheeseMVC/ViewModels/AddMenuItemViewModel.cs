using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        public int menuID { get; set; }
        public int cheeseID { get; set; }

        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }

        public AddMenuItemViewModel() { }

        public AddMenuItemViewModel(Menu menu, IEnumerable<Cheese> cheese)
        {
            Cheeses = new List<SelectListItem>();


            Menu = menu;
            foreach (var obj in cheese)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = obj.ID.ToString(),
                    Text = obj.Name
    
                });
            }

        }

    }

   
}
