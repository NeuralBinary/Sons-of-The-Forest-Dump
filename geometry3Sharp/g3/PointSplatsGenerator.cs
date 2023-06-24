using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002C0 RID: 704
	[Token(Token = "0x20002C0")]
	public class PointSplatsGenerator : MeshGenerator
	{
		// Token: 0x060018D5 RID: 6357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x1EE6B60", Offset = "0x1EE5160", VA = "0x181EE6B60")]
		public PointSplatsGenerator()
		{
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x1EE6B80", Offset = "0x1EE5180", VA = "0x181EE6B80", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x1EE7770", Offset = "0x1EE5D70", VA = "0x181EE7770")]
		public static DMesh3 Generate(IList<int> indices, Func<int, Vector3d> PointF, Func<int, Vector3d> NormalF, double radius)
		{
			return null;
		}

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0x40")]
		public IEnumerable<int> PointIndices;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0x48")]
		public int PointIndicesCount;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0x50")]
		public Func<int, Vector3d> PointF;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0x58")]
		public Func<int, Vector3d> NormalF;

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		[FieldOffset(Offset = "0x60")]
		public double Radius;
	}
}
