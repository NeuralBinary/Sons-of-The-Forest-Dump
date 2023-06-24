using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	public struct CREATESOUNDEXINFO
	{
		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x0")]
		public int cbsize;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x4")]
		public uint length;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x8")]
		public uint fileoffset;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0xC")]
		public int numchannels;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x10")]
		public int defaultfrequency;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x14")]
		public SOUND_FORMAT format;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x18")]
		public uint decodebuffersize;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x1C")]
		public int initialsubsound;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x20")]
		public int numsubsounds;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x28")]
		public IntPtr inclusionlist;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x30")]
		public int inclusionlistnum;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x38")]
		public SOUND_PCMREAD_CALLBACK pcmreadcallback;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x40")]
		public SOUND_PCMSETPOS_CALLBACK pcmsetposcallback;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x48")]
		public SOUND_NONBLOCK_CALLBACK nonblockcallback;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x50")]
		public IntPtr dlsname;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x58")]
		public IntPtr encryptionkey;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x60")]
		public int maxpolyphony;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x68")]
		public IntPtr userdata;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x70")]
		public SOUND_TYPE suggestedsoundtype;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x78")]
		public FILE_OPEN_CALLBACK fileuseropen;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x80")]
		public FILE_CLOSE_CALLBACK fileuserclose;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x88")]
		public FILE_READ_CALLBACK fileuserread;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x90")]
		public FILE_SEEK_CALLBACK fileuserseek;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x98")]
		public FILE_ASYNCREAD_CALLBACK fileuserasyncread;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0xA0")]
		public FILE_ASYNCCANCEL_CALLBACK fileuserasynccancel;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0xA8")]
		public IntPtr fileuserdata;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0xB0")]
		public int filebuffersize;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0xB4")]
		public CHANNELORDER channelorder;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0xB8")]
		public IntPtr initialsoundgroup;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0xC0")]
		public uint initialseekposition;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0xC4")]
		public TIMEUNIT initialseekpostype;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0xC8")]
		public int ignoresetfilesystem;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0xCC")]
		public uint audioqueuepolicy;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0xD0")]
		public uint minmidigranularity;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0xD4")]
		public int nonblockthreadid;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0xD8")]
		public IntPtr fsbguid;
	}
}
