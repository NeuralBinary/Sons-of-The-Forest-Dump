using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public class DefaultEventFilter : IEventFilter
	{
		// Token: 0x060003AF RID: 943 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
		private bool EventReceived(Event ev)
		{
			return default(bool);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DefaultEventFilter()
		{
		}
	}
}
