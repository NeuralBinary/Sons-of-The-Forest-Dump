using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public sealed class MutuallyExclusiveSetError : NamedError
	{
		// Token: 0x060001CA RID: 458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x9901E0", Offset = "0x98E7E0", VA = "0x1809901E0")]
		internal MutuallyExclusiveSetError(NameInfo nameInfo, string setName)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public string SetName
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x20")]
		private readonly string setName;
	}
}
