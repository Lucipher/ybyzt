using Newtonsoft.Json;
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

    public class Notification 
	{
        public String alert{get;set;}
        [JsonProperty(PropertyName = "ios")]
        public IosNotification IosNotification { get; set; }
        [JsonProperty(PropertyName = "android")]
        public AndroidNotification AndroidNotification { get; set; }
        [JsonProperty(PropertyName = "winphone")]
        public WinphoneNotification WinphoneNotification { get; set; }

        public Notification()
        {
            this.alert = null;
            this.IosNotification = null;
            this.AndroidNotification = null;
            this.WinphoneNotification = null;
        }
    
        public Notification setAlert(string alert)
        {
            this.alert = alert;
            return this;
        }
        public Notification setAndroid(AndroidNotification android)
        {
            this.AndroidNotification = android;
            return this;
        }
        public Notification setIos(IosNotification ios)
        {
            this.IosNotification = ios;
            return this;
        }
        public Notification setWinphone(WinphoneNotification winphone)
        {
            this.WinphoneNotification = winphone;
            return this;
        }
        
        public static Notification android(String alert, String title)
        {
            var platformNotification = new AndroidNotification().setAlert(alert).setTitle(title);
            var notificaiton = new Notification().setAlert(alert);
            notificaiton.AndroidNotification = platformNotification;
            return notificaiton;
        }
        public static Notification ios(String alert)
        {
            var iosNotification = new IosNotification().setAlert(alert);
            var notification = new Notification().setAlert(alert);
            notification.IosNotification = iosNotification;
            return notification;
        }
        public static Notification ios_auto_badge()
        {
            var platformNotification = new IosNotification();
            platformNotification.autoBadge();
            var notificaiton = new Notification().setAlert("");;
            notificaiton.IosNotification = platformNotification;
            return notificaiton;
        }
        public static Notification ios_set_badge(int badge)
        {
            var platformNotification = new IosNotification();
            platformNotification.setBadge(badge);

            var notificaiton = new Notification();
            notificaiton.IosNotification = platformNotification;
            return notificaiton;
        }
        public static Notification ios_incr_badge(int badge)
        {
            var platformNotification = new IosNotification();
            platformNotification.incrBadge(badge);
            var notificaiton = new Notification();
            notificaiton.IosNotification = platformNotification;
            return notificaiton;
        }
        public static Notification winphone(String alert)
        {
            var platformNotification = new WinphoneNotification().setAlert(alert);

            var notificaiton = new Notification().setAlert(alert);
            notificaiton.WinphoneNotification = platformNotification;
            return notificaiton;
        }

        public  Notification Check()
        {
            Preconditions.checkArgument(!(isPlatformEmpty() && null == alert), "No notification payload is set.");
            if (IosNotification!=null)
            {
                Preconditions.checkArgument(!(null==IosNotification.alert && null == alert), "No notification payload is set.");
            }
            if(AndroidNotification!=null)
            {
                Preconditions.checkArgument(!(null == AndroidNotification.alert && null == alert), "No notification payload is set.");

            }
            if (WinphoneNotification!=null)
            {
                Preconditions.checkArgument(!(null == WinphoneNotification.alert && null == alert), "No notification payload is set.");

            }
            return this; 
        }
        private bool isPlatformEmpty() 
        {
            return (IosNotification == null && AndroidNotification == null && WinphoneNotification == null);
        }
	}


