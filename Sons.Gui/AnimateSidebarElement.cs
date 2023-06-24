using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class AnimateSidebarElement : MonoBehaviour
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3000410", Offset = "0x2FFEA10", VA = "0x183000410")]
		private void Update()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x3000460", Offset = "0x2FFEA60", VA = "0x183000460")]
		private void OnEnable()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3000470", Offset = "0x2FFEA70", VA = "0x183000470")]
		public void SlideIn()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3000560", Offset = "0x2FFEB60", VA = "0x183000560")]
		public void SlideOut()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x30005B0", Offset = "0x2FFEBB0", VA = "0x1830005B0")]
		public void SlideOutInstant()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AnimateSidebarElement()
		{
		}

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x28")]
		public bool ShouldPulse;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x29")]
		private bool _isActive;
	}
}
