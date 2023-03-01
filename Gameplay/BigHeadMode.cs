using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200062D RID: 1581
	[Token(Token = "0x200062D")]
	[AddComponentMenu("Sons/Gameplay/BigHeadMode")]
	public class BigHeadMode : MonoBehaviour
	{
		// Token: 0x0600285E RID: 10334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285E")]
		[Address(RVA = "0x2DABF50", Offset = "0x2DAAF50", VA = "0x182DABF50")]
		private void Awake()
		{
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285F")]
		[Address(RVA = "0x2DAC150", Offset = "0x2DAB150", VA = "0x182DAC150")]
		private void RegisterSettingCallback()
		{
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002860")]
		[Address(RVA = "0x2DAC090", Offset = "0x2DAB090", VA = "0x182DAC090")]
		private void BigHeadModeChanged(bool newValue)
		{
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002861")]
		[Address(RVA = "0x2DAC0D0", Offset = "0x2DAB0D0", VA = "0x182DAC0D0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002862")]
		[Address(RVA = "0x2DAC220", Offset = "0x2DAB220", VA = "0x182DAC220")]
		private void SetBigHeadMode(bool enable)
		{
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002863")]
		[Address(RVA = "0x2DAC330", Offset = "0x2DAB330", VA = "0x182DAC330")]
		public BigHeadMode()
		{
		}

		// Token: 0x0400240F RID: 9231
		[Token(Token = "0x400240F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _scale;

		// Token: 0x04002410 RID: 9232
		[Token(Token = "0x4002410")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 _defaultScale;

		// Token: 0x04002411 RID: 9233
		[Token(Token = "0x4002411")]
		[FieldOffset(Offset = "0x30")]
		private bool _hasApplied;

		// Token: 0x04002412 RID: 9234
		[Token(Token = "0x4002412")]
		[FieldOffset(Offset = "0x0")]
		private static bool _hasRegisteredSettingCallback;

		// Token: 0x04002413 RID: 9235
		[Token(Token = "0x4002413")]
		[FieldOffset(Offset = "0x1")]
		private static bool _isActive;
	}
}
