using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000889 RID: 2185
	[Token(Token = "0x2000889")]
	public class CollectWatchesAchievement : Achievement
	{
		// Token: 0x06003E6C RID: 15980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E6C")]
		[Address(RVA = "0x35D1E30", Offset = "0x35D0430", VA = "0x1835D1E30", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E6D")]
		[Address(RVA = "0x35D1F10", Offset = "0x35D0510", VA = "0x1835D1F10")]
		private void OnItemPickedUp(object eventParameter)
		{
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E6E")]
		[Address(RVA = "0x35D1FC0", Offset = "0x35D05C0", VA = "0x1835D1FC0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E6F")]
		[Address(RVA = "0x35D2150", Offset = "0x35D0750", VA = "0x1835D2150", Slot = "7")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E70")]
		[Address(RVA = "0x35D2230", Offset = "0x35D0830", VA = "0x1835D2230")]
		public CollectWatchesAchievement()
		{
		}

		// Token: 0x04003471 RID: 13425
		[Token(Token = "0x4003471")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _requiredCount;
	}
}
