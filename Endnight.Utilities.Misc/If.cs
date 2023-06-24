using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Endnight.Utilities.Misc
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public static class If
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000003")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T RuntimeElse<T>(T runtimeValue, T editorValue)
		{
			return null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000004")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T EditorElse<T>(T editorValue, T runtimeValue)
		{
			return null;
		}
	}
}
