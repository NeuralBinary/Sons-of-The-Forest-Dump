using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public class VisualFader : MonoBehaviour
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00002E4C File Offset: 0x0000104C
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009E")]
		public bool Initialized
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x1700009F")]
		public bool FadedIn
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x2DB4B90", Offset = "0x2DB3190", VA = "0x182DB4B90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x170000A0")]
		public bool FadedOut
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x2DB4BB0", Offset = "0x2DB31B0", VA = "0x182DB4BB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void Awake()
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2DB4BD0", Offset = "0x2DB31D0", VA = "0x182DB4BD0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2DB5200", Offset = "0x2DB3800", VA = "0x182DB5200")]
		private void Init()
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2DB5350", Offset = "0x2DB3950", VA = "0x182DB5350")]
		private bool ShouldBeEnabled()
		{
			return default(bool);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2DB5370", Offset = "0x2DB3970", VA = "0x182DB5370")]
		public void PunchScale()
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2DB53D0", Offset = "0x2DB39D0", VA = "0x182DB53D0")]
		public void SetFocused()
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2DB5430", Offset = "0x2DB3A30", VA = "0x182DB5430")]
		public void SetUnfocused()
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2DB55A0", Offset = "0x2DB3BA0", VA = "0x182DB55A0")]
		public void FadeIn()
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2DB5680", Offset = "0x2DB3C80", VA = "0x182DB5680")]
		public void FadeOut()
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2DB5700", Offset = "0x2DB3D00", VA = "0x182DB5700")]
		public void Tint(Color c, bool applyNow = true)
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2DB5840", Offset = "0x2DB3E40", VA = "0x182DB5840")]
		public VisualFader()
		{
		}

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadingSpeed;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _punchScaleSpeed;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _punchScaleTo;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x38")]
		private bool _punchingScale;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x39")]
		private bool _focused;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x3A")]
		private bool _fading;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x3C")]
		private float _fadeTweenTime;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x40")]
		private float _fadeFromAlpha;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x44")]
		private float _fadeToAlpha;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x48")]
		private float _highLightTweenTime;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x50")]
		private MaterialPropertyBlock _mtp;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x58")]
		private Color _initialColor;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int ColorPropertyId;
	}
}
