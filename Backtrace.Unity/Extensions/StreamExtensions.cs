using System;
using System.IO;
using Il2CppDummyDll;

namespace Backtrace.Unity.Extensions
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	internal static class StreamExtensions
	{
		// Token: 0x06000373 RID: 883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x768310", Offset = "0x766910", VA = "0x180768310")]
		public static void CopyTo(this Stream original, Stream destination)
		{
		}

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		private const int _DefaultCopyBufferSize = 81920;
	}
}
