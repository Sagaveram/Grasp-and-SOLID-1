using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library{
    public static class ConsolePrinter    
        {public static void PrintRecipe(Recipe recipe)
            {
            Console.WriteLine(recipe.GetTextToPrint());
            }
        }
}
/*Para implementar este cambio utilice el principio SRP ya que previamente, la clase recipe era la encargada de realizar las impresiones
en consola, bajo el principio SRP esto no estaría bien, ya que puede tener mas de una razón para cambiar.
Ya con la clase ConsolePrinter esto no sucede puesto a que si queremos cambiar lo que se imprime posteriormente en el programa, podemos
hacerlo directamente en esta nueva clase la cuál solo tiene una responsabilidad, la cuál es imprimir la receta. */
