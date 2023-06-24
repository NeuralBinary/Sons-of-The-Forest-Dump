using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Input
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[Serializable]
	public class RumbleProfile
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x307D860", Offset = "0x307BE60", VA = "0x18307D860")]
		public void OnValidate()
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x307D8A0", Offset = "0x307BEA0", VA = "0x18307D8A0")]
		private float GetFrequencyLength(AnimationCurve frequencyCurve)
		{
			return 0f;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x307D9E0", Offset = "0x307BFE0", VA = "0x18307D9E0")]
		public void Sample(float time, out float lowFrequency, out float highFrequency)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x307DA60", Offset = "0x307C060", VA = "0x18307DA60")]
		public bool Matches(string rumbleProfileId)
		{
			return default(bool);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
		public float GetLength()
		{
			return 0f;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public RumbleProfile()
		{
		}

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _name;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationCurve _lowFrequencyCurve;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve _highFrequencyCurve;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _length;
	}
}
