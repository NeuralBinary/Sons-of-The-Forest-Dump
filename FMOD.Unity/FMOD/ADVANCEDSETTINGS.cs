using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public struct ADVANCEDSETTINGS
	{
		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x0")]
		public int cbSize;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x4")]
		public int maxMPEGCodecs;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x8")]
		public int maxADPCMCodecs;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0xC")]
		public int maxXMACodecs;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x10")]
		public int maxVorbisCodecs;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x14")]
		public int maxAT9Codecs;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x18")]
		public int maxFADPCMCodecs;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x1C")]
		public int maxPCMCodecs;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x20")]
		public int ASIONumChannels;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x28")]
		public IntPtr ASIOChannelList;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x30")]
		public IntPtr ASIOSpeakerList;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x38")]
		public float vol0virtualvol;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x3C")]
		public uint defaultDecodeBufferSize;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x40")]
		public ushort profilePort;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x44")]
		public uint geometryMaxFadeTime;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x48")]
		public float distanceFilterCenterFreq;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x4C")]
		public int reverb3Dinstance;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x50")]
		public int DSPBufferPoolSize;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x54")]
		public uint stackSizeStream;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x58")]
		public uint stackSizeNonBlocking;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x5C")]
		public uint stackSizeMixer;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x60")]
		public DSP_RESAMPLER resamplerMethod;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x64")]
		public uint commandQueueSize;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x68")]
		public uint randomSeed;
	}
}
