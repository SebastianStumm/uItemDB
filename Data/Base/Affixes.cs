using UnityEngine;
using UnityEditor;

public abstract class Affix
{
    private string _name;
    private AffixTypes _affixType;
    private Vector3Int _color;
    private int _priority;
    private int _value;
    private int _min;
    private int _max;

    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }

    public AffixTypes AffixType
    {
        get
        {
            return _affixType;
        }

        set
        {
            _affixType = value;
        }
    }

    public Vector3Int Color
    {
        get
        {
            return _color;
        }

        set
        {
            _color = value;
        }
    }

    public int Priority
    {
        get
        {
            return _priority;
        }

        set
        {
            _priority = value;
        }
    }

    public int Value
    {
        get
        {
            return _value;
        }

        set
        {
            _value = value;
        }
    }

    public int Min
    {
        get
        {
            return _min;
        }

        set
        {
            _min = value;
        }
    }

    public int Max
    {
        get
        {
            return _max;
        }

        set
        {
            _max = value;
        }
    }
}

public class Mighty : Affix
{
    public Mighty()
    {
        this.Name = "Mighty";
        this.AffixType = AffixTypes.Damage;
        this.Color = AffixColors.Red;
        this.Priority = 0;
        this.Min = 50;
        this.Max = 100;
    }
}

public class Brutal : Affix
{
    public Brutal()
    {
        this.Name = "Brutal";
        this.AffixType = AffixTypes.Damage;
        this.Color = AffixColors.Red;
        this.Priority = 0;
        this.Min = 100;
        this.Max = 200;
    }
}

public class Swift : Affix
{
    public Swift()
    {
        this.Name = "Swift";
        this.AffixType = AffixTypes.Attackspeed;
        this.Color = AffixColors.Green;
        this.Priority = 0;
        this.Min = 10;
        this.Max = 20;
    }
}

public class Quick : Affix
{
    public Quick()
    {
        this.Name = "Quick";
        this.AffixType = AffixTypes.Attackspeed;
        this.Color = AffixColors.Green;
        this.Priority = 0;
        this.Min = 20;
        this.Max = 40;
    }
}