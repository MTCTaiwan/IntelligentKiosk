﻿#pragma checksum "C:\Kiosk\Views\EmotionRecognitionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AEBE6BF68122A21E78808BA48251BF08"
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
    partial class EmotionRecognitionPage : 
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
            case 1: // Views\EmotionRecognitionPage.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).SizeChanged += this.OnPageSizeChanged;
                }
                break;
            case 2: // Views\EmotionRecognitionPage.xaml line 19
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 3: // Views\EmotionRecognitionPage.xaml line 50
                {
                    this.webCamHostGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Views\EmotionRecognitionPage.xaml line 55
                {
                    this.imageWithFacesControl = (global::IntelligentKioskSample.Controls.ImageWithFaceBorderUserControl)(target);
                }
                break;
            case 5: // Views\EmotionRecognitionPage.xaml line 51
                {
                    this.imageFromCameraWithFaces = (global::IntelligentKioskSample.Controls.ImageWithFaceBorderUserControl)(target);
                }
                break;
            case 6: // Views\EmotionRecognitionPage.xaml line 52
                {
                    this.cameraControl = (global::IntelligentKioskSample.Controls.CameraControl)(target);
                }
                break;
            case 7: // Views\EmotionRecognitionPage.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element7 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element7).Click += this.OnWebCamButtonClicked;
                }
                break;
            case 8: // Views\EmotionRecognitionPage.xaml line 21
                {
                    this.PicturesAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 9: // Views\EmotionRecognitionPage.xaml line 23
                {
                    this.imageSearchFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 10: // Views\EmotionRecognitionPage.xaml line 24
                {
                    global::IntelligentKioskSample.Controls.ImageSearchUserControl element10 = (global::IntelligentKioskSample.Controls.ImageSearchUserControl)(target);
                    ((global::IntelligentKioskSample.Controls.ImageSearchUserControl)element10).OnImageSearchCompleted += this.OnImageSearchCompleted;
                    ((global::IntelligentKioskSample.Controls.ImageSearchUserControl)element10).OnImageSearchCanceled += this.OnImageSearchCanceled;
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

