﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAML2 {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SAML2.ErrorMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Artifact is not from a known identity provider.
        /// </summary>
        internal static string ArtifactResolveIdentityProviderUnknown {
            get {
                return ResourceManager.GetString("ArtifactResolveIdentityProviderUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not verify SAML SOAP binding message signature.
        /// </summary>
        internal static string ArtifactResolveSignatureInvalid {
            get {
                return ResourceManager.GetString("ArtifactResolveSignatureInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ArtifactResponse did not contain an assertion.
        /// </summary>
        internal static string ArtifactResponseMissingAssertion {
            get {
                return ResourceManager.GetString("ArtifactResponseMissingAssertion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported payload message in ArtifactResponse.
        /// </summary>
        internal static string ArtifactResponseMissingResponse {
            get {
                return ResourceManager.GetString("ArtifactResponseMissingResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not verify artifact response message signature.
        /// </summary>
        internal static string ArtifactResponseSignatureInvalid {
            get {
                return ResourceManager.GetString("ArtifactResponseSignatureInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ArtifactResponse status code was invalid, expected {0}.
        /// </summary>
        internal static string ArtifactResponseStatusCodeInvalid {
            get {
                return ResourceManager.GetString("ArtifactResponseStatusCodeInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assertion expiration has been exceeded.
        /// </summary>
        internal static string AssertionExpired {
            get {
                return ResourceManager.GetString("AssertionExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not process assertion with an unknown identity provider.
        /// </summary>
        internal static string AssertionIdentityProviderUnknown {
            get {
                return ResourceManager.GetString("AssertionIdentityProviderUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assertion not found.
        /// </summary>
        internal static string AssertionNotFound {
            get {
                return ResourceManager.GetString("AssertionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assertion with OneTimeUse condition detected more than once.
        /// </summary>
        internal static string AssertionOneTimeUseExceeded {
            get {
                return ResourceManager.GetString("AssertionOneTimeUseExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assertion signature is invalid.
        /// </summary>
        internal static string AssertionSignatureInvalid {
            get {
                return ResourceManager.GetString("AssertionSignatureInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attribute query can not be performed when user is not logged in with an identity provider.
        /// </summary>
        internal static string AttrQueryNoLogin {
            get {
                return ResourceManager.GetString("AttrQueryNoLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AttrQuery response with status code &quot;{0}&quot; received when &quot;Success&quot; was expected.
        /// </summary>
        internal static string AttrQueryStatusNotSuccessful {
            get {
                return ResourceManager.GetString("AttrQueryStatusNotSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate with DN &quot;{0}&quot; and thumbprint &quot;{1}&quot; is not valid according to RFC3280.
        /// </summary>
        internal static string CertificateIsNotRFC3280Valid {
            get {
                return ResourceManager.GetString("CertificateIsNotRFC3280Valid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate {0} was not found.
        /// </summary>
        internal static string CertificateNotFound {
            get {
                return ResourceManager.GetString("CertificateNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found more than one certificate matching {0}.
        /// </summary>
        internal static string CertificateNotUnique {
            get {
                return ResourceManager.GetString("CertificateNotUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Common Domain Cookie identity provider not found in list of known identity providers: {0}.
        /// </summary>
        internal static string CommonDomainCookieIdentityProviderInvalid {
            get {
                return ResourceManager.GetString("CommonDomainCookieIdentityProviderInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration element &lt;saml2&gt; does not contain an &lt;identityProviders&gt; element.
        /// </summary>
        internal static string ConfigMissingIdentityProvidersElement {
            get {
                return ResourceManager.GetString("ConfigMissingIdentityProvidersElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration for &lt;identityProviders&gt; does not contain a &quot;metadata&quot; attribute.
        /// </summary>
        internal static string ConfigMissingMetadataLocation {
            get {
                return ResourceManager.GetString("ConfigMissingMetadataLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration does not contain &lt;saml2&gt; element.
        /// </summary>
        internal static string ConfigMissingSaml2Element {
            get {
                return ResourceManager.GetString("ConfigMissingSaml2Element", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration element &lt;saml2&gt; does not contain a &lt;serviceProvider&gt; element.
        /// </summary>
        internal static string ConfigMissingServiceProviderElement {
            get {
                return ResourceManager.GetString("ConfigMissingServiceProviderElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration for &lt;serviceProvider&gt; does not contain an &quot;id&quot; attribute.
        /// </summary>
        internal static string ConfigMissingServiceProviderIdAttribute {
            get {
                return ResourceManager.GetString("ConfigMissingServiceProviderIdAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration for &lt;serviceProvider&gt; does not contain a &lt;signingCertificate&gt; element.
        /// </summary>
        internal static string ConfigMissingSigningCertificateElement {
            get {
                return ResourceManager.GetString("ConfigMissingSigningCertificateElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration for &lt;serviceProvider&gt; does not contain a SignOn endpoint.
        /// </summary>
        internal static string ConfigServiceProviderMissingSignOnEndpoint {
            get {
                return ResourceManager.GetString("ConfigServiceProviderMissingSignOnEndpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified &lt;signingCertificate&gt; does not have a private key.
        /// </summary>
        internal static string ConfigSigningCertificateMissingPrivateKey {
            get {
                return ResourceManager.GetString("ConfigSigningCertificateMissingPrivateKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The endpoint binding must be one of POST, Redirect, or Artifact.
        /// </summary>
        internal static string EndpointBindingInvalid {
            get {
                return ResourceManager.GetString("EndpointBindingInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty protocol message id is not allowed.
        /// </summary>
        internal static string ExpectedInResponseToEmpty {
            get {
                return ResourceManager.GetString("ExpectedInResponseToEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session ExpectedInResponseTo missing.
        /// </summary>
        internal static string ExpectedInResponseToMissing {
            get {
                return ResourceManager.GetString("ExpectedInResponseToMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred.
        /// </summary>
        internal static string GenericError {
            get {
                return ResourceManager.GetString("GenericError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key {0} was not found for endpoint {1}.
        /// </summary>
        internal static string KeyNotFound {
            get {
                return ResourceManager.GetString("KeyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified metadata directory &quot;{0}&quot; could not be located.
        /// </summary>
        internal static string MetadataLocationNotFound {
            get {
                return ResourceManager.GetString("MetadataLocationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &quot;sign&quot;query string parameter could not be parsed.
        /// </summary>
        internal static string MetadataSignQueryParameterInvalid {
            get {
                return ResourceManager.GetString("MetadataSignQueryParameterInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Possible replay attack detected, unexpected value {0} for InResponseTo, expected {1}.
        /// </summary>
        internal static string ReplayAttack {
            get {
                return ResourceManager.GetString("ReplayAttack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request signature is invalid.
        /// </summary>
        internal static string RequestSignatureInvalid {
            get {
                return ResourceManager.GetString("RequestSignatureInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request is not signed.
        /// </summary>
        internal static string RequestSignatureMissing {
            get {
                return ResourceManager.GetString("RequestSignatureMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received a response message that did not contain an InResponseTo attribute.
        /// </summary>
        internal static string ResponseMissingInResponseToAttribute {
            get {
                return ResourceManager.GetString("ResponseMissingInResponseToAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response signature is invalid.
        /// </summary>
        internal static string ResponseSignatureInvalid {
            get {
                return ResourceManager.GetString("ResponseSignatureInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response is not signed.
        /// </summary>
        internal static string ResponseSignatureMissing {
            get {
                return ResourceManager.GetString("ResponseSignatureMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response with status code NoPassive received. A user cannot be signed in with the IsPassiveFlag set when the user does not have a session with the identity provider.
        /// </summary>
        internal static string ResponseStatusIsNoPassive {
            get {
                return ResourceManager.GetString("ResponseStatusIsNoPassive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response with status code &quot;{0}&quot; received when &quot;Success&quot;was expected.
        /// </summary>
        internal static string ResponseStatusNotSuccessful {
            get {
                return ResourceManager.GetString("ResponseStatusNotSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SOAP message did not contain a supported SamlMessage element.
        /// </summary>
        internal static string SOAPMessageUnsupportedSamlMessage {
            get {
                return ResourceManager.GetString("SOAPMessageUnsupportedSamlMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User accessing resource &quot;{0}&quot; without authentication.
        /// </summary>
        internal static string UnauthenticatedAccess {
            get {
                return ResourceManager.GetString("UnauthenticatedAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encoding &quot;{0}&quot; is not supported.
        /// </summary>
        internal static string UnknownEncoding {
            get {
                return ResourceManager.GetString("UnknownEncoding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown identity provider &quot;{0}&quot;.
        /// </summary>
        internal static string UnknownIdentityProvider {
            get {
                return ResourceManager.GetString("UnknownIdentityProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RequestType &quot;{0}&quot; is not supported..
        /// </summary>
        internal static string UnsupportedRequestType {
            get {
                return ResourceManager.GetString("UnsupportedRequestType", resourceCulture);
            }
        }
    }
}
