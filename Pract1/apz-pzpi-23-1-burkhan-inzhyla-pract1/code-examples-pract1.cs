// Component
public interface ICharacter
{
    string GetDescription();
    int GetPower();
}


// ConcreteComponent
public class BasicCharacter : ICharacter
{
    public string GetDescription()
    {
        return "Basic character";
    }
    public int GetPower()
    {
        return 10;
    }
}

// Decorator
public abstract class CharacterDecorator : ICharacter
{
    protected ICharacter character;
    public CharacterDecorator(ICharacter character)
    {
        this.character = character;
    }


    public virtual string GetDescription()
    {
        return character.GetDescription();
    }

    public virtual int GetPower()
    {
        return character.GetPower();
    }
}

// ConcreteDecorator: Shield
public class ShieldDecorator : CharacterDecorator
{
    public ShieldDecorator(ICharacter character) : base(character) { }

    public override string GetDescription()
    {
        return character.GetDescription() + " + Shield";
    }

    public override int GetPower()
    {
        return character.GetPower() + 5;
    }
}

// ConcreteDecorator: Speed
public class SpeedDecorator : CharacterDecorator
{
    public SpeedDecorator(ICharacter character) : base(character) { }

    public override string GetDescription()
    {
        return character.GetDescription() + " + Speed";
    }
    public override int GetPower()
    {
        return character.GetPower() + 3;
    }
}