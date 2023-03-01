using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace TheForest.Player
{
	// Token: 0x02000461 RID: 1121
	[Token(Token = "0x2000461")]
	public class StoryCluesFolder : MonoBehaviour
	{
		// Token: 0x06001C62 RID: 7266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C62")]
		[Address(RVA = "0x2D048A0", Offset = "0x2D038A0", VA = "0x182D048A0")]
		private void Update()
		{
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C63")]
		[Address(RVA = "0x2D04490", Offset = "0x2D03490", VA = "0x182D04490")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C64")]
		[Address(RVA = "0x2D045E0", Offset = "0x2D035E0", VA = "0x182D045E0")]
		private void OnInventoryAddedItem(object o)
		{
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x2D04770", Offset = "0x2D03770", VA = "0x182D04770")]
		private void OnInventoryAddedItem(int itemId)
		{
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x2D04420", Offset = "0x2D03420", VA = "0x182D04420")]
		public void Init()
		{
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C67")]
		[Address(RVA = "0x2D043B0", Offset = "0x2D033B0", VA = "0x182D043B0")]
		private IEnumerator InitFromSave()
		{
			return null;
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C68")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public StoryCluesFolder()
		{
		}

		// Token: 0x04001B13 RID: 6931
		[Token(Token = "0x4001B13")]
		[FieldOffset(Offset = "0x20")]
		public List<StoryCluesFolder.ClueItem> _clues;

		// Token: 0x04001B14 RID: 6932
		[Token(Token = "0x4001B14")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] _cluePages;

		// Token: 0x04001B15 RID: 6933
		[Token(Token = "0x4001B15")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _exceedingCluesPage;

		// Token: 0x04001B16 RID: 6934
		[Token(Token = "0x4001B16")]
		[FieldOffset(Offset = "0x38")]
		public bool refresh;

		// Token: 0x02000462 RID: 1122
		[Token(Token = "0x2000462")]
		[Serializable]
		public class ClueItem
		{
			// Token: 0x06001C69 RID: 7273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001C69")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ClueItem()
			{
			}

			// Token: 0x04001B17 RID: 6935
			[Token(Token = "0x4001B17")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker]
			public int _itemId;

			// Token: 0x04001B18 RID: 6936
			[Token(Token = "0x4001B18")]
			[FieldOffset(Offset = "0x18")]
			public GameObject[] _renderers;
		}
	}
}
