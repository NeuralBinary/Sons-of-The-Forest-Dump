using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x20005E3")]
	public class PlasmaLighterOpenLid : MonoBehaviour
	{
		// Token: 0x060026A3 RID: 9891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A3")]
		[Address(RVA = "0x2DA7BA0", Offset = "0x2DA6BA0", VA = "0x182DA7BA0")]
		private void Start()
		{
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A4")]
		[Address(RVA = "0x2DA7D00", Offset = "0x2DA6D00", VA = "0x182DA7D00")]
		private void Update()
		{
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x2DA7AD0", Offset = "0x2DA6AD0", VA = "0x182DA7AD0")]
		private void OnDisable()
		{
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A6")]
		[Address(RVA = "0x2DA7AE0", Offset = "0x2DA6AE0", VA = "0x182DA7AE0")]
		private void OnMouseEnter(LayoutItem sender)
		{
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x2DA7AF0", Offset = "0x2DA6AF0", VA = "0x182DA7AF0")]
		private void OnMouseExit(LayoutItem sender)
		{
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A8")]
		[Address(RVA = "0x2DA7B00", Offset = "0x2DA6B00", VA = "0x182DA7B00")]
		private void OnRenderableLoaded(Transform eventTransform)
		{
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A9")]
		[Address(RVA = "0x2DA7D00", Offset = "0x2DA6D00", VA = "0x182DA7D00")]
		private void UpdateAnimation()
		{
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AA")]
		[Address(RVA = "0x2DA7AD0", Offset = "0x2DA6AD0", VA = "0x182DA7AD0")]
		private void ResetAnimation()
		{
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AB")]
		[Address(RVA = "0x2DA7E40", Offset = "0x2DA6E40", VA = "0x182DA7E40")]
		public PlasmaLighterOpenLid()
		{
		}

		// Token: 0x04002318 RID: 8984
		[Token(Token = "0x4002318")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemRenderable _itemRenderable;

		// Token: 0x04002319 RID: 8985
		[Token(Token = "0x4002319")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InventoryLayoutItem _inventoryLayoutItem;

		// Token: 0x0400231A RID: 8986
		[Token(Token = "0x400231A")]
		[FieldOffset(Offset = "0x30")]
		private float _delayTime;

		// Token: 0x0400231B RID: 8987
		[Token(Token = "0x400231B")]
		[FieldOffset(Offset = "0x38")]
		private Animation _animation;

		// Token: 0x0400231C RID: 8988
		[Token(Token = "0x400231C")]
		[FieldOffset(Offset = "0x40")]
		private AnimationClip _animationClip;

		// Token: 0x0400231D RID: 8989
		[Token(Token = "0x400231D")]
		[FieldOffset(Offset = "0x48")]
		private float _currentAnimTime;

		// Token: 0x0400231E RID: 8990
		[Token(Token = "0x400231E")]
		[FieldOffset(Offset = "0x4C")]
		private float _remainingAnimationDelay;

		// Token: 0x0400231F RID: 8991
		[Token(Token = "0x400231F")]
		[FieldOffset(Offset = "0x50")]
		private bool _spreadOut;

		// Token: 0x04002320 RID: 8992
		[Token(Token = "0x4002320")]
		[FieldOffset(Offset = "0x51")]
		private bool _trackAnimationDelay;

		// Token: 0x04002321 RID: 8993
		[Token(Token = "0x4002321")]
		[FieldOffset(Offset = "0x58")]
		private GameObject _animatedObject;
	}
}
