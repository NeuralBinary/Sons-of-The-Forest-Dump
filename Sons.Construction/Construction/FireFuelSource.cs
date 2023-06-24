using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001EB RID: 491
	[Token(Token = "0x20001EB")]
	[AddComponentMenu("Sons/Construction/FireFuelSource")]
	public class FireFuelSource : MonoBehaviour
	{
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700036B")]
		public FireRenderers Renderers
		{
			[Token(Token = "0x6000EC0")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x000090D4 File Offset: 0x000072D4
		[Token(Token = "0x1700036C")]
		public float FuelAmount
		{
			[Token(Token = "0x6000EC1")]
			[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x2EF2800", Offset = "0x2EF0E00", VA = "0x182EF2800")]
		private void OnEnable()
		{
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x2EF28A0", Offset = "0x2EF0EA0", VA = "0x182EF28A0")]
		private IEnumerator DelayedOnEnable()
		{
			return null;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x2EF2930", Offset = "0x2EF0F30", VA = "0x182EF2930")]
		private void OnDisable()
		{
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000090EC File Offset: 0x000072EC
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x2EF29C0", Offset = "0x2EF0FC0", VA = "0x182EF29C0")]
		private bool TryGetCookingFire(out CookingFireNew cookingFire)
		{
			return default(bool);
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FireFuelSource()
		{
		}

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FireRenderers _renderers;

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fuelAmount;
	}
}
