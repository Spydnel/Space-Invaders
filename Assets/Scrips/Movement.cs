using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float Xvelocity;
    [SerializeField]float Speed;
    [SerializeField] float Friction;
    [SerializeField] float Rotation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Xvelocity += (
            (Input.GetKey(KeyCode.D) ? 1 : 0) -
            (Input.GetKey(KeyCode.A) ? 1 : 0)) * Speed * Time.deltaTime;

        transform.position = transform.position + new Vector3(Xvelocity * Time.deltaTime, 0f, 0f);
        transform.rotation = transform.rotation = Quaternion.AngleAxis(Xvelocity * Rotation, Vector3.forward);

        Xvelocity = Xvelocity * Mathf.Pow(Friction, Time.deltaTime);
    }
}
