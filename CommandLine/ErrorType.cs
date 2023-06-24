using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public enum ErrorType
	{
		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		BadFormatTokenError,
		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		MissingValueOptionError,
		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		UnknownOptionError,
		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		MissingRequiredOptionError,
		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		MutuallyExclusiveSetError,
		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		BadFormatConversionError,
		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		SequenceOutOfRangeError,
		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		RepeatedOptionError,
		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		NoVerbSelectedError,
		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		BadVerbSelectedError,
		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		HelpRequestedError,
		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		HelpVerbRequestedError,
		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		VersionRequestedError,
		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		SetValueExceptionError,
		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		InvalidAttributeConfigurationError,
		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		MissingGroupOptionError,
		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		GroupOptionAmbiguityError,
		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		MultipleDefaultVerbsError
	}
}
