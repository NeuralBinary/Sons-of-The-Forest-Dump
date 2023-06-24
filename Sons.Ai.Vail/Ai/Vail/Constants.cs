using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	internal static class Constants
	{
		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		internal const string PrettyPrintCamelCaseRegex = "((?<=\\p{Ll})\\p{Lu})|((?!\\A)\\p{Lu}(?>\\p{Ll}))";

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		internal const string PrettyPrintCamelCaseReplacement = " $0";

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		internal const string MetersOverlayString = "m";

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		internal const string InvalidString = "[invalid]";

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		internal const string EqualsString = "==";

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		internal const string NotEqualsString = "!=";

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		internal const string LessThanString = "<";

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		internal const string GreaterThanString = ">";

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		internal const string LessThanOrEqualString = "<=";

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		internal const string GreaterThanOrEqual = ">=";
	}
}
