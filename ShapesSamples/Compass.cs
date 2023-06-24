using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class Compass : MonoBehaviour
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2A58C30", Offset = "0x2A57230", VA = "0x182A58C30")]
		public void DrawCompass(Vector3 worldDir)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2A594E0", Offset = "0x2A57AE0", VA = "0x182A594E0")]
		public Compass()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2A59680", Offset = "0x2A57C80", VA = "0x182A59680")]
		[CompilerGenerated]
		private void <DrawCompass>g__DrawTick|14_0(float worldAng, float size, [Optional] string label, ref Compass.<>c__DisplayClass14_0 A_4)
		{
		}

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 position;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float width;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 0.01f)]
		public float lineThickness;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0.1f, 2f)]
		public float bendRadius;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0.05f, 3.0787609f)]
		public float fieldOfView;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Ticks")]
		public int ticksPerQuarterTurn;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 0.2f)]
		public float tickSize;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float tickEdgeFadeFraction;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0.01f, 0.26f)]
		public float fontSizeTickLabel;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 0.1f)]
		public float tickLabelOffset;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0.01f, 0.26f)]
		[Header("Degree Marker")]
		public float fontSizeLookLabel;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector2 lookAngLabelOffset;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 0.05f)]
		public float triangleNootSize;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string[] directionLabels;
	}
}
