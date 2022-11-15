using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        //Modificado por DIP
        public void PrintRecipe(IRecipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}