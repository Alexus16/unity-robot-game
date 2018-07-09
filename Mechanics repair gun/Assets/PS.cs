using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PS : MonoBehaviour
{
    public GameObject RepairMain;

    RepairGun gun;
    AI Tar;

    ParticleSystem ballP;
    ParticleSystem m1P;
    ParticleSystem m2P;
    ParticleSystem m3P;
    ParticleSystem m4P;
    ParticleSystem mrP;
    ParticleSystem repairP;

    Transform RepairPar;

    public GameObject ball;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    public GameObject mr;
    public GameObject Repair;
    void Start()
    {
        RepairPar = Repair.GetComponent<Transform>();

        gun = RepairMain.GetComponent<RepairGun>();

        ballP = ball.GetComponent<ParticleSystem>();
        m1P = m1.GetComponent<ParticleSystem>();
        m2P = m2.GetComponent<ParticleSystem>();
        m3P = m3.GetComponent<ParticleSystem>();
        m4P = m4.GetComponent<ParticleSystem>();
        mrP = mr.GetComponent<ParticleSystem>();
        repairP = Repair.GetComponent<ParticleSystem>();
        //-------Initialization end---------------//
        ballP.Stop();
        m1P.Stop();
        m2P.Stop();
        m3P.Stop();
        m4P.Stop();
        mrP.Stop();
        repairP.Stop();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Tar = gun.target.GetComponent<AI>();
            if (Tar.HP != Tar.HP_MAX)
            {
                Tar.HP += 1 ;
                Thread.Sleep(5);
            }
                
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            ballP.Play();
            m1P.Play();
            m2P.Play();
            m3P.Play();
            m4P.Play();
            mrP.Play();
            
            if (gun.isTargered)
            {
                RepairPar.LookAt(gun.target.transform);
                repairP.Play();
                
            }
            else
            {
                repairP.Stop();
            }
            //repairP.Play();
            
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            ballP.Stop();
            m1P.Stop();
            m2P.Stop();
            m3P.Stop();
            m4P.Stop();
            mrP.Stop();
            repairP.Stop();

        }
        else
        {

        }
    }

}