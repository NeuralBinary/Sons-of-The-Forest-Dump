using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(UIWidget))]
	[AddComponentMenu("NGUI/UI/Localize")]
	public class UILocalize : MonoBehaviour
	{
		// Token: 0x17000073 RID: 115
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		public string value
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x26401B0", Offset = "0x263E7B0", VA = "0x1826401B0")]
			set
			{
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x26407F0", Offset = "0x263EDF0", VA = "0x1826407F0")]
		private void OnEnable()
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2640800", Offset = "0x263EE00", VA = "0x182640800")]
		private void Start()
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2640810", Offset = "0x263EE10", VA = "0x182640810")]
		private void OnLocalize()
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UILocalize()
		{
		}

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x20")]
		public string key;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x28")]
		private bool mStarted;
	}
}
