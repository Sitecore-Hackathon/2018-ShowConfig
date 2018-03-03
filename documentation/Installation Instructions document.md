Installation Steps
Prerequisites
1. Install Sitecore Powershell 4.7.2
2. Install SXA package for Sitecore 9.0

Steps
1. Install Package "ShowConfig_ExpressForms.zip" using sitecore package installation wizard.
2. Add "SelectRenderingDatasource.xml" XML file in the "/sitecore/shell/override/Applications/Dialogs/SelectRenderingDatasource" folder path.
3. Drop dll "Feature.Forms.ExpressForm.dll" in bin of the CMS webroot.
4. Add "Express Sitecore form Wrapper"  in the renderings field of "/sitecore/content/{Tenantname}/{Sitename}/Presentation/Available Renderings/Forms".



