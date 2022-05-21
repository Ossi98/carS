using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
	    public GameObject win;
		public CarController carController;
		public static bool gamefinished; 


		private void OnTriggerEnter2D(Collider2D collision)
		{
			    gamefinished = true;
            	win.SetActive(true);

		}
}

