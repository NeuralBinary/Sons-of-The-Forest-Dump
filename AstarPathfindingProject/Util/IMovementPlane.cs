using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000137")]
	public interface IMovementPlane
	{
		// Token: 0x060009D3 RID: 2515
		[Token(Token = "0x60009D3")]
		Vector2 ToPlane(Vector3 p);

		// Token: 0x060009D4 RID: 2516
		[Token(Token = "0x60009D4")]
		Vector2 ToPlane(Vector3 p, out float elevation);

		// Token: 0x060009D5 RID: 2517
		[Token(Token = "0x60009D5")]
		Vector3 ToWorld(Vector2 p, float elevation = 0f);
	}
}
