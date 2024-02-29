using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{

    [SerializeField]public Transform[] Points;

    [SerializeField]public float moveSpeed;

    public int pointIndex;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Points[pointIndex].transform.position;
    }

    // Update is called once per frame
    public void MoveToPoint()
    {
       if(pointIndex<= Points.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, Points[pointIndex].transform.position, moveSpeed * Time.deltaTime);

            if(transform.position == Points[pointIndex].transform.position)
            {
                pointIndex += 1;
            }
        }
    }
}
