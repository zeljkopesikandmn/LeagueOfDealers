using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChipBuilder : MonoBehaviour
{


	void Start()
    {
		ObjectPooler.Instance.SpawnFromPool("whiteChip", transform.position, Quaternion.identity);
	}


	private void BuildChips(int inputChips)
	{

		
		int numOfChips = inputChips;
		int chip5s = 0;
		int singleChips = 0;

		
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
