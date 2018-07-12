using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "BaseWeapons", menuName = "BaseWeapons", order = 1)]
public class BaseWeaponData : ScriptableObject
{

    public Axe BaseAxe
    {
        get
        {
            return new Axe();
        }
    }

    public Sword BaseSword
{
        get
        {
            return new Sword();
        }
    }

    public Dagger BaseDagger
{
        get
        {
            return new Dagger();
        }
    }

    public Mace BaseMace
{
        get
        {
            return new Mace();
        }
    }
}


