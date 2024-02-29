using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Character_Controller : MonoBehaviour
{
    public Rigidbody rigidBody;
    public Collider collider;

    public Animator animator;

    public float Speed = 5f;

    public Path path;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
        animator = GetComponent<Animator>();
        path = GetComponent<Path>();
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    public void Moving()
    {
        if(animator.GetBool("CompletedReloading") == true)
        {
            //transform.Translate(0f, 0f, 3f * Time.deltaTime);
            path.MoveToPoint();
            float h = Input.GetAxis("Horizontal") * Speed;

            transform.Translate(h * Time.deltaTime, 0, 0);
        }
    }

    public void ReloadingComplete()
    {
        animator.SetBool("CompletedReloading", true);
    }
}
