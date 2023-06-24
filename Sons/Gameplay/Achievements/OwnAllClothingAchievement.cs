using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000896 RID: 2198
	[Token(Token = "0x2000896")]
	public class OwnAllClothingAchievement : Achievement
	{
		// Token: 0x06003EA9 RID: 16041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA9")]
		[Address(RVA = "0x35D4400", Offset = "0x35D2A00", VA = "0x1835D4400", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAA")]
		[Address(RVA = "0x35D44E0", Offset = "0x35D2AE0", VA = "0x1835D44E0")]
		private void OnClothingAdded(object eventParameter)
		{
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAB")]
		[Address(RVA = "0x35D47F0", Offset = "0x35D2DF0", VA = "0x1835D47F0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAC")]
		[Address(RVA = "0x35D48F0", Offset = "0x35D2EF0", VA = "0x1835D48F0", Slot = "7")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAD")]
		[Address(RVA = "0x35D49D0", Offset = "0x35D2FD0", VA = "0x1835D49D0")]
		public OwnAllClothingAchievement()
		{
		}

		// Token: 0x04003479 RID: 13433
		[Token(Token = "0x4003479")]
		[FieldOffset(Offset = "0x38")]
		[ItemIdPicker(Types.Clothing, true)]
		[SerializeField]
		private List<int> _requiredClothing;
	}
}
