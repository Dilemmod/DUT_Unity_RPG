using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
	private Chat chatScript;
	int counter = 0;
	void Awake()
	{
		GameObject chatCanvas = GameObject.Find("ChatCanvas");
		chatScript = chatCanvas.GetComponent<Chat>();
	}
	void OnTriggerEnter(Collider obj) 
	{
		if (obj.name == "Player")
		{
			if (counter == 0)
			{
				chatScript.CreateMessage("RISE from the dead, I am your MASTER");
				chatScript.CreateMessage("in order to destroy this world,");
				chatScript.CreateMessage("you first have to equip yourself with weapons.");
				chatScript.CreateMessage("Take this beautiful sword and shield behind me");
				counter = 1;
			}
            else if(counter == 1)
            {
				chatScript.CreateMessage("If you have already taken the sword, ");
				chatScript.CreateMessage("KILL the man behind the tree in front of me");
				counter = 2;
			}
            else if(counter ==2 )
            {
				chatScript.CreateMessage("I have nothing more to teach you");
				counter = 3;
			}
		}
	}
}
