using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	[CreateAssetMenu(fileName = "distance field", menuName = "Obi/Distance Field", order = 181)]
	[ExecuteInEditMode]
	public class ObiDistanceField : ScriptableObject
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x000043F4 File Offset: 0x000025F4
		[Token(Token = "0x170000EF")]
		public bool Initialized
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x76B600", Offset = "0x769C00", VA = "0x18076B600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0000440C File Offset: 0x0000260C
		[Token(Token = "0x170000F0")]
		public Bounds FieldBounds
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0xA25290", Offset = "0xA23890", VA = "0x180A25290")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00004424 File Offset: 0x00002624
		[Token(Token = "0x170000F1")]
		public float EffectiveSampleSize
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000F2")]
		public Mesh InputMesh
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x27CE4E0", Offset = "0x27CCAE0", VA = "0x1827CE4E0")]
			set
			{
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x27CE650", Offset = "0x27CCC50", VA = "0x1827CE650")]
		public void Reset()
		{
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x27CE7D0", Offset = "0x27CCDD0", VA = "0x1827CE7D0")]
		public IEnumerator Generate()
		{
			return null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x27CE860", Offset = "0x27CCE60", VA = "0x1827CE860")]
		public Texture3D GetVolumeTexture(int size)
		{
			return null;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x27CEE40", Offset = "0x27CD440", VA = "0x1827CEE40")]
		public ObiDistanceField()
		{
		}

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[SerializeProperty("InputMesh")]
		private Mesh input;

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private float minNodeSize;

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private Bounds bounds;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public List<DFNode> nodes;

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x48")]
		[Range(1E-05f, 0.1f)]
		public float maxError;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x4C")]
		[Range(1f, 8f)]
		public int maxDepth;
	}
}
