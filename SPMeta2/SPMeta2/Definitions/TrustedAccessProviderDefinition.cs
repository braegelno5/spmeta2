﻿using System;
using System.Runtime.Serialization;
using SPMeta2.Attributes;
using SPMeta2.Attributes.Capabilities;
using SPMeta2.Attributes.Identity;
using SPMeta2.Attributes.Regression;
using SPMeta2.Utils;

namespace SPMeta2.Definitions
{
    /// <summary>
    /// Allows to define and deploy SharePoint web application.
    /// </summary>
    /// 
    [SPObjectType(SPObjectModelType.SSOM, "Microsoft.SharePoint.Administration.Claims.SPTrustedAccessProvider", "Microsoft.SharePoint")]

    [DefaultRootHost(typeof(FarmDefinition))]
    [DefaultParentHost(typeof(FarmDefinition))]

    //[ExpectAddHostExtensionMethod]
    [Serializable]
    [DataContract]
    //[ExpectWithExtensionMethod]
    [ExpectArrayExtensionMethod]

    [ParentHostCapability(typeof(FarmDefinition))]
    public class TrustedAccessProviderDefinition : DefinitionBase
    {
        #region properties


        [ExpectValidation]
        [DataMember]
        [IdentityKey]
        public string Name { get; set; }

        #endregion

        #region methods

        public override string ToString()
        {
            return new ToStringResult<TrustedAccessProviderDefinition>(this)
                          .AddPropertyValue(p => p.Name)
                          .ToString();
        }

        #endregion
    }
}
