using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.GPS
{
	// Token: 0x02000857 RID: 2135
	[Token(Token = "0x2000857")]
	public class GpsLocatorRegister : MonoBehaviour
	{
		// Token: 0x06003CD7 RID: 15575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD7")]
		[Address(RVA = "0x35ACDF0", Offset = "0x35AB3F0", VA = "0x1835ACDF0")]
		private void FindLocatorsInScene()
		{
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD8")]
		[Address(RVA = "0x35AD050", Offset = "0x35AB650", VA = "0x1835AD050")]
		private void OnEnable()
		{
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD9")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public GpsLocatorRegister()
		{
		}

		// Token: 0x04003364 RID: 13156
		[Token(Token = "0x4003364")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GPSLocator> _locators;
	}
}
