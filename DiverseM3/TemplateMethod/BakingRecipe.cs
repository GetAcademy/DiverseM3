namespace DiverseM3.TemplateMethod
{
    class BakingRecipe : Recipe
    {
        protected override void GatherIngredients()
        {
            AddFlour();
        }

        private void AddFlour()
        {
        }

        protected override void Mix()
        {
            RunInBlender();
        }

        private void RunInBlender()
        {
        }

        protected override void ExposeWithHeat()
        {
        }

        protected override void FinalStep()
        {
        }
    }
}
