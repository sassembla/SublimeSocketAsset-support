using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;

class Something : MonoBehaviour{
	public void Some ()	{
		/*
			you can complete Unity's default class and parameters.
		*/
		var a = transform.position.x;
		// var b = new Vector3(x, y, z)
		// var c = Instantiate(original)
		
		/*
			also you can complete C# libs, your own classes and parameters,
			 with http://u3d.as/content/sassembla/sublime-socket-asset/4SP version! 
		*/
		// var d = new List<T>() 
		// var e = new Someone(s)
		// var f = counter.Equals(obj)

	}

	int counter = 0;
	public void Update () {
		Debug.Log("L:here! " + counter);
		counter++;
	}


}

class Someone {
	public string a;

	public Someone(string s) {
		
	}
}