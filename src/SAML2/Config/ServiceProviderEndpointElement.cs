using System.Configuration;

namespace SAML2.Config
{
    public class ServiceProviderEndpointElement : WritableConfigurationElement, IConfigurationElementCollectionElement
    {
        [ConfigurationProperty("binding")]
        public BindingType Binding
        {
            get { return (BindingType)base["binding"]; }
            set { base["binding"] = value; }
        }

        [ConfigurationProperty("index")]
        public int Index
        {
            get { return (int)base["index"]; }
            set { base["index"] = value; }
        }

        [ConfigurationProperty("localPath", IsRequired = true)]
        public string LocalPath
        {
            get { return (string)base["localPath"]; }
            set { base["localPath"] = value; }
        }

        [ConfigurationProperty("redirectUrl")]
        public string RedirectUrl
        {
            get { return (string)base["redirectUrl"]; }
            set { base["redirectUrl"] = value; }
        }

        [ConfigurationProperty("type", IsKey = true, IsRequired = true)]
        public EndpointType Type
        {
            get { return (EndpointType)base["type"]; }
            set { base["type"] = value; }
        }

        [ConfigurationProperty("signLogoutResponses")]
        public bool SignLogoutResponses
        {
            get { return (bool)base["signLogoutResponses"]; }
            set { base["signLogoutResponses"] = value; }
        }

        #region Implementation of IConfigurationElementCollectionElement
        public object ElementKey
        {
            get { return Type; }
        }
        #endregion
    }
}
