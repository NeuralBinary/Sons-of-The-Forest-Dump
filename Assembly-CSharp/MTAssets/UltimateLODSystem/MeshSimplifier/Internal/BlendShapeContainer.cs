using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem.MeshSimplifier.Internal
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	internal class BlendShapeContainer
	{
		// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x60CD50", Offset = "0x60B350", VA = "0x18060CD50")]
		public BlendShapeContainer(BlendShape blendShape)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x60A280", Offset = "0x608880", VA = "0x18060A280")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void MoveVertexElement(int dst, int src)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x60D040", Offset = "0x60B640", VA = "0x18060D040")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void InterpolateVertexAttributes(int dst, int i0, int i1, int i2, ref Vector3 barycentricCoord)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x60D110", Offset = "0x60B710", VA = "0x18060D110")]
		public void Resize(int length, bool trimExess = false)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x60D250", Offset = "0x60B850", VA = "0x18060D250")]
		public BlendShape ToBlendShape()
		{
			return default(BlendShape);
		}

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x10")]
		private readonly string shapeName;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x18")]
		private readonly BlendShapeFrameContainer[] frames;
	}
}
