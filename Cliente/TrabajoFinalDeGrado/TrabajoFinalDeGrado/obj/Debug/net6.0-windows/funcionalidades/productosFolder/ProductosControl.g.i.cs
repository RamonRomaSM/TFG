﻿#pragma checksum "..\..\..\..\..\funcionalidades\productosFolder\ProductosControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3E92C5E3999A8C0CC6815937A267684C952FA864"
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
using TrabajoFinalDeGrado.funcionalidades.productosFolder;


namespace TrabajoFinalDeGrado.funcionalidades.productosFolder {
    
    
    /// <summary>
    /// ProductosControl
    /// </summary>
    public partial class ProductosControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 10 "..\..\..\..\..\funcionalidades\productosFolder\ProductosControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer MyScroller;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\funcionalidades\productosFolder\ProductosControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewProducts;
        
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
            System.Uri resourceLocater = new System.Uri("/TrabajoFinalDeGrado;component/funcionalidades/productosfolder/productoscontrol.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\funcionalidades\productosFolder\ProductosControl.xaml"
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
            
            #line 10 "..\..\..\..\..\funcionalidades\productosFolder\ProductosControl.xaml"
            this.MyScroller.ScrollChanged += new System.Windows.Controls.ScrollChangedEventHandler(this.OnScrollChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ListViewProducts = ((System.Windows.Controls.ListView)(target));
            
            #line 16 "..\..\..\..\..\funcionalidades\productosFolder\ProductosControl.xaml"
            this.ListViewProducts.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.ListViewProducts_PreviewMouseWheel);
            
            #line default
            #line hidden
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
            
            #line 40 "..\..\..\..\..\funcionalidades\productosFolder\ProductosControl.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.abrir_url);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 71 "..\..\..\..\..\funcionalidades\productosFolder\ProductosControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addCarritobtn_Click);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 94 "..\..\..\..\..\funcionalidades\productosFolder\ProductosControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addListaBtn_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

