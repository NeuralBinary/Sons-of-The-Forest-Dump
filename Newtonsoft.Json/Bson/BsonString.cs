using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	internal class BsonString : BsonValue
	{
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x000072D8 File Offset: 0x000054D8
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B8")]
		public int ByteCount
		{
			[Token(Token = "0x6001016")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001017")]
			[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x000072F0 File Offset: 0x000054F0
		[Token(Token = "0x170002B9")]
		public bool IncludeLength
		{
			[Token(Token = "0x6001018")]
			[Address(RVA = "0x2084CB0", Offset = "0x20832B0", VA = "0x182084CB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001019")]
		[Address(RVA = "0x260D390", Offset = "0x260B990", VA = "0x18260D390")]
		public BsonString(object value, bool includeLength)
		{
		}
	}
}
