using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008F1 RID: 2289
	[Token(Token = "0x20008F1")]
	[AddComponentMenu("Sons/Items/WalkieTalkieController")]
	public class WalkieTalkieController : HeldControllerBase
	{
		// Token: 0x06004164 RID: 16740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004164")]
		[Address(RVA = "0x36107F0", Offset = "0x360EDF0", VA = "0x1836107F0")]
		private void Update()
		{
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004165")]
		[Address(RVA = "0x3610860", Offset = "0x360EE60", VA = "0x183610860", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004166")]
		[Address(RVA = "0x3610A20", Offset = "0x360F020", VA = "0x183610A20", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x00013F80 File Offset: 0x00012180
		[Token(Token = "0x6004167")]
		[Address(RVA = "0x3610E00", Offset = "0x360F400", VA = "0x183610E00", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004168")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WalkieTalkieController()
		{
		}

		// Token: 0x04003621 RID: 13857
		[Token(Token = "0x4003621")]
		[FieldOffset(Offset = "0x68")]
		private AnimatorLayersController _layersController;

		// Token: 0x04003622 RID: 13858
		[Token(Token = "0x4003622")]
		[FieldOffset(Offset = "0x70")]
		private LayerBehaviourActivator _leftArmLayerBehaviourActivator;
	}
}
