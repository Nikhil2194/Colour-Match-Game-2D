using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class ColorSO : ScriptableObject
{
    public Color colorData;
    public string colorName;
    

    [MenuItem("Color Database/Create Color SO")]
    private static void CreateColorSO()
    {
        ColorSO colorSOInstance = CreateInstance<ColorSO>();
        
        colorSOInstance.colorData = colorSOInstance.colorData;
        colorSOInstance.colorName = colorSOInstance.colorName;
        
        AssetDatabase.CreateAsset(colorSOInstance, "Assets/ColorDatabase/Config.ColorSO.asset");
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}
