using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public class TerrainDigDetectionArea : MonoBehaviour
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060001E6 RID: 486 RVA: 0x00002096 File Offset: 0x00000296
		// (remove) Token: 0x060001E7 RID: 487 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x14000005")]
		public event Action<int> OnCountChanged
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x2FBF780", Offset = "0x2FBDD80", VA = "0x182FBF780")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x2FBF8F0", Offset = "0x2FBDEF0", VA = "0x182FBF8F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2FBFA60", Offset = "0x2FBE060", VA = "0x182FBFA60")]
		private void OnEnable()
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2FBFBD0", Offset = "0x2FBE1D0", VA = "0x182FBFBD0")]
		private void OnDisable()
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2FBFC90", Offset = "0x2FBE290", VA = "0x182FBFC90")]
		public bool OverlapsNode(TerrainDigNode node)
		{
			return default(bool);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2FBFF30", Offset = "0x2FBE530", VA = "0x182FBFF30")]
		public void RegisterNode(TerrainDigNode node)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2FC0170", Offset = "0x2FBE770", VA = "0x182FC0170")]
		private void UnregisterNode(TerrainDigNode node)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2FC03B0", Offset = "0x2FBE9B0", VA = "0x182FC03B0")]
		private void RefreshCount()
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2FC0440", Offset = "0x2FBEA40", VA = "0x182FC0440")]
		public TerrainDigDetectionArea()
		{
		}

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BoxCollider _boxCollider;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent<int> _onCountChangedUnityEvent;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x30")]
		private List<TerrainDigNode> _nodes;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x38")]
		private int _count;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x3C")]
		private bool _initialized;
	}
}
