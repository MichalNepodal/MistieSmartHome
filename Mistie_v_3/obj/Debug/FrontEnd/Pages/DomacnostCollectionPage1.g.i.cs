﻿#pragma checksum "..\..\..\..\FrontEnd\Pages\DomacnostCollectionPage1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7FED7B04D0844E98788C14841BA977D1F86386220DBF95727F0416D64589EF2E"
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
    /// DomacnostCollectionPage1
    /// </summary>
    public partial class DomacnostCollectionPage1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\FrontEnd\Pages\DomacnostCollectionPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button hudbaButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\FrontEnd\Pages\DomacnostCollectionPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button svetlaButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\FrontEnd\Pages\DomacnostCollectionPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button collectionButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\FrontEnd\Pages\DomacnostCollectionPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextFrameButton;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\FrontEnd\Pages\DomacnostCollectionPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PraceCollectionButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Mistie_v_3;component/frontend/pages/domacnostcollectionpage1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\FrontEnd\Pages\DomacnostCollectionPage1.xaml"
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
            
            #line 25 "..\..\..\..\FrontEnd\Pages\DomacnostCollectionPage1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.hudbaButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.svetlaButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.collectionButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.nextFrameButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\FrontEnd\Pages\DomacnostCollectionPage1.xaml"
            this.nextFrameButton.Click += new System.Windows.RoutedEventHandler(this.nextFrameButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PraceCollectionButton = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\FrontEnd\Pages\DomacnostCollectionPage1.xaml"
            this.PraceCollectionButton.Click += new System.Windows.RoutedEventHandler(this.PraceCollectionButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

