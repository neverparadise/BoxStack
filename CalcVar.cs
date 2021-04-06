using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcVar : MonoBehaviour
{

    public GameObject Boxes;
    public Rigidbody Box1, Box2, Box3, Box4, Box5, Box6, Box7, Box8;
    public List<Rigidbody> Stacked_Box_list;
    

void Start()
    {
        Stacked_Box_list.Add(Box1);
        Stacked_Box_list.Add(Box2);
        Stacked_Box_list.Add(Box3);
        Stacked_Box_list.Add(Box4);
        Stacked_Box_list.Add(Box5);
        Stacked_Box_list.Add(Box6);
        Stacked_Box_list.Add(Box7);
        Stacked_Box_list.Add(Box8);
    }


    // Update is called once per frame
    void Update()
    {
        float tempVar = 0.0f;
        float boundary = 0.0f;
        for (int i = 0; i < Stacked_Box_list.Count - 1; i++)
        {
            for (int j = i + 1; j < Stacked_Box_list.Count; j++)
            {
                tempVar += Mathf.Pow(Vector3.Distance(Stacked_Box_list[i].worldCenterOfMass, Stacked_Box_list[j].worldCenterOfMass), 2.0f);
            }
        }
        Debug.Log(tempVar);
    }
}
