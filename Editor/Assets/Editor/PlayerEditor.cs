using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerEditor {

    [MenuItem("CONTEXT/PlayerHealth/InitHealthAndSpeed")]//(脚本右键)
    public static void InitHealthAndSpeed(MenuCommand cmd)//当前正在操作的组件
    {
        Debug.Log(cmd.context.name);
        CompleteProject.PlayerHealth ph = cmd.context as CompleteProject.PlayerHealth;
        //修改值
        Debug.Log("111111");
    }
}
