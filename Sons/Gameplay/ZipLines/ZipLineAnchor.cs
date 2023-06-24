using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.ZipLines
{
	// Token: 0x02000821 RID: 2081
	[Token(Token = "0x2000821")]
	[AddComponentMenu("Sons/Gameplay/Ziplines/ZipLineAnchor")]
	public class ZipLineAnchor : MonoBehaviour
	{
		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06003A92 RID: 14994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079F")]
		public GameObject DismantleInteractionObject
		{
			[Token(Token = "0x6003A92")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A93")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ZipLineAnchor()
		{
		}

		// Token: 0x040031DC RID: 12764
		[Token(Token = "0x40031DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _dismantleInteractionObject;
	}
}
