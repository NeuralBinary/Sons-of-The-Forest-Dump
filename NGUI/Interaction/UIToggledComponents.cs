using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/Interaction/Toggled Components")]
	[RequireComponent(typeof(UIToggle))]
	public class UIToggledComponents : MonoBehaviour
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x26E0CA0", Offset = "0x26DF2A0", VA = "0x1826E0CA0")]
		private void Awake()
		{
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x26E0EE0", Offset = "0x26DF4E0", VA = "0x1826E0EE0")]
		public void Toggle()
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIToggledComponents()
		{
		}

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x20")]
		public List<MonoBehaviour> activate;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0x28")]
		public List<MonoBehaviour> deactivate;

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private MonoBehaviour target;

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		private bool inverse;
	}
}
