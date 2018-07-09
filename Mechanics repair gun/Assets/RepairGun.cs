using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairGun : MonoBehaviour
{
    
    public List<GameObject> Targets = new List<GameObject>();
    GameObject RepairParticle;
    Transform Start_Transform;
    Transform Mytransform;
    public bool isTargered;
    public bool isEnded;
    public GameObject target;
    private void Start()
    {


    }
    // Use this for initialization
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))

        {foreach (GameObject i in Targets)
                {
                    AI hp = i.GetComponent<AI>();
                    if (hp.HP_MAX == hp.HP)
                    {
                        Targets.Remove(i);
                    }
                }
            if (Targets.Count != 0)
            {
                isEnded = false;
                isTargered = false;

                target = Targets[0];
                foreach (GameObject i in Targets)
                {

                    if (Vector3.Distance(transform.position, i.transform.position) <= Vector3.Distance(target.transform.position, transform.position))
                    {
                        target = i;

                    }
                }
                isEnded = true;
                isTargered = true;
            }
            //float dist = Vector3.Distance(box.position, transform.position);
            //isEnded = false;
            //isTargered = false;
            //if (Targets.Count != 0)
            //{
            //    AI test;

            //    AI temp = target.GetComponent<AI>();
            //    foreach (GameObject i in Targets)
            //    {
            //        test = i.GetComponent<AI>();
            //        if (temp.HP > test.HP)
            //        {
            //            temp = test;
            //            target = i;
            //        }
            //    }
            //    isEnded = true;
           else
            {
                isEnded = true;
                isTargered = false;
            } //    isTargered = true;
        }
            
    }
    
    private void OnTriggerEnter(Collider other)
    {
        GameObject ent = other.gameObject;
        AI ente = ent.GetComponent<AI>();
        if (ente.IsFriendly)
        {
            Targets.Add(ent);
        }
            //foreach (GameObject o in Targets)
            //{
            //    if (o != ent)
            //    {
            
            //    }
            //}
    }
        
    
    private void OnTriggerExit(Collider other)
    {
        GameObject ent = other.gameObject;
        AI ente = ent.GetComponent<AI>();
        if (ente.IsFriendly)
        {
            Targets.Remove(ent);
        }
    }
    
}