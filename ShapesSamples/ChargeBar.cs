using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class ChargeBar : MonoBehaviour
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2A57E40", Offset = "0x2A56440", VA = "0x182A57E40")]
		public void UpdateCharge()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2A57F40", Offset = "0x2A56540", VA = "0x182A57F40")]
		public void DrawBar(FpsController fpsController, float barRadius)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2A58B20", Offset = "0x2A57120", VA = "0x182A58B20")]
		public ChargeBar()
		{
		}

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Gameplay")]
		private float chargeSpeed;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float chargeDecaySpeed;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public bool isCharging;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x2C")]
		private float charge;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x30")]
		[Header("Style")]
		public Color tickColor;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x40")]
		public Gradient chargeFillGradient;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 0.1f)]
		public float tickSizeSmol;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 0.1f)]
		public float tickSizeLorge;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 0.05f)]
		public float tickTickness;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x54")]
		[Range(0f, 0.5f)]
		public float fontSize;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 0.5f)]
		public float fontSizeLorge;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x5C")]
		[Range(0f, 0.1f)]
		public float percentLabelOffset;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 0.4f)]
		public float fontGrowRangePrev;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x64")]
		[Range(0f, 0.4f)]
		public float fontGrowRangeNext;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x68")]
		[Header("Animation")]
		public AnimationCurve chargeFillCurve;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x70")]
		public AnimationCurve animChargeShakeMagnitude;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x78")]
		[Range(0f, 0.05f)]
		public float chargeShakeMagnitude;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x7C")]
		public float chargeShakeSpeed;
	}
}
