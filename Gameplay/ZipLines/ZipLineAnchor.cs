using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.ZipLines
{
	// Token: 0x020006D5 RID: 1749
	[Token(Token = "0x20006D5")]
	[AddComponentMenu("Sons/Gameplay/Ziplines/ZipLineAnchor")]
	public class ZipLineAnchor : MonoBehaviour
	{
		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059C")]
		public GameObject DismantleInteractionObject
		{
			[Token(Token = "0x6002CAF")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB0")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ZipLineAnchor()
		{
		}

		// Token: 0x040027FE RID: 10238
		[Token(Token = "0x40027FE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _dismantleInteractionObject;
	}
}
