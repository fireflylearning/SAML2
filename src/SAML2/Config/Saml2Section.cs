﻿using System.Configuration;
using System.Xml.Serialization;

namespace SAML2.Config
{
    /// <summary>
    /// SAML2 Configuration Section.
    /// </summary>
    public class Saml2Section : ConfigurationSection
    {
        private string _metaDataShaHashingAlgorithm = ShaHashingAlgorithm.SHA256.ToString();

        /// <summary>
        /// Gets the section name.
        /// </summary>
        public static string Name { get { return "saml2"; } }

        #region Elements

        [XmlElement(ElementName = "MetaDataShaHashingAlgorithm")]
        public string MetaDataShaHashingAlgorithm
        {
            get { return _metaDataShaHashingAlgorithm; }
            set { _metaDataShaHashingAlgorithm = value; }
        }

        /// <summary>
        /// Gets or sets the actions to perform on successful processing.
        /// </summary>
        /// <value>The actions.</value>
        [ConfigurationProperty("signOnActions")]
        public ActionCollection SignOnActions
        {
            get { return (ActionCollection)base["signOnActions"]; }
            set { base["signOnActions"] = value; }
        }

        /// <summary>
        /// Gets or sets the actions to perform on successful processing.
        /// </summary>
        /// <value>The actions.</value>
        [ConfigurationProperty("logoutActions")]
        public ActionCollection LogoutActions
        {
            get { return (ActionCollection)base["logoutActions"]; }
            set { base["logoutActions"] = value; }
        }

        /// <summary>
        /// Gets or sets the allowed audience uris.
        /// </summary>
        /// <value>The allowed audience uris.</value>
        [ConfigurationProperty("allowedAudienceUris")]
        public AllowedAudienceUriCollection AllowedAudienceUris
        {
            get { return (AllowedAudienceUriCollection)base["allowedAudienceUris"]; }
            set { base["allowedAudienceUris"] = value; }
        }

        /// <summary>
        /// Gets or sets the assertion profile.
        /// </summary>
        /// <value>The assertion profile configuration.</value>
        [ConfigurationProperty("assertionProfile")]
        public AssertionProfileElement AssertionProfile
        {
            get { return (AssertionProfileElement)base["assertionProfile"]; }
            set { base["assertionProfile"] = value; }
        }

        /// <summary>
        /// Gets or sets the common domain cookie configuration.
        /// </summary>
        /// <value>The common domain cookie configuration.</value>
        [ConfigurationProperty("commonDomainCookie")]
        public CommonDomainCookieElement CommonDomainCookie
        {
            get { return (CommonDomainCookieElement)base["commonDomainCookie"]; }
            set { base["commonDomainCookie"] = value; }
        }

        /// <summary>
        /// Gets or sets the identity providers.
        /// </summary>
        /// <value>The identity providers.</value>
        [ConfigurationProperty("identityProviders")]
        public IdentityProviderCollection IdentityProviders
        {
            get { return (IdentityProviderCollection)base["identityProviders"]; }
            set { base["identityProviders"] = value; }
        }

        /// <summary>
        /// Gets or sets the logging configuration.
        /// </summary>
        /// <value>The logging configuration.</value>
        [ConfigurationProperty("logging")]
        public LoggingElement Logging
        {
            get { return (LoggingElement)base["logging"]; }
            set { base["logging"] = value; }
        }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        /// <value>The metadata.</value>
        [ConfigurationProperty("metadata")]
        public MetadataElement Metadata
        {
            get { return (MetadataElement)base["metadata"]; }
            set { base["metadata"] = value; }
        }

        /// <summary>
        /// Gets or sets the service provider.
        /// </summary>
        /// <value>The service provider.</value>
        [ConfigurationProperty("serviceProvider")]
        public ServiceProviderElement ServiceProvider
        {
            get { return (ServiceProviderElement)base["serviceProvider"]; }
            set { base["serviceProvider"] = value; }
        }

        /// <summary>
        /// Gets or sets the state service configuration.
        /// </summary>
        /// <value>The state service configuration.</value>
        [ConfigurationProperty("state")]
        public StateElement State
        {
            get { return (StateElement)base["state"]; }
            set { base["state"] = value; }
        }

        #endregion

        /// <summary>
        /// Gets a value indicating whether the <see cref="T:System.Configuration.ConfigurationElement"/> object is read-only.
        /// </summary>
        /// <returns>true if the <see cref="T:System.Configuration.ConfigurationElement"/> object is read-only; otherwise, false.</returns>
        public override bool IsReadOnly()
        {
            return false;
        }
    }
}
