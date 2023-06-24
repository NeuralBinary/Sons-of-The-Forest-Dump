using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001E1 RID: 481
	[Token(Token = "0x20001E1")]
	internal class BsonBinary : BsonValue
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x00007308 File Offset: 0x00005508
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BA")]
		public BsonBinaryType BinaryType
		{
			[Token(Token = "0x600101A")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			[CompilerGenerated]
			get
			{
				return BsonBinaryType.Binary;
			}
			[Token(Token = "0x600101B")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101C")]
		[Address(RVA = "0x260D400", Offset = "0x260BA00", VA = "0x18260D400")]
		public BsonBinary(byte[] value, BsonBinaryType binaryType)
		{
		}
	}
}
