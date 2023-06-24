using System;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using Sons.Ai.Vail.Inventory;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[AddComponentMenu("Sons/Ai/Interact/Drop Location")]
	public class DropLocation : MonoBehaviour, IVailActorInteract, IVailDropTarget
	{
		// Token: 0x060004DB RID: 1243 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2B20A10", Offset = "0x2B1F010", VA = "0x182B20A10")]
		private static ValueDropdownList<string> GetItemTypes()
		{
			return null;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetItemType(string newItemType)
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "7")]
		public string GetItemType()
		{
			return null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "8")]
		private int TryAddItem(int itemId, int itemCount)
		{
			return 0;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
		private bool IsFull()
		{
			return default(bool);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DropLocation()
		{
		}

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x20")]
		public string _itemType;
	}
}
