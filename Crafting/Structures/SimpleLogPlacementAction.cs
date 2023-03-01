using System;
using System.Collections;
using Il2CppDummyDll;
using TheForest.Player.Actions;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007D2 RID: 2002
	[Token(Token = "0x20007D2")]
	public class SimpleLogPlacementAction : ISpecialItemPlacementAction
	{
		// Token: 0x060034D8 RID: 13528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D8")]
		[Address(RVA = "0x2E9D5A0", Offset = "0x2E9C5A0", VA = "0x182E9D5A0", Slot = "4")]
		public void Execute(int ingredientId, int itemCount, StructureCraftingNode structure)
		{
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D9")]
		[Address(RVA = "0x2E9D2F0", Offset = "0x2E9C2F0", VA = "0x182E9D2F0", Slot = "5")]
		public void Cancel()
		{
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034DA")]
		[Address(RVA = "0x2E9D660", Offset = "0x2E9C660", VA = "0x182E9D660")]
		private IEnumerator PlaceLogAnimation(int ingredientId, int itemCount, StructureCraftingNode structure)
		{
			return null;
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034DB")]
		[Address(RVA = "0x2E9D340", Offset = "0x2E9C340", VA = "0x182E9D340")]
		private IEnumerator CleanUpBeforeExiting(float delay = 0.25f)
		{
			return null;
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DC")]
		[Address(RVA = "0x2E9D3C0", Offset = "0x2E9C3C0", VA = "0x182E9D3C0")]
		private void CleanUp()
		{
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DD")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public SimpleLogPlacementAction()
		{
		}

		// Token: 0x04002D81 RID: 11649
		[Token(Token = "0x4002D81")]
		[FieldOffset(Offset = "0x10")]
		private Coroutine _activeCoroutine;

		// Token: 0x04002D82 RID: 11650
		[Token(Token = "0x4002D82")]
		[FieldOffset(Offset = "0x0")]
		private static int DebugNum;
	}
}
