using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		DEVICELISTCHANGED = 1U,
		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		DEVICELOST = 2U,
		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		MEMORYALLOCATIONFAILED = 4U,
		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		THREADCREATED = 8U,
		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		BADDSPCONNECTION = 16U,
		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		PREMIX = 32U,
		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		POSTMIX = 64U,
		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		ERROR = 128U,
		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		MIDMIX = 256U,
		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		THREADDESTROYED = 512U,
		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		PREUPDATE = 1024U,
		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		POSTUPDATE = 2048U,
		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		RECORDLISTCHANGED = 4096U,
		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		ALL = 4294967295U
	}
}
