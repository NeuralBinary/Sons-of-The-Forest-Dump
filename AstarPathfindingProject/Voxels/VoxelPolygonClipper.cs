using System;
using Il2CppDummyDll;

namespace Pathfinding.Voxels
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	internal struct VoxelPolygonClipper
	{
		// Token: 0x0600091A RID: 2330 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x6F8730", Offset = "0x6F6D30", VA = "0x1806F8730")]
		public VoxelPolygonClipper(int capacity)
		{
		}

		// Token: 0x17000146 RID: 326
		[Token(Token = "0x17000146")]
		public int this[int i]
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x6F88C0", Offset = "0x6F6EC0", VA = "0x1806F88C0")]
			set
			{
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x6F8920", Offset = "0x6F6F20", VA = "0x1806F8920")]
		public void ClipPolygonAlongX(ref VoxelPolygonClipper result, float multi, float offset)
		{
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x6F8BA0", Offset = "0x6F71A0", VA = "0x1806F8BA0")]
		public void ClipPolygonAlongZWithYZ(ref VoxelPolygonClipper result, float multi, float offset)
		{
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600091E")]
		[Address(RVA = "0x6F8D90", Offset = "0x6F7390", VA = "0x1806F8D90")]
		public void ClipPolygonAlongZWithY(ref VoxelPolygonClipper result, float multi, float offset)
		{
		}

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x0")]
		public float[] x;

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0x8")]
		public float[] y;

		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0x10")]
		public float[] z;

		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0x18")]
		public int n;
	}
}
