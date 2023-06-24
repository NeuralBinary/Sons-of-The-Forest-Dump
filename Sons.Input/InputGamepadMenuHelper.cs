using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Input
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[AddComponentMenu("Sons/Input/InputGamepadMenuHelper")]
	public class InputGamepadMenuHelper : MonoBehaviour
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetLastActiveControl(GameObject target)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
		public void SetNextActiveControl(GameObject target)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
		public void SetWhiteList(List<GameObject> targets)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x3066BA0", Offset = "0x30651A0", VA = "0x183066BA0")]
		private void OnKeyboardActive()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3066D30", Offset = "0x3065330", VA = "0x183066D30")]
		private void OnGamepadActive()
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3067000", Offset = "0x3065600", VA = "0x183067000")]
		private void Update()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x30673B0", Offset = "0x30659B0", VA = "0x1830673B0")]
		private void UpdateLastActiveControl(GameObject currentEventSystemSelected)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x30674E0", Offset = "0x3065AE0", VA = "0x1830674E0")]
		private bool PassesWhiteList(GameObject target)
		{
			return default(bool);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3067760", Offset = "0x3065D60", VA = "0x183067760")]
		private void OnEnable()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x3067830", Offset = "0x3065E30", VA = "0x183067830")]
		private void OnDisable()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x3067900", Offset = "0x3065F00", VA = "0x183067900")]
		public void AddToWhiteList(GameObject sourceObject)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x3067A90", Offset = "0x3066090", VA = "0x183067A90")]
		public bool HasActiveControl()
		{
			return default(bool);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x3067BF0", Offset = "0x30661F0", VA = "0x183067BF0")]
		public void Clear()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x3067DB0", Offset = "0x30663B0", VA = "0x183067DB0")]
		public InputGamepadMenuHelper()
		{
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lastActiveControl;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useWhiteList;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _whiteList;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _nextUpdateSetActiveControl;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x40")]
		private bool _gamepadActive;
	}
}
