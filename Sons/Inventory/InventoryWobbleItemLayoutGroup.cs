using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005F1 RID: 1521
	[Token(Token = "0x20005F1")]
	[AddComponentMenu("Sons/Inventory/Inventory Wobble Item Layout Group")]
	public class InventoryWobbleItemLayoutGroup : MonoBehaviour
	{
		// Token: 0x0600279E RID: 10142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279E")]
		[Address(RVA = "0x33CA4B0", Offset = "0x33C8AB0", VA = "0x1833CA4B0")]
		private void Update()
		{
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279F")]
		[Address(RVA = "0x33CA6E0", Offset = "0x33C8CE0", VA = "0x1833CA6E0")]
		public void Play()
		{
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A0")]
		[Address(RVA = "0x33CA750", Offset = "0x33C8D50", VA = "0x1833CA750")]
		private void Stop()
		{
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A1")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InventoryWobbleItemLayoutGroup()
		{
		}

		// Token: 0x040023E1 RID: 9185
		[Token(Token = "0x40023E1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected AnimationClip _animationClip;

		// Token: 0x040023E2 RID: 9186
		[Token(Token = "0x40023E2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayoutItemGroup<InventoryLayoutItem> _layoutGroup;

		// Token: 0x040023E3 RID: 9187
		[Token(Token = "0x40023E3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private Animation _wobbleAnimation;

		// Token: 0x040023E4 RID: 9188
		[Token(Token = "0x40023E4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private Transform _wobbleTransform;

		// Token: 0x040023E5 RID: 9189
		[Token(Token = "0x40023E5")]
		[FieldOffset(Offset = "0x40")]
		private bool _isPlaying;
	}
}
