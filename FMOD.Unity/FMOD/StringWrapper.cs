using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public struct StringWrapper
	{
		// Token: 0x0600041D RID: 1053 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600041D")]
		[Address(RVA = "0xB387F0", Offset = "0xB36DF0", VA = "0x180B387F0")]
		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr nativeUtf8Ptr;
	}
}
