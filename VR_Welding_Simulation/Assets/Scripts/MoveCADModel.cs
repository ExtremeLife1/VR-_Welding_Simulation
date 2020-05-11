using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCADModel : MonoBehaviour
{

    public GameObject target;
    public Transform spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(target);
        GameObject Ball = Instantiate(target, spawnPosition.position, spawnPosition.rotation);
        Debug.Log(Ball.name);
        //Ball.AddComponent<Rigidbody>().AddForce(0,100,0);

        //BoxCollider box_ = Ball.AddComponent<BoxCollider>() as BoxCollider;
        //Ball.AddComponent<BoxCollider>();
        //Ball.GetComponent<BoxCollider>().enabled = true;

        


        Quaternion rotation = Quaternion.Euler(new Vector3(0, 0, 180));
        Ball.GetComponent<Transform>().rotation = rotation;
        //GameObject tmp = transform.Find("_14_DP3A_K1_001").gameObject;
        GameObject tmp_ = Ball.transform.Find("_14_DP3A_K1_001").gameObject;
        tmp_.GetComponent<Transform>().Translate(0, -5, 0);
        Ball.GetComponent<Transform>().Translate(10, 10, 0);
        //transform.FindChild()

    }

    // Update is called once per frame
    void Update()
    {

    }
}
