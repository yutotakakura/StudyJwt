﻿using Duende.IdentityServer.Models;

namespace App;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        { 
            new IdentityResources.OpenId()
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[] { new ApiScope(name: "api1", displayName: "MyAPI") };

    public static IEnumerable<Client> Clients =>
        new Client[] 
            {
                new Client 
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedScopes = { "api1" }
                }
            };
}