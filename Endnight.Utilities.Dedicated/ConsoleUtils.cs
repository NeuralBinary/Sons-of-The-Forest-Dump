using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Endnight.Utilities.Dedicated
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public static class ConsoleUtils
	{
		// Token: 0x06000003 RID: 3
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xA82440", Offset = "0xA80A40", VA = "0x180A82440")]
		[PreserveSig]
		private static extern IntPtr GetStdHandle(int nStdHandle);

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xA824D0", Offset = "0xA80AD0", VA = "0x180A824D0")]
		[PreserveSig]
		private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

		// Token: 0x06000005 RID: 5
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xA82570", Offset = "0xA80B70", VA = "0x180A82570")]
		[PreserveSig]
		private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0xA82610", Offset = "0xA80C10", VA = "0x180A82610")]
		public static void DisableConsoleQuickEditMode()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		private const int STD_INPUT_HANDLE = -10;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		private const uint ENABLE_QUICK_EDIT = 64U;
	}
}
