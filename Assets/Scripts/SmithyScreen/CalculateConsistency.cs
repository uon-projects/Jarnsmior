﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateConsistency
{

    List<float> mList = new List<float>();
    public void Add(float n)
    {
        mList.Add(n);
        calulateConsistecy();
    }
    public List<float> GetList()
    {
        return mList;
    }
    public void Initinialize()
    {
        mList = new List<float>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void calulateConsistecy()
    {
        int i = 0;
        while(i<mList.Capacity - 1)
        {
            Debug.Log(i);
            Debug.Log(mList[i] - mList[+1]);
            i++;
        }
    }

}
