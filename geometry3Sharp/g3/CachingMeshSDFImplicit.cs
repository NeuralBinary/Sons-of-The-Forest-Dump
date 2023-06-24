using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	public class CachingMeshSDFImplicit : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x06000997 RID: 2455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x1FEE670", Offset = "0x1FECC70", VA = "0x181FEE670")]
		public CachingMeshSDFImplicit(CachingMeshSDF sdf)
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000072EC File Offset: 0x000054EC
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x1FEE7C0", Offset = "0x1FECDC0", VA = "0x181FEE7C0", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00007304 File Offset: 0x00005504
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x1FEE860", Offset = "0x1FECE60", VA = "0x181FEE860", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x1FEEC60", Offset = "0x1FED260", VA = "0x181FEEC60")]
		private void get_value_pair(int i, int j, int k, out double a, out double b)
		{
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0000731C File Offset: 0x0000551C
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x1FEED20", Offset = "0x1FED320", VA = "0x181FEED20")]
		public Vector3d Gradient(ref Vector3d pt)
		{
			return default(Vector3d);
		}

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x10")]
		public CachingMeshSDF SDF;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x18")]
		public double CellSize;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x20")]
		public Vector3d GridOrigin;

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x38")]
		public double Outside;
	}
}
