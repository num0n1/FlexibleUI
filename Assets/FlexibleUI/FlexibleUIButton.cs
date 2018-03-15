using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]
public class FlexibleUIButton : FlexibleUI
{
    private Button button;
    private Image image;

    public override void Awake()
    {
        button = GetComponent<Button>();
        image = GetComponent<Image>();

        base.Awake();
    }

    public override void onSkinUI()
    {
        base.onSkinUI();

        button = GetComponent<Button>();
        image = GetComponent<Image>();

        if (skinData == null)
            return;

        button.transition = Selectable.Transition.SpriteSwap;
        button.targetGraphic = image;
        image.sprite = skinData.sprite;
        image.color = skinData.color;
        image.SetNativeSize();
        image.type = skinData.imageType;
        button.spriteState = skinData.buttonSpriteState;
    }

}
