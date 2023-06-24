using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	internal class BufferPool
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x775770", Offset = "0x773D70", VA = "0x180775770")]
		public BufferPool(bool cleanBuffers)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x775890", Offset = "0x773E90", VA = "0x180775890")]
		public byte[] Allocate(uint size)
		{
			return null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x775950", Offset = "0x773F50", VA = "0x180775950")]
		public void Free(byte[] buf)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x775A00", Offset = "0x774000", VA = "0x180775A00")]
		private Queue<byte[]> GetQueue(uint size)
		{
			return null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x775B00", Offset = "0x774100", VA = "0x180775B00")]
		private static uint NextPow2(uint v)
		{
			return 0U;
		}

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<uint, Queue<byte[]>> _queues;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _threadId;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x1C")]
		private readonly bool _cleanBuffers;
	}
}
