﻿#pragma checksum "..\..\..\..\..\funcionalidades\perfilFolder\ListaWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "536AE1A92B1766FB640D670C98A296CDD55FA284"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TrabajoFinalDeGrado.funcionalidades.perfilFolder;


namespace TrabajoFinalDeGrado.funcionalidades.perfilFolder {
    
    
    /// <summary>
    /// ListaWindow
    /// </summary>
    public partial class ListaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 29 "..\..\..\..\..\funcionalidades\perfilFolder\ListaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer MyScroller;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\funcionalidades\perfilFolder\ListaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewCarrito;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\..\..\funcionalidades\perfilFolder\ListaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreLista;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\..\..\..\funcionalidades\perfilFolder\ListaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addListaBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TrabajoFinalDeGrado;component/funcionalidades/perfilfolder/listawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\funcionalidades\perfilFolder\ListaWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MyScroller = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 2:
            this.ListViewCarrito = ((System.Windows.Controls.ListView)(target));
            
            #line 35 "..\..\..\..\..\funcionalidades\perfilFolder\ListaWindow.xaml"
            this.ListViewCarrito.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.ListViewProducts_PreviewMouseWheel);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtNombreLista = ((System.Windows.Controls.TextBox)(target));
            
            #line 204 "..\..\..\..\..\funcionalidades\perfilFolder\ListaWindow.xaml"
            this.txtNombreLista.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtNombreLista_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 205 "..\..\..\..\..\funcionalidades\perfilFolder\ListaWindow.xaml"
            this.txtNombreLista.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtNombreLista_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addListaBtn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 61 "..\..\..\..\..\funcionalidades\perfilFolder\ListaWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.abrir_url);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

