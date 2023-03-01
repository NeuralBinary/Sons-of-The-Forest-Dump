using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200058F RID: 1423
	[Token(Token = "0x200058F")]
	public class ScionDebug
	{
		// Token: 0x060024FB RID: 9467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FB")]
		[Address(RVA = "0x2D8BEC0", Offset = "0x2D8AEC0", VA = "0x182D8BEC0")]
		public void RegisterTextureForVisualization(RenderTexture texture, bool shouldRelease, bool forceBilinear = false, bool forcePoint = false)
		{
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FC")]
		[Address(RVA = "0x2D8C0B0", Offset = "0x2D8B0B0", VA = "0x182D8C0B0")]
		public void VisualizeDebug(RenderTexture dest)
		{
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FD")]
		[Address(RVA = "0x2D8C310", Offset = "0x2D8B310", VA = "0x182D8C310")]
		public ScionDebug()
		{
		}

		// Token: 0x04002151 RID: 8529
		[Token(Token = "0x4002151")]
		[FieldOffset(Offset = "0x10")]
		private List<RenderTexture> registeredTextures;

		// Token: 0x04002152 RID: 8530
		[Token(Token = "0x4002152")]
		[FieldOffset(Offset = "0x18")]
		private List<bool> forceBilinear;

		// Token: 0x04002153 RID: 8531
		[Token(Token = "0x4002153")]
		[FieldOffset(Offset = "0x20")]
		private List<bool> forcePoint;

		// Token: 0x04002154 RID: 8532
		[Token(Token = "0x4002154")]
		[FieldOffset(Offset = "0x28")]
		private List<bool> shouldRelease;
	}
}
