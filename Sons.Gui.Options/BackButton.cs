using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sons.Gui.Options
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[AddComponentMenu("Sons/Gui/BackButton")]
	public class BackButton : MonoBehaviour
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x3039900", Offset = "0x3037F00", VA = "0x183039900")]
		private void OnValidate()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3039910", Offset = "0x3037F10", VA = "0x183039910")]
		private void OnEnable()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x30399C0", Offset = "0x3037FC0", VA = "0x1830399C0")]
		private void ValidateButton()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3039B00", Offset = "0x3038100", VA = "0x183039B00")]
		private void OnDisable()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3039BA0", Offset = "0x30381A0", VA = "0x183039BA0")]
		private void OnBack()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
		public BackButton()
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _autoFindButton;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _targetButton;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onBackUnityEvent;
	}
}
