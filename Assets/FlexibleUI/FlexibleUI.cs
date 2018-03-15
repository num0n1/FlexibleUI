using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FlexibleUI : MonoBehaviour {

    public FlexibleUIData skinData;

    public virtual void Awake()
    {
        onSkinUI();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Application.isEditor)
        {
            onSkinUI();
        }
		
	}

    public virtual void onSkinUI()
    {

    }
}
