using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

	public int coins;
	public int hearts;
	public Text coinsText;
	public Text heartsText;

	// Update is called once per frame
	void Update () {

		coinsText.text = ("Coins: " + coins);
		heartsText.text = ("Hearts: " + hearts);
	}
}
