using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	internal class BsonEmpty : BsonToken
	{
		// Token: 0x0600100E RID: 4110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
		private BsonEmpty(BsonType type)
		{
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x170002B5")]
		public override BsonType Type
		{
			[Token(Token = "0x600100F")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (BsonType)0;
			}
		}

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BsonToken Null;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x8")]
		public static readonly BsonToken Undefined;
	}
}
