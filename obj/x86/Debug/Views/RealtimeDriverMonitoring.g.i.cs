﻿#pragma checksum "C:\Users\v-caspch\Desktop\IntelligentKiosk\Views\RealtimeDriverMonitoring.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2D7096076309486C8248D03E745CC229"
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
    partial class RealtimeDriverMonitoring : global::Windows.UI.Xaml.Controls.Page
    {


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.Page page; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.Grid MainGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock highLatencyWarning; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock faceLantencyDebugText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock visionLantencyDebugText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.ColumnDefinition driverPanelColumn; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.Grid cameraHostGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.Grid driverPanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::IntelligentKioskSample.Controls.VerticalBarTimelineControl headPoseChart; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::IntelligentKioskSample.Controls.VerticalBarTimelineControl mouthApertureChart; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::IntelligentKioskSample.Controls.VerticalBarTimelineControl eyeApertureChart; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::IntelligentKioskSample.Controls.VerticalBarTimelineControl distractionChart; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock driverId; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::IntelligentKioskSample.Controls.CameraControl cameraControl; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.MediaElement videoPlayer; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.ComboBox inputSourceComboBox; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private global::Windows.UI.Xaml.Controls.ComboBoxItem videoInputSource; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;

            global::System.Uri resourceLocator = new global::System.Uri("ms-appx:///Views/RealtimeDriverMonitoring.xaml");
            global::Windows.UI.Xaml.Application.LoadComponent(this, resourceLocator, global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
        }

        partial void UnloadObject(global::Windows.UI.Xaml.DependencyObject unloadableObject);

    }
}


