using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RailwaySharp.ErrorHandling
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	internal sealed class Bad<TSuccess, TMessage> : Result<TSuccess, TMessage>
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009A")]
		public Bad(IEnumerable<TMessage> messages)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		public IEnumerable<TMessage> Messages
		{
			[Token(Token = "0x600009B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x0")]
		private readonly IEnumerable<TMessage> _messages;
	}
}
