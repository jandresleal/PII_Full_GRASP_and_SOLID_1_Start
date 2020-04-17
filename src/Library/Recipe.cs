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
        public double GetProductionCost(Step step)

    //Lo hicimos en esta clase xq es la contiene toda la información para realizar el calculo (por metodo EXPERT)
        {
            double costo = 0;
            costo = costo + step.Quantity * step.Input.UnitCost + step.Equipment.HourlyCost * step.Time; 
            
            
            return costo;
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
                Console.WriteLine($"Costo total de producción: {this.GetProductionCost(step)}:");
                
            }
        }
    }
}