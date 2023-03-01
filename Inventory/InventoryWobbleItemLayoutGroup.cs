using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005E0 RID: 1504
	[Token(Token = "0x20005E0")]
	[AddComponentMenu("Sons/Inventory/Inventory Wobble Item Layout Group")]
	public class InventoryWobbleItemLayoutGroup : MonoBehaviour
	{
		// Token: 0x06002695 RID: 9877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002695")]
		[Address(RVA = "0x2DA40E0", Offset = "0x2DA30E0", VA = "0x182DA40E0")]
		private void Update()
		{
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002696")]
		[Address(RVA = "0x2DA4030", Offset = "0x2DA3030", VA = "0x182DA4030")]
		public void Play()
		{
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002697")]
		[Address(RVA = "0x2DA4060", Offset = "0x2DA3060", VA = "0x182DA4060")]
		private void Stop()
		{
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002698")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public InventoryWobbleItemLayoutGroup()
		{
		}

		// Token: 0x04002303 RID: 8963
		[Token(Token = "0x4002303")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected AnimationClip _animationClip;

		// Token: 0x04002304 RID: 8964
		[Token(Token = "0x4002304")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayoutItemGroup<InventoryLayoutItem> _layoutGroup;

		// Token: 0x04002305 RID: 8965
		[Token(Token = "0x4002305")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private Animation _wobbleAnimation;

		// Token: 0x04002306 RID: 8966
		[Token(Token = "0x4002306")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private Transform _wobbleTransform;

		// Token: 0x04002307 RID: 8967
		[Token(Token = "0x4002307")]
		[FieldOffset(Offset = "0x40")]
		private bool _isPlaying;
	}
}
