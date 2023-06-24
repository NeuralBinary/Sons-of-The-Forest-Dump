using System;
using System.Runtime.InteropServices;
using Backtrace.Unity.Types;
using Il2CppDummyDll;

namespace Backtrace.Unity.Common
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	internal static class MinidumpHelper
	{
		// Token: 0x0600038B RID: 907 RVA: 0x0000314C File Offset: 0x0000134C
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x769CE0", Offset = "0x7682E0", VA = "0x180769CE0")]
		private static bool IsMemoryDumpAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600038C RID: 908
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x769F30", Offset = "0x768530", VA = "0x180769F30")]
		[PreserveSig]
		internal static extern bool MiniDumpWriteDump(IntPtr hProcess, uint processId, SafeHandle hFile, uint dumpType, ref MiniDumpExceptionInformation expParam, IntPtr userStreamParam, IntPtr callbackParam);

		// Token: 0x0600038D RID: 909
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x76A0A0", Offset = "0x7686A0", VA = "0x18076A0A0")]
		[PreserveSig]
		internal static extern bool MiniDumpWriteDump(IntPtr hProcess, uint processId, SafeHandle hFile, uint dumpType, IntPtr expParam, IntPtr userStreamParam, IntPtr callbackParam);

		// Token: 0x0600038E RID: 910 RVA: 0x00003164 File Offset: 0x00001364
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x76A1D0", Offset = "0x7687D0", VA = "0x18076A1D0")]
		internal static bool Write(string filePath, MiniDumpType options = MiniDumpType.WithFullMemory, MinidumpException exceptionType = MinidumpException.None)
		{
			return default(bool);
		}

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] Libraries;
	}
}
