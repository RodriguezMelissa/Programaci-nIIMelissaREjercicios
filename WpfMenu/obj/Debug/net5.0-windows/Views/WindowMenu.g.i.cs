﻿#pragma checksum "..\..\..\..\Views\WindowMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63E2F4599826B01CB09E7FD302627FB1579670D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WpfMenu.Views;


namespace WpfMenu.Views {
    
    
    /// <summary>
    /// WindowMenu
    /// </summary>
    public partial class WindowMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Views\WindowMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Menu;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Views\WindowMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnConfigurar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\WindowMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnSalir;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\WindowMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnTextos;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\WindowMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnnicaragua;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\WindowMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnConvertidordemonedas;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfMenu;component/views/windowmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\WindowMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            this.btnConfigurar = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\..\Views\WindowMenu.xaml"
            this.btnConfigurar.Click += new System.Windows.RoutedEventHandler(this.btnConfigurar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSalir = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            this.btnTextos = ((System.Windows.Controls.MenuItem)(target));
            
            #line 28 "..\..\..\..\Views\WindowMenu.xaml"
            this.btnTextos.Click += new System.Windows.RoutedEventHandler(this.btnTextos_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnnicaragua = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\..\..\Views\WindowMenu.xaml"
            this.btnnicaragua.Click += new System.Windows.RoutedEventHandler(this.btnnicaragua_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnConvertidordemonedas = ((System.Windows.Controls.MenuItem)(target));
            
            #line 38 "..\..\..\..\Views\WindowMenu.xaml"
            this.btnConvertidordemonedas.Click += new System.Windows.RoutedEventHandler(this.btnConvertidordemonedas_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
