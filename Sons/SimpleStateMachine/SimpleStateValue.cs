using System;
using Il2CppDummyDll;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000529 RID: 1321
	[Token(Token = "0x2000529")]
	public abstract class SimpleStateValue<T> : SimpleState
	{
		// Token: 0x06002314 RID: 8980
		[Token(Token = "0x6002314")]
		public abstract T GetValue();

		// Token: 0x06002315 RID: 8981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002315")]
		public SimpleStateValue(T value)
		{
		}

		// Token: 0x04001FEB RID: 8171
		[Token(Token = "0x4001FEB")]
		[FieldOffset(Offset = "0x0")]
		private readonly T _value;
	}
}
