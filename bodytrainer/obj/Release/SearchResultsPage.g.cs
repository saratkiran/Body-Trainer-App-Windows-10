﻿

#pragma checksum "C:\Users\saratkiran\Documents\Visual Studio 2012\Projects\body\bodytrainer\SearchResultsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F800C1AF25BD7CDF48ABC2F04CC0D25D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContosoCookbook
{
    partial class SearchResultsPage : global::ContosoCookbook.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 122 "..\..\SearchResultsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.Filter_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 137 "..\..\SearchResultsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.OnItemClick;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 97 "..\..\SearchResultsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.OnItemClick;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 79 "..\..\SearchResultsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.Filter_Checked;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 45 "..\..\SearchResultsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


