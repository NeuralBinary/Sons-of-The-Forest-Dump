using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006BC RID: 1724
	[Token(Token = "0x20006BC")]
	[AddComponentMenu("Gameplay/SpawnedObjectManager")]
	public class SpawnedObjectManager : SingletonBehaviour<SpawnedObjectManager>
	{
		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000594")]
		public static bool ShowStats
		{
			[Token(Token = "0x6002C45")]
			[Address(RVA = "0x2DF9900", Offset = "0x2DF8900", VA = "0x182DF9900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C46")]
			[Address(RVA = "0x2DF9940", Offset = "0x2DF8940", VA = "0x182DF9940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C47")]
		[Address(RVA = "0x2DF9760", Offset = "0x2DF8760", VA = "0x182DF9760")]
		public static void SetShowStats(bool value)
		{
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C48")]
		[Address(RVA = "0x2DF97A0", Offset = "0x2DF87A0", VA = "0x182DF97A0")]
		private void Start()
		{
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C49")]
		[Address(RVA = "0x2DF9430", Offset = "0x2DF8430", VA = "0x182DF9430")]
		private SpawnedObjectManager.SpawnedObjectList GetList(SpawnedObjectTag.TagType tagType)
		{
			return null;
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C4A")]
		[Address(RVA = "0x2DF9660", Offset = "0x2DF8660", VA = "0x182DF9660")]
		public void OnObjectSpawn(SpawnedObjectTag spawnedObject)
		{
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C4B")]
		[Address(RVA = "0x2DF95E0", Offset = "0x2DF85E0", VA = "0x182DF95E0")]
		public void OnObjectDespawn(SpawnedObjectTag spawnedObject)
		{
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C4C")]
		[Address(RVA = "0x2DF8F90", Offset = "0x2DF7F90", VA = "0x182DF8F90")]
		private void DeleteObject(Transform removeTr)
		{
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4D")]
		[Address(RVA = "0x2DF9570", Offset = "0x2DF8570", VA = "0x182DF9570")]
		private IEnumerator ManageSpawnedObjects()
		{
			return null;
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C4E")]
		[Address(RVA = "0x2DF8C50", Offset = "0x2DF7C50", VA = "0x182DF8C50")]
		private void DeleteFurthestObjectFromPlayer(SpawnedObjectManager.SpawnedObjectList list)
		{
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C4F")]
		[Address(RVA = "0x2DF93D0", Offset = "0x2DF83D0", VA = "0x182DF93D0")]
		public static void DrawDebugStats()
		{
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C50")]
		[Address(RVA = "0x2DF9040", Offset = "0x2DF8040", VA = "0x182DF9040")]
		private void DrawDebugStatsInternal()
		{
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C51")]
		[Address(RVA = "0x2DF98C0", Offset = "0x2DF88C0", VA = "0x182DF98C0")]
		public SpawnedObjectManager()
		{
		}

		// Token: 0x040027A8 RID: 10152
		[Token(Token = "0x40027A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SpawnedObjectManager.SpawnedObjectList> _types;

		// Token: 0x040027A9 RID: 10153
		[Token(Token = "0x40027A9")]
		private const float TickRate = 0.5f;

		// Token: 0x040027AA RID: 10154
		[Token(Token = "0x40027AA")]
		[FieldOffset(Offset = "0x30")]
		private SpawnPool _pickupPool;

		// Token: 0x020006BD RID: 1725
		[Token(Token = "0x20006BD")]
		[Serializable]
		public class SpawnedObjectList
		{
			// Token: 0x06002C52 RID: 11346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C52")]
			[Address(RVA = "0x2DF89B0", Offset = "0x2DF79B0", VA = "0x182DF89B0")]
			public void Add(Transform tr)
			{
			}

			// Token: 0x06002C53 RID: 11347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C53")]
			[Address(RVA = "0x2DF8B70", Offset = "0x2DF7B70", VA = "0x182DF8B70")]
			public void Remove(Transform tr)
			{
			}

			// Token: 0x06002C54 RID: 11348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C54")]
			[Address(RVA = "0x2DF8A90", Offset = "0x2DF7A90", VA = "0x182DF8A90")]
			public void ClearNulls()
			{
			}

			// Token: 0x06002C55 RID: 11349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002C55")]
			[Address(RVA = "0x2DF8BD0", Offset = "0x2DF7BD0", VA = "0x182DF8BD0")]
			public SpawnedObjectList()
			{
			}

			// Token: 0x040027AC RID: 10156
			[Token(Token = "0x40027AC")]
			[FieldOffset(Offset = "0x10")]
			public SpawnedObjectTag.TagType _type;

			// Token: 0x040027AD RID: 10157
			[Token(Token = "0x40027AD")]
			[FieldOffset(Offset = "0x14")]
			public int _maxSpawned;

			// Token: 0x040027AE RID: 10158
			[Token(Token = "0x40027AE")]
			[FieldOffset(Offset = "0x18")]
			public List<Transform> _spawnedObjects;
		}
	}
}
