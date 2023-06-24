using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public struct Debug
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xB18190", Offset = "0xB16790", VA = "0x180B18190")]
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode = DEBUG_MODE.TTY, [Optional] DEBUG_CALLBACK callback, [Optional] string filename)
		{
			return RESULT.OK;
		}

		// Token: 0x060000C9 RID: 201
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xB18330", Offset = "0xB16930", VA = "0x180B18330")]
		[PreserveSig]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, byte[] filename);
	}
}
