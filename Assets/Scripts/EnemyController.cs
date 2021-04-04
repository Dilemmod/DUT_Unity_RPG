using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Chat chatScript;
	private Animator enemyAnim;
	private int  counter =0;
    void Awake()
    {
        GameObject chatCanvas = GameObject.Find("ChatCanvas");
        chatScript = chatCanvas.GetComponent<Chat>();
		enemyAnim = GetComponent<Animator>();

	}
	void OnTriggerEnter(Collider obj) 
	{
		if(counter==0)
		if (obj.name == "Player")
		{
			
			enemyAnim.SetTrigger("PlayerCome");
			chatScript.CreateMessage("The battle has begun");
				counter = 1;
			//Destroy(gameObject); //Удаление объекта с карты
		}
		
	}
}
