using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace TheForest.Player
{
	// Token: 0x02000453 RID: 1107
	[Token(Token = "0x2000453")]
	public class StoryCluesFolder : MonoBehaviour
	{
		// Token: 0x06001CA0 RID: 7328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x32C6420", Offset = "0x32C4A20", VA = "0x1832C6420")]
		private void Update()
		{
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x32C6560", Offset = "0x32C4B60", VA = "0x1832C6560")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x32C66D0", Offset = "0x32C4CD0", VA = "0x1832C66D0")]
		private void OnInventoryAddedItem(object o)
		{
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x32C6740", Offset = "0x32C4D40", VA = "0x1832C6740")]
		private void OnInventoryAddedItem(int itemId)
		{
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0x32C6950", Offset = "0x32C4F50", VA = "0x1832C6950")]
		public void Init()
		{
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x32C6A40", Offset = "0x32C5040", VA = "0x1832C6A40")]
		private IEnumerator InitFromSave()
		{
			return null;
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public StoryCluesFolder()
		{
		}

		// Token: 0x04001B37 RID: 6967
		[Token(Token = "0x4001B37")]
		[FieldOffset(Offset = "0x20")]
		public List<StoryCluesFolder.ClueItem> _clues;

		// Token: 0x04001B38 RID: 6968
		[Token(Token = "0x4001B38")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] _cluePages;

		// Token: 0x04001B39 RID: 6969
		[Token(Token = "0x4001B39")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _exceedingCluesPage;

		// Token: 0x04001B3A RID: 6970
		[Token(Token = "0x4001B3A")]
		[FieldOffset(Offset = "0x38")]
		public bool refresh;

		// Token: 0x02000454 RID: 1108
		[Token(Token = "0x2000454")]
		[Serializable]
		public class ClueItem
		{
			// Token: 0x06001CA7 RID: 7335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001CA7")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ClueItem()
			{
			}

			// Token: 0x04001B3B RID: 6971
			[Token(Token = "0x4001B3B")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker]
			public int _itemId;

			// Token: 0x04001B3C RID: 6972
			[Token(Token = "0x4001B3C")]
			[FieldOffset(Offset = "0x18")]
			public GameObject[] _renderers;
		}
	}
}
