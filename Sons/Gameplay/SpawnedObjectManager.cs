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
	// Token: 0x020007F4 RID: 2036
	[Token(Token = "0x20007F4")]
	[AddComponentMenu("Gameplay/SpawnedObjectManager")]
	public class SpawnedObjectManager : SingletonBehaviour<SpawnedObjectManager>
	{
		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x00010710 File Offset: 0x0000E910
		// (set) Token: 0x06003713 RID: 14099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D2")]
		public static bool ShowStats
		{
			[Token(Token = "0x6003712")]
			[Address(RVA = "0x35385F0", Offset = "0x3536BF0", VA = "0x1835385F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003713")]
			[Address(RVA = "0x3538630", Offset = "0x3536C30", VA = "0x183538630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003714")]
		[Address(RVA = "0x3538670", Offset = "0x3536C70", VA = "0x183538670")]
		public static void SetShowStats(bool value)
		{
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003715")]
		[Address(RVA = "0x35386B0", Offset = "0x3536CB0", VA = "0x1835386B0")]
		private void Start()
		{
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003716")]
		[Address(RVA = "0x3538890", Offset = "0x3536E90", VA = "0x183538890")]
		private SpawnedObjectManager.SpawnedObjectList GetList(SpawnedObjectTag.TagType tagType)
		{
			return null;
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x35389E0", Offset = "0x3536FE0", VA = "0x1835389E0")]
		public void OnObjectSpawn(SpawnedObjectTag spawnedObject)
		{
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003718")]
		[Address(RVA = "0x3538AB0", Offset = "0x35370B0", VA = "0x183538AB0")]
		public void OnObjectDespawn(SpawnedObjectTag spawnedObject)
		{
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003719")]
		[Address(RVA = "0x3538B60", Offset = "0x3537160", VA = "0x183538B60")]
		private void ClearObject(Transform removeTr, bool virtualize)
		{
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371A")]
		[Address(RVA = "0x3538D60", Offset = "0x3537360", VA = "0x183538D60")]
		private IEnumerator ManageSpawnedObjects()
		{
			return null;
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371B")]
		[Address(RVA = "0x3538DF0", Offset = "0x35373F0", VA = "0x183538DF0")]
		private void ClearFurthestObjectFromPlayer(SpawnedObjectManager.SpawnedObjectList list)
		{
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371C")]
		[Address(RVA = "0x3539230", Offset = "0x3537830", VA = "0x183539230")]
		public static void DrawDebugStats()
		{
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371D")]
		[Address(RVA = "0x3539290", Offset = "0x3537890", VA = "0x183539290")]
		private void DrawDebugStatsInternal()
		{
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371E")]
		[Address(RVA = "0x35397B0", Offset = "0x3537DB0", VA = "0x1835397B0")]
		public SpawnedObjectManager()
		{
		}

		// Token: 0x04002F90 RID: 12176
		[Token(Token = "0x4002F90")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SpawnedObjectManager.SpawnedObjectList> _types;

		// Token: 0x04002F91 RID: 12177
		[Token(Token = "0x4002F91")]
		private const float TickRate = 0.5f;

		// Token: 0x04002F92 RID: 12178
		[Token(Token = "0x4002F92")]
		private const string PickupsPoolId = "PickUps";

		// Token: 0x04002F93 RID: 12179
		[Token(Token = "0x4002F93")]
		[FieldOffset(Offset = "0x30")]
		private SpawnPool _pickupPool;

		// Token: 0x020007F5 RID: 2037
		[Token(Token = "0x20007F5")]
		[Serializable]
		public class SpawnedObjectList
		{
			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x0600371F RID: 14111 RVA: 0x00010728 File Offset: 0x0000E928
			// (set) Token: 0x06003720 RID: 14112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006D3")]
			public bool Virtualize
			{
				[Token(Token = "0x600371F")]
				[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003720")]
				[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06003721 RID: 14113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003721")]
			[Address(RVA = "0x3539810", Offset = "0x3537E10", VA = "0x183539810")]
			public void Add(Transform tr)
			{
			}

			// Token: 0x06003722 RID: 14114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003722")]
			[Address(RVA = "0x3539880", Offset = "0x3537E80", VA = "0x183539880")]
			public void Remove(Transform tr)
			{
			}

			// Token: 0x06003723 RID: 14115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003723")]
			[Address(RVA = "0x35398E0", Offset = "0x3537EE0", VA = "0x1835398E0")]
			public void ClearNulls()
			{
			}

			// Token: 0x06003724 RID: 14116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003724")]
			[Address(RVA = "0x3539A50", Offset = "0x3538050", VA = "0x183539A50")]
			public SpawnedObjectList()
			{
			}

			// Token: 0x04002F95 RID: 12181
			[Token(Token = "0x4002F95")]
			[FieldOffset(Offset = "0x10")]
			public SpawnedObjectTag.TagType _type;

			// Token: 0x04002F96 RID: 12182
			[Token(Token = "0x4002F96")]
			[FieldOffset(Offset = "0x14")]
			public int _maxSpawned;

			// Token: 0x04002F98 RID: 12184
			[Token(Token = "0x4002F98")]
			[FieldOffset(Offset = "0x20")]
			public List<Transform> _spawnedObjects;
		}
	}
}
