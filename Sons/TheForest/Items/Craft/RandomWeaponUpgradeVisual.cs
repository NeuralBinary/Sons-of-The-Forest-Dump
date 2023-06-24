using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Items.Craft
{
	// Token: 0x020004B7 RID: 1207
	[Token(Token = "0x20004B7")]
	public class RandomWeaponUpgradeVisual : MonoBehaviour
	{
		// Token: 0x06001FBD RID: 8125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBD")]
		[Address(RVA = "0x330AF60", Offset = "0x3309560", VA = "0x18330AF60")]
		public void OnEnable()
		{
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBE")]
		[Address(RVA = "0x330AFC0", Offset = "0x33095C0", VA = "0x18330AFC0")]
		private void OnDisable()
		{
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x6001FBF")]
		[Address(RVA = "0x330B060", Offset = "0x3309660", VA = "0x18330B060")]
		public bool PlaceVisual()
		{
			return default(bool);
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0x330BA40", Offset = "0x330A040", VA = "0x18330BA40")]
		public void ClearVisuals()
		{
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0x330BC50", Offset = "0x330A250", VA = "0x18330BC50")]
		public RandomWeaponUpgradeVisual()
		{
		}

		// Token: 0x04001D28 RID: 7464
		[Token(Token = "0x4001D28")]
		[FieldOffset(Offset = "0x20")]
		public Transform _prefab;

		// Token: 0x04001D29 RID: 7465
		[Token(Token = "0x4001D29")]
		[FieldOffset(Offset = "0x28")]
		public MeshCollider _target;

		// Token: 0x04001D2A RID: 7466
		[Token(Token = "0x4001D2A")]
		[FieldOffset(Offset = "0x30")]
		public SphereCollider _castReferal;

		// Token: 0x04001D2B RID: 7467
		[Token(Token = "0x4001D2B")]
		[FieldOffset(Offset = "0x38")]
		public Transform[] _proxies;

		// Token: 0x04001D2C RID: 7468
		[Token(Token = "0x4001D2C")]
		[FieldOffset(Offset = "0x40")]
		public int _autoVisualCount;

		// Token: 0x04001D2D RID: 7469
		[Token(Token = "0x4001D2D")]
		[FieldOffset(Offset = "0x48")]
		private List<Transform> _visuals;

		// Token: 0x04001D2E RID: 7470
		[Token(Token = "0x4001D2E")]
		[FieldOffset(Offset = "0x50")]
		private bool _hasAutoVisual;
	}
}
