using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	public class CachingDenseGridTrilinearImplicit : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x06000978 RID: 2424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x1FEB550", Offset = "0x1FE9B50", VA = "0x181FEB550")]
		public CachingDenseGridTrilinearImplicit(Vector3d gridOrigin, double cellSize, Vector3i gridDimensions)
		{
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0000716C File Offset: 0x0000536C
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x1FEB700", Offset = "0x1FE9D00", VA = "0x181FEB700", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00007184 File Offset: 0x00005384
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1FEB780", Offset = "0x1FE9D80", VA = "0x181FEB780", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x1FEBAC0", Offset = "0x1FEA0C0", VA = "0x181FEBAC0")]
		private void get_value_pair(int i, int j, int k, out double a, out double b)
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0000719C File Offset: 0x0000539C
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1FEBE20", Offset = "0x1FEA420", VA = "0x181FEBE20")]
		private Vector3d grid_position(int i, int j, int k)
		{
			return default(Vector3d);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000071B4 File Offset: 0x000053B4
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x1FEBE70", Offset = "0x1FEA470", VA = "0x181FEBE70")]
		public Vector3d Gradient(ref Vector3d pt)
		{
			return default(Vector3d);
		}

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x10")]
		public DenseGrid3f Grid;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x18")]
		public double CellSize;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x20")]
		public Vector3d GridOrigin;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x38")]
		public ImplicitFunction3d AnalyticF;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x40")]
		public double Outside;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x48")]
		public float Invalid;
	}
}
