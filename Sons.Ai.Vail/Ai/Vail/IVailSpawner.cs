using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public interface IVailSpawner : ISpawner, IActorZone
	{
		// Token: 0x0600056E RID: 1390
		[Token(Token = "0x600056E")]
		void OnActorDied(WorldSimActor actor, bool killedByPlayer);

		// Token: 0x0600056F RID: 1391
		[Token(Token = "0x600056F")]
		void OnActorInitialized(VailActor actor);

		// Token: 0x06000570 RID: 1392
		[Token(Token = "0x6000570")]
		WorldSimActor SpawnNewActor(int familyId = 0);

		// Token: 0x06000571 RID: 1393
		[Token(Token = "0x6000571")]
		void OnPostLoad();

		// Token: 0x06000572 RID: 1394
		[Token(Token = "0x6000572")]
		bool CanSpawn();

		// Token: 0x06000573 RID: 1395
		[Token(Token = "0x6000573")]
		IActorZone GetConnectedZone(WorldTeleport.TeleportZone zoneId);

		// Token: 0x06000574 RID: 1396
		[Token(Token = "0x6000574")]
		VailZoneBase GetSpawnerZone();

		// Token: 0x06000575 RID: 1397
		[Token(Token = "0x6000575")]
		WorldSimController GetWorldSimControllerOverride();

		// Token: 0x06000576 RID: 1398
		[Token(Token = "0x6000576")]
		Vector3 RandomPositionInSpawnVolume();

		// Token: 0x06000577 RID: 1399
		[Token(Token = "0x6000577")]
		float FamilyClusterRadius();

		// Token: 0x06000578 RID: 1400
		[Token(Token = "0x6000578")]
		int VariationSubSet();
	}
}
