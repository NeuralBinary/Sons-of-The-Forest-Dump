using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RailwaySharp.ErrorHandling
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	internal sealed class Ok<TSuccess, TMessage> : Result<TSuccess, TMessage>
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000097")]
		public Ok(TSuccess success, IEnumerable<TMessage> messages)
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public TSuccess Success
		{
			[Token(Token = "0x6000098")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public IEnumerable<TMessage> Messages
		{
			[Token(Token = "0x6000099")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x0")]
		private readonly Tuple<TSuccess, IEnumerable<TMessage>> _value;
	}
}
