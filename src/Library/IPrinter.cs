using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library;

public interface IPrinter
{
    void PrintRecipe(Recipe recipe);
    /* operación polimorfica ya que la usan dos objetos con diferente tipo (objeto de FilePrinter y objeto de ConsolePrinter). 
    A demás cumple con el principio de sustitucion ya que las salidas son las mismas, y el tipo de FilePrinter y
    ConsolePrinter es subtipo del tipo de IPrinter.*/
}