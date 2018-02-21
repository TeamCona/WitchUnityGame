using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class Test2 {

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator TestUpgradeShop() 
	{

		//Check the cauldron upgrades.
		if (UpgradeShop.upgrade1 == 1) 
		{
			Assert.AreEqual (2, Cauldron.seconds);
		}

		if (UpgradeShop.upgrade1 == 2) 
		{
			Assert.AreEqual (1, Cauldron.seconds);

		}

		//Check the upgrade costs
		if (UpgradeShop.cost1 == 4) 
		{
			Assert.AreEqual (0, UpgradeShop.upgrade1);
		}

		if (UpgradeShop.cost1 == 7) 
		{
			Assert.AreEqual (1, UpgradeShop.upgrade1);
		}

		if (UpgradeShop.cost2 == 5) 
		{
			Assert.AreEqual( 0, UpgradeShop.upgrade2);
		}

		if (UpgradeShop.cost2 == 9)
		{
			Assert.AreEqual (1, UpgradeShop.upgrade2);
		}

		yield return null;

	}

	[UnityTest]
	public IEnumerator TestNotUpgradeShop()
	{
		//Check the cauldron upgrades

		if (UpgradeShop.upgrade1 == 1) 
		{
			Assert.AreNotEqual (3, Cauldron.seconds);
		}

		if (UpgradeShop.upgrade1 == 1) 
		{
			Assert.AreEqual (1, Cauldron.seconds);

		}

		//Check th upgrade costs

		if (UpgradeShop.cost1 == 5) 
		{
			Assert.AreNotEqual (0, UpgradeShop.upgrade1);
		}

		if (UpgradeShop.cost1 == 7) 
		{
			Assert.AreNotEqual (2, UpgradeShop.upgrade1);
		}

		if (UpgradeShop.cost2 == 5) 
		{
			Assert.AreNotEqual( 1, UpgradeShop.upgrade2);
		}

		if (UpgradeShop.cost2 == 9)
		{
			Assert.AreNotEqual (0, UpgradeShop.upgrade2);
		}

		yield return null;
	}

}
