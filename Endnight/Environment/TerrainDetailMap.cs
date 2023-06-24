using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Environment
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	[CreateAssetMenu(fileName = "TerrainDetailMap", menuName = "Sons/Environment/TerrainDetailMap", order = 0)]
	public class TerrainDetailMap : ScriptableObject
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000045")]
		public IReadOnlyList<TerrainDetail> Details
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046E")]
		[Address(RVA = "0xAA8CC0", Offset = "0xAA72C0", VA = "0x180AA8CC0")]
		public void Add(TerrainDetail detail)
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x600046F")]
		[Address(RVA = "0xAA8DF0", Offset = "0xAA73F0", VA = "0x180AA8DF0")]
		public int GetCount()
		{
			return 0;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000470")]
		[Address(RVA = "0xAA8E30", Offset = "0xAA7430", VA = "0x180AA8E30")]
		public void Clear()
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public TerrainDetailMap()
		{
		}

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<TerrainDetail> _details;
	}
}
