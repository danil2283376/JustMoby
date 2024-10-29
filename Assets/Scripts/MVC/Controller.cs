using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller
{
    protected View _view;
    protected Model _model;

    protected Controller(View view, Model model)
    {
        _view = view;
        _model = model;
    }

    public abstract void Init();

    public abstract bool OpenMainWindow(ControllerData controllerData);

    public abstract void OpenBuyWindow();

    public abstract void CloseBuyWindow();
}
