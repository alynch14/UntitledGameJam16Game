using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStats : MonoBehaviour
{
    public string charName;
    public int playerLevel = 1;
    public int currentEXP;
    public int[] expToNextLevel;
    public int maxLevel = 100;
    public int baseEXP = 1000;
    public int currentHP;
    public int maxHP = 100;
    //todo: add public ints for other stats 
    public Sprite charImage;
    // Start is called before the first frame update
    void Start()
    {
        expToNextLevel = new int[maxLevel];
        expToNextLevel[1] = baseEXP;
        for (int i = 2; i < expToNextLevel.Length; i++)
        {
            expToNextLevel[i] = Mathf.FloorToInt(expToNextLevel[i - 1] * 1.05f);
        }
    }

    public void AddExp(int expToAdd)
    {
        currentEXP += expToAdd;
        if (playerLevel < maxLevel)
        {
            if (currentEXP > expToNextLevel[playerLevel])
            {
                currentEXP -= expToNextLevel[playerLevel];
                playerLevel++;
                if (playerLevel % 2 == 0)
                {
                    //some stat
                }
                else
                {
                    //some stat
                }
                maxHP = Mathf.FloorToInt(maxHP * 1.05f);
                currentHP = maxHP;
            }
        }
        if (playerLevel >= maxLevel)
        {
            currentEXP = 0;
        }
    }
}
