using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class Test3 {


	[UnityTest]
	public IEnumerator DayStart() {

		if (FDesk.potionneed1 == 1 && FDesk.potionneed2 == 1 && FDesk.potionneed3 == 0 && FDesk.potionneed4 == 0)
		{
			Assert.AreEqual(1, FDesk.day);
		}

		if (FDesk.potionneed1 == 2 && FDesk.potionneed2 == 3 && FDesk.potionneed3 == 2 && FDesk.potionneed4 == 0)
		{
			Assert.AreEqual(2, FDesk.day);
		}

		if (FDesk.potionneed1 == 3 && FDesk.potionneed2 == 4 && FDesk.potionneed3 == 3 && FDesk.potionneed4 == 4)
		{
			Assert.AreEqual(3, FDesk.day);
		}
		yield return null;
	}


	[UnityTest]
	public IEnumerator NotDayStart() {

		if (FDesk.potionneed1 == 1 && FDesk.potionneed2 == 1 && FDesk.potionneed3 == 0 && FDesk.potionneed4 == 0)
		{
			Assert.AreEqual(2, FDesk.day);
		}

		if (FDesk.potionneed1 == 2 && FDesk.potionneed2 == 3 && FDesk.potionneed3 == 2 && FDesk.potionneed4 == 0)
		{
			Assert.AreEqual(3, FDesk.day);
		}

		if (FDesk.potionneed1 == 3 && FDesk.potionneed2 == 4 && FDesk.potionneed3 == 3 && FDesk.potionneed4 == 4)
		{
			Assert.AreEqual(1, FDesk.day);
		}
		yield return null;
	}
}
