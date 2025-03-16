// See https://aka.ms/new-console-template for more information


class Coconut_flour : Ingredient
{
    public Coconut_flour(int id, string name) : base(id, name)
    {
    }

    public override string preparation_instructions()
    {
        return ("Sieve. Add to other ingredients.");
    }
}
