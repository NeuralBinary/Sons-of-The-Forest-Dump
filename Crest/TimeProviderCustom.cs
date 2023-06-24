using System;
using Il2CppDummyDll;

namespace Crest
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public class TimeProviderCustom : TimeProviderBase
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x170000AD")]
		public override float CurrentTime
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x170000AE")]
		public override float DeltaTime
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x170000AF")]
		public override float DeltaTimeDynamics
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xA175B0", Offset = "0xA15BB0", VA = "0x180A175B0", Slot = "9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TimeProviderCustom()
		{
		}

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x20")]
		public float _time;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x24")]
		public float _deltaTime;
	}
}
