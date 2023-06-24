using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Shapes
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	internal struct ShapeDrawCall
	{
		// Token: 0x06000B76 RID: 2934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x2A44C70", Offset = "0x2A43270", VA = "0x182A44C70")]
		public ShapeDrawCall(ShapeDrawState drawState, Matrix4x4 matrix)
		{
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x2A44E40", Offset = "0x2A43440", VA = "0x182A44E40")]
		public ShapeDrawCall(ShapeDrawState drawState, int count, Matrix4x4[] matrices)
		{
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x2A44FE0", Offset = "0x2A435E0", VA = "0x182A44FE0")]
		public void AddToCommandBuffer(CommandBuffer cmd)
		{
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x2A450A0", Offset = "0x2A436A0", VA = "0x182A450A0")]
		public void Cleanup()
		{
		}

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x0")]
		public ShapeDrawState drawState;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x18")]
		public MaterialPropertyBlock mpb;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x24")]
		public Matrix4x4 matrix;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x68")]
		public Matrix4x4[] matrices;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x70")]
		private bool instanced;
	}
}
