using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

[CustomEditor(typeof(SuperComponent))]
[CanEditMultipleObjects]
public class SuperComponentEditor : Editor
{
    SerializedProperty _sceneIndexProperty;
    SerializedProperty _sampleTextProperty;


    void OnEnable()
    {
        _sampleTextProperty = serializedObject.FindProperty("_sampleText");
        _sceneIndexProperty = serializedObject.FindProperty("_sceneIndex");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.PropertyField(_sampleTextProperty);

        EditorGUILayout.LabelField(_sampleTextProperty.stringValue);

        serializedObject.Update();
        EditorGUILayout.PropertyField(_sceneIndexProperty);

        serializedObject.ApplyModifiedProperties();
    }
}