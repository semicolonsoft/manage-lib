﻿#pragma checksum "..\..\Window12.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D118FDC4FADF3E3FB7D973062D6A95AC97FE0AEC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LIBRARY;
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


namespace LIBRARY {
    
    
    /// <summary>
    /// Window12
    /// </summary>
    public partial class Window12 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 239 "..\..\Window12.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnupdate;
        
        #line default
        #line hidden
        
        
        #line 250 "..\..\Window12.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnupdate_Copy;
        
        #line default
        #line hidden
        
        
        #line 261 "..\..\Window12.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnupdate_Copy1;
        
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
            System.Uri resourceLocater = new System.Uri("/LIBRARY;component/window12.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window12.xaml"
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
            
            #line 10 "..\..\Window12.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnupdate = ((System.Windows.Controls.Button)(target));
            
            #line 239 "..\..\Window12.xaml"
            this.btnupdate.Click += new System.Windows.RoutedEventHandler(this.Btnupdate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnupdate_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 250 "..\..\Window12.xaml"
            this.btnupdate_Copy.Click += new System.Windows.RoutedEventHandler(this.Btnupdate_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnupdate_Copy1 = ((System.Windows.Controls.Button)(target));
            
            #line 261 "..\..\Window12.xaml"
            this.btnupdate_Copy1.Click += new System.Windows.RoutedEventHandler(this.Btnupdate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

