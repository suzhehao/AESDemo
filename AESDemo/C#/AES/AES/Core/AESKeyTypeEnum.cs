using System.ComponentModel;

namespace AES.Core
{
    public enum AESKeyTypeEnum
    {
        [Description("128")]
        KEY128 = 16,
        [Description("192")]
        KEY192 = 24,
        [Description("256")]
        KEY256 = 32
    }
}
