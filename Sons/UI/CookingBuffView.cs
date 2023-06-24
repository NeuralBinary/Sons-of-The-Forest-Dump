using System;
using System.Collections.Generic;
using Assemblies.Sons.Items.Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.UI
{
	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	[AddComponentMenu("Sons/UI/CookingBuffView")]
	public class CookingBuffView : MonoBehaviour
	{
		// Token: 0x06002110 RID: 8464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002110")]
		[Address(RVA = "0x3321CA0", Offset = "0x33202A0", VA = "0x183321CA0")]
		public void Initialize(CookingBuffs.CookingBuffData buffData, int tierLevel)
		{
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002111")]
		[Address(RVA = "0x3321E00", Offset = "0x3320400", VA = "0x183321E00")]
		public CookingBuffView()
		{
		}

		// Token: 0x04001EA4 RID: 7844
		[Token(Token = "0x4001EA4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage _icon;

		// Token: 0x04001EA5 RID: 7845
		[Token(Token = "0x4001EA5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RawImage _iconBackground;

		// Token: 0x04001EA6 RID: 7846
		[Token(Token = "0x4001EA6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _tierArrows;
	}
}
