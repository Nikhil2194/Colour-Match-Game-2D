using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChecker : MonoBehaviour
{
   public RandomiserColor _randomiserColor;
   public GameObject buttonGroup;
   public GameObject winnerScreen;
   public GameObject loserScreen;

   public Color colorSetted;
   public string colorNameSetted;

   private void Start()
   {
       colorSetted= _randomiserColor.currentColor ;
       colorNameSetted=_randomiserColor.currentcolorName;
   }

   private void Update()
   {
       if (Input.GetKeyDown(KeyCode.Space))  // Example: Check for the space key, replace it with the actual button press logic
       {
           if (_randomiserColor.IsCorrectColorPressed())
           {
               Debug.Log("WINNER");
               winnerScreen.SetActive(true);
               buttonGroup.SetActive(false);
           }
           else
           {
               Debug.Log("LOSER");
               loserScreen.SetActive(true);
               buttonGroup.SetActive(false);
           }
       }
   }
   
   
   public void BlackButton()
   {
       colorNameSetted = "Black";
       buttonGroup.SetActive(false);
       winnerScreen.SetActive(true);
   }
   
   public void Blueutton()
   {
       colorNameSetted = "Blue";
       buttonGroup.SetActive(false);
       winnerScreen.SetActive(true);
   }
   
   public void BrownButton()
   {
       colorNameSetted = "Brown";
       buttonGroup.SetActive(false);
       winnerScreen.SetActive(true);
   }
   public void GreenButton()
   {
       colorNameSetted = "Green";
       buttonGroup.SetActive(false);
       winnerScreen.SetActive(true);
   }
   
   public void RedButton()
   {
       colorNameSetted = "Red";
       buttonGroup.SetActive(false);
       winnerScreen.SetActive(true);
   }
   
   public void PurpleButton()
   {
       colorNameSetted = "Purple";
       buttonGroup.SetActive(false);
       winnerScreen.SetActive(true);
   }
   public void OrangeButton()
   {
       colorNameSetted = "Orange";
       buttonGroup.SetActive(false);
       winnerScreen.SetActive(true);
   }
   public void PinkButton()
   {
       colorNameSetted = "Pink";
       buttonGroup.SetActive(false);
       winnerScreen.SetActive(true);
   }
   public void SkyBlueButton()
   {
       colorNameSetted = "SkyBlue";
       buttonGroup.SetActive(false);
       winnerScreen.SetActive(true);
   }
   public void YellowButton()
   {
       colorNameSetted = "Yellow";
       buttonGroup.SetActive(false);
       winnerScreen.SetActive(true);
   }
   
}
