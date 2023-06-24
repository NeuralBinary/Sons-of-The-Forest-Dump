using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[AddComponentMenu("Sons/Gui/ForceGuiSelection")]
	public class ForceGuiSelection : MonoBehaviour
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x3007460", Offset = "0x3005A60", VA = "0x183007460")]
		private void OnEnable()
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ForceGuiSelection()
		{
		}

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _target;
	}
}
