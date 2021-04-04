using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    private Camera camera;
    private bool leftPointerClicked;
    private bool atackButtonClicked;
    private Animator playerAnimator;
    private GameObject wepons;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        leftPointerClicked = Input.GetButton("Fire1");
        atackButtonClicked = Input.GetButton("Fire2");
    }
    private void FixedUpdate()
    {
        if (atackButtonClicked)
        {
            //wepons.SetActive(true);
            playerAnimator.SetTrigger("Atack");
        }
        if (leftPointerClicked)
        {
            //Зустріч проміня з колайдером
            RaycastHit hitInfo;
            //Raycast створює промінь 
            if (Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hitInfo, 100))
            {
                navMeshAgent.destination = hitInfo.point;
                playerAnimator.SetBool("Run", true);
            }
        }
        //Зупинка анімації бігу
        if (Vector3.Distance(transform.position, navMeshAgent.destination) <= navMeshAgent.stoppingDistance && playerAnimator.GetBool("Run"))
        {
            playerAnimator.SetBool("Run", false);
            navMeshAgent.destination = transform.position;
        }
    }
}
