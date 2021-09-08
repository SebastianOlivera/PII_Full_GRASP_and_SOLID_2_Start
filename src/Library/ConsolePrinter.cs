using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe (Recipe recipe)
        {
            Console.WriteLine(recipe.GetRecipeText());
        }
    }
}

//Cambie las responsabilidades usando el principio SRP para crean una clase Consoleprinter el cual tenga un metodo PrintRecipe que se encarge de imprimir el texto