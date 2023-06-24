using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public struct Factory
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xB17FA0", Offset = "0xB165A0", VA = "0x180B17FA0")]
		public static RESULT System_Create(out System system)
		{
			return RESULT.OK;
		}

		// Token: 0x060000C3 RID: 195
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xB17FA0", Offset = "0xB165A0", VA = "0x180B17FA0")]
		[PreserveSig]
		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
}
