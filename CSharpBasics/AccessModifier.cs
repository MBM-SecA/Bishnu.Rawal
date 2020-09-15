using EnumsAndProperties;

public class AccessModifier
{
    internal void DoSomething()
    {

    }

    public void DoAnotherThing()
    {
        DoSomething();
    }
}

class ModifierDemo
{
    void DoSomething()
    {
        Person person = new Person();
        person.Age = 34;
        person.Age = 45;
    }
}