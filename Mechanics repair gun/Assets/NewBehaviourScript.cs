﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repair : MonoBehaviour
{
    ParticleSystem ballP;
    ParticleSystem m1P;
    ParticleSystem m2P;
    ParticleSystem m3P;
    ParticleSystem m4P;
    ParticleSystem mrP;
    ParticleSystem repairP;

    public GameObject ball;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    public GameObject mr;
    public GameObject Repair;
    void Start()
    {
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
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ballP.Play();
            m1P.Play();
            m2P.Play();
            m3P.Play();
            m4P.Play();
            mrP.Play();
            repairP.Play();
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
        else { }
    }
}
