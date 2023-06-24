using System;
using Endnight.Utilities.Configurations;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class BlobTransportConfig : JsonConfigurationFile<BlobTransportConfig>
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700000D")]
		public override string RootName
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x775420", Offset = "0x773A20", VA = "0x180775420", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x775450", Offset = "0x773A50", VA = "0x180775450")]
		public BlobTransportConfig()
		{
		}

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x10")]
		public int ConnectionNonResponsiveMs;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x14")]
		public int ConnectionTimeoutMs;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x18")]
		public int MaximumSendBandwidth;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x1C")]
		public int InitialBlobSendReserve;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x20")]
		public double BandwidthGrowthRatePerSecond;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x28")]
		public double BandwidthFlatGrowthPerSecond;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x30")]
		public int AckRateMeasureWindowMs;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x34")]
		public int OutgoingBlocksMeasureWindowMs;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x38")]
		public int PostQueueSwapPauseDurationMs;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x3C")]
		public bool LogRtt;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x3D")]
		public bool LogStatus;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x40")]
		public int LogStatusDelay;
	}
}
