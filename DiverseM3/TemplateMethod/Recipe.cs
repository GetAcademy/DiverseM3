namespace DiverseM3.TemplateMethod
{
    abstract class Recipe
    {
        public virtual void Prepare()
        {
            GatherIngredients();
            Mix();
            ExposeWithHeat();
            ExtraStep();
            FinalStep();
        }

        protected abstract void GatherIngredients();
        protected abstract void Mix();
        protected abstract void ExposeWithHeat();

        // abstract = må overrides
        protected abstract void FinalStep();

        // virtual = kan overrides
        protected virtual void ExtraStep()
        {
        }
    }
}
