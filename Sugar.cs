// See https://aka.ms/new-console-template for more information


class Sugar : Ingredient
{
    public Sugar(int id, string name) : base(id, name)
    {
    }

    public override string preparation_instructions()
    {
        return ("Add to other ingredients.");
    }
}
