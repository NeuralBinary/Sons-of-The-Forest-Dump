using System;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[Serializable]
	public struct IntRect
	{
		// Token: 0x060001EF RID: 495 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x634340", Offset = "0x632940", VA = "0x180634340")]
		public IntRect(int xmin, int ymin, int xmax, int ymax)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x634360", Offset = "0x632960", VA = "0x180634360")]
		public bool Contains(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x17000089")]
		public Int2 Min
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x634380", Offset = "0x632980", VA = "0x180634380")]
			get
			{
				return default(Int2);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x1700008A")]
		public Int2 Max
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x6343A0", Offset = "0x6329A0", VA = "0x1806343A0")]
			get
			{
				return default(Int2);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x1700008B")]
		public int Width
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x6343C0", Offset = "0x6329C0", VA = "0x1806343C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x1700008C")]
		public int Height
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x6343D0", Offset = "0x6329D0", VA = "0x1806343D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x1700008D")]
		public int Area
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x6343E0", Offset = "0x6329E0", VA = "0x1806343E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x634400", Offset = "0x632A00", VA = "0x180634400")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x634420", Offset = "0x632A20", VA = "0x180634420")]
		public static bool operator ==(IntRect a, IntRect b)
		{
			return default(bool);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x634450", Offset = "0x632A50", VA = "0x180634450")]
		public static bool operator !=(IntRect a, IntRect b)
		{
			return default(bool);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x634480", Offset = "0x632A80", VA = "0x180634480", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x634520", Offset = "0x632B20", VA = "0x180634520", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x634540", Offset = "0x632B40", VA = "0x180634540")]
		public static IntRect Intersection(IntRect a, IntRect b)
		{
			return default(IntRect);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x6345E0", Offset = "0x632BE0", VA = "0x1806345E0")]
		public static bool Intersects(IntRect a, IntRect b)
		{
			return default(bool);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x634610", Offset = "0x632C10", VA = "0x180634610")]
		public static IntRect Union(IntRect a, IntRect b)
		{
			return default(IntRect);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x6346B0", Offset = "0x632CB0", VA = "0x1806346B0")]
		public IntRect ExpandToContain(int x, int y)
		{
			return default(IntRect);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x634760", Offset = "0x632D60", VA = "0x180634760")]
		public IntRect Expand(int range)
		{
			return default(IntRect);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x634790", Offset = "0x632D90", VA = "0x180634790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x6348F0", Offset = "0x632EF0", VA = "0x1806348F0")]
		public void DebugDraw(GraphTransform transform, Color color)
		{
		}

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x0")]
		public int xmin;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x4")]
		public int ymin;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x8")]
		public int xmax;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0xC")]
		public int ymax;
	}
}
