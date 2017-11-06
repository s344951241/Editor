using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class MyWindow : EditorWindow {


    [MenuItem("Window/ShowMyWin")]
    static void ShowMyWindow()
    {
        MyWindow win = EditorWindow.GetWindow<MyWindow>();
        win.Show();
    }
    private string name = "";
    private void OnGUI()
    {
        GUILayout.Label("这是我的窗口");
        GUILayout.TextField(name);
        if (GUILayout.Button("创建"))
        {
            GameObject go = new GameObject("new");
            Undo.RegisterCreatedObjectUndo(go, "Create gameObject");
        }
    }
}
