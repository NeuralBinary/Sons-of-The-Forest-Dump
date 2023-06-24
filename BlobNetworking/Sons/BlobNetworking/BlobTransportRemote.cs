using System;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class BlobTransportRemote
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x7754E0", Offset = "0x773AE0", VA = "0x1807754E0")]
		public BlobTransportRemote(BlobTransportEndpoint remoteEp, KeepAlive keepAlive, long time)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x775550", Offset = "0x773B50", VA = "0x180775550")]
		public void Update(KeepAlive keepAlive, long time)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x775570", Offset = "0x773B70", VA = "0x180775570")]
		public bool IsTimeout(long time)
		{
			return default(bool);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x775630", Offset = "0x773C30", VA = "0x180775630")]
		public bool IsResponsive(long time)
		{
			return default(bool);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x7756F0", Offset = "0x773CF0", VA = "0x1807756F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x10")]
		public readonly BlobTransportEndpoint Ep;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x18")]
		public short Rtt;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x20")]
		public ulong Token;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x28")]
		private long LastKeepAliveTimeTicks;
	}
}
