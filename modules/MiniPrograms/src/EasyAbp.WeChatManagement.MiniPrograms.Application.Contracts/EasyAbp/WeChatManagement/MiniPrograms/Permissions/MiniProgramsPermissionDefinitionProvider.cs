﻿using EasyAbp.WeChatManagement.MiniPrograms.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EasyAbp.WeChatManagement.MiniPrograms.Permissions
{
    public class MiniProgramsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MiniProgramsPermissions.GroupName, L("Permission:MiniPrograms"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MiniProgramsResource>(name);
        }
    }
}