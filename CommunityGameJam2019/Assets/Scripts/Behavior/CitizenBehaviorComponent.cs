using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenBehaviorComponent : MonoBehaviour
{
    public void OnSeePlayer(bool isInSight, GameObject Player)
    {
        GetComponent<Animator>().SetBool("seePlayer", isInSight);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
