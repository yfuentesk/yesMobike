﻿#pragma checksum "..\..\PedirBici.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45829AC1820C9D22A1F780EF15A6DAE371E0D544"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Mobike.Presentación;
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


namespace Mobike.Presentación {
    
    
    /// <summary>
    /// PedirBici
    /// </summary>
    public partial class PedirBici : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\PedirBici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbEst;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\PedirBici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnComienzo;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PedirBici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbPatente;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\PedirBici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFin;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\PedirBici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVolver;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\PedirBici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblValor;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\PedirBici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblKm;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PedirBici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKm;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PedirBici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbEst2;
        
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
            System.Uri resourceLocater = new System.Uri("/Mobike.Presentacion;component/pedirbici.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PedirBici.xaml"
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
            this.cmbEst = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\PedirBici.xaml"
            this.cmbEst.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbEst_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnComienzo = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\PedirBici.xaml"
            this.btnComienzo.Click += new System.Windows.RoutedEventHandler(this.btnComienzo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbPatente = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.btnFin = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\PedirBici.xaml"
            this.btnFin.Click += new System.Windows.RoutedEventHandler(this.btnFin_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnVolver = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\PedirBici.xaml"
            this.btnVolver.Click += new System.Windows.RoutedEventHandler(this.btnVolver_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblValor = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lblKm = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.txtKm = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\PedirBici.xaml"
            this.txtKm.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtKm_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cmbEst2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

