using System;
using Il2CppDummyDll;

namespace RailwaySharp.ErrorHandling
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	internal abstract class Result<TSuccess, TMessage>
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000090")]
		protected Result(ResultType tag)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x17000034")]
		public ResultType Tag
		{
			[Token(Token = "0x6000091")]
			get
			{
				return ResultType.Ok;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x0")]
		private readonly ResultType _tag;
	}
}
