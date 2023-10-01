using System;
using System.Collections.Generic;
using System.IO;

namespace Full_GRASP_And_SOLID.Library;
public class FilePrinter : IPrinter
{
    public void PrintRecipe(Recipe recipe)
    {
        if (recipe != null)
        {
            File.WriteAllText("recipe.txt", recipe.GetTextToPrint());
        }
        else
        {
            throw new Exception("La receta a imprimir es invalida");
        }
    }
}