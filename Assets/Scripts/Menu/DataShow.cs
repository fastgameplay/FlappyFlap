using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppsFlyerSDK;

public class DataShow : MonoBehaviour, IAppsFlyerConversionData
{
    void Start()
    {
        AppsFlyer.initSDK("ZLigGqGzDdxGMT7QBPjsMG", "com.testtask.flappybird", this);
        AppsFlyer.startSDK();
    }

    public void onConversionDataSuccess(string conversionData)
    {
        AppsFlyer.AFLog("onConversionDataSuccess", conversionData);
        Dictionary<string, object> conversionDataDictionary = AppsFlyer.CallbackStringToDictionary(conversionData);
        Debug.Log("ConvertionData = " + conversionData);
    }

    public void onConversionDataFail(string error)
    {
        AppsFlyer.AFLog("onConversionDataFail", error);
        Debug.Log("Erroe = ");

    }

    public void onAppOpenAttribution(string attributionData)
    {
        AppsFlyer.AFLog("onAppOpenAttribution", attributionData);
        Dictionary<string, object> attributionDataDictionary = AppsFlyer.CallbackStringToDictionary(attributionData);
        Debug.Log("Erroe s ");

    }

    public void onAppOpenAttributionFailure(string error)
    {
        AppsFlyer.AFLog("onAppOpenAttributionFailure", error);
        Debug.Log("Erroe g ");
    }
}
