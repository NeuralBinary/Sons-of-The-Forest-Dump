using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	internal class EventReliableSendBuffer
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E9")]
		public IEnumerable<EventReliable> Pending
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x8E7DA0", Offset = "0x8E63A0", VA = "0x1808E7DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000EA")]
		public IEnumerable<EventReliable> Delivered
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x8E7E40", Offset = "0x8E6440", VA = "0x1808E7E40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x170000EB")]
		public bool Full
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x8E7EE0", Offset = "0x8E64E0", VA = "0x1808E7EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x8E7F10", Offset = "0x8E6510", VA = "0x1808E7F10")]
		public EventReliableSendBuffer(int windowBits, int sequenceBits)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x8E8010", Offset = "0x8E6610", VA = "0x1808E8010")]
		public bool TryEnqueue(EventReliable value)
		{
			return default(bool);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x8E8130", Offset = "0x8E6730", VA = "0x1808E8130")]
		public bool TryNext(out EventReliable value)
		{
			return default(bool);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x8E8200", Offset = "0x8E6800", VA = "0x1808E8200")]
		public void SetDelivered(EventReliable value)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x8E8290", Offset = "0x8E6890", VA = "0x1808E8290")]
		public void SetSend(EventReliable value)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x8E8320", Offset = "0x8E6920", VA = "0x1808E8320")]
		public bool TryRemove(out EventReliable value)
		{
			return default(bool);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x8E8410", Offset = "0x8E6A10", VA = "0x1808E8410")]
		private void ChangeState(EventReliable value, EventReliableSendBuffer.State state)
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x8E8490", Offset = "0x8E6A90", VA = "0x1808E8490")]
		private int SequenceDistance(uint from, uint to)
		{
			return 0;
		}

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x10")]
		private int tail;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x14")]
		private int mask;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x18")]
		private int shift;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x1C")]
		private int count;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x20")]
		private EventReliableSendBuffer.Node[] nodes;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x28")]
		private BoltSequenceGenerator generator;

		// Token: 0x02000083 RID: 131
		[Token(Token = "0x2000083")]
		private enum State
		{
			// Token: 0x04000236 RID: 566
			[Token(Token = "0x4000236")]
			Free,
			// Token: 0x04000237 RID: 567
			[Token(Token = "0x4000237")]
			Send,
			// Token: 0x04000238 RID: 568
			[Token(Token = "0x4000238")]
			Transit,
			// Token: 0x04000239 RID: 569
			[Token(Token = "0x4000239")]
			Delivered
		}

		// Token: 0x02000084 RID: 132
		[Token(Token = "0x2000084")]
		private struct Node
		{
			// Token: 0x0400023A RID: 570
			[Token(Token = "0x400023A")]
			[FieldOffset(Offset = "0x0")]
			public EventReliableSendBuffer.State State;

			// Token: 0x0400023B RID: 571
			[Token(Token = "0x400023B")]
			[FieldOffset(Offset = "0x8")]
			public EventReliable Value;
		}
	}
}
