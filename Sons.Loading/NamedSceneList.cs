using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Loading
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[Serializable]
	public class NamedSceneList
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x131BF20", Offset = "0x131A520", VA = "0x18131BF20")]
		public IReadOnlyList<string> GetSceneNames()
		{
			return null;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000005")]
		public string Id
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x17000006")]
		public int Count
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x30B78E0", Offset = "0x30B5EE0", VA = "0x1830B78E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x30B79E0", Offset = "0x30B5FE0", VA = "0x1830B79E0")]
		public bool Matches(string id)
		{
			return default(bool);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NamedSceneList()
		{
		}

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _id;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SceneList _sceneList;
	}
}
