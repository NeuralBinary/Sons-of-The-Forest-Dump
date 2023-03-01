using System;
using Il2CppDummyDll;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000521 RID: 1313
	[Token(Token = "0x2000521")]
	public abstract class SimpleStateValue<T> : SimpleState
	{
		// Token: 0x06002227 RID: 8743
		[Token(Token = "0x6002227")]
		public abstract T GetValue();

		// Token: 0x06002228 RID: 8744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002228")]
		public SimpleStateValue(T value)
		{
		}

		// Token: 0x04001F37 RID: 7991
		[Token(Token = "0x4001F37")]
		[FieldOffset(Offset = "0x0")]
		private readonly T _value;
	}
}
