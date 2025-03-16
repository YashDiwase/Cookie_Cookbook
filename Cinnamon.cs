// See https://aka.ms/new-console-template for more information


class Cinnamon : Ingredient
{
    public Cinnamon(int id, string name) : base(id, name)
    {
    }

    public override string preparation_instructions()
    {
        return ("Take half a teaspoon. Add to other ingredients.");
    }
}
