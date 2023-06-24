using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public class IKExecutionOrder : MonoBehaviour
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00003134 File Offset: 0x00001334
		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x29112A0", Offset = "0x290F8A0", VA = "0x1829112A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x29113C0", Offset = "0x290F9C0", VA = "0x1829113C0")]
		private void Start()
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2911480", Offset = "0x290FA80", VA = "0x182911480")]
		private void Update()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x29114B0", Offset = "0x290FAB0", VA = "0x1829114B0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x29114E0", Offset = "0x290FAE0", VA = "0x1829114E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2911600", Offset = "0x290FC00", VA = "0x182911600")]
		private void FixTransforms()
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public IKExecutionOrder()
		{
		}

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x30")]
		private bool fixedFrame;
	}
}
