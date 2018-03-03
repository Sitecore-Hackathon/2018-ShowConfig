using Sitecore.Buckets.Util;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Utilities;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Globalization;
using Sitecore.Web.UI.HtmlControls;
using Sitecore.Web.UI.Sheer;
using System;
//using Sitecore.Buckets.Forms;
using Sitecore;
using Sitecore.Shell.Applications.Dialogs;
using Sitecore.Web.UI.WebControls;
using Sitecore.Shell.Applications.Dialogs.ItemLister;
using Sitecore.Data;
using Sitecore.Configuration;
using Sitecore.Resources;
using Sitecore.StringExtensions;
using System.Collections.Generic;
using Sitecore.Web.UI;
using Sitecore.Text;
using Sitecore.XA.Foundation.LocalDatasources.Dialogs;
using System.Linq;
using Sitecore.Web;

namespace Feature.Forms.ExpressForm
{
    /// <summary>
    /// Inheriting the SelectRenderingDatasourceForm to override OnLoad method.
    /// </summary>
    public class RenderingDatasourceCustom : SelectRenderingDatasourceForm
    {
        protected Border FormsOption;
        #region Constants
        private const string url = "/sitecore/client/Applications/FormsBuilder/Pages/Forms";
        private const string customFormRenderingId = "{A53A57EF-D93C-4863-8C49-DA1D598E4A92}";
        #endregion Constants

        /// <summary>
        /// OnLoad - Check for the "Create New Form" option and attach the click event for the "create new form" option.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            try
            {


                Assert.ArgumentNotNull(e, "e");
                base.OnLoad(e);
                if (Context.ClientPage.IsEvent)
                {
                    return;
                }
                //Check to show/hide the "Create New Form" option on Select Associated content dialog.
                string Id = WebUtil.GetQueryString("r");
                if (!string.IsNullOrEmpty(Id) && !Id.Equals(customFormRenderingId, StringComparison.OrdinalIgnoreCase))
                {
                    if (this.FormsOption != null)
                        this.FormsOption.Visible = false;
                }
                else
                {
                    this.FormsOption.Click = "OnOpenFormWizard()";
                }
            }
            catch (Exception ex)
            {
                Sitecore.Diagnostics.Log.Error("Error occurred on load of Rendering Datasource" + ex.Message, ex.Source);
            }
        }

        /// <summary>
        /// CLick event for "Create New Form" button to open Sitecore 9 forms speak UI in a dialog.
        /// </summary>
        protected void OnOpenFormWizard()
        {
            SheerResponse.ShowModalDialog(url);
        }
    }
}

