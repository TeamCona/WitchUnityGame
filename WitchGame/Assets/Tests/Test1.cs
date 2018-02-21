using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class Test1 {

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator Test1WithEnumeratorPasses() {

		SetupScene ();
		yield return new WaitForSeconds(3);
	}

	public void SetupScene()
	{
		GameObject Potion = GameObject.FindWithTag("Potion");
		MonoBehaviour.Instantiate(Potion) ;
	}
}
