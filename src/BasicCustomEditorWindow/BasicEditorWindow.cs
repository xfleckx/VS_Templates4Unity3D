using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System;
using System.Linq;

public class $safeitemname$ : EditorWindow
{ 
    [MenuItem("$safeitemname$")]
    static void Open$safeitemname$()
    {
        var window = EditorWindow.GetWindow<$safeitemname$>();

        window.titleContent = new GUIContent("$safeitemname$");
        
        window.Initialize();

        window.Show();
    }
    
    void Initialize()
    {
    }

    private UnityEngine.Object lastSelection;

    void OnGUI()
    {
        var currentSelection = Selection.activeGameObject;

        if (currentSelection != null && (lastSelection != null || lastSelection != currentSelection))
            OnUpdateSelection(currentSelection);
    }

    private void OnUpdateSelection(GameObject selection)
    {
    }
      
    public void OnEnable()
    {
        Initialize();

        Selection.selectionChanged += Repaint;

        if (SceneView.onSceneGUIDelegate == null)
            SceneView.onSceneGUIDelegate += OnSceneGUI;
    }

    public void OnDisable()
    {
        Selection.selectionChanged -= Repaint;
        SceneView.onSceneGUIDelegate -= OnSceneGUI;
    }

    private void OnSceneGUI(SceneView sceneView)
    {
    } 

}

