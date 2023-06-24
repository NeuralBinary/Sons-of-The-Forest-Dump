using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Input
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[AddComponentMenu("Sons/Input/InputDeviceTypeChange")]
	public class InputDeviceTypeChange : MonoBehaviour
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3064BA0", Offset = "0x30631A0", VA = "0x183064BA0")]
		private void OnKeyboardActive()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0xA88300", Offset = "0xA86900", VA = "0x180A88300")]
		private void OnGamepadActive()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3064BC0", Offset = "0x30631C0", VA = "0x183064BC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3064C90", Offset = "0x3063290", VA = "0x183064C90")]
		private void OnDisable()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InputDeviceTypeChange()
		{
		}

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent _unityEventOnGamepadActive;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent _unityEventOnKeyboardActive;
	}
}
