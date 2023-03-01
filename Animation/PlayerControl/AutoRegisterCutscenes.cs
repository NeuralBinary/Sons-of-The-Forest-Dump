using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Cutscenes;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008B6 RID: 2230
	[Token(Token = "0x20008B6")]
	public class AutoRegisterCutscenes : MonoBehaviour
	{
		// Token: 0x06003C1B RID: 15387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1B")]
		[Address(RVA = "0x2F0D610", Offset = "0x2F0C610", VA = "0x182F0D610")]
		private void Start()
		{
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1C")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public AutoRegisterCutscenes()
		{
		}

		// Token: 0x0400405B RID: 16475
		[Token(Token = "0x400405B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Cutscene> _cutscenes;
	}
}
