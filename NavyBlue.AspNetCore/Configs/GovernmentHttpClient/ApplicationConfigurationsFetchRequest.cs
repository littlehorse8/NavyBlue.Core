﻿// *****************************************************************************************************************
// Project          : NavyBlue
// File             : ApplicationConfigurationsFetchRequest.cs
// Created          : 2019-01-14  17:08
//
// Last Modified By : (jstsmaxx@163.com)
// Last Modified On : 2019-01-15  10:56
// *****************************************************************************************************************
// <copyright file="ApplicationConfigurationsFetchRequest.cs" company="Shanghai Future Mdt InfoTech Ltd.">
//     Copyright ©  2012-2019 Mdt InfoTech Ltd. All rights reserved.
// </copyright>
// *****************************************************************************************************************

namespace NavyBlue.AspNetCore.Lib.Configs.GovernmentHttpClient
{
    /// <summary>
    ///     ApplicationConfigurationsFetchRequest.
    /// </summary>
    public class ApplicationConfigurationsFetchRequest
    {
        /// <summary>
        ///     Gets or sets the role.
        /// </summary>
        /// <value>The role.</value>
        public string Role { get; set; }

        /// <summary>
        ///     Gets or sets the role instance.
        /// </summary>
        /// <value>The role instance.</value>
        public string RoleInstance { get; set; }

        /// <summary>
        ///     Gets or sets the source version.
        /// </summary>
        /// <value>The source version.</value>
        public string SourceVersion { get; set; }
    }
}