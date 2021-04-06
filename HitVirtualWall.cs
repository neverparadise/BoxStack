using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.MLAgents;

public class HitVirtualWall : MonoBehaviour
{
    public StackAgent11 agent_script;
    public GameObject box;
    public int Index;
    // Start is called before the first frame update
    void Start()
    {
        agent_script = GameObject.Find("Agent").GetComponent<StackAgent11>();
        //box = GameObject.FindGameObjectWithTag("Box").GetComponent<GameObject>();
        box = this.gameObject;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("Collide with wall, Set Reward -1");
            agent_script.SetReward(-1.0f);
            agent_script.EndEpisode();
        }
        
        if (collision.gameObject.CompareTag("Box"))
        {
            Debug.Log("Collide with Box");
            agent_script.Box_Stacked_list[Index] = true;
            //agent_script.AddReward(1/120f);
            //Debug.Log("Collide with Box" + Index);
        }

        else if (collision.gameObject.CompareTag("pallet"))
        {
            Debug.Log("Collide with pallet");
            agent_script.Box_Stacked_list[Index] = true;
            //agent_script.AddReward(1 / 240f);
            //Debug.Log("Collide with Plane" + Index);

        }
        else if (collision.collider == true)
            agent_script.Box_Stacked_list[Index] = false;
        else if (collision.collider == null)
            agent_script.Box_Stacked_list[Index] = false;

    }
}
