﻿#pragma checksum "C:\Kiosk\Views\RealTimeDemo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7CE3A30F75488F6939D48529093EDD62"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views
{
    partial class RealTimeDemo : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\RealTimeDemo.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).SizeChanged += this.OnPageSizeChanged;
                }
                break;
            case 2: // Views\RealTimeDemo.xaml line 13
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\RealTimeDemo.xaml line 53
                {
                    this.initializingUI = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Views\RealTimeDemo.xaml line 56
                {
                    this.initializingProgressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 5: // Views\RealTimeDemo.xaml line 48
                {
                    this.ageGenderDistributionControl = (global::IntelligentKioskSample.Controls.AgeGenderDistributionControl)(target);
                }
                break;
            case 6: // Views\RealTimeDemo.xaml line 49
                {
                    this.overallStatsControl = (global::IntelligentKioskSample.Controls.OverallStatsControl)(target);
                }
                break;
            case 7: // Views\RealTimeDemo.xaml line 50
                {
                    this.emotionDataTimelineControl = (global::IntelligentKioskSample.Controls.EmotionResponseTimelineControl)(target);
                }
                break;
            case 8: // Views\RealTimeDemo.xaml line 28
                {
                    this.cameraHostGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9: // Views\RealTimeDemo.xaml line 32
                {
                    this.debugText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Views\RealTimeDemo.xaml line 29
                {
                    this.cameraControl = (global::IntelligentKioskSample.Controls.CameraControl)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

