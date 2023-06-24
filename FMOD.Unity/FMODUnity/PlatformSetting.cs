using System;
using Il2CppDummyDll;

namespace FMODUnity
{
	// Token: 0x02000100 RID: 256
	[Token(Token = "0x2000100")]
	public class PlatformSetting<T> : PlatformSettingBase
	{
		// Token: 0x06000686 RID: 1670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000686")]
		public PlatformSetting()
		{
		}

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x0")]
		public T Value;
	}
}
