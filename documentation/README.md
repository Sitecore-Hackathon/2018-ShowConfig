Summary
Category: Sitecore SXA

This module provides a capability to create new forms in one go by using Sitecore 9 forms. The same can also be achieved using out of the box features, but it's quite tedious job for users since user can add only one element(Form/Page/Section/Controls) at a time without validations not being handled and to preview. Sitecore 9 forms feature cannot be used in SXA experience editor mode.
This module is going to solve the above problems by offering sitecore 9 forms module to be opened while we are at the SXA itself. 


Pre-requisites
1. Sitecore SXA module 9.0
2. Sitecore PowerShell 4.7.2

Installation
Please follow the installation guide document and install all the required packages and files.

Configuration
1. Add "Express Sitecore form Wrapper"  in the renderings field of "/sitecore/content/{Tenantname}/{Sitename}/Presentation/Available Renderings/Forms".

Usage
1. Open a page created using SXA in Experience Editor mode and open SXA tool box in the right hand pane. Refer Screenshot "/Images/ExperienceEditor.jpg"
3. Under Forms section from the tool box, select "Express Sitecore Form Wrapper" and drag and drop on any section of the page. Refer screenshot "/Images/SelectExpressWrapper.jpg".
4. As soon as the wrapper is dragged, a new "Express MVC Form" is generated under the Forms section in the toolbox and drag and drop the "Express MVC Form" on the page.Refer screenshot "/Images/ExpressMvcFormRendering.jpg".
5. As soon as the form is dropped, a dialog to select the associated form is populated and a new button "Create New Form" button (highlighted) is shown. Refer screenshot "/Images/CreateNewFormPopup.jpg".
6. Click on "Create New Form" and a sitecore 9 forms window will open in a dialog.Refer screenshot "Sitecore9Form.jpg".
7. Design a form using sitecore 9 forms features and close the dialog.
8. Refresh the Forms root folder in the treeview. Select the newly created form and click on OK.
