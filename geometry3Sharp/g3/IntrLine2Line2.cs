using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	public class IntrLine2Line2
	{
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00007AB4 File Offset: 0x00005CB4
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C9")]
		public Line2d Line1
		{
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0xEEB890", Offset = "0xEE9E90", VA = "0x180EEB890")]
			get
			{
				return default(Line2d);
			}
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x1FF84C0", Offset = "0x1FF6AC0", VA = "0x181FF84C0")]
			set
			{
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00007ACC File Offset: 0x00005CCC
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001CA")]
		public Line2d Line2
		{
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x1FE4350", Offset = "0x1FE2950", VA = "0x181FE4350")]
			get
			{
				return default(Line2d);
			}
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x1FF84E0", Offset = "0x1FF6AE0", VA = "0x181FF84E0")]
			set
			{
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00007AE4 File Offset: 0x00005CE4
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001CB")]
		public double DotThreshold
		{
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x1FF8500", Offset = "0x1FF6B00", VA = "0x181FF8500")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x1FF8510", Offset = "0x1FF6B10", VA = "0x181FF8510")]
			set
			{
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00007AFC File Offset: 0x00005CFC
		[Token(Token = "0x170001CC")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x1FF85B0", Offset = "0x1FF6BB0", VA = "0x181FF85B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1FF85D0", Offset = "0x1FF6BD0", VA = "0x181FF85D0")]
		public IntrLine2Line2(Line2d l1, Line2d l2)
		{
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1FF8600", Offset = "0x1FF6C00", VA = "0x181FF8600")]
		public IntrLine2Line2 Compute()
		{
			return null;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00007B14 File Offset: 0x00005D14
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x1FF8800", Offset = "0x1FF6E00", VA = "0x181FF8800")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00007B2C File Offset: 0x00005D2C
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x1FF8A10", Offset = "0x1FF7010", VA = "0x181FF8A10")]
		public static IntersectionType Classify(Vector2d P0, Vector2d D0, Vector2d P1, Vector2d D1, double dotThreshold, ref Vector2d s)
		{
			return IntersectionType.Empty;
		}

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x10")]
		private Line2d line1;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x30")]
		private Line2d line2;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x50")]
		private double dotThresh;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x58")]
		public int Quantity;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x5C")]
		public IntersectionResult Result;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x60")]
		public IntersectionType Type;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x68")]
		public Vector2d Point;

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x78")]
		public double Segment1Parameter;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x80")]
		public double Segment2Parameter;
	}
}
