using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Cutscenes;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000928 RID: 2344
	[Token(Token = "0x2000928")]
	public class AutoRegisterCutscenes : MonoBehaviour
	{
		// Token: 0x0600434E RID: 17230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434E")]
		[Address(RVA = "0x3643F10", Offset = "0x3642510", VA = "0x183643F10")]
		private void Start()
		{
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AutoRegisterCutscenes()
		{
		}

		// Token: 0x0400468A RID: 18058
		[Token(Token = "0x400468A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Cutscene> _cutscenes;
	}
}
