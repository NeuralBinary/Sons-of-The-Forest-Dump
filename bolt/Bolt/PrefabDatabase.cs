using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[CreateAssetMenu(menuName = "Bolt/Prefab Database", fileName = "BoltPrefabDatabase", order = 0)]
	public class PrefabDatabase : ScriptableObject
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000BD")]
		public static PrefabDatabase Instance
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x8DBE90", Offset = "0x8DA490", VA = "0x1808DBE90")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x8DC140", Offset = "0x8DA740", VA = "0x1808DC140")]
		internal static void BuildCache()
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x8DC160", Offset = "0x8DA760", VA = "0x1808DC160")]
		private static void UpdateLookup()
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x8DC720", Offset = "0x8DAD20", VA = "0x1808DC720")]
		private static void LoadInstance()
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x8DC8D0", Offset = "0x8DAED0", VA = "0x1808DC8D0")]
		public static GameObject Find(PrefabId id)
		{
			return null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x8DCA90", Offset = "0x8DB090", VA = "0x1808DCA90")]
		internal static bool Contains(BoltEntity entity)
		{
			return default(bool);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x8DCCE0", Offset = "0x8DB2E0", VA = "0x1808DCCE0")]
		public PrefabDatabase()
		{
		}

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x0")]
		private static PrefabDatabase _instance;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<PrefabId, GameObject> _lookup;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal PrefabDatabaseMode DatabaseMode;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal GameObject[] Prefabs;
	}
}
