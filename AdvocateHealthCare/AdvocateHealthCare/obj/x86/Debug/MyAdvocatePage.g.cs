﻿#pragma checksum "C:\Users\sridhar\Documents\Visual Studio 2015\Projects\GitHubAdvocateHealthCare\AdvocateHealthCare\AdvocateHealthCare\MyAdvocatePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "91FFF4D6CB473FF39DF2029C361BF733"
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
    partial class MyAdvocatePage : 
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
                    global::Windows.UI.Xaml.Controls.Pivot element1 = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                    #line 40 "..\..\..\MyAdvocatePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Pivot)element1).SelectionChanged += this.Pivot_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.grdDeliveryDetails3 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 3:
                {
                    this.grdDeliveryDetails2 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 4:
                {
                    this.grdDeliveryDetails1 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 5:
                {
                    this.GridDiet = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6:
                {
                    this.grdAddNotes = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.JorQtext = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 200 "..\..\..\MyAdvocatePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.saveJorQnotes;
                    #line default
                }
                break;
            case 9:
                {
                    this.text = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 167 "..\..\..\MyAdvocatePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.text).Tapped += this.Journaltext_Tapped;
                    #line default
                }
                break;
            case 10:
                {
                    this.text2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 171 "..\..\..\MyAdvocatePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.text2).Tapped += this.Questionstext_Tapped;
                    #line default
                }
                break;
            case 11:
                {
                    this.txtquestions = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.txtjournal = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element13 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 142 "..\..\..\MyAdvocatePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element13).Tapped += this.CloseImage_Tapped;
                    #line default
                }
                break;
            case 14:
                {
                    this.getback = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 69 "..\..\..\MyAdvocatePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.getback).Tapped += this.GetbackButton_Click;
                    #line default
                }
                break;
            case 15:
                {
                    global::Windows.UI.Xaml.Controls.Grid element15 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 31 "..\..\..\MyAdvocatePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element15).Tapped += this.Notificationgridtapped;
                    #line default
                }
                break;
            case 16:
                {
                    this.mySearchBox = (global::Windows.UI.Xaml.Controls.SearchBox)(target);
                    #line 36 "..\..\..\MyAdvocatePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.SearchBox)this.mySearchBox).QuerySubmitted += this.mySearchBox_QuerySubmitted;
                    #line default
                }
                break;
            case 17:
                {
                    this.notificationsImg = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 18:
                {
                    this.ec = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 19:
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

