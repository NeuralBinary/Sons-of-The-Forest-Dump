using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	[Nullable(0)]
	[NullableContext(2)]
	internal static class BufferUtils
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x25633B0", Offset = "0x25619B0", VA = "0x1825633B0")]
		[NullableContext(1)]
		public static char[] RentBuffer([Nullable(2)] IArrayPool<char> bufferPool, int minSize)
		{
			return null;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x2563430", Offset = "0x2561A30", VA = "0x182563430")]
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer)
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x2563480", Offset = "0x2561A80", VA = "0x182563480")]
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer)
		{
			return null;
		}
	}
}
