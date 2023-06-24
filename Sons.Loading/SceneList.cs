using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Loading
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[CreateAssetMenu(fileName = "SceneList", menuName = "Sons/Loading/SceneList", order = 0)]
	public class SceneList : ScriptableObject
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x17000007")]
		public int Count
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x30B7C70", Offset = "0x30B6270", VA = "0x1830B7C70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public IReadOnlyList<string> GetSceneNames()
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public SceneList()
		{
		}

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<string> _sceneNames;
	}
}
