using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000316 RID: 790
	[Token(Token = "0x2000316")]
	internal class Quads
	{
		// Token: 0x06001454 RID: 5204 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x6001454")]
		[Address(RVA = "0x2C6A080", Offset = "0x2C69080", VA = "0x182C6A080")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x2C697F0", Offset = "0x2C687F0", VA = "0x182C697F0")]
		public static void Cleanup()
		{
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x2C69DD0", Offset = "0x2C68DD0", VA = "0x182C69DD0")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x2C69980", Offset = "0x2C68980", VA = "0x182C69980")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public Quads()
		{
		}

		// Token: 0x04001415 RID: 5141
		[Token(Token = "0x4001415")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		// Token: 0x04001416 RID: 5142
		[Token(Token = "0x4001416")]
		[FieldOffset(Offset = "0x8")]
		private static int currentQuads;
	}
}
