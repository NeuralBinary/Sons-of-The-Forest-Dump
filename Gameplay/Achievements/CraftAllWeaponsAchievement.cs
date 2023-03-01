using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200072E RID: 1838
	[Token(Token = "0x200072E")]
	public class CraftAllWeaponsAchievement : Achievement
	{
		// Token: 0x06003004 RID: 12292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003004")]
		[Address(RVA = "0x2E28D60", Offset = "0x2E27D60", VA = "0x182E28D60", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003005")]
		[Address(RVA = "0x2E28E40", Offset = "0x2E27E40", VA = "0x182E28E40")]
		private void OnItemCrafted(object eventParameter)
		{
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003006")]
		[Address(RVA = "0x2E28FE0", Offset = "0x2E27FE0", VA = "0x182E28FE0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003007")]
		[Address(RVA = "0x2E290D0", Offset = "0x2E280D0", VA = "0x182E290D0")]
		public CraftAllWeaponsAchievement()
		{
		}

		// Token: 0x04002A44 RID: 10820
		[Token(Token = "0x4002A44")]
		[FieldOffset(Offset = "0x38")]
		[ItemIdPicker(2048, true)]
		[SerializeField]
		private List<int> _requiredWeapons;
	}
}
