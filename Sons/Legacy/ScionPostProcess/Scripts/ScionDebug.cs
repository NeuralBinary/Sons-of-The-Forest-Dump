using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200059F RID: 1439
	[Token(Token = "0x200059F")]
	public class ScionDebug
	{
		// Token: 0x060025FA RID: 9722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FA")]
		[Address(RVA = "0x33A3F00", Offset = "0x33A2500", VA = "0x1833A3F00")]
		public void RegisterTextureForVisualization(RenderTexture texture, bool shouldRelease, bool forceBilinear = false, bool forcePoint = false)
		{
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FB")]
		[Address(RVA = "0x33A40E0", Offset = "0x33A26E0", VA = "0x1833A40E0")]
		public void VisualizeDebug(RenderTexture dest)
		{
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FC")]
		[Address(RVA = "0x33A43C0", Offset = "0x33A29C0", VA = "0x1833A43C0")]
		public ScionDebug()
		{
		}

		// Token: 0x04002225 RID: 8741
		[Token(Token = "0x4002225")]
		[FieldOffset(Offset = "0x10")]
		private List<RenderTexture> registeredTextures;

		// Token: 0x04002226 RID: 8742
		[Token(Token = "0x4002226")]
		[FieldOffset(Offset = "0x18")]
		private List<bool> forceBilinear;

		// Token: 0x04002227 RID: 8743
		[Token(Token = "0x4002227")]
		[FieldOffset(Offset = "0x20")]
		private List<bool> forcePoint;

		// Token: 0x04002228 RID: 8744
		[Token(Token = "0x4002228")]
		[FieldOffset(Offset = "0x28")]
		private List<bool> shouldRelease;
	}
}
