//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
        public double GetProductionCost()
        {
            double stepCounter=0;
            foreach (Step step in this.steps)
            {
                stepCounter=stepCounter+step.GetStepcost();
                
            }
            return stepCounter;
        }
        /*El principio que utilice para seleccionar la clase Recipe es el método Expert ya que en esta clase se encuentra se encuentra
        la clase step, y considero que es la indicada para realizar los cálculos para obtener el costo total con todos los pasos*/
    }
}