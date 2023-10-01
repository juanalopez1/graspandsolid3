using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library;

public class ConsolePrinter : IPrinter
{
    public void PrintRecipe(Recipe recipe)
    {
        if (recipe != null)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
        else
        {
            throw new Exception("La receta a imprimir es invalida");
        }
    }
}