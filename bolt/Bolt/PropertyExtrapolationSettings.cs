using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	internal struct PropertyExtrapolationSettings
	{
		// Token: 0x0600066A RID: 1642 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x8FE3F0", Offset = "0x8FC9F0", VA = "0x1808FE3F0")]
		public static PropertyExtrapolationSettings Create(int maxFrames, float errorTolerance, float snapMagnitude, ExtrapolationVelocityModes velocityMode)
		{
			return default(PropertyExtrapolationSettings);
		}

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x0")]
		public bool Enabled;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x4")]
		public int MaxFrames;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x8")]
		public float ErrorTolerance;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0xC")]
		public float SnapMagnitude;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x10")]
		public ExtrapolationVelocityModes VelocityMode;
	}
}
