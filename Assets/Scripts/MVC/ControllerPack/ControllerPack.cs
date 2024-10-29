using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPack : Controller
{
    private bool _init = false;

    public ControllerPack(View view, Model model) : base(view, model)
    {
    }

    public override void Init()
    {
        if (_init == false)
        {
            _model.Init();
            _init = true;
        }
    }

    public override bool OpenMainWindow(ControllerData controllerData)
    {
        ControllerDataPack controllerDataPack = controllerData as ControllerDataPack;

        if (_init == false)
        {
            Init();
        }

        if (int.TryParse(controllerDataPack.CountMaxItems, out int value))
        {
            _view.OpenMainWindow();
            _view.Init(_model.GetItemsForUI(new ModelDataPack(value)));
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void OpenBuyWindow()
    {
        if (_model.Purchasing())
            _view.OpenBuyWindow();
    }

    public override void CloseBuyWindow() 
    {
        _view.CloseBuyWindow();
    }
}
