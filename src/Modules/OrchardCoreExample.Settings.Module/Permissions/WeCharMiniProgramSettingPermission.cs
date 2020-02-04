﻿using OrchardCore.Security.Permissions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrchardCoreExample.Settings.Module.Permissions
{
    public class WeCharMiniProgramSettingPermission : IPermissionProvider
    {
        public static readonly Permission WeCharMiniProgramAccess = new Permission("WeCharMiniProgramAccess", "微信小程序WebApi接口权限");
        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            return new[]
            {
                new PermissionStereotype
                {
                    Name = "Authenticated",
                    Permissions = new[] {WeCharMiniProgramAccess}
                }
            };
        }

        public Task<IEnumerable<Permission>> GetPermissionsAsync()
        {
            return Task.FromResult(new[] { WeCharMiniProgramAccess }.AsEnumerable());
        }
    }
}
