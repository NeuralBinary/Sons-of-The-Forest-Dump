using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DE RID: 478
	[Token(Token = "0x20001DE")]
	internal class BsonValue : BsonToken
	{
		// Token: 0x06001011 RID: 4113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001011")]
		[Address(RVA = "0x260D140", Offset = "0x260B740", VA = "0x18260D140")]
		public BsonValue(object value, BsonType type)
		{
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170002B6")]
		public object Value
		{
			[Token(Token = "0x6001012")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x000072C0 File Offset: 0x000054C0
		[Token(Token = "0x170002B7")]
		public override BsonType Type
		{
			[Token(Token = "0x6001013")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0", Slot = "4")]
			get
			{
				return (BsonType)0;
			}
		}

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x20")]
		private readonly object _value;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x28")]
		private readonly BsonType _type;
	}
}
