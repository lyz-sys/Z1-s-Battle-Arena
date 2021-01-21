﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroManager : MonoBehaviour
{
    public GameObject heroTypeBlue;
	public Sprite spriteTypeBlue;
	public Transform spawnPosBlue;

	public GameObject heroTypeRed;
	public Sprite spriteTypeRed;
	public Transform spawnPosRed;

	public static GameObject playerControledHero;
	public static Sprite playerHeroSprite;

	public void ChangeToMainScene()
	{
		playerControledHero = Instantiate(heroTypeBlue, spawnPosBlue);
		playerHeroSprite = spriteTypeBlue;

		DontDestroyOnLoad(heroTypeBlue);
		//DontDestroyOnLoad(Instantiate(heroTypeRed, spawnPosRed));
		SceneManager.LoadScene(0);
	}
}
