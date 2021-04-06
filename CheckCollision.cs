using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.MLAgents;

public class CheckCollision : MonoBehaviour
{
    public StackAgent14 agent_script;
    public GameObject box;
    public int Index;
    // Start is called before the first frame update
    void Start()
    {
        agent_script = GameObject.Find("Agent").GetComponent<StackAgent14>();
        //box = GameObject.FindGameObjectWithTag("Box").GetComponent<GameObject>();
        box = this.gameObject;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        agent_script.Box_Stacked_list[Index] = true;
        //Debug.Log("Box collide with something");
    }
}
