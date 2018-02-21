using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class Test2 {

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator Test2WithEnumeratorPasses() 
	{

		int expected = 1;


		Assert.AreEqual (expected, FDesk.day);

		yield return null;
	}
}
