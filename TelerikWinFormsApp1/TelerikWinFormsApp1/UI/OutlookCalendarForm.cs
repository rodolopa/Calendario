using System;
using Telerik.WinControls.UI;

namespace TelerikWinFormsApp1.UI
{
    public partial class OutlookCalendarForm : RadForm
    {
        public OutlookCalendarForm()
        {
            InitializeComponent();

            this.FormElement.TitleBar.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
        }
    }
}
