using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	[AddComponentMenu("Sons/Construction/StructureResistanceDebug")]
	public class StructureResistanceDebug : MonoBehaviour
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2DCA180", Offset = "0x2DC8780", VA = "0x182DCA180")]
		private void Awake()
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x2DCA270", Offset = "0x2DC8870", VA = "0x182DCA270")]
		private void OnDestroy()
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2DCA2D0", Offset = "0x2DC88D0", VA = "0x182DCA2D0")]
		private void OnGUI()
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x26AB660", Offset = "0x26A9C60", VA = "0x1826AB660")]
		private void ToggleStructureResistanceDebug(bool show)
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2DCAD50", Offset = "0x2DC9350", VA = "0x182DCAD50")]
		public StructureResistanceDebug()
		{
		}

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x20")]
		private List<Structure> _displayed;
	}
}
