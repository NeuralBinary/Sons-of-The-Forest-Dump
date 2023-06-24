using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Input
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class InputActiveTester : MonoBehaviour
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3062900", Offset = "0x3060F00", VA = "0x183062900")]
		private void OnEnable()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x30629D0", Offset = "0x3060FD0", VA = "0x1830629D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3062AA0", Offset = "0x30610A0", VA = "0x183062AA0")]
		public void OnKeyboardActive()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3062AB0", Offset = "0x30610B0", VA = "0x183062AB0")]
		public void OnGamepadActive()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3062AC0", Offset = "0x30610C0", VA = "0x183062AC0")]
		private void SetGamepadActive(bool value)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3062CC0", Offset = "0x30612C0", VA = "0x183062CC0")]
		private void Update()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3062CD0", Offset = "0x30612D0", VA = "0x183062CD0")]
		private void RefreshReadout()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x30631B0", Offset = "0x30617B0", VA = "0x1830631B0")]
		private static string GetLog(InputDevice eachDevice)
		{
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InputActiveTester()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _keyboardIndicator;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _gamepadIndicator;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TMP_Text _text;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x38")]
		private InputDevice _lastActiveDevice;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x40")]
		private bool _isGamePad;
	}
}
