using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CommandLine.Text
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public sealed class UsageAttribute : Attribute
	{
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BC")]
		public string ApplicationAlias
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public UsageAttribute()
		{
		}
	}
}
