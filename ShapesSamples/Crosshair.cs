using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class Crosshair : MonoBehaviour
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2A59BB0", Offset = "0x2A581B0", VA = "0x182A59BB0")]
		public void Fire()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2A59BD0", Offset = "0x2A581D0", VA = "0x182A59BD0")]
		public void FireHit()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2A59BF0", Offset = "0x2A581F0", VA = "0x182A59BF0")]
		public void UpdateCrosshairDecay()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2A59C30", Offset = "0x2A58230", VA = "0x182A59C30")]
		public void DrawCrosshair()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A5A1A0", Offset = "0x2A587A0", VA = "0x182A5A1A0")]
		public Crosshair()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2A5A300", Offset = "0x2A58900", VA = "0x182A5A300")]
		[CompilerGenerated]
		internal static void <DrawCrosshair>g__DrawCross|12_0(Vector2[] dirs, float radInner, float radOuter, float thickness, float radialOffset, Color color)
		{
		}

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 0.05f)]
		[Header("Style")]
		public float crosshairCrossInnerRad;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 0.05f)]
		public float crosshairCrossOuterRad;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 0.05f)]
		public float crosshairCrossThickness;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 0.05f)]
		public float crosshairHitCrossInnerRad;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 0.05f)]
		public float crosshairHitCrossOuterRad;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 0.05f)]
		public float crosshairHitCrossThickness;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x38")]
		[Header("Animation")]
		[Range(0f, 1f)]
		public float scaleFire;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x40")]
		public Decayer fireDecayer;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x48")]
		public Decayer hitDecayer;
	}
}
