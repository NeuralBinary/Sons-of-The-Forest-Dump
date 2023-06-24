using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007FC RID: 2044
	[Token(Token = "0x20007FC")]
	public class SpearedPickupItem : MonoBehaviour
	{
		// Token: 0x06003737 RID: 14135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003737")]
		[Address(RVA = "0x353AF30", Offset = "0x3539530", VA = "0x18353AF30")]
		public GameObject AttachToSpearTip(Transform spearTip, bool destroyParent)
		{
			return null;
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003738")]
		[Address(RVA = "0x353B150", Offset = "0x3539750", VA = "0x18353B150")]
		private void OnItemLoaded(Transform arg0)
		{
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003739")]
		[Address(RVA = "0x353B160", Offset = "0x3539760", VA = "0x18353B160")]
		private void GetBloody()
		{
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SpearedPickupItem()
		{
		}

		// Token: 0x04002FAE RID: 12206
		[Token(Token = "0x4002FAE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pickupItem;

		// Token: 0x04002FAF RID: 12207
		[Token(Token = "0x4002FAF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _parentObject;

		// Token: 0x04002FB0 RID: 12208
		[Token(Token = "0x4002FB0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _shouldGetBloody;

		// Token: 0x04002FB1 RID: 12209
		[Token(Token = "0x4002FB1")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _spawnedItem;
	}
}
