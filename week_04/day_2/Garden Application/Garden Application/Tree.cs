namespace Garden_Application
{
    class Tree : Plant
    {
        public Tree(string color)
        {
            this.plantType = "tree";
            this.color = color;
            this.waterNeeds = 10;
            this.absorbing = 0.4;

        }
    } 
}
