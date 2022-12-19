
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float x,y,z = 0;
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //GetAxis, define los controles de teclado para mover el player
        // * Time.deltaTime; se agrega por los cuadros por segundo, y lo dej estandar
        x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(x,y,z);        
    }
}
