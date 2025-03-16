// See https://aka.ms/new-console-template for more information


public abstract class Ingredient
{
    int id_;
    string name_;
    public Ingredient(int id, string name)
    {
        id_ = id;
        name_= name;
    }

    public int Id { get => id_; set => id_ = value; }
    public string Name { get => name_; set => name_ = value; }

    public abstract string preparation_instructions();

}
