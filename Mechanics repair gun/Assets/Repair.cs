using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repair : MonoBehaviour {
    Transform obj;
    public ParticleSystem repair;
    public bool friendly;
    public List<GameObject> Names = new List<GameObject>();
    public List<GameObject> Friendly = new List<GameObject>();
    bool f1;
	void Start () {
        f1 = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey/*Down*/(KeyCode.Mouse0))
        {
            
            foreach (GameObject Name in Names)
            {
                f1 = false;
                NewBehaviourScript2 friend = Name.GetComponent<NewBehaviourScript2>();
                friendly = friend.friendly;
                foreach(GameObject f in Friendly)
                {
                    if(f == Name)
                    {
                        f1 = true;
                    }
                }
                if(f1 == false && friendly == true)
                {
                    Friendly.Add(Name);
                }
            }

        }
        else/* if (Input.GetKeyUp(KeyCode.Mouse0))*/
        {
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Names.Add(other.gameObject);
    }
    private void OnTriggerExit(Collider other)
    {
        Names.Remove(other.gameObject); 
        foreach(GameObject name in Friendly)
        {
            bool i = false;
            if (name == other.gameObject)
            {
                i = true;
            }
            if(i == true)
            {
                Friendly.Remove(other.gameObject);
            }
        }
    }
}
