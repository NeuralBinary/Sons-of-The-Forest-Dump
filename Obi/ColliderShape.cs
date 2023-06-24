using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	public struct ColliderShape
	{
		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0x0")]
		public Vector4 center;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x10")]
		public Vector4 size;

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x20")]
		public ColliderShape.ShapeType type;

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0x24")]
		public float contactOffset;

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x28")]
		public int dataIndex;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[FieldOffset(Offset = "0x2C")]
		public int rigidbodyIndex;

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		[FieldOffset(Offset = "0x30")]
		public int materialIndex;

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		[FieldOffset(Offset = "0x34")]
		public int phase;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0x38")]
		public int flags;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x3C")]
		public int is2D;

		// Token: 0x0200017B RID: 379
		[Token(Token = "0x200017B")]
		public enum ShapeType
		{
			// Token: 0x0400064A RID: 1610
			[Token(Token = "0x400064A")]
			Sphere,
			// Token: 0x0400064B RID: 1611
			[Token(Token = "0x400064B")]
			Box,
			// Token: 0x0400064C RID: 1612
			[Token(Token = "0x400064C")]
			Capsule,
			// Token: 0x0400064D RID: 1613
			[Token(Token = "0x400064D")]
			Heightmap,
			// Token: 0x0400064E RID: 1614
			[Token(Token = "0x400064E")]
			TriangleMesh,
			// Token: 0x0400064F RID: 1615
			[Token(Token = "0x400064F")]
			EdgeMesh,
			// Token: 0x04000650 RID: 1616
			[Token(Token = "0x4000650")]
			SignedDistanceField
		}
	}
}
