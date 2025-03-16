// See https://aka.ms/new-console-template for more information


class Butter : Ingredient
{
    public Butter(int id, string name) : base(id, name)
    {
    }

    public override string preparation_instructions()
    {
        return ("Melt on low heat. Add to other ingredients.");
    }
}
