#pragma checksum "..\..\..\UCParametres.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C14553FA5010A1A232686E742F463147F483B20F"
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
    /// UCParametres
    /// </summary>
    public partial class UCParametres : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\UCParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changerpseudo;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UCParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changermdp;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UCParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox clair;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UCParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox sombre;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\UCParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox normale;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UCParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox grosse;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\UCParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelUser;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\UCParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button utilisateurs;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\UCParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl contentControl;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;V1.0.0.0;component/ucparametres.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UCParametres.xaml"
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
            this.changerpseudo = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\UCParametres.xaml"
            this.changerpseudo.Click += new System.Windows.RoutedEventHandler(this.Changerpseudo_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.changermdp = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\UCParametres.xaml"
            this.changermdp.Click += new System.Windows.RoutedEventHandler(this.Changermdp_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.clair = ((System.Windows.Controls.CheckBox)(target));
            
            #line 36 "..\..\..\UCParametres.xaml"
            this.clair.Checked += new System.Windows.RoutedEventHandler(this.Clair_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sombre = ((System.Windows.Controls.CheckBox)(target));
            
            #line 37 "..\..\..\UCParametres.xaml"
            this.sombre.Checked += new System.Windows.RoutedEventHandler(this.Sombre_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.normale = ((System.Windows.Controls.CheckBox)(target));
            
            #line 41 "..\..\..\UCParametres.xaml"
            this.normale.Checked += new System.Windows.RoutedEventHandler(this.Normale_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.grosse = ((System.Windows.Controls.CheckBox)(target));
            
            #line 42 "..\..\..\UCParametres.xaml"
            this.grosse.Checked += new System.Windows.RoutedEventHandler(this.Grosse_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DelUser = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\UCParametres.xaml"
            this.DelUser.Click += new System.Windows.RoutedEventHandler(this.DelUser_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.utilisateurs = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\UCParametres.xaml"
            this.utilisateurs.Click += new System.Windows.RoutedEventHandler(this.utilisateurs_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.contentControl = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

