using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RandomiserColor : MonoBehaviour
{
    [SerializeField] private ColorSO[] colorSOInstance;
    [SerializeField] public Image bgScreenImage;
    [SerializeField] public GameObject buttonGroup;
    [SerializeField] public GameObject winnerScreen;
    [SerializeField] public GameObject losserScreen;
    [SerializeField] public ColorChecker ColorChecker;
    

    [Header("Curent Color Data")]
    public Color currentColor;
    public  string currentcolorName;
    
    [Header("Color From SO")]
    public Color colorSetted;
    public string colorNameSetted;
    private void Awake()
    { 
        winnerScreen.SetActive(false);
        losserScreen.SetActive(false);
         ColorRandom();
    }

    public void ColorRandom()     // Start Again Function
    {
        int randomIndex = Random.Range(0, colorSOInstance.Length);
        ColorSO randomColorSO = colorSOInstance[randomIndex];
        
       
        currentColor = randomColorSO.colorData;     //Setting Color and name of as Random Function is selected 
        currentcolorName = randomColorSO.colorName;

        bgScreenImage.color = currentColor;       // Setting Background Color 
        
        buttonGroup.SetActive(true);
        winnerScreen.SetActive(false);
        losserScreen.SetActive(false);
        ColorChecker.colorSetted = currentColor;
       ColorChecker.colorNameSetted = currentcolorName;
    }

    
    public bool IsCorrectColorPressed()
    {
        return (currentColor == ColorChecker.colorSetted);
    }
}


