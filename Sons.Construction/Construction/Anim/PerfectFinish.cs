using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction.Anim
{
	// Token: 0x020002C4 RID: 708
	[Token(Token = "0x20002C4")]
	public class PerfectFinish : IPerfectFinishSettings
	{
		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x0000C164 File Offset: 0x0000A364
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700047C")]
		public PerfectFinishIkModes IkMode
		{
			[Token(Token = "0x6001560")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return PerfectFinishIkModes.None;
			}
			[Token(Token = "0x6001561")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700047D")]
		public IIkSingleGoalProviderModule GoalProvider
		{
			[Token(Token = "0x6001562")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001563")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700047E")]
		public TargetInfo TargetInfo
		{
			[Token(Token = "0x6001564")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001565")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700047F")]
		public StructureElement Prefab
		{
			[Token(Token = "0x6001566")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001567")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x0000C17C File Offset: 0x0000A37C
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000480")]
		public float Delay
		{
			[Token(Token = "0x6001568")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001569")]
			[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x0000C194 File Offset: 0x0000A394
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000481")]
		public float SmoothDuration
		{
			[Token(Token = "0x600156A")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600156B")]
			[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PerfectFinish()
		{
		}
	}
}
