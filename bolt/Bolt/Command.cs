using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[Documentation]
	public abstract class Command : NetworkObj_Root, IBoltListNode
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C4")]
		internal override NetworkStorage Storage
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C5")]
		internal NetworkCommand_Data InputObject
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x8DCE40", Offset = "0x8DB440", VA = "0x1808DCE40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C6")]
		internal NetworkCommand_Data ResultObject
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x8DCF00", Offset = "0x8DB500", VA = "0x1808DCF00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000033C0 File Offset: 0x000015C0
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C7")]
		public int ServerFrame
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x8DCFC0", Offset = "0x8DB5C0", VA = "0x1808DCFC0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x8DCFD0", Offset = "0x8DB5D0", VA = "0x1808DCFD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x170000C8")]
		public bool IsFirstExecution
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x8DCFE0", Offset = "0x8DB5E0", VA = "0x1808DCFE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C9")]
		public object UserToken
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CA")]
		private object prev
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x8DD040", Offset = "0x8DB640", VA = "0x1808DD040", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CB")]
		private object next
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CC")]
		private object list
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x8DD110", Offset = "0x8DB710", VA = "0x1808DD110", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x8DD170", Offset = "0x8DB770", VA = "0x1808DD170")]
		internal Command(Command_Meta meta)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x8DD250", Offset = "0x8DB850", VA = "0x1808DD250")]
		internal void VerifyCanSetInput()
		{
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x8DD300", Offset = "0x8DB900", VA = "0x1808DD300")]
		internal void VerifyCanSetResult()
		{
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x8DD3B0", Offset = "0x8DB9B0", VA = "0x1808DD3B0")]
		internal void PackInput(BoltConnection connection, UdpPacket packet)
		{
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x8DD4F0", Offset = "0x8DBAF0", VA = "0x1808DD4F0")]
		internal void ReadInput(BoltConnection connection, UdpPacket packet)
		{
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x8DD630", Offset = "0x8DBC30", VA = "0x1808DD630")]
		internal void PackResult(BoltConnection connection, UdpPacket packet)
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x8DD770", Offset = "0x8DBD70", VA = "0x1808DD770")]
		internal void ReadResult(BoltConnection connection, UdpPacket packet)
		{
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x8DD8A0", Offset = "0x8DBEA0", VA = "0x1808DD8A0")]
		internal void BeginSmoothing()
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x8DDA40", Offset = "0x8DC040", VA = "0x1808DDA40")]
		internal void SmoothCorrection()
		{
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x8DDC40", Offset = "0x8DC240", VA = "0x1808DDC40")]
		internal void Free()
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x786DC0", Offset = "0x7853C0", VA = "0x180786DC0")]
		public static implicit operator bool(Command cmd)
		{
			return default(bool);
		}

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		internal const int SEQ_BITS = 8;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		internal const int SEQ_SHIFT = 8;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		internal const int SEQ_MASK = 255;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x40")]
		private NetworkStorage storage;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x48")]
		internal new Command_Meta Meta;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x50")]
		internal int SmoothFrameFrom;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x54")]
		internal int SmoothFrameTo;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x58")]
		internal NetworkStorage SmoothStorageFrom;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x60")]
		internal NetworkStorage SmoothStorageTo;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x68")]
		internal ushort Sequence;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x6C")]
		internal CommandFlags Flags;
	}
}
