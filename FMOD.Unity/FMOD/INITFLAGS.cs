using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[Flags]
	public enum INITFLAGS : uint
	{
		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		NORMAL = 0U,
		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		STREAM_FROM_UPDATE = 1U,
		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		MIX_FROM_UPDATE = 2U,
		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		_3D_RIGHTHANDED = 4U,
		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		CHANNEL_LOWPASS = 256U,
		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		CHANNEL_DISTANCEFILTER = 512U,
		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		PROFILE_ENABLE = 65536U,
		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		VOL0_BECOMES_VIRTUAL = 131072U,
		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		GEOMETRY_USECLOSEST = 262144U,
		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		PREFER_DOLBY_DOWNMIX = 524288U,
		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		THREAD_UNSAFE = 1048576U,
		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		PROFILE_METER_ALL = 2097152U
	}
}
