using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Player
{
	// Token: 0x02000757 RID: 1879
	[Token(Token = "0x2000757")]
	public class StealthVfx : MonoBehaviour
	{
		// Token: 0x0600311B RID: 12571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600311B")]
		[Address(RVA = "0x2E54C30", Offset = "0x2E53C30", VA = "0x182E54C30")]
		private void Start()
		{
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600311C")]
		[Address(RVA = "0x2E54CC0", Offset = "0x2E53CC0", VA = "0x182E54CC0")]
		private void Update()
		{
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		[Token(Token = "0x600311D")]
		[Address(RVA = "0x2E54BB0", Offset = "0x2E53BB0", VA = "0x182E54BB0")]
		private float ConvertToGoal()
		{
			return default(float);
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[Token(Token = "0x600311E")]
		[Address(RVA = "0x2E54BD0", Offset = "0x2E53BD0", VA = "0x182E54BD0")]
		private float GetStealthFactor()
		{
			return default(float);
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600311F")]
		[Address(RVA = "0x2E54E90", Offset = "0x2E53E90", VA = "0x182E54E90")]
		public StealthVfx()
		{
		}

		// Token: 0x04002AE0 RID: 10976
		[Token(Token = "0x4002AE0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Volume _fadeVolume;

		// Token: 0x04002AE1 RID: 10977
		[Token(Token = "0x4002AE1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _smoothTime;

		// Token: 0x04002AE2 RID: 10978
		[Token(Token = "0x4002AE2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _smoothMaxSpeed;

		// Token: 0x04002AE3 RID: 10979
		[Token(Token = "0x4002AE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _remapMin;

		// Token: 0x04002AE4 RID: 10980
		[Token(Token = "0x4002AE4")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _remapMax;

		// Token: 0x04002AE5 RID: 10981
		[Token(Token = "0x4002AE5")]
		[FieldOffset(Offset = "0x38")]
		private float _currentStealthFactor;

		// Token: 0x04002AE6 RID: 10982
		[Token(Token = "0x4002AE6")]
		[FieldOffset(Offset = "0x40")]
		private PlayerVisibility _playerVisibility;

		// Token: 0x04002AE7 RID: 10983
		[Token(Token = "0x4002AE7")]
		[FieldOffset(Offset = "0x48")]
		private float _currentGoal;

		// Token: 0x04002AE8 RID: 10984
		[Token(Token = "0x4002AE8")]
		[FieldOffset(Offset = "0x4C")]
		private float _smoothDampVel;

		// Token: 0x04002AE9 RID: 10985
		[Token(Token = "0x4002AE9")]
		[FieldOffset(Offset = "0x50")]
		private float _currentValue;

		// Token: 0x04002AEA RID: 10986
		[Token(Token = "0x4002AEA")]
		[FieldOffset(Offset = "0x54")]
		private bool _hasApplied;
	}
}
