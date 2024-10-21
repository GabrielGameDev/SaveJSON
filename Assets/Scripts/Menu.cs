using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class Menu : MonoBehaviour
{
	public TMP_InputField inputField;
	public Image selectedColor;

	public Color red, green, blue, yellow;


	void SetColor(Color color)
	{
		GameManager.instance.color = color;
		selectedColor.color = color;
	}


	public void SetRed()
	{
		SetColor(red);
	}

	public void SetGreen()
	{
		SetColor(green);
	}

	public void SetBlue()
	{
		SetColor(blue);
	}

	public void SetYellow()
	{
		SetColor(yellow);
	}

	public void StartGame()
	{
		GameManager.instance.amount = inputField.text == "" ? 0 : int.Parse(inputField.text);
		SceneManager.LoadScene("Game");
	}

	public void LoadGame()
	{
		GameManager.instance.Load();
		selectedColor.color = GameManager.instance.color;
		inputField.text = GameManager.instance.amount.ToString();
	}

	public void SaveGame()
	{
		GameManager.instance.amount = inputField.text == "" ? 0 : int.Parse(inputField.text);
		GameManager.instance.Save();
	}
}
