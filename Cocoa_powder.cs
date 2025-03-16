// See https://aka.ms/new-console-template for more information


class Cocoa_powder : Ingredient
{
    public Cocoa_powder(int id, string name) : base(id, name)
    {
    }

    public override string preparation_instructions()
    {
        return ("Add to other ingredients.");
    }
}
