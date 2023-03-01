using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200073A RID: 1850
	[Token(Token = "0x200073A")]
	public class OwnAllClothingAchievement : Achievement
	{
		// Token: 0x06003039 RID: 12345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003039")]
		[Address(RVA = "0x2E369D0", Offset = "0x2E359D0", VA = "0x182E369D0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303A")]
		[Address(RVA = "0x2E36AB0", Offset = "0x2E35AB0", VA = "0x182E36AB0")]
		private void OnClothingAdded(object eventParameter)
		{
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303B")]
		[Address(RVA = "0x2E36D10", Offset = "0x2E35D10", VA = "0x182E36D10", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303C")]
		[Address(RVA = "0x2E36EC0", Offset = "0x2E35EC0", VA = "0x182E36EC0")]
		public OwnAllClothingAchievement()
		{
		}

		// Token: 0x04002A4B RID: 10827
		[Token(Token = "0x4002A4B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[ItemIdPicker(2, true)]
		private List<int> _requiredClothing;
	}
}
