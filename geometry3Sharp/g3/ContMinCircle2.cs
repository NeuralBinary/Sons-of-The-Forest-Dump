using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	public class ContMinCircle2
	{
		// Token: 0x0600019F RID: 415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1F34D80", Offset = "0x1F33380", VA = "0x181F34D80")]
		public ContMinCircle2(IList<Vector2d> pointsIn, double epsilon = 1E-05)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1F355B0", Offset = "0x1F33BB0", VA = "0x181F355B0")]
		private bool Contains(Vector2d point, ref ContMinCircle2.Circle circle, ref double distDiff)
		{
			return default(bool);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1F35650", Offset = "0x1F33C50", VA = "0x181F35650")]
		private ContMinCircle2.Circle ExactCircle2(ref Vector2d P0, ref Vector2d P1)
		{
			return default(ContMinCircle2.Circle);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1F35720", Offset = "0x1F33D20", VA = "0x181F35720")]
		private ContMinCircle2.Circle ExactCircle2(Vector2d P0, ref Vector2d P1)
		{
			return default(ContMinCircle2.Circle);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1F357F0", Offset = "0x1F33DF0", VA = "0x181F357F0")]
		private ContMinCircle2.Circle ExactCircle3(ref Vector2d P0, ref Vector2d P1, ref Vector2d P2)
		{
			return default(ContMinCircle2.Circle);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1F35A70", Offset = "0x1F34070", VA = "0x181F35A70")]
		private ContMinCircle2.Circle ExactCircle3(Vector2d P0, Vector2d P1, ref Vector2d P2)
		{
			return default(ContMinCircle2.Circle);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002FE4 File Offset: 0x000011E4
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1F35A70", Offset = "0x1F34070", VA = "0x181F35A70")]
		private ContMinCircle2.Circle ExactCircle3(Vector2d P0, ref Vector2d P1, ref Vector2d P2)
		{
			return default(ContMinCircle2.Circle);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1F35AC0", Offset = "0x1F340C0", VA = "0x181F35AC0")]
		private ContMinCircle2.Circle UpdateSupport1(int i, int[] permutation, ContMinCircle2.Support support)
		{
			return default(ContMinCircle2.Circle);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00003014 File Offset: 0x00001214
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1F35D60", Offset = "0x1F34360", VA = "0x181F35D60")]
		private ContMinCircle2.Circle UpdateSupport2(int i, int[] permutation, ContMinCircle2.Support support)
		{
			return default(ContMinCircle2.Circle);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000302C File Offset: 0x0000122C
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1F36460", Offset = "0x1F34A60", VA = "0x181F36460")]
		private ContMinCircle2.Circle UpdateSupport3(int i, int[] permutation, ContMinCircle2.Support support)
		{
			return default(ContMinCircle2.Circle);
		}

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x10")]
		private double mEpsilon;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x18")]
		private Func<int, int[], ContMinCircle2.Support, ContMinCircle2.Circle>[] mUpdate;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x20")]
		private IList<Vector2d> Points;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x28")]
		private ContMinCircle2.Circle[] circle_buf;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x30")]
		public Circle2d Result;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[,] type2_2;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[,] type2_3;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[,] type3_3;

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		private struct Circle
		{
			// Token: 0x060001AA RID: 426 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x1F37280", Offset = "0x1F35880", VA = "0x181F37280")]
			public Circle(Vector2d c, double radius)
			{
			}

			// Token: 0x040001DE RID: 478
			[Token(Token = "0x40001DE")]
			[FieldOffset(Offset = "0x0")]
			public Vector2d Center;

			// Token: 0x040001DF RID: 479
			[Token(Token = "0x40001DF")]
			[FieldOffset(Offset = "0x10")]
			public double Radius;
		}

		// Token: 0x0200005F RID: 95
		[Token(Token = "0x200005F")]
		protected class Support
		{
			// Token: 0x060001AB RID: 427 RVA: 0x00003044 File Offset: 0x00001244
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x1F37290", Offset = "0x1F35890", VA = "0x181F37290")]
			public bool Contains(int index, IList<Vector2d> Points, int[] permutation, double epsilon)
			{
				return default(bool);
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Support()
			{
			}

			// Token: 0x040001E0 RID: 480
			[Token(Token = "0x40001E0")]
			[FieldOffset(Offset = "0x10")]
			public int Quantity;

			// Token: 0x040001E1 RID: 481
			[Token(Token = "0x40001E1")]
			[FieldOffset(Offset = "0x14")]
			public Index3i Index;
		}
	}
}
