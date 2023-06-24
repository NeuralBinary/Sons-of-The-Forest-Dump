using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	internal class BsonRegex : BsonToken
	{
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BB")]
		public BsonString Pattern
		{
			[Token(Token = "0x600101D")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600101E")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BC")]
		public BsonString Options
		{
			[Token(Token = "0x600101F")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001020")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001021")]
		[Address(RVA = "0x260D470", Offset = "0x260BA70", VA = "0x18260D470")]
		public BsonRegex(string pattern, string options)
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x170002BD")]
		public override BsonType Type
		{
			[Token(Token = "0x6001022")]
			[Address(RVA = "0x260D640", Offset = "0x260BC40", VA = "0x18260D640", Slot = "4")]
			get
			{
				return (BsonType)0;
			}
		}
	}
}
