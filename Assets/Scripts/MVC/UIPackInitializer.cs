using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPackInitializer : MonoBehaviour
{
    public TMP_InputField InputField;
    public Button ButtonInputFieldReadValue;
    public Button ButtonBuyPack;
    public Button ButtonCloseBuyPack;

    [SerializeField] private View _view;
    private Controller _controller;

    public void Start()
    {
        ButtonInputFieldReadValue.onClick.AddListener(OpenPackWindow);
        ButtonBuyPack.onClick.AddListener(OpenBuyWindow);
        ButtonCloseBuyPack.onClick.AddListener(CloseBuyWindow);
        Init();
    }

    public void Init()
    {
        _controller = new ControllerPack(_view, new ModelPack());
        _controller.Init();
    }

    public void OpenPackWindow() 
    {
        _controller.OpenMainWindow(new ControllerDataPack(InputField.text));
    }

    public void OpenBuyWindow() 
    {
        _controller.OpenBuyWindow();
    }

    public void CloseBuyWindow()
    {
        _controller.CloseBuyWindow();
    }

    public void OnDestroy()
    {
        ButtonInputFieldReadValue.onClick.RemoveListener(OpenPackWindow);
        ButtonBuyPack.onClick.RemoveListener(OpenBuyWindow);
        ButtonCloseBuyPack.onClick.RemoveListener(CloseBuyWindow);
    }
}
