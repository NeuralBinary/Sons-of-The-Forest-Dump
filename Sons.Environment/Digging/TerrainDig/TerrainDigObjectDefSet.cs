using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[CreateAssetMenu(menuName = "Sons/Digging/TerrainDigObjectDefSet", fileName = "TerrainDigObjectDefSet", order = 0)]
	public class TerrainDigObjectDefSet : ScriptableObject
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000012")]
		public List<TerrainDigObjectDef> TerrainDigObjectDefs
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2FC7130", Offset = "0x2FC5730", VA = "0x182FC7130")]
		private void OnValidate()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2FC73D0", Offset = "0x2FC59D0", VA = "0x182FC73D0")]
		public TerrainDigObjectDef FindOrFirst(int prominentTerrainLayer)
		{
			return null;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public TerrainDigObjectDefSet()
		{
		}
	}
}
