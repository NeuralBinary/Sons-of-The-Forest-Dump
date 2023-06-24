using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem.MeshSimplifier
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[Serializable]
	[StructLayout(3)]
	public struct BlendShapeFrame
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x5F8570", Offset = "0x5F6B70", VA = "0x1805F8570")]
		public BlendShapeFrame(float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents)
		{
		}

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float FrameWeight;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3[] DeltaVertices;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] DeltaNormals;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] DeltaTangents;
	}
}
