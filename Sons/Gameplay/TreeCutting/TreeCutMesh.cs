using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x02000836 RID: 2102
	[Token(Token = "0x2000836")]
	[Serializable]
	public class TreeCutMesh
	{
		// Token: 0x06003B81 RID: 15233 RVA: 0x00012228 File Offset: 0x00010428
		[Token(Token = "0x6003B81")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
		public TreeCutCellRemovedFlags GetRemovedFlags()
		{
			return TreeCutCellRemovedFlags.Undefined;
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B82")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		[ItemCanBeNull]
		public List<Mesh> GetMesh()
		{
			return null;
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B83")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TreeCutMesh()
		{
		}

		// Token: 0x0400329E RID: 12958
		[Token(Token = "0x400329E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TreeCutCellRemovedFlags _removedFlags;

		// Token: 0x0400329F RID: 12959
		[Token(Token = "0x400329F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Mesh> _cellMesh;
	}
}
