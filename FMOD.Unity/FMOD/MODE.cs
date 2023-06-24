using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	[Flags]
	public enum MODE : uint
	{
		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		DEFAULT = 0U,
		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		LOOP_OFF = 1U,
		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		LOOP_NORMAL = 2U,
		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		LOOP_BIDI = 4U,
		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		_2D = 8U,
		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		_3D = 16U,
		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		CREATESTREAM = 128U,
		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		CREATESAMPLE = 256U,
		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		CREATECOMPRESSEDSAMPLE = 512U,
		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		OPENUSER = 1024U,
		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		OPENMEMORY = 2048U,
		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		OPENMEMORY_POINT = 268435456U,
		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		OPENRAW = 4096U,
		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		OPENONLY = 8192U,
		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		ACCURATETIME = 16384U,
		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		MPEGSEARCH = 32768U,
		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		NONBLOCKING = 65536U,
		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		UNIQUE = 131072U,
		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		_3D_HEADRELATIVE = 262144U,
		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		_3D_WORLDRELATIVE = 524288U,
		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		_3D_INVERSEROLLOFF = 1048576U,
		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		_3D_LINEARROLLOFF = 2097152U,
		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		_3D_LINEARSQUAREROLLOFF = 4194304U,
		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		_3D_INVERSETAPEREDROLLOFF = 8388608U,
		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		_3D_CUSTOMROLLOFF = 67108864U,
		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		_3D_IGNOREGEOMETRY = 1073741824U,
		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		IGNORETAGS = 33554432U,
		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		LOWMEM = 134217728U,
		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		VIRTUAL_PLAYFROMSTART = 2147483648U
	}
}
