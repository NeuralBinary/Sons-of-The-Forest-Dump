using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000272 RID: 626
	[Token(Token = "0x2000272")]
	internal class StagingDelay
	{
		// Token: 0x06001305 RID: 4869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001305")]
		[Address(RVA = "0x2F4A430", Offset = "0x2F48A30", VA = "0x182F4A430")]
		public void TryBegin()
		{
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001306")]
		[Address(RVA = "0x2F4A4F0", Offset = "0x2F48AF0", VA = "0x182F4A4F0")]
		public void ResetAfterDelay()
		{
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0000B8C4 File Offset: 0x00009AC4
		[Token(Token = "0x6001307")]
		[Address(RVA = "0x2F4A550", Offset = "0x2F48B50", VA = "0x182F4A550")]
		private bool CheckDelayStarted()
		{
			return default(bool);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0000B8DC File Offset: 0x00009ADC
		[Token(Token = "0x6001308")]
		[Address(RVA = "0x2F4A5D0", Offset = "0x2F48BD0", VA = "0x182F4A5D0")]
		public bool HasDelayElapsed(float delay)
		{
			return default(bool);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001309")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StagingDelay()
		{
		}

		// Token: 0x0400095F RID: 2399
		[Token(Token = "0x400095F")]
		[FieldOffset(Offset = "0x10")]
		private bool _stageDelayStarted;

		// Token: 0x04000960 RID: 2400
		[Token(Token = "0x4000960")]
		[FieldOffset(Offset = "0x11")]
		private bool _resetDelayStarted;

		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x4000961")]
		[FieldOffset(Offset = "0x14")]
		private float _stageDelayStartTime;

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x18")]
		private float _resetStartTime;
	}
}
