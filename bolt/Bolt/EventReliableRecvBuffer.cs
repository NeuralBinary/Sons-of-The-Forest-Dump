using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	internal class EventReliableRecvBuffer
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x8E7AC0", Offset = "0x8E60C0", VA = "0x1808E7AC0")]
		public EventReliableRecvBuffer(int windowBits, int sequenceBits)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x8E7BC0", Offset = "0x8E61C0", VA = "0x1808E7BC0")]
		public bool TryRemove(out EventReliable value)
		{
			return default(bool);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x8E7CD0", Offset = "0x8E62D0", VA = "0x1808E7CD0")]
		public RecvBufferAddResult TryEnqueue(EventReliable value)
		{
			return RecvBufferAddResult.Old;
		}

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x10")]
		private int tail;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x14")]
		private int mask;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x18")]
		private int sequenceShift;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x1C")]
		private uint sequenceNext;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x20")]
		private uint sequenceMask;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x28")]
		private readonly EventReliableRecvBuffer.Node[] nodes;

		// Token: 0x02000081 RID: 129
		[Token(Token = "0x2000081")]
		private struct Node
		{
			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			[FieldOffset(Offset = "0x0")]
			public bool Received;

			// Token: 0x0400022E RID: 558
			[Token(Token = "0x400022E")]
			[FieldOffset(Offset = "0x8")]
			public EventReliable Value;
		}
	}
}
