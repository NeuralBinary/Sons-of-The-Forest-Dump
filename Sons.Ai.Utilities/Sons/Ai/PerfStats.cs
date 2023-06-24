using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sons.Ai
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class PerfStats
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2A99C30", Offset = "0x2A98230", VA = "0x182A99C30")]
		public void StartFrame()
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2A99CA0", Offset = "0x2A982A0", VA = "0x182A99CA0")]
		public void Pause()
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2A99CC0", Offset = "0x2A982C0", VA = "0x182A99CC0")]
		public void Continue()
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2A99D20", Offset = "0x2A98320", VA = "0x182A99D20")]
		public void Clear()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2A99D30", Offset = "0x2A98330", VA = "0x182A99D30")]
		public void EndFrame()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2A99DC0", Offset = "0x2A983C0", VA = "0x182A99DC0")]
		public PerfStats()
		{
		}

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x10")]
		public float TickTimeDisplay;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x14")]
		private float _tickTime;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x18")]
		private int _tickFrames;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x20")]
		private readonly Stopwatch _watch;
	}
}
