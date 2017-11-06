using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class Tools {
    [MenuItem("GameObject/test _t", false, 10)]//快捷键%->Ctrl,#->shift,&->alt
    public static void test()
    {
        Debug.Log("item");
    }

    [MenuItem("Game Tools/ShowInfo %q")]
    public static void ShowInfo()
    {
        Debug.Log(Selection.activeGameObject.name);//第一个选择的游戏物体[hierarchy]

        Debug.Log(Selection.objects.Length);//[hierarchy][project]

        Debug.Log(Selection.gameObjects.Length);//[hierarchy][project]

        
    }
    [MenuItem("GameObject/myDelete", true, 11)]//功能是否启用
    public static bool MyDeleteValidate()
    {
        if (Selection.objects.Length > 0)
            return true;
        return false;
    }

    [MenuItem("GameObject/myDelete", false, 11)]
    public static void MyDelete()
    {
        foreach (UnityEngine.Object o in Selection.objects)
        {
            Undo.DestroyObjectImmediate(o);
        }
    }

}
