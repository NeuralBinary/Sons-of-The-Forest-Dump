using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000308 RID: 776
	[Token(Token = "0x2000308")]
	internal class Quads
	{
		// Token: 0x0600147F RID: 5247 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x320C470", Offset = "0x320AA70", VA = "0x18320C470")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x320C5A0", Offset = "0x320ABA0", VA = "0x18320C5A0")]
		public static void Cleanup()
		{
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x320C7D0", Offset = "0x320ADD0", VA = "0x18320C7D0")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x320CB40", Offset = "0x320B140", VA = "0x18320CB40")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001483")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Quads()
		{
		}

		// Token: 0x04001433 RID: 5171
		[Token(Token = "0x4001433")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		// Token: 0x04001434 RID: 5172
		[Token(Token = "0x4001434")]
		[FieldOffset(Offset = "0x8")]
		private static int currentQuads;
	}
}
