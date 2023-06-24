using System;
using Bolt;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class BoltPrefabPoolManager : SingletonBehaviour<BoltPrefabPoolManager>, IPrefabPool
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
		public override bool GetDontDestroyOnLoad()
		{
			return default(bool);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
		public override bool HideDontDestroyOnLoadProperty()
		{
			return default(bool);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x30D56F0", Offset = "0x30D3CF0", VA = "0x1830D56F0", Slot = "11")]
		private GameObject Instantiate(PrefabId prefabId, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x8EA3D0", Offset = "0x8E89D0", VA = "0x1808EA3D0", Slot = "10")]
		private GameObject LoadPrefab(PrefabId prefabId)
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x30D5820", Offset = "0x30D3E20", VA = "0x1830D5820", Slot = "12")]
		private void Destroy(GameObject gameObject)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x30D5870", Offset = "0x30D3E70", VA = "0x1830D5870")]
		public static BoltPrefabPoolManager CreateInstance()
		{
			return null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x30D58A0", Offset = "0x30D3EA0", VA = "0x1830D58A0")]
		public static void Dispose()
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x30D59E0", Offset = "0x30D3FE0", VA = "0x1830D59E0")]
		private void DisposeInternal()
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x30D5AC0", Offset = "0x30D40C0", VA = "0x1830D5AC0")]
		public static void Initialize()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x30D5B70", Offset = "0x30D4170", VA = "0x1830D5B70")]
		public BoltPrefabPoolManager()
		{
		}
	}
}
