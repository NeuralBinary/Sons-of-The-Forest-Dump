using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace Pathfinding.Ionic
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	internal enum ComparisonOperator
	{
		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[Description(">")]
		GreaterThan,
		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[Description(">=")]
		GreaterThanOrEqualTo,
		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[Description("<")]
		LesserThan,
		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[Description("<=")]
		LesserThanOrEqualTo,
		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[Description("=")]
		EqualTo,
		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[Description("!=")]
		NotEqualTo
	}
}
