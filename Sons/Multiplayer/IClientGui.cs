using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x0200053E RID: 1342
	[Token(Token = "0x200053E")]
	public interface IClientGui
	{
		// Token: 0x060023A2 RID: 9122
		[Token(Token = "0x60023A2")]
		void Dispose();

		// Token: 0x060023A3 RID: 9123
		[Token(Token = "0x60023A3")]
		void SetErrorText(string stringMessage);

		// Token: 0x060023A4 RID: 9124
		[Token(Token = "0x60023A4")]
		GameObject GetGameObject();
	}
}
