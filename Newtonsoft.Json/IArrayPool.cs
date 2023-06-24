using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[NullableContext(1)]
	public interface IArrayPool<T>
	{
		// Token: 0x06000015 RID: 21
		[Token(Token = "0x6000015")]
		T[] Rent(int minimumLength);

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		void Return([Nullable(new byte[]
		{
			2,
			1
		})] T[] array);
	}
}
