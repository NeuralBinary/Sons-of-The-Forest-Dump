using System;
using System.Collections;
using Il2CppDummyDll;
using TheForest.Player.Actions;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006DE RID: 1758
	[Token(Token = "0x20006DE")]
	public class SimpleLogPlacementAction : ISpecialItemPlacementAction
	{
		// Token: 0x06002E6C RID: 11884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E6C")]
		[Address(RVA = "0x344D350", Offset = "0x344B950", VA = "0x18344D350", Slot = "4")]
		public void Execute(int ingredientId, int itemCount, StructureCraftingNode structure)
		{
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E6D")]
		[Address(RVA = "0x344D500", Offset = "0x344BB00", VA = "0x18344D500", Slot = "5")]
		public void Cancel()
		{
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E6E")]
		[Address(RVA = "0x344D580", Offset = "0x344BB80", VA = "0x18344D580")]
		private IEnumerator PlaceLogAnimation(int ingredientId, int itemCount, StructureCraftingNode structure)
		{
			return null;
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E6F")]
		[Address(RVA = "0x344D6B0", Offset = "0x344BCB0", VA = "0x18344D6B0")]
		private IEnumerator CleanUpBeforeExiting(float delay = 0.25f)
		{
			return null;
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E70")]
		[Address(RVA = "0x344D770", Offset = "0x344BD70", VA = "0x18344D770")]
		private void CleanUp()
		{
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E71")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SimpleLogPlacementAction()
		{
		}

		// Token: 0x04002865 RID: 10341
		[Token(Token = "0x4002865")]
		[FieldOffset(Offset = "0x10")]
		private Coroutine _activeCoroutine;
	}
}
