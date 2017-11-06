using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EnemyChangeEdior : ScriptableWizard {


    public int changeHeathValue = 10;

    public int changeFlashValue = 10;

    [MenuItem("Game Tools/CreateWizard")]
    public static void CreateWizard()
    {
        ScriptableWizard.DisplayWizard<EnemyChangeEdior>("统一修改敌人","changeValue","otherButton");
    }

    private void OnWizardCreate()//监听按钮点击（固定）
    {
        Debug.Log("click");
    }

    private void OnWizardOtherButton()
    {
        EditorUtility.DisplayProgressBar("进度", "0/3",0);
        for (int i = 1; i <= 3; i++)
        {
            EditorUtility.DisplayProgressBar("进度", i+"/3", i/3);
        }
        EditorUtility.ClearProgressBar();
        Debug.Log("otherButton");
        ShowNotification(new GUIContent("info"));
    }

    private void OnWizardUpdate()//值修改的时候调用
    {
        helpString = "";
        errorString = "";
        if (Selection.gameObjects.Length > 0)
        {
            helpString = "chose" + Selection.gameObjects.Length;
           
        }
        else
        {
           
            errorString = "please chose enemy";
        }
    }

    private void OnSelectionChange()
    {
        OnWizardUpdate();
    }


}
