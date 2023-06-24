using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000903 RID: 2307
	[Token(Token = "0x2000903")]
	public class IkFakeBone : MonoBehaviour, IIkFakeBone
	{
		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06004259 RID: 16985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085D")]
		public Transform TipTransform
		{
			[Token(Token = "0x6004259")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x0600425A RID: 16986 RVA: 0x00014238 File Offset: 0x00012438
		[Token(Token = "0x1700085E")]
		public IkLimbs Limb
		{
			[Token(Token = "0x600425A")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000", Slot = "5")]
			get
			{
				return IkLimbs.RightHand;
			}
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425B")]
		[Address(RVA = "0x3634AB0", Offset = "0x36330B0", VA = "0x183634AB0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425C")]
		[Address(RVA = "0x3634B90", Offset = "0x3633190", VA = "0x183634B90")]
		private void OnEnable()
		{
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public IkFakeBone()
		{
		}

		// Token: 0x040045B9 RID: 17849
		[Token(Token = "0x40045B9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _tipTransform;

		// Token: 0x040045BA RID: 17850
		[Token(Token = "0x40045BA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private IkLimbs _limb;

		// Token: 0x040045BB RID: 17851
		[Token(Token = "0x40045BB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private IkTargetsController _controller;
	}
}
