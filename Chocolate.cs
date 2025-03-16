// See https://aka.ms/new-console-template for more information


class Chocolate : Ingredient
{
    public Chocolate(int id, string name) : base(id, name)
    {
    }

    public override string preparation_instructions()
    {
        return ("Melt in a water bath. Add to other ingredients.");
    }
}
