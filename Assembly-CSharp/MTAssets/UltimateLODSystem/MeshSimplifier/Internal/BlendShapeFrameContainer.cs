using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem.MeshSimplifier.Internal
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	internal class BlendShapeFrameContainer
	{
		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x60D460", Offset = "0x60BA60", VA = "0x18060D460")]
		public BlendShapeFrameContainer(BlendShapeFrame frame)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x60D640", Offset = "0x60BC40", VA = "0x18060D640")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void MoveVertexElement(int dst, int src)
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x60D780", Offset = "0x60BD80", VA = "0x18060D780")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void InterpolateVertexAttributes(int dst, int i0, int i1, int i2, ref Vector3 barycentricCoord)
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x60DD10", Offset = "0x60C310", VA = "0x18060DD10")]
		public void Resize(int length, bool trimExess = false)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x60DDD0", Offset = "0x60C3D0", VA = "0x18060DDD0")]
		public BlendShapeFrame ToBlendShapeFrame()
		{
			return default(BlendShapeFrame);
		}

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x10")]
		private readonly float frameWeight;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x18")]
		private readonly ResizableArray<Vector3> deltaVertices;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x20")]
		private readonly ResizableArray<Vector3> deltaNormals;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x28")]
		private readonly ResizableArray<Vector3> deltaTangents;
	}
}
