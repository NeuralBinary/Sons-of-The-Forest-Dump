using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	public class IntrLine2Triangle2
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00007BD4 File Offset: 0x00005DD4
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D2")]
		public Line2d Line
		{
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0xEEB890", Offset = "0xEE9E90", VA = "0x180EEB890")]
			get
			{
				return default(Line2d);
			}
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x1FF9130", Offset = "0x1FF7730", VA = "0x181FF9130")]
			set
			{
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x00007BEC File Offset: 0x00005DEC
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D3")]
		public Triangle2d Triangle
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x1FF9150", Offset = "0x1FF7750", VA = "0x181FF9150")]
			get
			{
				return default(Triangle2d);
			}
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x1FF9170", Offset = "0x1FF7770", VA = "0x181FF9170")]
			set
			{
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00007C04 File Offset: 0x00005E04
		[Token(Token = "0x170001D4")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x1FF9190", Offset = "0x1FF7790", VA = "0x181FF9190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x1FF91B0", Offset = "0x1FF77B0", VA = "0x181FF91B0")]
		public IntrLine2Triangle2(Line2d l, Triangle2d t)
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x1FF91E0", Offset = "0x1FF77E0", VA = "0x181FF91E0")]
		public IntrLine2Triangle2 Compute()
		{
			return null;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00007C1C File Offset: 0x00005E1C
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x1FF9200", Offset = "0x1FF7800", VA = "0x181FF9200")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x1FF98B0", Offset = "0x1FF7EB0", VA = "0x181FF98B0")]
		public static void TriangleLineRelations(Vector2d origin, Vector2d direction, Triangle2d tri, ref Vector3d dist, ref Vector3i sign, ref int positive, ref int negative, ref int zero)
		{
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x1FF9B20", Offset = "0x1FF8120", VA = "0x181FF9B20")]
		public static void GetInterval(Vector2d origin, Vector2d direction, Triangle2d tri, Vector3d dist, Vector3i sign, ref Vector2d param)
		{
		}

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x10")]
		private Line2d line;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x30")]
		private Triangle2d triangle;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x60")]
		public int Quantity;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x64")]
		public IntersectionResult Result;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x68")]
		public IntersectionType Type;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x70")]
		public Vector2d Point0;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x80")]
		public Vector2d Point1;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x90")]
		public double Param0;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x98")]
		public double Param1;
	}
}
