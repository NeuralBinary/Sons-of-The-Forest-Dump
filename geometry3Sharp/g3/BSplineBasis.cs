using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	public class BSplineBasis
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected BSplineBasis()
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1F96780", Offset = "0x1F94D80", VA = "0x181F96780")]
		public BSplineBasis(int numCtrlPoints, int degree, bool open)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1F968D0", Offset = "0x1F94ED0", VA = "0x181F968D0")]
		public BSplineBasis(int numCtrlPoints, int degree, double[] knots, bool bIsInteriorKnots)
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1F96B20", Offset = "0x1F95120", VA = "0x181F96B20")]
		public BSplineBasis Clone()
		{
			return null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000048EC File Offset: 0x00002AEC
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
		public int GetNumCtrlPoints()
		{
			return 0;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00004904 File Offset: 0x00002B04
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
		public int GetDegree()
		{
			return 0;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0000491C File Offset: 0x00002B1C
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
		public bool IsOpen()
		{
			return default(bool);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00004934 File Offset: 0x00002B34
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0")]
		public bool IsUniform()
		{
			return default(bool);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0000494C File Offset: 0x00002B4C
		[Token(Token = "0x170000C8")]
		public int KnotCount
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x1F96C70", Offset = "0x1F95270", VA = "0x181F96C70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00004964 File Offset: 0x00002B64
		[Token(Token = "0x170000C9")]
		public int InteriorKnotCount
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x1F96C80", Offset = "0x1F95280", VA = "0x181F96C80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1F96C90", Offset = "0x1F95290", VA = "0x181F96C90")]
		public void SetInteriorKnot(int j, double value)
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000497C File Offset: 0x00002B7C
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1F96DB0", Offset = "0x1F953B0", VA = "0x181F96DB0")]
		public double GetInteriorKnot(int j)
		{
			return 0.0;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1F96E80", Offset = "0x1F95480", VA = "0x181F96E80")]
		public void SetKnot(int j, double value)
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00004994 File Offset: 0x00002B94
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1F96EB0", Offset = "0x1F954B0", VA = "0x181F96EB0")]
		public double GetKnot(int j)
		{
			return 0.0;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000049AC File Offset: 0x00002BAC
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1F96EE0", Offset = "0x1F954E0", VA = "0x181F96EE0")]
		public double GetD0(int i)
		{
			return 0.0;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000049C4 File Offset: 0x00002BC4
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1F96F30", Offset = "0x1F95530", VA = "0x181F96F30")]
		public double GetD1(int i)
		{
			return 0.0;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1F96F80", Offset = "0x1F95580", VA = "0x181F96F80")]
		public double GetD2(int i)
		{
			return 0.0;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000049F4 File Offset: 0x00002BF4
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1F96FD0", Offset = "0x1F955D0", VA = "0x181F96FD0")]
		public double GetD3(int i)
		{
			return 0.0;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1F97020", Offset = "0x1F95620", VA = "0x181F97020")]
		public void Compute(double t, int order, ref int minIndex, ref int maxIndex)
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1F97DC0", Offset = "0x1F963C0", VA = "0x181F97DC0")]
		protected int Initialize(int numCtrlPoints, int degree, bool open)
		{
			return 0;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1F97F80", Offset = "0x1F96580", VA = "0x181F97F80")]
		protected double[,] Allocate()
		{
			return null;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00004A24 File Offset: 0x00002C24
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1F98040", Offset = "0x1F96640", VA = "0x181F98040")]
		protected int GetKey(ref double t)
		{
			return 0;
		}

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x10")]
		protected int mNumCtrlPoints;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x14")]
		protected int mDegree;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x18")]
		protected double[] mKnot;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x20")]
		protected bool mOpen;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x21")]
		protected bool mUniform;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x28")]
		protected double[,] mBD0;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x30")]
		protected double[,] mBD1;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x38")]
		protected double[,] mBD2;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x40")]
		protected double[,] mBD3;
	}
}
