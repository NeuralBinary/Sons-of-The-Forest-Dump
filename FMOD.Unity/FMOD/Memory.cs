using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	public struct Memory
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xB18020", Offset = "0xB16620", VA = "0x180B18020")]
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags = MEMORY_TYPE.ALL)
		{
			return RESULT.OK;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xB180F0", Offset = "0xB166F0", VA = "0x180B180F0")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return RESULT.OK;
		}

		// Token: 0x060000C6 RID: 198
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xB18020", Offset = "0xB16620", VA = "0x180B18020")]
		[PreserveSig]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		// Token: 0x060000C7 RID: 199
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xB180F0", Offset = "0xB166F0", VA = "0x180B180F0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
}
