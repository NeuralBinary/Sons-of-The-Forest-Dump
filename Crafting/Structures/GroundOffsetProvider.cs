using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007BF RID: 1983
	[Token(Token = "0x20007BF")]
	[AddComponentMenu("Sons/Crafting/Structures/GroundOffsetProvider")]
	public class GroundOffsetProvider : MonoBehaviour, IGroundOffsetProvider
	{
		// Token: 0x06003467 RID: 13415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003467")]
		[Address(RVA = "0x2E5F990", Offset = "0x2E5E990", VA = "0x182E5F990")]
		public void RefreshGroundAnchors()
		{
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003468")]
		[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
		public void SetGroundAnchors(List<Transform> groundAnchors)
		{
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		[Token(Token = "0x6003469")]
		[Address(RVA = "0x2E5FAE0", Offset = "0x2E5EAE0", VA = "0x182E5FAE0", Slot = "4")]
		public bool TryCalculateMinHeight(out float height)
		{
			return default(bool);
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346A")]
		[Address(RVA = "0x2E5FF20", Offset = "0x2E5EF20", VA = "0x182E5FF20")]
		public GroundOffsetProvider()
		{
		}

		// Token: 0x04002D4D RID: 11597
		[Token(Token = "0x4002D4D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask _groundLayers;

		// Token: 0x04002D4E RID: 11598
		[Token(Token = "0x4002D4E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> _groundAnchors;

		// Token: 0x04002D4F RID: 11599
		[Token(Token = "0x4002D4F")]
		[FieldOffset(Offset = "0x30")]
		private readonly RaycastHit[] _raycastHitsCache;
	}
}
