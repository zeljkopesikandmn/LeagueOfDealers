using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChipBuilder : MonoBehaviour
{

	public WhiteChipPool m_whiteChipPool;

	private List<ChipMono> m_activeChips = new List<ChipMono>();

	void Start()
    {
        
    }


	private void BuildChips(int inputChips)
	{

		
		int numOfChips = inputChips;
		int chip5s = 0;
		int singleChips = 0;
		var chip = m_whiteChipPool.Get();
		if (chip == null)
		{
			Debug.LogWarning("Chip pool is empty!");
			return;
		}

		while (numOfChips > 0)
		{
			if (numOfChips >= 5)
			{
				numOfChips -= 5;
				chip5s++;

			} 

			if (numOfChips < 5)
			{
				numOfChips--;
				singleChips++;
			}


		}
	}
}
