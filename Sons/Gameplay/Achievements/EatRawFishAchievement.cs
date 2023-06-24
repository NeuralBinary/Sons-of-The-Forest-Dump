using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200088E RID: 2190
	[Token(Token = "0x200088E")]
	public class EatRawFishAchievement : Achievement
	{
		// Token: 0x06003E88 RID: 16008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E88")]
		[Address(RVA = "0x35D3360", Offset = "0x35D1960", VA = "0x1835D3360", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E89")]
		[Address(RVA = "0x35D3440", Offset = "0x35D1A40", VA = "0x1835D3440")]
		private void OnItemConsumed(object eventParameter)
		{
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E8A")]
		[Address(RVA = "0x35D3560", Offset = "0x35D1B60", VA = "0x1835D3560", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E8B")]
		[Address(RVA = "0x35D3640", Offset = "0x35D1C40", VA = "0x1835D3640", Slot = "7")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E8C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public EatRawFishAchievement()
		{
		}
	}
}
