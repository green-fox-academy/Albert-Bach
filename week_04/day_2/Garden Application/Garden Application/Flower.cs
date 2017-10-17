namespace Garden_Application
{
    class Flower : Plant
    {
       public Flower(string color)
       {
            this.plantType = "flower";
            this.color = color;
            this.waterNeeds = 5;
            this.absorbing = 0.75;
       }
    } 
}
