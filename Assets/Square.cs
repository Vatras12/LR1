using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public GameObject square;
    public float rotationSpeed = 10;
    public int maxScale = 5;

    IEnumerator  Start()
    {
        while(true)
        {
            yield return  StartCoroutine(ChangeScale());
        }
      
    }

    void Update()
    {
        
        Vector3 position = transform.position;
        Vector3 axis = Vector3.forward;
        
        square.transform.RotateAround(position, axis, Time.deltaTime * rotationSpeed);
    }
     
    IEnumerator ChangeScale()
    {
        if (transform.localScale.x <= maxScale && transform.localScale.y <= maxScale)
        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
