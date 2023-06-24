using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Backtrace.Unity.Common
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	internal static class SystemHelper
	{
		// Token: 0x06000390 RID: 912
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x76A5F0", Offset = "0x768BF0", VA = "0x18076A5F0")]
		[PreserveSig]
		internal static extern uint GetCurrentThreadId();

		// Token: 0x06000391 RID: 913
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x76A660", Offset = "0x768C60", VA = "0x18076A660")]
		[PreserveSig]
		internal static extern IntPtr LoadLibrary(string lpFileName);

		// Token: 0x06000392 RID: 914 RVA: 0x0000317C File Offset: 0x0000137C
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x76A710", Offset = "0x768D10", VA = "0x18076A710")]
		internal static bool IsLibraryAvailable(string libraryName)
		{
			return default(bool);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x76A7D0", Offset = "0x768DD0", VA = "0x18076A7D0")]
		internal static bool IsLibraryAvailable(string[] libraries)
		{
			return default(bool);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x76A900", Offset = "0x768F00", VA = "0x18076A900")]
		internal static string Name()
		{
			return null;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x76ABC0", Offset = "0x7691C0", VA = "0x18076ABC0")]
		internal static string CpuArchitecture()
		{
			return null;
		}
	}
}
