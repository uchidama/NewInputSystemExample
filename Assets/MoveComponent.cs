using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{

    bool jump = false;
    Vector3 jump_vec = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(jump == true)
        {
            Vector3 g = new Vector3(0.0f, -0.05f, 0.0f);
            Vector3 pos = this.transform.position;

            jump_vec += g;
            pos += jump_vec;

            if(pos.y <= 0.0f)
            {
                pos.y = 0.0f;
                jump = false;
            }

            transform.position = pos;
        }
    }

    public void Jump()
    {
        Debug.Log("Jump");

        if (jump == true)
        {
            return;
        }

        jump = true;
        jump_vec = new Vector3(0.0f, 0.7f, 0.0f);

    }

    public void MoveHorizontal(float horizontal)
    {
        Vector3 m = new Vector3(horizontal/2.0f, 0f, 0f);
        this.transform.position += m;
    }

}
