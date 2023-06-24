using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.CoM
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public interface IMassAffector
	{
		// Token: 0x06000003 RID: 3
		[Token(Token = "0x6000003")]
		string GetName();

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		float GetMass();

		// Token: 0x06000005 RID: 5
		[Token(Token = "0x6000005")]
		Vector3 GetPosition();
	}
}
