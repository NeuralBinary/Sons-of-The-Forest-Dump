using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	internal class Packet : IDisposable
	{
		// Token: 0x060006FF RID: 1791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x901430", Offset = "0x8FFA30", VA = "0x180901430", Slot = "4")]
		private void Dispose()
		{
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x9014B0", Offset = "0x8FFAB0", VA = "0x1809014B0")]
		public Packet()
		{
		}

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x10")]
		public bool Pooled;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x14")]
		public int Frame;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x18")]
		public int Number;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x1C")]
		public PacketStats Stats;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x28")]
		public UdpPacket UdpPacket;

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x30")]
		public List<EventReliable> ReliableEvents;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x38")]
		public Queue<EntityProxyEnvelope> EntityUpdates;
	}
}
