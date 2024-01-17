using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    public Rigidbody rigidBody;
    public Collider collider;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
        animator = GetComponent<Animator>();
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
            transform.Translate(0f, 0f, 3f * Time.deltaTime);
        }
    }

    public void ReloadingComplete()
    {
        animator.SetBool("CompletedReloading", true);
    }
}
