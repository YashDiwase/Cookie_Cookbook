// See https://aka.ms/new-console-template for more information


class Wheat : Ingredient
{
    public Wheat(int id, string name) : base(id, name)
    {
    }

    public override string preparation_instructions()
    {
        return ("Sieve. Add to other ingredients.");
    }
}
