﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareToTwitter : MonoBehaviour
{
    // Call send tweet function when button is clicked
    public void OnClick()
    {
        SendTweet("I just played Astroworld! I scored " + ScoreCounter.CURR_SCORE + " points!");
    }

    //store twitter address and language
    private string _twitterAddress = "http://twitter.com/intent/tweet";
    private string _tweetLanguage = "en";

    //Send tweet to twitter
    void SendTweet(string textToDisplay)
    {
        //open new window
        Application.OpenURL(_twitterAddress +
                    "?text=" + WWW.EscapeURL(textToDisplay) +
                    "&amp;lang=" + WWW.EscapeURL(_tweetLanguage));
    }
}