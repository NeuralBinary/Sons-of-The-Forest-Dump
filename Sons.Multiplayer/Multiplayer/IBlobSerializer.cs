using System;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public interface IBlobSerializer<T>
	{
		// Token: 0x06000148 RID: 328
		[Token(Token = "0x6000148")]
		T OnSerialize();

		// Token: 0x06000149 RID: 329
		[Token(Token = "0x6000149")]
		void OnDeserialize(T data);
	}
}
