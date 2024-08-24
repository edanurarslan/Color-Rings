
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class ADManager : MonoBehaviour
{
    

    private BannerView bannerView;
    private InterstitialAd interstitial;
    //public Spawner spawner;

    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>{ });
        // Banner reklam n  y kle
        //this.RequestBanner();
        //this.RequestInterstitial();
		//this.RegisterReloadHandler(); //InterstitialAd interstitial

    }
    private void RequestInterstitial()
    {
        //print("RequestInte");      
        string adUnitId = "ca-app-pub-6689356860659400/3057221528";
        this.interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);
    }
	
	/*private void RegisterReloadHandler(InterstitialAd interstitial)
{
    // Raised when the ad closed full screen content.
    interstitial.OnAdFullScreenContentClosed += ()
    {
        Debug.Log("Interstitial Ad full screen content closed.");

        // Reload the ad so that we can show another as soon as possible.
        RequestInterstitial();
    };
    // Raised when the ad failed to open full screen content.
    interstitial.OnAdFullScreenContentFailed += (AdError error) =>
    {
        Debug.LogError("Interstitial ad failed to open full screen content " +
                       "with error : " + error);

        // Reload the ad so that we can show another as soon as possible.
        RequestInterstitial();
    };
}
*/
	
    public void showAd()
    {
        //print("ssddddd");
        if (this.interstitial != null && this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
        //else
       // {
        //       this.interstitial.Show();
       // }
    }
    public void RequestBanner()
    {
     

        // Banner reklam birimi kimli ini belirtin.
        string adUnitId = "ca-app-pub-6689356860659400/8780321494";

        // Banner reklam birimi boyutunu belirtin.
        AdSize adSize = new AdSize(320, 50);

        // Banner reklam  olu turun.
        bannerView = new BannerView(adUnitId, adSize, AdPosition.Bottom);

        // Banner reklam y kleme iste inde bulunun.
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
    }

    public void RequestStart() {
         this.RequestInterstitial();
    }
   // void Update()
   // {
   //     this.RequestInterstitial();
  //  }

    
}
