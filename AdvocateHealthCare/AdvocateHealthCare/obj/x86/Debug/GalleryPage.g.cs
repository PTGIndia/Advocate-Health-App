﻿#pragma checksum "C:\Users\sridhar\Documents\Visual Studio 2015\Projects\GitHubAdvocateHealthCare\AdvocateHealthCare\AdvocateHealthCare\GalleryPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B02E6EB4B9578B3CFD1EC83682E60A8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvocateHealthCare
{
    partial class GalleryPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Image element1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 46 "..\..\..\GalleryPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)element1).Tapped += this.Image_Tapped;
                    #line default
                }
                break;
            case 2:
                {
                    this.gridGallary = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 97 "..\..\..\GalleryPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.gridGallary).SelectionChanged += this.gridGallary_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.Grid element3 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 73 "..\..\..\GalleryPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element3).Tapped += this.Notificationgridtapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.mySearchBox = (global::Windows.UI.Xaml.Controls.SearchBox)(target);
                    #line 78 "..\..\..\GalleryPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.SearchBox)this.mySearchBox).QuerySubmitted += this.mySearchBox_QuerySubmitted;
                    #line default
                }
                break;
            case 5:
                {
                    this.notificationsImg = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6:
                {
                    this.ec = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 7:
                {
                    this.txtNotificationCount = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

