using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	public int index = 0; //Номер предмета
	private Chat chatScript;
	public GameObject Weapons;

    void Awake()
    {
		GameObject chatCanvas = GameObject.Find("ChatCanvas");
		chatScript = chatCanvas.GetComponent<Chat>();
    }
    void OnTriggerEnter(Collider obj) //«Наезд» на объект
	{
		if (obj.name == "Player")
		{
			//Destroy(Weapons);
			Weapons.SetActive(true);
			chatScript.CreateMessage("You picked up sword and shield");
			Destroy(gameObject); //Удаление объекта с карты
		}
	}
}
