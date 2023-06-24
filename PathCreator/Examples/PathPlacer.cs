using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation.Examples
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	public class PathPlacer : PathSceneTool
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2836BB0", Offset = "0x28351B0", VA = "0x182836BB0")]
		private void Generate()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2836FE0", Offset = "0x28355E0", VA = "0x182836FE0")]
		private void DestroyObjects()
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2837230", Offset = "0x2835830", VA = "0x182837230", Slot = "5")]
		protected override void PathUpdated()
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2837300", Offset = "0x2835900", VA = "0x182837300")]
		public PathPlacer()
		{
		}

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x38")]
		public GameObject prefab;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject holder;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x48")]
		public float spacing;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		private const float minSpacing = 0.1f;
	}
}
