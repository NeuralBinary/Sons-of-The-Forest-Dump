using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public interface ICollisionHandler
	{
		// Token: 0x06000187 RID: 391
		[Token(Token = "0x6000187")]
		void HandleCollision(GameObject obj, List<ParticleCollisionEvent> collision, int collisionCount);
	}
}
