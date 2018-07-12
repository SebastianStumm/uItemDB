using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "BaseWeapons", menuName = "BaseWeapons", order = 1)]
public class AffixesData : ScriptableObject
{
    private List<Affix> _prefixes;
    private List<Affix> _suffixes;
    
    public AffixesData()
    {
        this._prefixes = new List<Affix>();
        this._suffixes = new List<Affix>();
        this._prefixes.Add(new Mighty());
        this._prefixes.Add(new Brutal());
        this._prefixes.Add(new Swift());
        this._prefixes.Add(new Quick());
    }

    public List<Affix> Prefixes
    {
        get
        {
            return _prefixes;
        }
    }

    public List<Affix> Suffixes
    {
        get
        {
            return _suffixes;
        }
    }
}