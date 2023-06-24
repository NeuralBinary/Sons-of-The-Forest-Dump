using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	internal abstract class BoltChannel
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000132")]
		public BoltConnection connection
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x901390", Offset = "0x8FF990", VA = "0x180901390")]
			internal set
			{
			}
		}

		// Token: 0x060006F9 RID: 1785
		[Token(Token = "0x60006F9")]
		public abstract void Pack(Packet packet);

		// Token: 0x060006FA RID: 1786
		[Token(Token = "0x60006FA")]
		public abstract void Read(Packet packet);

		// Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public virtual void Lost(Packet packet)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public virtual void Delivered(Packet packet)
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public virtual void Disconnected()
		{
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected BoltChannel()
		{
		}

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x10")]
		private BoltConnection _cn;
	}
}
