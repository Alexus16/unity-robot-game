using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
    public int HP = 50;
    public  int HP_MAX = 100;
    public int AP;
    public int AP_MAX = 100;
    public GameObject Gun;
    public bool HaveGun;
    public GameObject Target;
    public bool isTargetDestroyed;
    public bool IsFriendly;
    public string Name;

	// Use this for initialization
	void Start () {
        IsFriendly = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
