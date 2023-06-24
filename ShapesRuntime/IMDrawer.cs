using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	internal struct IMDrawer : IDisposable
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x2A37AA0", Offset = "0x2A360A0", VA = "0x182A37AA0")]
		private static string[] GetMaterialKeywords(Material m)
		{
			return null;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x2A37C00", Offset = "0x2A36200", VA = "0x182A37C00")]
		public IMDrawer(MetaMpb metaMpb, Material sourceMat, Mesh sourceMesh, int submesh = 0, IMDrawer.DrawType drawType = IMDrawer.DrawType.Shape, bool allowInstancing = true)
		{
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x2A38A80", Offset = "0x2A37080", VA = "0x182A38A80")]
		private static void ApplyGlobalProperties(Material m)
		{
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x2A38E90", Offset = "0x2A37490", VA = "0x182A38E90")]
		private static void ApplyGlobalPropertiesTMP(Material m)
		{
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x2A39180", Offset = "0x2A37780", VA = "0x182A39180", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x0")]
		internal static MetaMpb metaMpbPrevious;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<Material, string[]> matKeywords;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x0")]
		private MetaMpb metaMpb;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x8")]
		private ShapeDrawState drawState;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x20")]
		private Matrix4x4 mtx;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x60")]
		private bool allowInstancing;

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		public enum DrawType
		{
			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			Shape,
			// Token: 0x04000120 RID: 288
			[Token(Token = "0x4000120")]
			Text
		}
	}
}
