using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public struct REVERB_PROPERTIES
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xB17620", Offset = "0xB15C20", VA = "0x180B17620")]
		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
		}

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x0")]
		public float DecayTime;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x4")]
		public float EarlyDelay;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x8")]
		public float LateDelay;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0xC")]
		public float HFReference;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x10")]
		public float HFDecayRatio;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x14")]
		public float Diffusion;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x18")]
		public float Density;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x1C")]
		public float LowShelfFrequency;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x20")]
		public float LowShelfGain;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x24")]
		public float HighCut;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x28")]
		public float EarlyLateMix;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x2C")]
		public float WetLevel;
	}
}
