using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DA RID: 474
	[Token(Token = "0x20001DA")]
	internal abstract class BsonToken
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000FFE RID: 4094
		[Token(Token = "0x170002B0")]
		public abstract BsonType Type { [Token(Token = "0x6000FFE")] get; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06001000 RID: 4096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B1")]
		public BsonToken Parent
		{
			[Token(Token = "0x6000FFF")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001000")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x00007260 File Offset: 0x00005460
		// (set) Token: 0x06001002 RID: 4098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B2")]
		public int CalculatedSize
		{
			[Token(Token = "0x6001001")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001002")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001003")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected BsonToken()
		{
		}
	}
}
