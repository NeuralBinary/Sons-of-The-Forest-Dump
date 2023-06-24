using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200088A RID: 2186
	[Token(Token = "0x200088A")]
	public class CraftAllWeaponsAchievement : Achievement
	{
		// Token: 0x06003E71 RID: 15985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E71")]
		[Address(RVA = "0x35D2280", Offset = "0x35D0880", VA = "0x1835D2280", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E72")]
		[Address(RVA = "0x35D2360", Offset = "0x35D0960", VA = "0x1835D2360")]
		private void OnItemCrafted(object eventParameter)
		{
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E73")]
		[Address(RVA = "0x35D25A0", Offset = "0x35D0BA0", VA = "0x1835D25A0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E74")]
		[Address(RVA = "0x35D26A0", Offset = "0x35D0CA0", VA = "0x1835D26A0", Slot = "7")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E75")]
		[Address(RVA = "0x35D2780", Offset = "0x35D0D80", VA = "0x1835D2780")]
		public CraftAllWeaponsAchievement()
		{
		}

		// Token: 0x04003472 RID: 13426
		[Token(Token = "0x4003472")]
		[FieldOffset(Offset = "0x38")]
		[ItemIdPicker(Types.Craftable, true)]
		[SerializeField]
		private List<int> _requiredWeapons;
	}
}
