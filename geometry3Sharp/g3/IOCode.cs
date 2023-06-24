using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000195 RID: 405
	[Token(Token = "0x2000195")]
	public enum IOCode
	{
		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		Ok,
		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		FileAccessError,
		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		UnknownFormatError,
		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		FormatNotSupportedError,
		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		InvalidFilenameError,
		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		FileParsingError = 100,
		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		GarbageDataError,
		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		GenericReaderError,
		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		GenericReaderWarning,
		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		WriterError = 200,
		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		ComputingInWorkerThread = 1000
	}
}
