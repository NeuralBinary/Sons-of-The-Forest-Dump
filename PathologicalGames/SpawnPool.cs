using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[AddComponentMenu("Path-o-logical/PoolManager/SpawnPool")]
	public sealed class SpawnPool : MonoBehaviour, IList<Transform>, ICollection<Transform>, IEnumerable<Transform>, IEnumerable
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002400 File Offset: 0x00000600
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public bool dontDestroyOnLoad
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x28B5CB0", Offset = "0x28B42B0", VA = "0x1828B5CB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x28B5CC0", Offset = "0x28B42C0", VA = "0x1828B5CC0")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public Transform group
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000027")]
		public Dictionary<string, PrefabPool> prefabPools
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x28B5F50", Offset = "0x28B4550", VA = "0x1828B5F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x28B6170", Offset = "0x28B4770", VA = "0x1828B6170")]
		private void Awake()
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x28B6A40", Offset = "0x28B5040", VA = "0x1828B6A40")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x28B6E20", Offset = "0x28B5420", VA = "0x1828B6E20")]
		public void CreatePrefabPool(PrefabPool prefabPool)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x28B7160", Offset = "0x28B5760", VA = "0x1828B7160")]
		public void Add(Transform instance, string prefabName, bool despawn, bool parent)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x28B74B0", Offset = "0x28B5AB0", VA = "0x1828B74B0", Slot = "11")]
		public void Add(Transform item)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x28B7500", Offset = "0x28B5B00", VA = "0x1828B7500")]
		public void Remove(Transform item)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x28B7550", Offset = "0x28B5B50", VA = "0x1828B7550")]
		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x28B7620", Offset = "0x28B5C20", VA = "0x1828B7620")]
		private Transform SpawnFromNew(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x28B78B0", Offset = "0x28B5EB0", VA = "0x1828B78B0")]
		private bool TrySpawnFromPool(Transform prefab, Vector3 pos, Quaternion rot, Transform parent, out Transform spawn)
		{
			return default(bool);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x28B7F30", Offset = "0x28B6530", VA = "0x1828B7F30")]
		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x28B80B0", Offset = "0x28B66B0", VA = "0x1828B80B0")]
		public Transform Spawn(Transform prefab)
		{
			return null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x28B8170", Offset = "0x28B6770", VA = "0x1828B8170")]
		public Transform Spawn(Transform prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x28B82B0", Offset = "0x28B68B0", VA = "0x1828B82B0")]
		public Transform Spawn(string prefabName)
		{
			return null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x28B82F0", Offset = "0x28B68F0", VA = "0x1828B82F0")]
		public Transform Spawn(string prefabName, Transform parent)
		{
			return null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x28B8450", Offset = "0x28B6A50", VA = "0x1828B8450")]
		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x28B84D0", Offset = "0x28B6AD0", VA = "0x1828B84D0")]
		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x28B85D0", Offset = "0x28B6BD0", VA = "0x1828B85D0")]
		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x28B8610", Offset = "0x28B6C10", VA = "0x1828B8610")]
		public AudioSource Spawn(AudioSource prefab)
		{
			return null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x28B86E0", Offset = "0x28B6CE0", VA = "0x1828B86E0")]
		public AudioSource Spawn(AudioSource prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x28B87B0", Offset = "0x28B6DB0", VA = "0x1828B87B0")]
		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x28B8B00", Offset = "0x28B7100", VA = "0x1828B8B00")]
		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x28B8B40", Offset = "0x28B7140", VA = "0x1828B8B40")]
		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x28B8E50", Offset = "0x28B7450", VA = "0x1828B8E50")]
		public void Despawn(Transform instance)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x28B8E60", Offset = "0x28B7460", VA = "0x1828B8E60")]
		public bool IsMaxInstancesReached(Transform instance)
		{
			return default(bool);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x28B8FE0", Offset = "0x28B75E0", VA = "0x1828B8FE0")]
		private void DespawnInternal(Transform instance)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x28B9390", Offset = "0x28B7990", VA = "0x1828B9390")]
		public void KillInstance(Transform instance)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x28B9640", Offset = "0x28B7C40", VA = "0x1828B9640")]
		public void Despawn(Transform instance, Transform parent)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x28B9690", Offset = "0x28B7C90", VA = "0x1828B9690")]
		public void Despawn(Transform instance, float seconds)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x28B96C0", Offset = "0x28B7CC0", VA = "0x1828B96C0")]
		public void Despawn(Transform instance, float seconds, Transform parent)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x28B9700", Offset = "0x28B7D00", VA = "0x1828B9700")]
		private IEnumerator DoDespawnAfterSeconds(Transform instance, float seconds, bool useParent, Transform parent)
		{
			return null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x28B9880", Offset = "0x28B7E80", VA = "0x1828B9880")]
		public void DespawnAll()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x28B9960", Offset = "0x28B7F60", VA = "0x1828B9960")]
		public bool IsSpawned(Transform instance)
		{
			return default(bool);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x28B99B0", Offset = "0x28B7FB0", VA = "0x1828B99B0")]
		public PrefabPool GetPrefabPool(Transform prefab)
		{
			return null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x28B9C90", Offset = "0x28B8290", VA = "0x1828B9C90")]
		public PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x28B9F50", Offset = "0x28B8550", VA = "0x1828B9F50")]
		public Transform GetPrefab(Transform instance)
		{
			return null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x28BA050", Offset = "0x28B8650", VA = "0x1828BA050")]
		public GameObject GetPrefab(GameObject instance)
		{
			return null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x28BA1B0", Offset = "0x28B87B0", VA = "0x1828BA1B0")]
		private IEnumerator ListForAudioStop(AudioSource src)
		{
			return null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x28BA2B0", Offset = "0x28B88B0", VA = "0x1828BA2B0")]
		private IEnumerator ListenForEmitDespawn(ParticleSystem emitter)
		{
			return null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x28BA3B0", Offset = "0x28B89B0", VA = "0x1828BA3B0")]
		public void SetMasterCullAbove(int value)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x28BA520", Offset = "0x28B8B20", VA = "0x1828BA520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000028 RID: 40
		[Token(Token = "0x17000028")]
		public Transform this[int index]
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x28BA8A0", Offset = "0x28B8EA0", VA = "0x1828BA8A0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x28BA910", Offset = "0x28B8F10", VA = "0x1828BA910", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x28BA960", Offset = "0x28B8F60", VA = "0x1828BA960", Slot = "13")]
		public bool Contains(Transform item)
		{
			return default(bool);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x28BA9B0", Offset = "0x28B8FB0", VA = "0x1828BA9B0", Slot = "14")]
		public void CopyTo(Transform[] array, int arrayIndex)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x17000029")]
		public int Count
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x28BAA30", Offset = "0x28B9030", VA = "0x1828BAA30", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x28BAA70", Offset = "0x28B9070", VA = "0x1828BAA70", Slot = "16")]
		public IEnumerator<Transform> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x28BAB00", Offset = "0x28B9100", VA = "0x1828BAB00", Slot = "17")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x28BAB90", Offset = "0x28B9190", VA = "0x1828BAB90", Slot = "6")]
		public int IndexOf(Transform item)
		{
			return 0;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x28BABD0", Offset = "0x28B91D0", VA = "0x1828BABD0", Slot = "7")]
		public void Insert(int index, Transform item)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x28BAC10", Offset = "0x28B9210", VA = "0x1828BAC10", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x28BAC50", Offset = "0x28B9250", VA = "0x1828BAC50", Slot = "12")]
		public void Clear()
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x1700002A")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x28BAC90", Offset = "0x28B9290", VA = "0x1828BAC90", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x28BACD0", Offset = "0x28B92D0", VA = "0x1828BACD0", Slot = "15")]
		private bool Remove(Transform item)
		{
			return default(bool);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x28BAD10", Offset = "0x28B9310", VA = "0x1828BAD10")]
		public SpawnPool()
		{
		}

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		private const string OnSpawnedMethodName = "OnSpawned";

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool DelayNextDisable;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform NextDisableTr;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x30")]
		public bool disableOnClient;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x31")]
		public bool disableOnServer;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x38")]
		public string poolName;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public bool _useDefaultPoolSettings;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public PrefabPool _defaultPoolSettings;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x50")]
		public bool matchPoolScale;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x51")]
		public bool matchPoolLayer;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x52")]
		public bool dontReparent;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x53")]
		public bool _dontDestroyOnLoad;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x54")]
		public bool logMessages;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x55")]
		public bool BroadcastOnSpawned;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x58")]
		public List<PrefabPool> _perPrefabPoolOptions;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<object, bool> prefabsFoldOutStates;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x68")]
		public float maxParticleDespawnTime;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x78")]
		public PrefabsDict prefabs;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<object, bool> _editorListItemStates;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x88")]
		private PrefabPool _lastDespawnPool;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x90")]
		private List<PrefabPool> _prefabPools;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x98")]
		internal List<Transform> _spawned;
	}
}
