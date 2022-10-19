//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        private static ProductCatalog productCatalog = new ProductCatalog();

        private static EquipmentCatalog equipmentCatalog = new EquipmentCatalog();

        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = productCatalog.GetProduct("Café con leche");
            recipe.AddStep(productCatalog.GetProduct("Café"), 100, equipmentCatalog.GetEquipment("Cafetera"), 120);
            recipe.AddStep(productCatalog.GetProduct("Leche"), 200, equipmentCatalog.GetEquipment("Hervidor"), 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }

        private static void PopulateCatalogs()
        {
            productCatalog.Add("Café", 100);
            productCatalog.Add("Leche", 200);
            productCatalog.Add("Café con leche", 300);

            equipmentCatalog.Add("Cafetera", 1000);
            equipmentCatalog.Add("Hervidor", 2000);
        }
        
    }
}
