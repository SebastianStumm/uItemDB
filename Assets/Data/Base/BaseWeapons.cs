using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class BaseWeapon
{
    #region private attributes

    private string _baseName;
    private int _baseDamage;
    private int _baseAttackSpeed;
    private int _baseRange;
    private int _baseAreaRadius;
    private int _baseAreaDamage;

    #endregion

    #region public attributes

    public string BaseName
    {
        get
        {
            return _baseName;
        }

        set
        {
            _baseName = value;
        }
    }

    public int BaseDamage
    {
        get
        {
            return _baseDamage;
        }

        set
        {
            _baseDamage = value;
        }
    }

    public int BaseAttackSpeed
    {
        get
        {
            return _baseAttackSpeed;
        }

        set
        {
            _baseAttackSpeed = value;
        }
    }

    public int BaseRange
    {
        get
        {
            return _baseRange;
        }

        set
        {
            _baseRange = value;
        }
    }

    public int BaseAreaRadius
    {
        get
        {
            return _baseAreaRadius;
        }

        set
        {
            _baseAreaRadius = value;
        }
    }

    public int BaseAreaDamage
    {
        get
        {
            return _baseAreaDamage;
        }

        set
        {
            _baseAreaDamage = value;
        }
    }

    #endregion

}

public class Axe : BaseWeapon
{
    public Axe()
    {
        this.BaseName = "Axe";
        this.BaseDamage = 6;
        this.BaseAttackSpeed = 10;
        this.BaseRange = 2;
        this.BaseAreaRadius = 0;
        this.BaseAreaDamage = 0;
    }
}

public class Sword : BaseWeapon
{
    public Sword()
    {
        this.BaseName = "Sword";
        this.BaseDamage = 4;
        this.BaseAttackSpeed = 20;
        this.BaseRange = 2;
        this.BaseAreaRadius = 0;
        this.BaseAreaDamage = 0;
    }
}

public class Dagger : BaseWeapon
{
    public Dagger()
    {
        this.BaseName = "Dagger";
        this.BaseDamage = 2;
        this.BaseAttackSpeed = 30;
        this.BaseRange = 2;
        this.BaseAreaRadius = 0;
        this.BaseAreaDamage = 0;
    }
}

public class Mace : BaseWeapon
{
    public Mace()
    {
        this.BaseName = "Mace";
        this.BaseDamage = 8;
        this.BaseAttackSpeed = 5;
        this.BaseRange = 2;
        this.BaseAreaRadius = 4;
        this.BaseAreaDamage = 50; // Percent! also 4
    }
}



