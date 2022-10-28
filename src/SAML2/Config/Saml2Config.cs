using System;
using System.Web;
using LazyCache;
using Microsoft.Extensions.Caching.Memory;

namespace SAML2.Config
{
    public static class Saml2Config
    {
        private static IAppCache _cache;
        private static Saml2Section _defaultProvider;

        public static void Init(IAppCache cache, ISaml2ConfigProvider defaultProvider)
        {
            _cache = cache;
            _defaultProvider = defaultProvider.SAML2Config;
        }

        public static void AddTenant(string tenantIdentifier, ISaml2ConfigProvider configProvider)
        {
            var samlConfig = _cache.GetOrAdd(
                tenantIdentifier,
                () => configProvider.SAML2Config,
                new MemoryCacheEntryOptions
                    {
                        AbsoluteExpiration = null
                    });

            samlConfig.IdentityProviders.Refresh();
        }

        public static Saml2Section GetConfig()
        {
            var host = HttpContext.Current.Request.Url.DnsSafeHost;
            return GetConfig(host);
        }

        public static Saml2Section GetConfig(string tenantIdentifier)
        {
            return _cache.Get<Saml2Section>(tenantIdentifier) ?? _defaultProvider;
        }
    }
}
