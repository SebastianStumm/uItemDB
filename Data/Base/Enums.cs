using UnityEngine;
using System.Collections;

public enum AffixTypes
{
    Damage,
    Attackspeed,
    Range,
    Radius,
    AreaDamage
}

public static class AffixColors
{
    private static Vector3Int _red = new Vector3Int(255, 0, 0);
    private static Vector3Int _green = new Vector3Int(0, 255, 0);
    private static Vector3Int _blue = new Vector3Int(0, 0, 255);

    public static Vector3Int Red
    {
        get
        {
            return _red;
        }
    }

    public static Vector3Int Green
    {
        get
        {
            return _green;
        }
    }

    public static Vector3Int Blue
    {
        get
        {
            return _blue;
        }
    }
}