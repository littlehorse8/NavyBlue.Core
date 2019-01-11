﻿// *****************************************************************************************************************
// Project          : NavyBlue
// File             : MiddlewareExtensions.cs
// Created          : 2019-01-10  20:05
// 
// Last Modified By : (jstsmaxx@163.com)
// Last Modified On : 2019-01-10  20:05
// *****************************************************************************************************************
// <copyright file="MiddlewareExtensions.cs" company="Shanghai Future Mdt InfoTech Ltd.">
//     Copyright ©  2012-2019 Mdt InfoTech Ltd. All rights reserved.
// </copyright>
// *****************************************************************************************************************


using Microsoft.AspNetCore.Builder;
using NavyBlue.AspNetCore.Web.Middlewares.Middleware;

namespace NavyBlue.AspNetCore.Web.Middlewares
{
    public static class MiddlewareExtensions
    {
        /// <summary>
        /// Uses the trace entry.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns></returns>
        public static IApplicationBuilder UseTraceEntry(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TraceEntryMiddleware>();
        }

        /// <summary>
        ///     Uses the jinyinmao json response wapper handler.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns>HttpConfiguration.</returns>
        public static IApplicationBuilder UseJsonResponseWapper(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<JsonResponseWarpperMiddleware>();
        }

        public static IApplicationBuilder UseNBAuthorization(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthorizationMiddleware>();
        }
    }
}