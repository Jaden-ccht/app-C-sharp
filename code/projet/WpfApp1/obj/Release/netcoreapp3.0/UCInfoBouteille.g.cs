﻿#pragma checksum "..\..\..\UCInfoBouteille.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13C0CCD24F205855E418C1508364BF03BC6F4C0A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// UCInfoBouteille
    /// </summary>
    public partial class UCInfoBouteille : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\UCInfoBouteille.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button previous;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UCInfoBouteille.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Supprimer;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UCInfoBouteille.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Modifier;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UCInfoBouteille.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageBouteille;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\UCInfoBouteille.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UCInfoBouteille.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListeBouteilles;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\UCInfoBouteille.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/ucinfobouteille.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UCInfoBouteille.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.previous = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\UCInfoBouteille.xaml"
            this.previous.Click += new System.Windows.RoutedEventHandler(this.previous_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Supprimer = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\UCInfoBouteille.xaml"
            this.Supprimer.Click += new System.Windows.RoutedEventHandler(this.Supprimer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Modifier = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\UCInfoBouteille.xaml"
            this.Modifier.Click += new System.Windows.RoutedEventHandler(this.Change_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ImageBouteille = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.next = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\UCInfoBouteille.xaml"
            this.next.Click += new System.Windows.RoutedEventHandler(this.next_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ListeBouteilles = ((System.Windows.Controls.ListBox)(target));
            
            #line 39 "..\..\..\UCInfoBouteille.xaml"
            this.ListeBouteilles.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListeBouteilles_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\UCInfoBouteille.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

