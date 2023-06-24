using System;
using Il2CppDummyDll;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	public struct BurstCellSpan : IEquatable<BurstCellSpan>
	{
		// Token: 0x060003AE RID: 942 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2799EE0", Offset = "0x27984E0", VA = "0x182799EE0")]
		public BurstCellSpan(CellSpan span)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x15C8940", Offset = "0x15C6F40", VA = "0x1815C8940")]
		public BurstCellSpan(int4 min, int4 max)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000368C File Offset: 0x0000188C
		[Token(Token = "0x17000075")]
		public int level
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xD96410", Offset = "0xD94A10", VA = "0x180D96410")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000036A4 File Offset: 0x000018A4
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x2799F30", Offset = "0x2798530", VA = "0x182799F30", Slot = "4")]
		public bool Equals(BurstCellSpan other)
		{
			return default(bool);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000036BC File Offset: 0x000018BC
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2799FB0", Offset = "0x27985B0", VA = "0x182799FB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000036D4 File Offset: 0x000018D4
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000036EC File Offset: 0x000018EC
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x279A090", Offset = "0x2798690", VA = "0x18279A090")]
		public static bool operator ==(BurstCellSpan a, BurstCellSpan b)
		{
			return default(bool);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00003704 File Offset: 0x00001904
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x279A110", Offset = "0x2798710", VA = "0x18279A110")]
		public static bool operator !=(BurstCellSpan a, BurstCellSpan b)
		{
			return default(bool);
		}

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x0")]
		public int4 min;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x10")]
		public int4 max;
	}
}
