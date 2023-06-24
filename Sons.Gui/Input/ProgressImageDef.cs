using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui.Input
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[Serializable]
	internal class ProgressImageDef
	{
		// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x305B5E0", Offset = "0x3059BE0", VA = "0x18305B5E0")]
		public void UpdateProgress(float progress)
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x305B6B0", Offset = "0x3059CB0", VA = "0x18305B6B0")]
		public ProgressImageDef()
		{
		}

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x10")]
		public Image Image;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x18")]
		public float Start;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x1C")]
		public float End;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve Curve;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x28")]
		public bool InvertCurveResult;
	}
}
