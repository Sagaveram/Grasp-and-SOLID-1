//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        public double GetStepcost()
        {
            double costoproducto=Quantity*Input.UnitCost;
            double costoequipamiento=Equipment.HourlyCost*Time;
            return costoproducto+costoequipamiento;
        }
        /*Para ubicar el método GetStepCost() utilice el principio SRP, ya que creo que al asignar todo a la clase GetProductionCost
        no se estaría cumpliendo que el método cupla con una sola responsabilidad que es calcular el costo del step
        También utilice el principio Expert ya que todos los datos para hacer el cálculo del GetStepcost se encuentran en la clase Step,
        siendo esta la clase experta para realizar esta función*/
    }
}
