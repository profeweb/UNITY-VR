using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using TMPro;

[RequireComponent(typeof(InputData))]
public class DisplayInputDataButtons : MonoBehaviour
{
    public TextMeshProUGUI xButtonDisplay;
    public TextMeshProUGUI yButtonDisplay;
    public TextMeshProUGUI menuLeftDisplay;

    public TextMeshProUGUI aButtonDisplay;
    public TextMeshProUGUI bButtonDisplay;
    public TextMeshProUGUI menuRightDisplay;

    private InputData _inputData;

    private void Start()
    {
        _inputData = GetComponent<InputData>();
    }
    // Update is called once per frame
    void Update()
    {


        // LEFT CONTROLLER

        if (_inputData._leftController.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonLeft))
        {
            xButtonDisplay.text = primaryButtonLeft ? "ON" : "OFF"; 
        }

        if (_inputData._leftController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButtonLeft))
        {
            yButtonDisplay.text = secondaryButtonLeft ? "ON" : "OFF";
        }

        if (_inputData._leftController.TryGetFeatureValue(CommonUsages.menuButton, out bool menuButtonLeft))
        {
            menuLeftDisplay.text = menuButtonLeft ? "ON" : "OFF";
        }


        // RIGHT CONTROLLER

        if (_inputData._rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonRight))
        {
            aButtonDisplay.text = primaryButtonRight ? "ON" : "OFF";
        }

        if (_inputData._rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButtonRight))
        {
            bButtonDisplay.text = secondaryButtonRight ? "ON" : "OFF";
        }

        if (_inputData._rightController.TryGetFeatureValue(CommonUsages.menuButton, out bool menuButtonRight))
        {
            menuRightDisplay.text = menuButtonRight ? "ON" : "OFF";
        }

    }
}
