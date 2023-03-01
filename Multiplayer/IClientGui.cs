using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000535 RID: 1333
	[Token(Token = "0x2000535")]
	public interface IClientGui
	{
		// Token: 0x060022AE RID: 8878
		[Token(Token = "0x60022AE")]
		void Dispose();

		// Token: 0x060022AF RID: 8879
		[Token(Token = "0x60022AF")]
		void SetErrorText(string stringMessage);

		// Token: 0x060022B0 RID: 8880
		[Token(Token = "0x60022B0")]
		GameObject GetGameObject();
	}
}
