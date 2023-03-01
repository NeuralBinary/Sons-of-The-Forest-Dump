using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006C4 RID: 1732
	[Token(Token = "0x20006C4")]
	public class SpearedPickupItem : MonoBehaviour
	{
		// Token: 0x06002C68 RID: 11368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C68")]
		[Address(RVA = "0x2DF9CE0", Offset = "0x2DF8CE0", VA = "0x182DF9CE0")]
		public GameObject AttachToSpearTip(Transform spearTip, bool destroyParent)
		{
			return null;
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C69")]
		[Address(RVA = "0x2DF9F50", Offset = "0x2DF8F50", VA = "0x182DF9F50")]
		private void OnItemLoaded(Transform arg0)
		{
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6A")]
		[Address(RVA = "0x2DF9E90", Offset = "0x2DF8E90", VA = "0x182DF9E90")]
		private void GetBloody()
		{
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6B")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SpearedPickupItem()
		{
		}

		// Token: 0x040027C4 RID: 10180
		[Token(Token = "0x40027C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pickupItem;

		// Token: 0x040027C5 RID: 10181
		[Token(Token = "0x40027C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _parentObject;

		// Token: 0x040027C6 RID: 10182
		[Token(Token = "0x40027C6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _shouldGetBloody;

		// Token: 0x040027C7 RID: 10183
		[Token(Token = "0x40027C7")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _spawnedItem;
	}
}
