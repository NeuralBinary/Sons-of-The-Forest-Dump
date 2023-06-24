using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	public interface ITransform
	{
		// Token: 0x060009D6 RID: 2518
		[Token(Token = "0x60009D6")]
		Vector3 Transform(Vector3 position);

		// Token: 0x060009D7 RID: 2519
		[Token(Token = "0x60009D7")]
		Vector3 InverseTransform(Vector3 position);
	}
}
