﻿#pragma checksum "C:\Users\sridhar\Documents\Visual Studio 2015\Projects\GitHubAdvocateHealthCare\AdvocateHealthCare\AdvocateHealthCare\QuestionEntry.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A05732DA2E5EF8B5414BD3F7C889A962"
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
    partial class QuestionEntry : 
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
                    this.txtquestioninfo = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.txtquestionvalue = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 74 "..\..\..\QuestionEntry.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.QuestionsButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.textprofilejournalid = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.txtdate = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.ProfileJournalID = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.Grid element7 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 30 "..\..\..\QuestionEntry.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element7).Tapped += this.Notificationgridtapped;
                    #line default
                }
                break;
            case 8:
                {
                    this.mySearchBox = (global::Windows.UI.Xaml.Controls.SearchBox)(target);
                    #line 35 "..\..\..\QuestionEntry.xaml"
                    ((global::Windows.UI.Xaml.Controls.SearchBox)this.mySearchBox).QuerySubmitted += this.mySearchBox_QuerySubmitted;
                    #line default
                }
                break;
            case 9:
                {
                    this.notificationsImg = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10:
                {
                    this.ec = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 11:
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

