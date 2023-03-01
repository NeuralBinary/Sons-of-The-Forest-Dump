using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Items.Craft
{
	// Token: 0x020004C2 RID: 1218
	[Token(Token = "0x20004C2")]
	public class RandomWeaponUpgradeVisual : MonoBehaviour
	{
		// Token: 0x06001F59 RID: 8025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0x2D2F0F0", Offset = "0x2D2E0F0", VA = "0x182D2F0F0")]
		public void OnEnable()
		{
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x2D2EF10", Offset = "0x2D2DF10", VA = "0x182D2EF10")]
		private void OnDisable()
		{
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x2D2F150", Offset = "0x2D2E150", VA = "0x182D2F150")]
		public bool PlaceVisual()
		{
			return default(bool);
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x2D2ED80", Offset = "0x2D2DD80", VA = "0x182D2ED80")]
		public void ClearVisuals()
		{
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x2D2F820", Offset = "0x2D2E820", VA = "0x182D2F820")]
		public RandomWeaponUpgradeVisual()
		{
		}

		// Token: 0x04001CEC RID: 7404
		[Token(Token = "0x4001CEC")]
		[FieldOffset(Offset = "0x20")]
		public Transform _prefab;

		// Token: 0x04001CED RID: 7405
		[Token(Token = "0x4001CED")]
		[FieldOffset(Offset = "0x28")]
		public MeshCollider _target;

		// Token: 0x04001CEE RID: 7406
		[Token(Token = "0x4001CEE")]
		[FieldOffset(Offset = "0x30")]
		public SphereCollider _castReferal;

		// Token: 0x04001CEF RID: 7407
		[Token(Token = "0x4001CEF")]
		[FieldOffset(Offset = "0x38")]
		public Transform[] _proxies;

		// Token: 0x04001CF0 RID: 7408
		[Token(Token = "0x4001CF0")]
		[FieldOffset(Offset = "0x40")]
		public int _autoVisualCount;

		// Token: 0x04001CF1 RID: 7409
		[Token(Token = "0x4001CF1")]
		[FieldOffset(Offset = "0x48")]
		private List<Transform> _visuals;

		// Token: 0x04001CF2 RID: 7410
		[Token(Token = "0x4001CF2")]
		[FieldOffset(Offset = "0x50")]
		private bool _hasAutoVisual;
	}
}
