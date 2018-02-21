using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class Test1 {

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator TestPotionMaker() {

		//Check ingredients make the correct potions
		if (IngredientDrag.countFWing == 2 && IngredientDrag.countUHorn == 1) 
		{
			Assert.AreEqual (2, Cauldron.potionType1);
		}

		if (IngredientDrag.countDScales == 1 && IngredientDrag.countFeather == 2 && IngredientDrag.countVBlood == 1) 
		{
			Assert.AreEqual (1, Cauldron.potionType1);
		}

		if (IngredientDrag.countVBlood == 4 && IngredientDrag.countDScales == 1) 
		{
			Assert.AreEqual (3, Cauldron.potionType1);
		}

		if (IngredientDrag.countFWing == 2 && IngredientDrag.countUHorn == 1) 
		{
			Assert.AreEqual (4, Cauldron.potionType1);
		}

		//Check mistake potion
		if (IngredientDrag.countDScales == 10) 
		{
			Assert.AreEqual (5, Cauldron.potionType1);
		}


		yield return null;
	}

	[UnityTest]
	public IEnumerator TestPotionNotMaker()
	{
		if (IngredientDrag.countFWing == 2 && IngredientDrag.countUHorn == 1) 
		{
			Assert.AreNotEqual (5, Cauldron.potionType1);
		}

		if (IngredientDrag.countVBlood == 4 && IngredientDrag.countDScales == 1) 
		{
			Assert.AreNotEqual (1, Cauldron.potionType1);
		}

		yield return null;

	}

}
