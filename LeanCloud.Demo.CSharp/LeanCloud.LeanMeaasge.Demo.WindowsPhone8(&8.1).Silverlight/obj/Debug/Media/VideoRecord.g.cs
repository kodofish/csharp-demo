﻿#pragma checksum "C:\Users\Cloud\Documents\windows-phone-sdk-demos\LeanCloud.Demo.CSharp\LeanCloud.LeanMeaasge.Demo.WindowsPhone8(&8.1).Silverlight\Media\VideoRecord.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1BD8CB7DB418D5A47227D86BA2805E71"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace LeanCloud.LeanMeaasge.Demo.Media {
    
    
    public partial class VideoRecord : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Media.VideoBrush videoBrush;
        
        internal System.Windows.Media.RotateTransform rt;
        
        internal System.Windows.Controls.MediaElement mediaElement;
        
        internal System.Windows.Controls.Button btnCapture;
        
        internal System.Windows.Controls.Button btnStop;
        
        internal System.Windows.Controls.Button btnPlay;
        
        internal System.Windows.Controls.Button btn_send;
        
        internal System.Windows.Controls.TextBlock lblMsg;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/LeanCloud.LeanMeaasge.Demo;component/Media/VideoRecord.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.videoBrush = ((System.Windows.Media.VideoBrush)(this.FindName("videoBrush")));
            this.rt = ((System.Windows.Media.RotateTransform)(this.FindName("rt")));
            this.mediaElement = ((System.Windows.Controls.MediaElement)(this.FindName("mediaElement")));
            this.btnCapture = ((System.Windows.Controls.Button)(this.FindName("btnCapture")));
            this.btnStop = ((System.Windows.Controls.Button)(this.FindName("btnStop")));
            this.btnPlay = ((System.Windows.Controls.Button)(this.FindName("btnPlay")));
            this.btn_send = ((System.Windows.Controls.Button)(this.FindName("btn_send")));
            this.lblMsg = ((System.Windows.Controls.TextBlock)(this.FindName("lblMsg")));
        }
    }
}

