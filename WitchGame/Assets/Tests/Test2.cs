using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class Test2 {

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator Test2WithEnumeratorPasses() {

		int po1 = 1;
		int po2 = 1;
		int po3 = 0;
		int po4 = 0;

		/*f (FDesk.day == 1) 
		{*/
			Assert.AreEqual (po1, FDesk.potionneed1);
			/*Assert.AreEqual (po2, FDesk.potionneed2);
			Assert.AreEqual (po3, FDesk.potionneed3);
			Assert.AreEqual (po4, FDesk.potionneed4);

		}*/

		yield return null;
	}
}
