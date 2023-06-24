using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TriangleNet.Logging
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	public interface ILog<T> where T : ILogItem
	{
		// Token: 0x060002DF RID: 735
		[Token(Token = "0x60002DF")]
		void Add(T item);

		// Token: 0x060002E0 RID: 736
		[Token(Token = "0x60002E0")]
		void Clear();

		// Token: 0x060002E1 RID: 737
		[Token(Token = "0x60002E1")]
		void Info(string message);

		// Token: 0x060002E2 RID: 738
		[Token(Token = "0x60002E2")]
		void Error(string message, string info);

		// Token: 0x060002E3 RID: 739
		[Token(Token = "0x60002E3")]
		void Warning(string message, string info);

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002E4 RID: 740
		[Token(Token = "0x17000080")]
		IList<T> Data { [Token(Token = "0x60002E4")] get; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002E5 RID: 741
		[Token(Token = "0x17000081")]
		LogLevel Level { [Token(Token = "0x60002E5")] get; }
	}
}
