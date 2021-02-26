using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdManager : MonoBehaviour
{
    public string appId;
    public string adBannerId;
    public string adInterstialId;
    public AdPosition bannerPosition;
    public bool testDevice = false;

    private BannerView _bannerView;
    private InterstitialAd _interstitial;

    public static AdManager Instance;
    public static Action OnInterstitialAdsClosed;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        MobileAds.Initialize(appId);
        this.CreateBannerAd(CreateRequest());
        this.CreateInterstitialAd(CreateRequest());

        this._interstitial.OnAdClosed += InterstitialAdClosed;
    }

    void OnDisable()
    {
        this._interstitial.OnAdClosed -= InterstitialAdClosed;
    }

    private void InterstitialAdClosed(object sender, EventArgs e)
    {
        if (OnInterstitialAdsClosed != null)
        OnInterstitialAdsClosed();
    }
    
    private AdRequest CreateRequest()
    {
        AdRequest request;

        if (testDevice)
        {
            request = new AdRequest.Builder().AddTestDevice(SystemInfo.deviceUniqueIdentifier).Build();
        }
        else
        {
            request = new AdRequest.Builder().Build();            
        }

    return request;
    }

    public void CreateInterstitialAd(AdRequest request)
    {
        this._interstitial = new InterstitialAd(adInterstialId);
        this._interstitial.LoadAd(request);
    }

    public void ShowInterstitialAd()
    {
        if (this._interstitial.IsLoaded())
        {
            this._interstitial.Show();
        }

        this._interstitial.LoadAd(CreateRequest());
    }

    public void CreateBannerAd(AdRequest request)
    {
        this._bannerView = new BannerView(adBannerId, AdSize.SmartBanner, bannerPosition);
        this._bannerView.LoadAd(request);
        HideBanner();
    }

    public void HideBanner()
    {
        _bannerView.Hide();
    }

    public void ShowBanner()
    {
        _bannerView.Show();
    }

}
