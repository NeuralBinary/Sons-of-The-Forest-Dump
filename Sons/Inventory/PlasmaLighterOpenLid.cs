using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005F4 RID: 1524
	[Token(Token = "0x20005F4")]
	public class PlasmaLighterOpenLid : MonoBehaviour
	{
		// Token: 0x060027AC RID: 10156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AC")]
		[Address(RVA = "0x33CC9F0", Offset = "0x33CAFF0", VA = "0x1833CC9F0")]
		private void Start()
		{
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AD")]
		[Address(RVA = "0x33CCB50", Offset = "0x33CB150", VA = "0x1833CCB50")]
		private void Update()
		{
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AE")]
		[Address(RVA = "0x33CCB60", Offset = "0x33CB160", VA = "0x1833CCB60")]
		private void OnDisable()
		{
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AF")]
		[Address(RVA = "0x33CCB70", Offset = "0x33CB170", VA = "0x1833CCB70")]
		private void OnMouseEnter(LayoutItem sender)
		{
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B0")]
		[Address(RVA = "0x33CCB80", Offset = "0x33CB180", VA = "0x1833CCB80")]
		private void OnMouseExit(LayoutItem sender)
		{
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B1")]
		[Address(RVA = "0x33CCB90", Offset = "0x33CB190", VA = "0x1833CCB90")]
		private void OnRenderableLoaded(Transform eventTransform)
		{
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B2")]
		[Address(RVA = "0x33CCD90", Offset = "0x33CB390", VA = "0x1833CCD90")]
		private void UpdateAnimation()
		{
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B3")]
		[Address(RVA = "0x33CCB60", Offset = "0x33CB160", VA = "0x1833CCB60")]
		private void ResetAnimation()
		{
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B4")]
		[Address(RVA = "0x33CCFC0", Offset = "0x33CB5C0", VA = "0x1833CCFC0")]
		public PlasmaLighterOpenLid()
		{
		}

		// Token: 0x040023F6 RID: 9206
		[Token(Token = "0x40023F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemRenderable _itemRenderable;

		// Token: 0x040023F7 RID: 9207
		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InventoryLayoutItem _inventoryLayoutItem;

		// Token: 0x040023F8 RID: 9208
		[Token(Token = "0x40023F8")]
		[FieldOffset(Offset = "0x30")]
		private float _delayTime;

		// Token: 0x040023F9 RID: 9209
		[Token(Token = "0x40023F9")]
		[FieldOffset(Offset = "0x38")]
		private Animation _animation;

		// Token: 0x040023FA RID: 9210
		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0x40")]
		private AnimationClip _animationClip;

		// Token: 0x040023FB RID: 9211
		[Token(Token = "0x40023FB")]
		[FieldOffset(Offset = "0x48")]
		private float _currentAnimTime;

		// Token: 0x040023FC RID: 9212
		[Token(Token = "0x40023FC")]
		[FieldOffset(Offset = "0x4C")]
		private float _remainingAnimationDelay;

		// Token: 0x040023FD RID: 9213
		[Token(Token = "0x40023FD")]
		[FieldOffset(Offset = "0x50")]
		private bool _spreadOut;

		// Token: 0x040023FE RID: 9214
		[Token(Token = "0x40023FE")]
		[FieldOffset(Offset = "0x51")]
		private bool _trackAnimationDelay;

		// Token: 0x040023FF RID: 9215
		[Token(Token = "0x40023FF")]
		[FieldOffset(Offset = "0x58")]
		private GameObject _animatedObject;
	}
}
