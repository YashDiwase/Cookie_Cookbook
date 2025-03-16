// See https://aka.ms/new-console-template for more information


class Cardamom : Ingredient
{
    public Cardamom(int id, string name) : base(id, name)
    {
    }

    public override string preparation_instructions()
    {
        return ("Take half a teaspoon. Add to other ingredients.");
    }
}
