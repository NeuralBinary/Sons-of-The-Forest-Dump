using System;
using Il2CppDummyDll;

namespace Endnight.Utilities.Timer
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	public interface IAutoTimer
	{
		// Token: 0x06000260 RID: 608
		[Token(Token = "0x6000260")]
		float TimeSampleMethod();

		// Token: 0x06000261 RID: 609
		[Token(Token = "0x6000261")]
		bool IsRunning();

		// Token: 0x06000262 RID: 610
		[Token(Token = "0x6000262")]
		bool IsStopped();

		// Token: 0x06000263 RID: 611
		[Token(Token = "0x6000263")]
		bool IsFinished();

		// Token: 0x06000264 RID: 612
		[Token(Token = "0x6000264")]
		void Start();

		// Token: 0x06000265 RID: 613
		[Token(Token = "0x6000265")]
		void Restart();

		// Token: 0x06000266 RID: 614
		[Token(Token = "0x6000266")]
		void Stop();
	}
}
