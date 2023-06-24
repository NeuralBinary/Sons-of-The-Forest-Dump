using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	internal interface IEventFactory : IFactory
	{
		// Token: 0x060004D1 RID: 1233
		[Token(Token = "0x60004D1")]
		void Dispatch(Event ev, object target);
	}
}
