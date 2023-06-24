using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Items.Core
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[CreateAssetMenu(fileName = "PerishableItemData", menuName = "Sons/Data/Items/Modules/PerishableItemData", order = 0)]
	public class PerishableItemData : ScriptableObject
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x30B1D70", Offset = "0x30B0370", VA = "0x1830B1D70")]
		public PerishableItemData.StateData GetStateData(PerishableItemData.State state)
		{
			return null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x30B1E50", Offset = "0x30B0450", VA = "0x1830B1E50")]
		public PerishableItemData()
		{
		}

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x18")]
		[ItemIdPicker(Types.Edible, true)]
		public int ItemId;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x20")]
		public List<PerishableItemData.StateData> StatesData;

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		public enum State
		{
			// Token: 0x040001BE RID: 446
			[Token(Token = "0x40001BE")]
			None,
			// Token: 0x040001BF RID: 447
			[Token(Token = "0x40001BF")]
			Raw,
			// Token: 0x040001C0 RID: 448
			[Token(Token = "0x40001C0")]
			Stale,
			// Token: 0x040001C1 RID: 449
			[Token(Token = "0x40001C1")]
			Rotten,
			// Token: 0x040001C2 RID: 450
			[Token(Token = "0x40001C2")]
			Dried,
			// Token: 0x040001C3 RID: 451
			[Token(Token = "0x40001C3")]
			Cooked,
			// Token: 0x040001C4 RID: 452
			[Token(Token = "0x40001C4")]
			Burnt
		}

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		[Serializable]
		public class StateData
		{
			// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x30B1F10", Offset = "0x30B0510", VA = "0x1830B1F10")]
			public StateData()
			{
			}

			// Token: 0x040001C5 RID: 453
			[Token(Token = "0x40001C5")]
			[FieldOffset(Offset = "0x10")]
			public PerishableItemData.State State;

			// Token: 0x040001C6 RID: 454
			[Token(Token = "0x40001C6")]
			[FieldOffset(Offset = "0x14")]
			public PerishableItemData.State NextState;

			// Token: 0x040001C7 RID: 455
			[Token(Token = "0x40001C7")]
			[FieldOffset(Offset = "0x18")]
			public float DurationGameDays;

			// Token: 0x040001C8 RID: 456
			[Token(Token = "0x40001C8")]
			[FieldOffset(Offset = "0x20")]
			public List<StatEffect> StatEffects;

			// Token: 0x040001C9 RID: 457
			[Token(Token = "0x40001C9")]
			[FieldOffset(Offset = "0x28")]
			public Material Material;

			// Token: 0x040001CA RID: 458
			[Token(Token = "0x40001CA")]
			[FieldOffset(Offset = "0x30")]
			public int MaterialIndex;
		}
	}
}
