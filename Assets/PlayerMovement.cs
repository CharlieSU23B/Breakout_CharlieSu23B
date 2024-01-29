using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    GameObject aimObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 aimPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, 50, -Camera.main.transform.position.z));

        if (aimPos.x < 8.01 && aimPos.x > -8.01)
        {
            aimObject.transform.position = aimPos;
        }
        else if(transform.position.x < -8.01)
        {
            transform.position = new Vector3(-8, transform.position.y, 0);
        }
        else if (transform.position.x > 8.01)
        {
            transform.position = new Vector3(8, transform.position.y, 0);
        }

    }
}
