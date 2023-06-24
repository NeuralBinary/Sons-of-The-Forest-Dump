using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	[AddComponentMenu("Sons/Ai/ActorSpawner")]
	public class ActorSpawner : MonoBehaviour
	{
		// Token: 0x06000707 RID: 1799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x2B45520", Offset = "0x2B43B20", VA = "0x182B45520")]
		public void SpawnActor(string actorName, VailActor srcActor)
		{
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000054D8 File Offset: 0x000036D8
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x2B45560", Offset = "0x2B43B60", VA = "0x182B45560")]
		public bool CanSpawnType(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x2B45710", Offset = "0x2B43D10", VA = "0x182B45710")]
		private ActorSpawner.SpawnableActor GetSpawnedActor(string actorName)
		{
			return null;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x2B45910", Offset = "0x2B43F10", VA = "0x182B45910")]
		private void UpdateSpawnedCounts()
		{
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x2B45A80", Offset = "0x2B44080", VA = "0x182B45A80")]
		private void SpawnActor(ActorSpawner.SpawnableActor spawned, VailActor srcActor)
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x2B461B0", Offset = "0x2B447B0", VA = "0x182B461B0")]
		public ActorSpawner()
		{
		}

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ActorSpawner.SpawnableActor> _spawnTypes;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _maxSmallSpawned;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _maxBigSpawned;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PushCollision _pushCollision;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x38")]
		private List<WorldSimActor> _spawnedActors;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<VailActorTypeId, int> _typeAlive;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<VailActorTypeId, int> _typeSpawned;

		// Token: 0x020000B4 RID: 180
		[Token(Token = "0x20000B4")]
		[Serializable]
		private class SpawnableActor
		{
			// Token: 0x0600070D RID: 1805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x2B463B0", Offset = "0x2B449B0", VA = "0x182B463B0")]
			public SpawnableActor()
			{
			}

			// Token: 0x04000584 RID: 1412
			[Token(Token = "0x4000584")]
			[FieldOffset(Offset = "0x10")]
			public string _name;

			// Token: 0x04000585 RID: 1413
			[Token(Token = "0x4000585")]
			[FieldOffset(Offset = "0x18")]
			public Transform _transform;

			// Token: 0x04000586 RID: 1414
			[Token(Token = "0x4000586")]
			[FieldOffset(Offset = "0x20")]
			public VailActor _prefab;

			// Token: 0x04000587 RID: 1415
			[Token(Token = "0x4000587")]
			[FieldOffset(Offset = "0x28")]
			public int _spawnCount;

			// Token: 0x04000588 RID: 1416
			[Token(Token = "0x4000588")]
			[FieldOffset(Offset = "0x2C")]
			public float _spreadAngle;
		}
	}
}
