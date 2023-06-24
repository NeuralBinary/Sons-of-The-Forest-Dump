using System;
using Il2CppDummyDll;

namespace Crest
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public class TimeProviderDefault : ITimeProvider
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x170000B0")]
		public float CurrentTime
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x789580", Offset = "0x787B80", VA = "0x180789580", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x170000B1")]
		public float DeltaTime
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0xA175D0", Offset = "0xA15BD0", VA = "0x180A175D0", Slot = "5")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x170000B2")]
		public float DeltaTimeDynamics
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0xA175D0", Offset = "0xA15BD0", VA = "0x180A175D0", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TimeProviderDefault()
		{
		}
	}
}
