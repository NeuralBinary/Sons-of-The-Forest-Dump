using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public static class TaskUtils
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA62A80", Offset = "0xA61080", VA = "0x180A62A80")]
		public static Task<bool> CheckPredicateWithTimeout(Func<bool> predicate, int timeout, int delay)
		{
			return null;
		}
	}
}
