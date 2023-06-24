using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	public struct Util
	{
		// Token: 0x060004EA RID: 1258 RVA: 0x00004C64 File Offset: 0x00002E64
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xB3FA50", Offset = "0xB3E050", VA = "0x180B3FA50")]
		public static RESULT parseID(string idString, out Guid id)
		{
			return RESULT.OK;
		}

		// Token: 0x060004EB RID: 1259
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xB3FBD0", Offset = "0xB3E1D0", VA = "0x180B3FBD0")]
		[PreserveSig]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
}
