using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public BaseWeaponData baseWeaponData;

	// Use this for initialization
	void Start () {
        Debug.Log(baseWeaponData.BaseAxe.BaseName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
