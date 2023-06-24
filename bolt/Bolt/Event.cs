using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	[Documentation]
	public abstract class Event : NetworkObj_Root
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x170000E3")]
		public bool FromSelf
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x8E38E0", Offset = "0x8E1EE0", VA = "0x1808E38E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E4")]
		public BoltConnection RaisedBy
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x170000E5")]
		public bool IsGlobalEvent
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x8E38F0", Offset = "0x8E1EF0", VA = "0x1808E38F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E6")]
		internal override NetworkStorage Storage
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E7")]
		public byte[] BinaryData
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x170000E8")]
		internal bool IsEntityEvent
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x8E3910", Offset = "0x8E1F10", VA = "0x1808E3910")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x8E3930", Offset = "0x8E1F30", VA = "0x1808E3930")]
		internal Event(Event_Meta meta)
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x8E3A10", Offset = "0x8E2010", VA = "0x1808E3A10")]
		internal void FreeStorage()
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x8E3A40", Offset = "0x8E2040", VA = "0x1808E3A40")]
		internal bool Pack(BoltConnection connection, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x8E3B10", Offset = "0x8E2110", VA = "0x1808E3B10")]
		internal void Read(BoltConnection connection, UdpPacket packet)
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x8E3BD0", Offset = "0x8E21D0", VA = "0x1808E3BD0")]
		public void Send()
		{
		}

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		internal const byte ENTITY_EVERYONE = 1;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		internal const byte ENTITY_EVERYONE_EXCEPT_OWNER = 3;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		internal const byte ENTITY_EVERYONE_EXCEPT_OWNER_AND_CONTROLLER = 13;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		internal const byte ENTITY_EVERYONE_EXCEPT_CONTROLLER = 5;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		internal const byte ENTITY_ONLY_CONTROLLER = 7;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		internal const byte ENTITY_ONLY_OWNER = 9;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		internal const byte ENTITY_ONLY_SELF = 11;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		internal const byte GLOBAL_EVERYONE = 2;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		internal const byte GLOBAL_OTHERS = 4;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		internal const byte GLOBAL_ONLY_SERVER = 6;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		internal const byte GLOBAL_ALL_CLIENTS = 8;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		internal const byte GLOBAL_SPECIFIC_CONNECTION = 10;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		internal const byte GLOBAL_ONLY_SELF = 12;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		internal const int RELIABLE_WINDOW_BITS = 10;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		internal const int RELIABLE_SEQUENCE_BITS = 12;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x40")]
		private NetworkStorage storage;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x48")]
		internal uint Sequence;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x4C")]
		internal ReliabilityModes Reliability;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x50")]
		internal int Targets;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x54")]
		internal bool Reliable;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x58")]
		internal Entity TargetEntity;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x60")]
		internal BoltConnection TargetConnection;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x68")]
		internal BoltConnection SourceConnection;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x70")]
		internal new Event_Meta Meta;
	}
}
