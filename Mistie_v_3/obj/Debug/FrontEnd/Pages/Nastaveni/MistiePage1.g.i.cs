﻿#pragma checksum "..\..\..\..\..\FrontEnd\Pages\Nastaveni\MistiePage1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C5340565BF94F7048EE4E44DA02BD105303CB8B13EFB5793688CDD1E79D60918"
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
    /// MistiePage1
    /// </summary>
    public partial class MistiePage1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\..\FrontEnd\Pages\Nastaveni\MistiePage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zpetButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\FrontEnd\Pages\Nastaveni\MistiePage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button aktivovatHlasoveOvladaniButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\FrontEnd\Pages\Nastaveni\MistiePage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deaktivovatHlasoveOvladaniButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Mistie_v_3;component/frontend/pages/nastaveni/mistiepage1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\FrontEnd\Pages\Nastaveni\MistiePage1.xaml"
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
            
            #line 36 "..\..\..\..\..\FrontEnd\Pages\Nastaveni\MistiePage1.xaml"
            this.zpetButton.Click += new System.Windows.RoutedEventHandler(this.zpetButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.aktivovatHlasoveOvladaniButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\..\FrontEnd\Pages\Nastaveni\MistiePage1.xaml"
            this.aktivovatHlasoveOvladaniButton.Click += new System.Windows.RoutedEventHandler(this.aktivovatHlasoveOvladaniButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.deaktivovatHlasoveOvladaniButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\..\FrontEnd\Pages\Nastaveni\MistiePage1.xaml"
            this.deaktivovatHlasoveOvladaniButton.Click += new System.Windows.RoutedEventHandler(this.deaktivovatHlasoveOvladaniButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

