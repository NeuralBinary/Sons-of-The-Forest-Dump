using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	public interface IWorldEventsSystem
	{
		// Token: 0x0600059C RID: 1436
		[Token(Token = "0x600059C")]
		void OnPlayerSighted(WorldSimActor actor);

		// Token: 0x0600059D RID: 1437
		[Token(Token = "0x600059D")]
		void OnSave(VailWorldSimulation.WorldEventsSaveData saveData);

		// Token: 0x0600059E RID: 1438
		[Token(Token = "0x600059E")]
		void OnLoad(VailWorldSimulation.WorldEventsSaveData saveData);

		// Token: 0x0600059F RID: 1439
		[Token(Token = "0x600059F")]
		void OnCameraShakeEvent(Vector3 position, float range);

		// Token: 0x060005A0 RID: 1440
		[Token(Token = "0x60005A0")]
		void OnHelicopterPickup();
	}
}
