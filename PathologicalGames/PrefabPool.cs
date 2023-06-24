using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[Serializable]
	public class PrefabPool
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x17000035")]
		public bool logMessages
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x28BBD10", Offset = "0x28BA310", VA = "0x1828BBD10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x28BBD50", Offset = "0x28BA350", VA = "0x1828BBD50")]
		public PrefabPool(Transform prefab)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x28BC020", Offset = "0x28BA620", VA = "0x1828BC020")]
		public PrefabPool(Transform prefab, PrefabPool defaultPoolSettings)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x28BC360", Offset = "0x28BA960", VA = "0x1828BC360")]
		public PrefabPool()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x28BC530", Offset = "0x28BAB30", VA = "0x1828BC530")]
		internal void inspectorInstanceConstructor()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x28BC710", Offset = "0x28BAD10", VA = "0x1828BC710")]
		internal void SelfDestruct()
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000036")]
		public List<Transform> spawned
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x28BCC30", Offset = "0x28BB230", VA = "0x1828BCC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000037")]
		public List<Transform> despawned
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x28BCCA0", Offset = "0x28BB2A0", VA = "0x1828BCCA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x17000038")]
		public int totalCount
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x28BCD10", Offset = "0x28BB310", VA = "0x1828BCD10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002580 File Offset: 0x00000780
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		internal bool preloaded
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x270DEE0", Offset = "0x270C4E0", VA = "0x18270DEE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x270DEF0", Offset = "0x270C4F0", VA = "0x18270DEF0")]
			private set
			{
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x28BCD60", Offset = "0x28BB360", VA = "0x1828BCD60")]
		public bool DespawnInstance(Transform xform)
		{
			return default(bool);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x28BCD90", Offset = "0x28BB390", VA = "0x1828BCD90")]
		internal bool DespawnInstance(Transform xform, bool sendEventMessage)
		{
			return default(bool);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x28BD260", Offset = "0x28BB860", VA = "0x1828BD260")]
		internal IEnumerator DelayedlDespawned(Transform xform)
		{
			return null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x28BD360", Offset = "0x28BB960", VA = "0x1828BD360")]
		internal IEnumerator CullDespawned(bool regularCulling = true)
		{
			return null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x28BD420", Offset = "0x28BBA20", VA = "0x1828BD420")]
		internal Transform SpawnInstance(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x28BD8F0", Offset = "0x28BBEF0", VA = "0x1828BD8F0")]
		public Transform SpawnNew()
		{
			return null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x28BD9A0", Offset = "0x28BBFA0", VA = "0x1828BD9A0")]
		private Transform InstantiateOrUnload(Transform prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x28BDA40", Offset = "0x28BC040", VA = "0x1828BDA40")]
		public Transform SpawnNew(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x28BE250", Offset = "0x28BC850", VA = "0x1828BE250")]
		private PoolLink AddPoolLink(Transform inst)
		{
			return null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Conditional("UNITY_EDITOR")]
		private void AddPoolLinkToPrefabAsset()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x28BE340", Offset = "0x28BC940", VA = "0x1828BE340")]
		private void SetRecursively(Transform xform, int layer)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x28BE620", Offset = "0x28BCC20", VA = "0x1828BE620")]
		internal void AddUnpooled(Transform inst, bool despawn)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x28BE730", Offset = "0x28BCD30", VA = "0x1828BE730")]
		internal void PreloadInstances()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x28BEB70", Offset = "0x28BD170", VA = "0x1828BEB70")]
		private IEnumerator PreloadOverTime()
		{
			return null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x28BEC00", Offset = "0x28BD200", VA = "0x1828BEC00")]
		public bool Contains(Transform transform)
		{
			return default(bool);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x28BEE10", Offset = "0x28BD410", VA = "0x1828BEE10")]
		private void nameInstance(Transform instance)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x28BEF70", Offset = "0x28BD570", VA = "0x1828BEF70")]
		public bool IsMaxInstancesReached()
		{
			return default(bool);
		}

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x10")]
		public Transform prefab;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x18")]
		internal GameObject prefabGO;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x20")]
		public int preloadAmount;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x24")]
		public bool preloadTime;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x28")]
		public int preloadFrames;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x2C")]
		public float preloadDelay;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x30")]
		public bool limitInstances;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x34")]
		public int limitAmount;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x38")]
		public bool limitFIFO;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x39")]
		public bool cullDespawned;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x3C")]
		public int cullAbove;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x40")]
		public int masterCullAbove;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x44")]
		public int cullDelay;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x48")]
		public int cullMaxPerPass;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x4C")]
		public bool _logMessages;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x4D")]
		private bool forceLoggingSilent;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x50")]
		public SpawnPool spawnPool;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x58")]
		public bool cullingActive;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x60")]
		internal List<Transform> _spawned;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x68")]
		internal List<Transform> _despawned;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x70")]
		internal int _delayedDespawnedCount;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x74")]
		private bool _preloaded;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x78")]
		private WaitForSeconds delayedDespawn;
	}
}
