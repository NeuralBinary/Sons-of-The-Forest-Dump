using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	internal class EventChannel : BoltChannel
	{
		// Token: 0x0600048F RID: 1167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x8E3ED0", Offset = "0x8E24D0", VA = "0x1808E3ED0")]
		public EventChannel()
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x8E4270", Offset = "0x8E2870", VA = "0x1808E4270")]
		public void Queue(Event ev)
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x8E4520", Offset = "0x8E2B20", VA = "0x1808E4520", Slot = "7")]
		public override void Delivered(Packet packet)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x8E46C0", Offset = "0x8E2CC0", VA = "0x1808E46C0", Slot = "6")]
		public override void Lost(Packet packet)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x8E4840", Offset = "0x8E2E40", VA = "0x1808E4840", Slot = "4")]
		public override void Pack(Packet packet)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x8E4E70", Offset = "0x8E3470", VA = "0x1808E4E70")]
		private bool PackEvent(Event ev, UdpPacket stream, uint sequence)
		{
			return default(bool);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x8E50C0", Offset = "0x8E36C0", VA = "0x1808E50C0", Slot = "5")]
		public override void Read(Packet packet)
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x8E53E0", Offset = "0x8E39E0", VA = "0x1808E53E0")]
		private Event ReadEvent(UdpPacket stream, ref uint sequence)
		{
			return null;
		}

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x18")]
		private List<EventUnreliable> unreliableSend;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x20")]
		private EventReliableSendBuffer reliableOrderedSend;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x28")]
		private EventReliableRecvBuffer reliableOrderedRecv;
	}
}
