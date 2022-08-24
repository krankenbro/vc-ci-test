using System.Collections.Generic;
using VirtoCommerce.Platform.Core.Settings;

namespace VirtoCommerce.CITest.Core
{
    public static class ModuleConstants
    {
        public static class Security
        {
            public static class Permissions
            {
                public const string Access = "CITest:access";
                public const string Create = "CITest:create";
                public const string Read = "CITest:read";
                public const string Update = "CITest:update";
                public const string Delete = "CITest:delete";

                public static string[] AllPermissions { get; } =
                {
                    Access,
                    Create,
                    Read,
                    Update,
                    Delete,
                };
            }
        }

        public static class Settings
        {
            public static class General
            {
                public static SettingDescriptor CITestEnabled { get; } = new SettingDescriptor
                {
                    Name = "CITest.CITestEnabled",
                    GroupName = "CITest|General",
                    ValueType = SettingValueType.Boolean,
                    DefaultValue = false,
                };

                public static SettingDescriptor CITestPassword { get; } = new SettingDescriptor
                {
                    Name = "CITest.CITestPassword",
                    GroupName = "CITest|Advanced",
                    ValueType = SettingValueType.SecureString,
                    DefaultValue = "qwerty",
                };

                public static IEnumerable<SettingDescriptor> AllGeneralSettings
                {
                    get
                    {
                        yield return CITestEnabled;
                        yield return CITestPassword;
                    }
                }
            }

            public static IEnumerable<SettingDescriptor> AllSettings
            {
                get
                {
                    return General.AllGeneralSettings;
                }
            }
        }
    }
}
