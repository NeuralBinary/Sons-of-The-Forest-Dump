using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FluidSimulation
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[Serializable]
	public struct BoundingBox
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0xAFE110", Offset = "0xAFC710", VA = "0x180AFE110")]
		public BoundingBox(Bounds b)
		{
		}

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x0")]
		public Vector4 min;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x10")]
		public Vector4 size;
	}
}
