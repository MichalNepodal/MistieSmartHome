﻿#pragma checksum "..\..\..\..\FrontEnd\Pages\HudbaPage1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5379ECCE7E2175ED94CA9EEF51EDCBC772283BCC7D8BA2B7AFC733620E8E12AC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Mistie_v_3.FrontEnd.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Mistie_v_3.FrontEnd.Pages {
    
    
    /// <summary>
    /// HudbaPage1
    /// </summary>
    public partial class HudbaPage1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\FrontEnd\Pages\HudbaPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zpetButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\FrontEnd\Pages\HudbaPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button spustitHudbuButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\FrontEnd\Pages\HudbaPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button svetlaButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\FrontEnd\Pages\HudbaPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vypnoutHudbuButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Mistie_v_3;component/frontend/pages/hudbapage1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\FrontEnd\Pages\HudbaPage1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.zpetButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\FrontEnd\Pages\HudbaPage1.xaml"
            this.zpetButton.Click += new System.Windows.RoutedEventHandler(this.zpetButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.spustitHudbuButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\FrontEnd\Pages\HudbaPage1.xaml"
            this.spustitHudbuButton.Click += new System.Windows.RoutedEventHandler(this.spustitHudbuButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.svetlaButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.vypnoutHudbuButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\FrontEnd\Pages\HudbaPage1.xaml"
            this.vypnoutHudbuButton.Click += new System.Windows.RoutedEventHandler(this.vypnoutHudbuButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
