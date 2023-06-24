using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006CA RID: 1738
	[Token(Token = "0x20006CA")]
	[AddComponentMenu("Sons/Crafting/Structures/GroundOffsetProvider")]
	public class GroundOffsetProvider : MonoBehaviour, IGroundOffsetProvider
	{
		// Token: 0x06002DE1 RID: 11745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE1")]
		[Address(RVA = "0x34418D0", Offset = "0x343FED0", VA = "0x1834418D0")]
		public void RefreshGroundAnchors()
		{
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE2")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetGroundAnchors(List<Transform> groundAnchors)
		{
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x0000D890 File Offset: 0x0000BA90
		[Token(Token = "0x6002DE3")]
		[Address(RVA = "0x3441B50", Offset = "0x3440150", VA = "0x183441B50", Slot = "4")]
		public bool TryCalculateMinHeight(out float height)
		{
			return default(bool);
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE4")]
		[Address(RVA = "0x3441FE0", Offset = "0x34405E0", VA = "0x183441FE0")]
		public GroundOffsetProvider()
		{
		}

		// Token: 0x04002821 RID: 10273
		[Token(Token = "0x4002821")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask _groundLayers;

		// Token: 0x04002822 RID: 10274
		[Token(Token = "0x4002822")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> _groundAnchors;

		// Token: 0x04002823 RID: 10275
		[Token(Token = "0x4002823")]
		[FieldOffset(Offset = "0x30")]
		private readonly RaycastHit[] _raycastHitsCache;
	}
}
