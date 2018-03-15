using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FlexibleUIInstance : Editor
{
    [MenuItem("GameObject/Flexble UI/Button", priority = 0)]
    static void AddButton()
    {
        Create("Button");
    }


    static GameObject clickedObject;

    private static GameObject Create(string objectName)
    {
        GameObject instance = Instantiate(Resources.Load<GameObject>(objectName));
        instance.name = objectName;
        clickedObject = UnityEditor.Selection.activeObject as GameObject;
        if (clickedObject != null)
        {
            instance.transform.SetParent(clickedObject.transform, false);
        }
        // Register the creation in the undo system
        Undo.RegisterCreatedObjectUndo(instance, instance.name);

        return instance;
    }

    
}
