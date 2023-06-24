using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class DemoGUIMessage : MonoBehaviour
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x28EF6F0", Offset = "0x28EDCF0", VA = "0x1828EF6F0")]
		private void OnGUI()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x28EF870", Offset = "0x28EDE70", VA = "0x1828EF870")]
		public DemoGUIMessage()
		{
		}

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x20")]
		public string text;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x28")]
		public Color color;
	}
}
