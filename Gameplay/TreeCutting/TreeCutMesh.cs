using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006EA RID: 1770
	[Token(Token = "0x20006EA")]
	[Serializable]
	public class TreeCutMesh
	{
		// Token: 0x06002D9F RID: 11679 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		[Token(Token = "0x6002D9F")]
		[Address(RVA = "0x55E9A0", Offset = "0x55D9A0", VA = "0x18055E9A0")]
		public TreeCutCellRemovedFlags GetRemovedFlags()
		{
			return TreeCutCellRemovedFlags.Undefined;
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA0")]
		[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
		[ItemCanBeNull]
		public List<Mesh> GetMesh()
		{
			return null;
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA1")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public TreeCutMesh()
		{
		}

		// Token: 0x040028C2 RID: 10434
		[Token(Token = "0x40028C2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TreeCutCellRemovedFlags _removedFlags;

		// Token: 0x040028C3 RID: 10435
		[Token(Token = "0x40028C3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Mesh> _cellMesh;
	}
}
