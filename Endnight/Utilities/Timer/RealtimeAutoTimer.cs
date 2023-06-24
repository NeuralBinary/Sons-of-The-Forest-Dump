using System;
using Il2CppDummyDll;

namespace Endnight.Utilities.Timer
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public class RealtimeAutoTimer : AutoTimerBase
	{
		// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000267")]
		[Address(RVA = "0xA904F0", Offset = "0xA8EAF0", VA = "0x180A904F0")]
		public RealtimeAutoTimer(float interval)
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x6000268")]
		[Address(RVA = "0xA90550", Offset = "0xA8EB50", VA = "0x180A90550", Slot = "11")]
		public override float TimeSampleMethod()
		{
			return 0f;
		}
	}
}
