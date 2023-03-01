using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.GPS
{
	// Token: 0x02000709 RID: 1801
	[Token(Token = "0x2000709")]
	public class GpsLocatorRegister : MonoBehaviour
	{
		// Token: 0x06002EDD RID: 11997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDD")]
		[Address(RVA = "0x2E344A0", Offset = "0x2E334A0", VA = "0x182E344A0")]
		private void FindLocatorsInScene()
		{
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDE")]
		[Address(RVA = "0x2E34610", Offset = "0x2E33610", VA = "0x182E34610")]
		private void OnEnable()
		{
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDF")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public GpsLocatorRegister()
		{
		}

		// Token: 0x0400297C RID: 10620
		[Token(Token = "0x400297C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GPSLocator> _locators;
	}
}
