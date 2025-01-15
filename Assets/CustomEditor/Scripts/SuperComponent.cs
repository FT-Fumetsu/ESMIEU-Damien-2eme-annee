using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using Attribute;

public class SuperComponent : MonoBehaviour
{
    //[SerializeField]
    //private Stats _stats;

    [SerializeField]
    private string _sampleText;

    [SerializeField]
    [Scene]
    private string _sceneName;

    [SerializeField]
    [Scene]
    private int _sceneIndex;
}
