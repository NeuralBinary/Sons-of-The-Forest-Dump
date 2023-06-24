using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	[AddComponentMenu("NGUI/Interaction/Toggled Objects")]
	public class UIToggledObjects : MonoBehaviour
	{
		// Token: 0x060007D7 RID: 2007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x26E11A0", Offset = "0x26DF7A0", VA = "0x1826E11A0")]
		private void Awake()
		{
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x26E13E0", Offset = "0x26DF9E0", VA = "0x1826E13E0")]
		public void Toggle()
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x26E15C0", Offset = "0x26DFBC0", VA = "0x1826E15C0")]
		private void Set(GameObject go, bool state)
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIToggledObjects()
		{
		}

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x20")]
		public List<GameObject> activate;

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x28")]
		public List<GameObject> deactivate;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private GameObject target;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private bool inverse;
	}
}
