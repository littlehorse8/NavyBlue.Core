﻿// *****************************************************************************************************************
// Project          : NavyBlue
// File             : ValuesController.cs
// Created          : 2019-01-10  18:53
//
// Last Modified By : (jstsmaxx@163.com)
// Last Modified On : 2019-01-15  10:55
// *****************************************************************************************************************
// <copyright file="ValuesController.cs" company="Shanghai Future Mdt InfoTech Ltd.">
//     Copyright ©  2012-2019 Mdt InfoTech Ltd. All rights reserved.
// </copyright>
// *****************************************************************************************************************

using System;
using Microsoft.AspNetCore.Mvc;
using NavyBlue.Demo.API.Model;
using System.Collections.Generic;
using NavyBlue.AspNetCore.Lib;
using Newtonsoft.Json;

namespace NavyBlue.Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post(UserInfo userInfo)
        {
            //JsonConvert.SerializeObject(userInfo);

            //userInfo.ToJson().FromJson<UserInfo>();

            //GuidUtility.NewSequentialGuid().ToGuidString()

            return this.Ok(new { UserName = "edison", Age = 30 });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}